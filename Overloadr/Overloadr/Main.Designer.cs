namespace Overloadr
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            targetUrlLabel = new Label();
            targetUrlTextbox = new TextBox();
            threadsLabel = new Label();
            threadsNumeric = new NumericUpDown();
            requestsPerSecondLabel = new Label();
            requestsPerSecondNumeric = new NumericUpDown();
            coreOptionsGroupBox = new GroupBox();
            methodComboBox = new ComboBox();
            methodLabel = new Label();
            durationLabel = new Label();
            durationNumeric = new NumericUpDown();
            advancedOptionsGroupBox = new GroupBox();
            timeoutLabel = new Label();
            timeoutNumeric = new NumericUpDown();
            followRedirectsCheckBox = new CheckBox();
            randomizeHeadersCheckBox = new CheckBox();
            keepAliveCheckBox = new CheckBox();
            mainToolTip = new ToolTip(components);
            liveStatsCheckBox = new CheckBox();
            logToFileCheckBox = new CheckBox();
            saveErrorsOnlyCheckBox = new CheckBox();
            exportCheckBox = new CheckBox();
            outputGroupBox = new GroupBox();
            presetsGroupBox = new GroupBox();
            intensePresetButton = new Button();
            standardPresetButton = new Button();
            lightPresetButton = new Button();
            attackButton = new Button();
            statsGroupBox = new GroupBox();
            progressBarLabel = new Label();
            statsProgressBar = new ProgressBar();
            activeThreadsLabel = new Label();
            totalErrorsLabel = new Label();
            totalRequestsSentLabel = new Label();
            timeElapsedLabel = new Label();
            ElapsedTimer = new System.Windows.Forms.Timer(components);
            terminateButton = new Button();
            infoGroupBox = new GroupBox();
            exitButton = new Button();
            restartButton = new Button();
            versionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)threadsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requestsPerSecondNumeric).BeginInit();
            coreOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)durationNumeric).BeginInit();
            advancedOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeoutNumeric).BeginInit();
            outputGroupBox.SuspendLayout();
            presetsGroupBox.SuspendLayout();
            statsGroupBox.SuspendLayout();
            infoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // targetUrlLabel
            // 
            targetUrlLabel.AutoSize = true;
            targetUrlLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            targetUrlLabel.Location = new Point(16, 32);
            targetUrlLabel.Name = "targetUrlLabel";
            targetUrlLabel.Size = new Size(88, 21);
            targetUrlLabel.TabIndex = 0;
            targetUrlLabel.Text = "Target URL:";
            mainToolTip.SetToolTip(targetUrlLabel, "The target URL or IP to send the attack to.");
            // 
            // targetUrlTextbox
            // 
            targetUrlTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            targetUrlTextbox.Location = new Point(110, 28);
            targetUrlTextbox.Name = "targetUrlTextbox";
            targetUrlTextbox.Size = new Size(327, 29);
            targetUrlTextbox.TabIndex = 1;
            mainToolTip.SetToolTip(targetUrlTextbox, "The target URL or IP to send the attack to.");
            // 
            // threadsLabel
            // 
            threadsLabel.AutoSize = true;
            threadsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            threadsLabel.Location = new Point(16, 64);
            threadsLabel.Name = "threadsLabel";
            threadsLabel.Size = new Size(68, 21);
            threadsLabel.TabIndex = 2;
            threadsLabel.Text = "Threads:";
            mainToolTip.SetToolTip(threadsLabel, "Number of concurrent threads (simulated users).");
            // 
            // threadsNumeric
            // 
            threadsNumeric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            threadsNumeric.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            threadsNumeric.Location = new Point(90, 62);
            threadsNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            threadsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            threadsNumeric.Name = "threadsNumeric";
            threadsNumeric.Size = new Size(347, 29);
            threadsNumeric.TabIndex = 3;
            mainToolTip.SetToolTip(threadsNumeric, "Number of concurrent threads (simulated users).");
            threadsNumeric.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // requestsPerSecondLabel
            // 
            requestsPerSecondLabel.AutoSize = true;
            requestsPerSecondLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestsPerSecondLabel.Location = new Point(16, 99);
            requestsPerSecondLabel.Name = "requestsPerSecondLabel";
            requestsPerSecondLabel.Size = new Size(157, 21);
            requestsPerSecondLabel.TabIndex = 4;
            requestsPerSecondLabel.Text = "Requests Per Second:";
            mainToolTip.SetToolTip(requestsPerSecondLabel, "Number of requests per second per thread.");
            // 
            // requestsPerSecondNumeric
            // 
            requestsPerSecondNumeric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestsPerSecondNumeric.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            requestsPerSecondNumeric.Location = new Point(179, 95);
            requestsPerSecondNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            requestsPerSecondNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            requestsPerSecondNumeric.Name = "requestsPerSecondNumeric";
            requestsPerSecondNumeric.Size = new Size(258, 29);
            requestsPerSecondNumeric.TabIndex = 5;
            mainToolTip.SetToolTip(requestsPerSecondNumeric, "Number of requests per second per thread.");
            requestsPerSecondNumeric.Value = new decimal(new int[] { 2500, 0, 0, 0 });
            // 
            // coreOptionsGroupBox
            // 
            coreOptionsGroupBox.Controls.Add(methodComboBox);
            coreOptionsGroupBox.Controls.Add(methodLabel);
            coreOptionsGroupBox.Controls.Add(durationLabel);
            coreOptionsGroupBox.Controls.Add(durationNumeric);
            coreOptionsGroupBox.Controls.Add(targetUrlLabel);
            coreOptionsGroupBox.Controls.Add(requestsPerSecondLabel);
            coreOptionsGroupBox.Controls.Add(requestsPerSecondNumeric);
            coreOptionsGroupBox.Controls.Add(threadsLabel);
            coreOptionsGroupBox.Controls.Add(targetUrlTextbox);
            coreOptionsGroupBox.Controls.Add(threadsNumeric);
            coreOptionsGroupBox.Location = new Point(12, 12);
            coreOptionsGroupBox.Name = "coreOptionsGroupBox";
            coreOptionsGroupBox.Size = new Size(451, 215);
            coreOptionsGroupBox.TabIndex = 6;
            coreOptionsGroupBox.TabStop = false;
            coreOptionsGroupBox.Text = "Core Options";
            // 
            // methodComboBox
            // 
            methodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            methodComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            methodComboBox.FormattingEnabled = true;
            methodComboBox.Items.AddRange(new object[] { "GET", "POST", "PUT", "DELETE" });
            methodComboBox.Location = new Point(130, 165);
            methodComboBox.Name = "methodComboBox";
            methodComboBox.Size = new Size(307, 29);
            methodComboBox.TabIndex = 9;
            mainToolTip.SetToolTip(methodComboBox, "HTTP request method.");
            // 
            // methodLabel
            // 
            methodLabel.AutoSize = true;
            methodLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            methodLabel.Location = new Point(17, 168);
            methodLabel.Name = "methodLabel";
            methodLabel.Size = new Size(107, 21);
            methodLabel.TabIndex = 8;
            methodLabel.Text = "HTTP Method:";
            mainToolTip.SetToolTip(methodLabel, "HTTP request method.");
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(16, 132);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(146, 21);
            durationLabel.TabIndex = 7;
            durationLabel.Text = "Duration (Seconds):";
            mainToolTip.SetToolTip(durationLabel, "Total test time in seconds.");
            // 
            // durationNumeric
            // 
            durationNumeric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationNumeric.Location = new Point(168, 130);
            durationNumeric.Maximum = new decimal(new int[] { 86400, 0, 0, 0 });
            durationNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            durationNumeric.Name = "durationNumeric";
            durationNumeric.Size = new Size(269, 29);
            durationNumeric.TabIndex = 6;
            mainToolTip.SetToolTip(durationNumeric, "Total test time in seconds.");
            durationNumeric.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // advancedOptionsGroupBox
            // 
            advancedOptionsGroupBox.Controls.Add(timeoutLabel);
            advancedOptionsGroupBox.Controls.Add(timeoutNumeric);
            advancedOptionsGroupBox.Controls.Add(followRedirectsCheckBox);
            advancedOptionsGroupBox.Controls.Add(randomizeHeadersCheckBox);
            advancedOptionsGroupBox.Controls.Add(keepAliveCheckBox);
            advancedOptionsGroupBox.Location = new Point(12, 233);
            advancedOptionsGroupBox.Name = "advancedOptionsGroupBox";
            advancedOptionsGroupBox.Size = new Size(215, 181);
            advancedOptionsGroupBox.TabIndex = 7;
            advancedOptionsGroupBox.TabStop = false;
            advancedOptionsGroupBox.Text = "Advanced Options";
            // 
            // timeoutLabel
            // 
            timeoutLabel.AutoSize = true;
            timeoutLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeoutLabel.Location = new Point(16, 133);
            timeoutLabel.Name = "timeoutLabel";
            timeoutLabel.Size = new Size(107, 21);
            timeoutLabel.TabIndex = 10;
            timeoutLabel.Text = "Timeout (MS):";
            mainToolTip.SetToolTip(timeoutLabel, "Timeout for each request in milliseconds.");
            // 
            // timeoutNumeric
            // 
            timeoutNumeric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeoutNumeric.Location = new Point(129, 131);
            timeoutNumeric.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            timeoutNumeric.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            timeoutNumeric.Name = "timeoutNumeric";
            timeoutNumeric.Size = new Size(66, 29);
            timeoutNumeric.TabIndex = 10;
            mainToolTip.SetToolTip(timeoutNumeric, "Timeout for each request in milliseconds.");
            timeoutNumeric.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // followRedirectsCheckBox
            // 
            followRedirectsCheckBox.AutoSize = true;
            followRedirectsCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            followRedirectsCheckBox.Location = new Point(16, 93);
            followRedirectsCheckBox.Name = "followRedirectsCheckBox";
            followRedirectsCheckBox.Size = new Size(143, 25);
            followRedirectsCheckBox.TabIndex = 10;
            followRedirectsCheckBox.Text = "Follow Redirects";
            mainToolTip.SetToolTip(followRedirectsCheckBox, "Automatically follow HTTP 3xx redirects.");
            followRedirectsCheckBox.UseVisualStyleBackColor = true;
            // 
            // randomizeHeadersCheckBox
            // 
            randomizeHeadersCheckBox.AutoSize = true;
            randomizeHeadersCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            randomizeHeadersCheckBox.Location = new Point(16, 62);
            randomizeHeadersCheckBox.Name = "randomizeHeadersCheckBox";
            randomizeHeadersCheckBox.Size = new Size(168, 25);
            randomizeHeadersCheckBox.TabIndex = 9;
            randomizeHeadersCheckBox.Text = "Randomize Headers";
            mainToolTip.SetToolTip(randomizeHeadersCheckBox, "Randomize headers slightly for realism (Recommended).");
            randomizeHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // keepAliveCheckBox
            // 
            keepAliveCheckBox.AutoSize = true;
            keepAliveCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keepAliveCheckBox.Location = new Point(16, 31);
            keepAliveCheckBox.Name = "keepAliveCheckBox";
            keepAliveCheckBox.Size = new Size(101, 25);
            keepAliveCheckBox.TabIndex = 8;
            keepAliveCheckBox.Text = "Keep Alive";
            mainToolTip.SetToolTip(keepAliveCheckBox, "Use persistent HTTP connections.");
            keepAliveCheckBox.UseVisualStyleBackColor = true;
            // 
            // liveStatsCheckBox
            // 
            liveStatsCheckBox.AutoSize = true;
            liveStatsCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            liveStatsCheckBox.Location = new Point(18, 31);
            liveStatsCheckBox.Name = "liveStatsCheckBox";
            liveStatsCheckBox.Size = new Size(94, 25);
            liveStatsCheckBox.TabIndex = 11;
            liveStatsCheckBox.Text = "Live Stats";
            mainToolTip.SetToolTip(liveStatsCheckBox, "Show real-time metrics while running.");
            liveStatsCheckBox.UseVisualStyleBackColor = true;
            // 
            // logToFileCheckBox
            // 
            logToFileCheckBox.AutoSize = true;
            logToFileCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logToFileCheckBox.Location = new Point(18, 62);
            logToFileCheckBox.Name = "logToFileCheckBox";
            logToFileCheckBox.Size = new Size(102, 25);
            logToFileCheckBox.TabIndex = 12;
            logToFileCheckBox.Text = "Log To File";
            mainToolTip.SetToolTip(logToFileCheckBox, "Save all request logs to a file.");
            logToFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveErrorsOnlyCheckBox
            // 
            saveErrorsOnlyCheckBox.AutoSize = true;
            saveErrorsOnlyCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveErrorsOnlyCheckBox.Location = new Point(18, 93);
            saveErrorsOnlyCheckBox.Name = "saveErrorsOnlyCheckBox";
            saveErrorsOnlyCheckBox.Size = new Size(145, 25);
            saveErrorsOnlyCheckBox.TabIndex = 13;
            saveErrorsOnlyCheckBox.Text = "Save Errors Only";
            mainToolTip.SetToolTip(saveErrorsOnlyCheckBox, "Log only failed requests (4xx/5xx).");
            saveErrorsOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // exportCheckBox
            // 
            exportCheckBox.AutoSize = true;
            exportCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportCheckBox.Location = new Point(18, 124);
            exportCheckBox.Name = "exportCheckBox";
            exportCheckBox.Size = new Size(196, 25);
            exportCheckBox.TabIndex = 14;
            exportCheckBox.Text = "Export Summary Report";
            mainToolTip.SetToolTip(exportCheckBox, "Generate and save a summary report after the test (e.g., total requests, average latency, error rate).");
            exportCheckBox.UseVisualStyleBackColor = true;
            // 
            // outputGroupBox
            // 
            outputGroupBox.Controls.Add(exportCheckBox);
            outputGroupBox.Controls.Add(saveErrorsOnlyCheckBox);
            outputGroupBox.Controls.Add(logToFileCheckBox);
            outputGroupBox.Controls.Add(liveStatsCheckBox);
            outputGroupBox.Location = new Point(233, 233);
            outputGroupBox.Name = "outputGroupBox";
            outputGroupBox.Size = new Size(230, 181);
            outputGroupBox.TabIndex = 11;
            outputGroupBox.TabStop = false;
            outputGroupBox.Text = "Output / Monitoring";
            // 
            // presetsGroupBox
            // 
            presetsGroupBox.Controls.Add(intensePresetButton);
            presetsGroupBox.Controls.Add(standardPresetButton);
            presetsGroupBox.Controls.Add(lightPresetButton);
            presetsGroupBox.Location = new Point(12, 420);
            presetsGroupBox.Name = "presetsGroupBox";
            presetsGroupBox.Size = new Size(451, 66);
            presetsGroupBox.TabIndex = 12;
            presetsGroupBox.TabStop = false;
            presetsGroupBox.Text = "Presets";
            // 
            // intensePresetButton
            // 
            intensePresetButton.Font = new Font("Segoe UI", 9.75F);
            intensePresetButton.ForeColor = Color.FromArgb(192, 0, 0);
            intensePresetButton.Location = new Point(312, 22);
            intensePresetButton.Name = "intensePresetButton";
            intensePresetButton.Size = new Size(125, 29);
            intensePresetButton.TabIndex = 15;
            intensePresetButton.Text = "Intense Attack";
            intensePresetButton.UseVisualStyleBackColor = true;
            intensePresetButton.Click += intensePresetButton_Click;
            // 
            // standardPresetButton
            // 
            standardPresetButton.Font = new Font("Segoe UI", 9.75F);
            standardPresetButton.ForeColor = Color.FromArgb(192, 192, 0);
            standardPresetButton.Location = new Point(165, 22);
            standardPresetButton.Name = "standardPresetButton";
            standardPresetButton.Size = new Size(125, 29);
            standardPresetButton.TabIndex = 14;
            standardPresetButton.Text = "Standard Attack";
            standardPresetButton.UseVisualStyleBackColor = true;
            standardPresetButton.Click += standardPresetButton_Click;
            // 
            // lightPresetButton
            // 
            lightPresetButton.Font = new Font("Segoe UI", 9.75F);
            lightPresetButton.ForeColor = Color.FromArgb(0, 192, 0);
            lightPresetButton.Location = new Point(17, 22);
            lightPresetButton.Name = "lightPresetButton";
            lightPresetButton.Size = new Size(125, 29);
            lightPresetButton.TabIndex = 13;
            lightPresetButton.Text = "Light Attack";
            lightPresetButton.UseVisualStyleBackColor = true;
            lightPresetButton.Click += lightPresetButton_Click;
            // 
            // attackButton
            // 
            attackButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attackButton.Location = new Point(469, 240);
            attackButton.Name = "attackButton";
            attackButton.Size = new Size(326, 68);
            attackButton.TabIndex = 13;
            attackButton.Text = "ATTACK";
            attackButton.UseVisualStyleBackColor = true;
            attackButton.Click += attackButton_Click;
            // 
            // statsGroupBox
            // 
            statsGroupBox.Controls.Add(progressBarLabel);
            statsGroupBox.Controls.Add(statsProgressBar);
            statsGroupBox.Controls.Add(activeThreadsLabel);
            statsGroupBox.Controls.Add(totalErrorsLabel);
            statsGroupBox.Controls.Add(totalRequestsSentLabel);
            statsGroupBox.Controls.Add(timeElapsedLabel);
            statsGroupBox.Location = new Point(469, 12);
            statsGroupBox.Name = "statsGroupBox";
            statsGroupBox.Size = new Size(326, 215);
            statsGroupBox.TabIndex = 14;
            statsGroupBox.TabStop = false;
            statsGroupBox.Text = "Stats";
            // 
            // progressBarLabel
            // 
            progressBarLabel.AutoSize = true;
            progressBarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            progressBarLabel.Location = new Point(15, 144);
            progressBarLabel.Name = "progressBarLabel";
            progressBarLabel.Size = new Size(71, 15);
            progressBarLabel.TabIndex = 19;
            progressBarLabel.Text = "Progress 0%";
            // 
            // statsProgressBar
            // 
            statsProgressBar.Location = new Point(15, 168);
            statsProgressBar.Name = "statsProgressBar";
            statsProgressBar.Size = new Size(305, 29);
            statsProgressBar.TabIndex = 15;
            // 
            // activeThreadsLabel
            // 
            activeThreadsLabel.AutoSize = true;
            activeThreadsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activeThreadsLabel.Location = new Point(15, 91);
            activeThreadsLabel.Name = "activeThreadsLabel";
            activeThreadsLabel.Size = new Size(127, 21);
            activeThreadsLabel.TabIndex = 18;
            activeThreadsLabel.Text = "Active Threads: 0";
            // 
            // totalErrorsLabel
            // 
            totalErrorsLabel.AutoSize = true;
            totalErrorsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalErrorsLabel.Location = new Point(15, 70);
            totalErrorsLabel.Name = "totalErrorsLabel";
            totalErrorsLabel.Size = new Size(104, 21);
            totalErrorsLabel.TabIndex = 17;
            totalErrorsLabel.Text = "Total Errors: 0";
            // 
            // totalRequestsSentLabel
            // 
            totalRequestsSentLabel.AutoSize = true;
            totalRequestsSentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalRequestsSentLabel.Location = new Point(15, 49);
            totalRequestsSentLabel.Name = "totalRequestsSentLabel";
            totalRequestsSentLabel.Size = new Size(160, 21);
            totalRequestsSentLabel.TabIndex = 16;
            totalRequestsSentLabel.Text = "Total Requests Sent: 0";
            // 
            // timeElapsedLabel
            // 
            timeElapsedLabel.AutoSize = true;
            timeElapsedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeElapsedLabel.Location = new Point(15, 28);
            timeElapsedLabel.Name = "timeElapsedLabel";
            timeElapsedLabel.Size = new Size(168, 21);
            timeElapsedLabel.TabIndex = 15;
            timeElapsedLabel.Text = "Time Elapsed: 00:00:00";
            // 
            // ElapsedTimer
            // 
            ElapsedTimer.Tick += ElapsedTimer_Tick;
            // 
            // terminateButton
            // 
            terminateButton.ForeColor = Color.FromArgb(192, 0, 0);
            terminateButton.Location = new Point(469, 314);
            terminateButton.Name = "terminateButton";
            terminateButton.Size = new Size(326, 37);
            terminateButton.TabIndex = 20;
            terminateButton.Text = "TERMINATE";
            terminateButton.UseVisualStyleBackColor = true;
            terminateButton.Click += terminateButton_Click;
            // 
            // infoGroupBox
            // 
            infoGroupBox.Controls.Add(exitButton);
            infoGroupBox.Controls.Add(restartButton);
            infoGroupBox.Controls.Add(versionLabel);
            infoGroupBox.Location = new Point(469, 357);
            infoGroupBox.Name = "infoGroupBox";
            infoGroupBox.Size = new Size(326, 129);
            infoGroupBox.TabIndex = 21;
            infoGroupBox.TabStop = false;
            infoGroupBox.Text = "Info";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(126, 89);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // restartButton
            // 
            restartButton.Location = new Point(126, 63);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(75, 23);
            restartButton.TabIndex = 1;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versionLabel.Location = new Point(85, 27);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(147, 30);
            versionLabel.TabIndex = 0;
            versionLabel.Text = "Overloadr v1.0";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 500);
            Controls.Add(infoGroupBox);
            Controls.Add(terminateButton);
            Controls.Add(statsGroupBox);
            Controls.Add(attackButton);
            Controls.Add(presetsGroupBox);
            Controls.Add(outputGroupBox);
            Controls.Add(advancedOptionsGroupBox);
            Controls.Add(coreOptionsGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Text = "Overloadr";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)threadsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)requestsPerSecondNumeric).EndInit();
            coreOptionsGroupBox.ResumeLayout(false);
            coreOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)durationNumeric).EndInit();
            advancedOptionsGroupBox.ResumeLayout(false);
            advancedOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timeoutNumeric).EndInit();
            outputGroupBox.ResumeLayout(false);
            outputGroupBox.PerformLayout();
            presetsGroupBox.ResumeLayout(false);
            statsGroupBox.ResumeLayout(false);
            statsGroupBox.PerformLayout();
            infoGroupBox.ResumeLayout(false);
            infoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label targetUrlLabel;
        private TextBox targetUrlTextbox;
        private Label threadsLabel;
        private NumericUpDown threadsNumeric;
        private Label requestsPerSecondLabel;
        private NumericUpDown requestsPerSecondNumeric;
        private GroupBox coreOptionsGroupBox;
        private ComboBox methodComboBox;
        private Label methodLabel;
        private Label durationLabel;
        private NumericUpDown durationNumeric;
        private GroupBox advancedOptionsGroupBox;
        private NumericUpDown timeoutNumeric;
        private CheckBox followRedirectsCheckBox;
        private CheckBox randomizeHeadersCheckBox;
        private CheckBox keepAliveCheckBox;
        private Label timeoutLabel;
        private ToolTip mainToolTip;
        private GroupBox outputGroupBox;
        private CheckBox saveErrorsOnlyCheckBox;
        private CheckBox logToFileCheckBox;
        private CheckBox liveStatsCheckBox;
        private CheckBox exportCheckBox;
        private GroupBox presetsGroupBox;
        private Button intensePresetButton;
        private Button standardPresetButton;
        private Button lightPresetButton;
        private Button attackButton;
        private GroupBox statsGroupBox;
        private Label timeElapsedLabel;
        private Label totalRequestsSentLabel;
        private Label activeThreadsLabel;
        private Label totalErrorsLabel;
        private Label progressBarLabel;
        private ProgressBar statsProgressBar;
        private System.Windows.Forms.Timer ElapsedTimer;
        private Button terminateButton;
        private GroupBox infoGroupBox;
        private Label versionLabel;
        private Button exitButton;
        private Button restartButton;
    }
}
