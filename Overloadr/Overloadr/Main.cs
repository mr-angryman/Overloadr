using dosLib;
using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Text;
using System.Threading.Tasks;

namespace Overloadr
{
    public partial class Main : Form
    {
        private Doser doser = new Doser();
        private System.Windows.Forms.Timer elapsedTimer;

        public Main()
        {
            InitializeComponent();
            doser.StatsUpdated += (sent, errors, threads, progress) =>
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        totalRequestsSentLabel.Text = sent.ToString();
                        totalErrorsLabel.Text = errors.ToString();
                        activeThreadsLabel.Text = threads.ToString();
                        statsProgressBar.Value = progress;
                        timeElapsedLabel.Text = doser.ElapsedTime.ToString(@"hh\:mm\:ss");
                    }));
                }
                else
                {
                    totalRequestsSentLabel.Text = sent.ToString();
                    totalErrorsLabel.Text = errors.ToString();
                    activeThreadsLabel.Text = threads.ToString();
                    statsProgressBar.Value = progress;
                    timeElapsedLabel.Text = doser.ElapsedTime.ToString(@"hh\:mm\:ss");
                }
            };
        }

        private void lightPresetButton_Click(object sender, EventArgs e)
        {
            threadsNumeric.Value = 10;
            requestsPerSecondNumeric.Value = 5;
            durationNumeric.Value = 60;
            methodComboBox.SelectedIndex = 0;
            keepAliveCheckBox.Checked = true;
            randomizeHeadersCheckBox.Checked = false;
            followRedirectsCheckBox.Checked = true;
            timeoutNumeric.Value = 5000;
        }

        private void standardPresetButton_Click(object sender, EventArgs e)
        {
            threadsNumeric.Value = 100;
            requestsPerSecondNumeric.Value = 20;
            durationNumeric.Value = 300;
            methodComboBox.SelectedIndex = 0;
            keepAliveCheckBox.Checked = true;
            randomizeHeadersCheckBox.Checked = true;
            followRedirectsCheckBox.Checked = true;
            timeoutNumeric.Value = 3000;
        }

        private void intensePresetButton_Click(object sender, EventArgs e)
        {
            threadsNumeric.Value = 1000;
            requestsPerSecondNumeric.Value = 100;
            durationNumeric.Value = 600;
            keepAliveCheckBox.Checked = true;
            randomizeHeadersCheckBox.Checked = true;
            followRedirectsCheckBox.Checked = false;
            timeoutNumeric.Value = 2000;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("This software is intended strictly for educational and testing purposes only. It is designed to help developers and administrators evaluate the performance and resilience of their own web infrastructure. I am not responsible for any misuse or illegal activity involving this program. Use it only on websites you own or have explicit permission to test. Misuse of this tool may violate the laws. Proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                return;
            }
            else { Application.Exit(); }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            attackButton.Enabled = false;

            // Read all UI values on UI thread before starting background task
            string url = targetUrlTextbox.Text;
            int threads = (int)threadsNumeric.Value;
            int rps = (int)requestsPerSecondNumeric.Value;
            int duration = (int)durationNumeric.Value;
            HttpMethodType method = (HttpMethodType)methodComboBox.SelectedIndex;
            bool keepAlive = keepAliveCheckBox.Checked;
            bool randomHeaders = randomizeHeadersCheckBox.Checked;
            bool followRedirects = followRedirectsCheckBox.Checked;
            int timeout = (int)timeoutNumeric.Value;

            attackButton.Enabled = false; // optional: disable button while attacking

            Task.Run(() =>
            {
                doser.Attack(
                    targetURL: url,
                    threads: threads,
                    requestsPerSecond: rps,
                    durationInSeconds: duration,
                    httpMethod: method,
                    keepAlive: keepAlive,
                    randomizeHeaders: randomHeaders,
                    followRedirects: followRedirects,
                    timeoutInMilliseconds: timeout
                );
            });
        }

        private void UpdateStatsUI(int totalSent, int errors, int threads, int progress)
        {
            // Optionally update labels or progress bar here
            Invoke((MethodInvoker)(() =>
            {
                totalRequestsSentLabel.Text = totalSent.ToString();
                totalErrorsLabel.Text = errors.ToString();
                activeThreadsLabel.Text = threads.ToString();
                statsProgressBar.Value = Math.Min(progress, 100);
            }));
        }

        private void ElapsedTimer_Tick(object sender, EventArgs e)
        {
            var elapsed = doser.ElapsedTime;
            timeElapsedLabel.Text = "Time Elapsed: " + elapsed.ToString(@"hh\:mm\:ss");
            progressBarLabel.Text = "Progress: " + statsProgressBar.Value + "%";
        }

        private async void terminateButton_Click(object sender, EventArgs e)
        {
            attackButton.Enabled = true;
            await doser.TerminateAsync();
            MessageBox.Show("TERMINATED", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            timeElapsedLabel.Text = "Time Elapsed: 00:00:00";
            totalRequestsSentLabel.Text = "Total Requests Sent: 0";
            totalErrorsLabel.Text = "Total Errors: 0";
            activeThreadsLabel.Text = "Active Threads: 0";
            progressBarLabel.Text = "Progress: 0%";
            statsProgressBar.Value = 0;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
