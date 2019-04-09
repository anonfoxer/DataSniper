namespace DataChewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.includeDataDump = new System.Windows.Forms.CheckBox();
            this.includeMemoryUsage = new System.Windows.Forms.CheckBox();
            this.includeCpuUsage = new System.Windows.Forms.CheckBox();
            this.includeDlls = new System.Windows.Forms.CheckBox();
            this.includeCrashlog = new System.Windows.Forms.CheckBox();
            this.includeMemoryDump = new System.Windows.Forms.CheckBox();
            this.confirmExe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.targetExeName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataDumpLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.crashlogLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.memDumpLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.memUsageVal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cpuUsageVal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.targetAdressVal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.targetProcessName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.runSniper = new System.Windows.Forms.Button();
            this.giveMeInfo = new System.Windows.Forms.Button();
            this.giveMeUpdates = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Sniper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(182, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "by anonfoxer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.includeDataDump);
            this.groupBox1.Controls.Add(this.includeMemoryUsage);
            this.groupBox1.Controls.Add(this.includeCpuUsage);
            this.groupBox1.Controls.Add(this.includeDlls);
            this.groupBox1.Controls.Add(this.includeCrashlog);
            this.groupBox1.Controls.Add(this.includeMemoryDump);
            this.groupBox1.Controls.Add(this.confirmExe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.targetExeName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(17, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sniping Options";
            // 
            // includeDataDump
            // 
            this.includeDataDump.AutoSize = true;
            this.includeDataDump.Location = new System.Drawing.Point(127, 104);
            this.includeDataDump.Name = "includeDataDump";
            this.includeDataDump.Size = new System.Drawing.Size(80, 17);
            this.includeDataDump.TabIndex = 9;
            this.includeDataDump.Text = "Data Dump";
            this.includeDataDump.UseVisualStyleBackColor = true;
            // 
            // includeMemoryUsage
            // 
            this.includeMemoryUsage.AutoSize = true;
            this.includeMemoryUsage.Location = new System.Drawing.Point(127, 81);
            this.includeMemoryUsage.Name = "includeMemoryUsage";
            this.includeMemoryUsage.Size = new System.Drawing.Size(97, 17);
            this.includeMemoryUsage.TabIndex = 8;
            this.includeMemoryUsage.Text = "Memory Usage";
            this.includeMemoryUsage.UseVisualStyleBackColor = true;
            // 
            // includeCpuUsage
            // 
            this.includeCpuUsage.AutoSize = true;
            this.includeCpuUsage.Location = new System.Drawing.Point(127, 58);
            this.includeCpuUsage.Name = "includeCpuUsage";
            this.includeCpuUsage.Size = new System.Drawing.Size(82, 17);
            this.includeCpuUsage.TabIndex = 7;
            this.includeCpuUsage.Text = "CPU Usage";
            this.includeCpuUsage.UseVisualStyleBackColor = true;
            // 
            // includeDlls
            // 
            this.includeDlls.AutoSize = true;
            this.includeDlls.Location = new System.Drawing.Point(5, 104);
            this.includeDlls.Name = "includeDlls";
            this.includeDlls.Size = new System.Drawing.Size(62, 17);
            this.includeDlls.TabIndex = 6;
            this.includeDlls.Text = "Dll Lists";
            this.includeDlls.UseVisualStyleBackColor = true;
            // 
            // includeCrashlog
            // 
            this.includeCrashlog.AutoSize = true;
            this.includeCrashlog.Location = new System.Drawing.Point(5, 81);
            this.includeCrashlog.Name = "includeCrashlog";
            this.includeCrashlog.Size = new System.Drawing.Size(95, 17);
            this.includeCrashlog.TabIndex = 5;
            this.includeCrashlog.Text = "Crash and Log";
            this.includeCrashlog.UseVisualStyleBackColor = true;
            // 
            // includeMemoryDump
            // 
            this.includeMemoryDump.AutoSize = true;
            this.includeMemoryDump.Checked = true;
            this.includeMemoryDump.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeMemoryDump.Location = new System.Drawing.Point(6, 58);
            this.includeMemoryDump.Name = "includeMemoryDump";
            this.includeMemoryDump.Size = new System.Drawing.Size(94, 17);
            this.includeMemoryDump.TabIndex = 4;
            this.includeMemoryDump.Text = "Memory Dump";
            this.includeMemoryDump.UseVisualStyleBackColor = true;
            // 
            // confirmExe
            // 
            this.confirmExe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmExe.Location = new System.Drawing.Point(127, 31);
            this.confirmExe.Name = "confirmExe";
            this.confirmExe.Size = new System.Drawing.Size(117, 20);
            this.confirmExe.TabIndex = 3;
            this.confirmExe.Text = "Lock On";
            this.confirmExe.UseVisualStyleBackColor = true;
            this.confirmExe.Click += new System.EventHandler(this.confirmExe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Task Name (w/o extention)";
            // 
            // targetExeName
            // 
            this.targetExeName.Location = new System.Drawing.Point(6, 31);
            this.targetExeName.Name = "targetExeName";
            this.targetExeName.Size = new System.Drawing.Size(115, 20);
            this.targetExeName.TabIndex = 0;
            this.targetExeName.TextChanged += new System.EventHandler(this.targetExeName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataDumpLocation);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.crashlogLocation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.memDumpLocation);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(17, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Center";
            // 
            // dataDumpLocation
            // 
            this.dataDumpLocation.Location = new System.Drawing.Point(5, 110);
            this.dataDumpLocation.Name = "dataDumpLocation";
            this.dataDumpLocation.Size = new System.Drawing.Size(149, 20);
            this.dataDumpLocation.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(3, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data Dump Location";
            // 
            // crashlogLocation
            // 
            this.crashlogLocation.Location = new System.Drawing.Point(6, 71);
            this.crashlogLocation.Name = "crashlogLocation";
            this.crashlogLocation.Size = new System.Drawing.Size(148, 20);
            this.crashlogLocation.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Crash Log Location";
            // 
            // memDumpLocation
            // 
            this.memDumpLocation.Location = new System.Drawing.Point(5, 32);
            this.memDumpLocation.Name = "memDumpLocation";
            this.memDumpLocation.Size = new System.Drawing.Size(149, 20);
            this.memDumpLocation.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Memory Dump Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.memUsageVal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cpuUsageVal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(317, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 285);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CPU and Memory Usages";
            // 
            // memUsageVal
            // 
            this.memUsageVal.AutoSize = true;
            this.memUsageVal.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memUsageVal.ForeColor = System.Drawing.SystemColors.Control;
            this.memUsageVal.Location = new System.Drawing.Point(161, 137);
            this.memUsageVal.Name = "memUsageVal";
            this.memUsageVal.Size = new System.Drawing.Size(37, 20);
            this.memUsageVal.TabIndex = 4;
            this.memUsageVal.Text = "-0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(6, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mem Usage:";
            // 
            // cpuUsageVal
            // 
            this.cpuUsageVal.AutoSize = true;
            this.cpuUsageVal.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuUsageVal.ForeColor = System.Drawing.SystemColors.Control;
            this.cpuUsageVal.Location = new System.Drawing.Point(161, 30);
            this.cpuUsageVal.Name = "cpuUsageVal";
            this.cpuUsageVal.Size = new System.Drawing.Size(37, 20);
            this.cpuUsageVal.TabIndex = 2;
            this.cpuUsageVal.Text = "-0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "CPU Usage:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.targetAdressVal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.targetProcessName);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(603, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 285);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Process Details";
            // 
            // targetAdressVal
            // 
            this.targetAdressVal.AutoSize = true;
            this.targetAdressVal.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetAdressVal.ForeColor = System.Drawing.SystemColors.Control;
            this.targetAdressVal.Location = new System.Drawing.Point(6, 153);
            this.targetAdressVal.Name = "targetAdressVal";
            this.targetAdressVal.Size = new System.Drawing.Size(37, 20);
            this.targetAdressVal.TabIndex = 5;
            this.targetAdressVal.Text = "-0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("OCR A Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Address Value:";
            // 
            // targetProcessName
            // 
            this.targetProcessName.AutoSize = true;
            this.targetProcessName.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetProcessName.ForeColor = System.Drawing.SystemColors.Control;
            this.targetProcessName.Location = new System.Drawing.Point(5, 42);
            this.targetProcessName.Name = "targetProcessName";
            this.targetProcessName.Size = new System.Drawing.Size(37, 20);
            this.targetProcessName.TabIndex = 3;
            this.targetProcessName.Text = "-0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("OCR A Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Targeted Process:";
            // 
            // runSniper
            // 
            this.runSniper.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runSniper.Location = new System.Drawing.Point(17, 327);
            this.runSniper.Name = "runSniper";
            this.runSniper.Size = new System.Drawing.Size(294, 89);
            this.runSniper.TabIndex = 6;
            this.runSniper.Text = "Snipe";
            this.runSniper.UseVisualStyleBackColor = true;
            // 
            // giveMeInfo
            // 
            this.giveMeInfo.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveMeInfo.Location = new System.Drawing.Point(317, 327);
            this.giveMeInfo.Name = "giveMeInfo";
            this.giveMeInfo.Size = new System.Drawing.Size(279, 89);
            this.giveMeInfo.TabIndex = 7;
            this.giveMeInfo.Text = "Info";
            this.giveMeInfo.UseVisualStyleBackColor = true;
            // 
            // giveMeUpdates
            // 
            this.giveMeUpdates.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveMeUpdates.Location = new System.Drawing.Point(603, 327);
            this.giveMeUpdates.Name = "giveMeUpdates";
            this.giveMeUpdates.Size = new System.Drawing.Size(273, 89);
            this.giveMeUpdates.TabIndex = 8;
            this.giveMeUpdates.Text = "Updates";
            this.giveMeUpdates.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(897, 428);
            this.Controls.Add(this.giveMeUpdates);
            this.Controls.Add(this.giveMeInfo);
            this.Controls.Add(this.runSniper);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Data Sniper || anonfoxer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox includeDataDump;
        private System.Windows.Forms.CheckBox includeMemoryUsage;
        private System.Windows.Forms.CheckBox includeCpuUsage;
        private System.Windows.Forms.CheckBox includeDlls;
        private System.Windows.Forms.CheckBox includeCrashlog;
        private System.Windows.Forms.CheckBox includeMemoryDump;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetExeName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dataDumpLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox crashlogLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox memDumpLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label memUsageVal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cpuUsageVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label targetAdressVal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label targetProcessName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button runSniper;
        private System.Windows.Forms.Button giveMeInfo;
        private System.Windows.Forms.Button giveMeUpdates;
        private System.Windows.Forms.Button confirmExe;
    }
}

