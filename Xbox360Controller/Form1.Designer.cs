namespace XboxControllerTest {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblLeftStickX = new System.Windows.Forms.Label();
            this.lblLeftStickY = new System.Windows.Forms.Label();
            this.lblRightStickY = new System.Windows.Forms.Label();
            this.lblRightStickX = new System.Windows.Forms.Label();
            this.lblLeftTrigger = new System.Windows.Forms.Label();
            this.lblRightTrigger = new System.Windows.Forms.Label();
            this.lblConnected = new System.Windows.Forms.Label();
            this.pbLeftStickX = new System.Windows.Forms.ProgressBar();
            this.pbLeftStickY = new System.Windows.Forms.ProgressBar();
            this.pbRightStickX = new System.Windows.Forms.ProgressBar();
            this.pbRightStickY = new System.Windows.Forms.ProgressBar();
            this.pbLeftTrigger = new System.Windows.Forms.ProgressBar();
            this.pbRightTrigger = new System.Windows.Forms.ProgressBar();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbY = new System.Windows.Forms.CheckBox();
            this.cbX = new System.Windows.Forms.CheckBox();
            this.cbRightStick = new System.Windows.Forms.CheckBox();
            this.cbLeftStick = new System.Windows.Forms.CheckBox();
            this.cbRB = new System.Windows.Forms.CheckBox();
            this.cbLB = new System.Windows.Forms.CheckBox();
            this.cbStart = new System.Windows.Forms.CheckBox();
            this.cbBack = new System.Windows.Forms.CheckBox();
            this.tbLeftMotor = new System.Windows.Forms.TrackBar();
            this.tbRightMotor = new System.Windows.Forms.TrackBar();
            this.lblLeftMotor = new System.Windows.Forms.Label();
            this.lblRightMotor = new System.Windows.Forms.Label();
            this.cbDL = new System.Windows.Forms.CheckBox();
            this.cbDD = new System.Windows.Forms.CheckBox();
            this.cbDR = new System.Windows.Forms.CheckBox();
            this.cbDU = new System.Windows.Forms.CheckBox();
            this.lblBattery = new System.Windows.Forms.Label();
            this.lblBatteryLevel = new System.Windows.Forms.Label();
            this.lblBatteryType = new System.Windows.Forms.Label();
            this.controllerCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(14, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 50;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblLeftStickX
            // 
            this.lblLeftStickX.AutoSize = true;
            this.lblLeftStickX.Location = new System.Drawing.Point(13, 138);
            this.lblLeftStickX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeftStickX.Name = "lblLeftStickX";
            this.lblLeftStickX.Size = new System.Drawing.Size(83, 17);
            this.lblLeftStickX.TabIndex = 1;
            this.lblLeftStickX.Text = "Left Stick X:";
            // 
            // lblLeftStickY
            // 
            this.lblLeftStickY.AutoSize = true;
            this.lblLeftStickY.Location = new System.Drawing.Point(13, 186);
            this.lblLeftStickY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeftStickY.Name = "lblLeftStickY";
            this.lblLeftStickY.Size = new System.Drawing.Size(83, 17);
            this.lblLeftStickY.TabIndex = 10;
            this.lblLeftStickY.Text = "Left Stick Y:";
            // 
            // lblRightStickY
            // 
            this.lblRightStickY.AutoSize = true;
            this.lblRightStickY.Location = new System.Drawing.Point(13, 282);
            this.lblRightStickY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRightStickY.Name = "lblRightStickY";
            this.lblRightStickY.Size = new System.Drawing.Size(92, 17);
            this.lblRightStickY.TabIndex = 12;
            this.lblRightStickY.Text = "Right Stick Y:";
            // 
            // lblRightStickX
            // 
            this.lblRightStickX.AutoSize = true;
            this.lblRightStickX.Location = new System.Drawing.Point(13, 234);
            this.lblRightStickX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRightStickX.Name = "lblRightStickX";
            this.lblRightStickX.Size = new System.Drawing.Size(92, 17);
            this.lblRightStickX.TabIndex = 11;
            this.lblRightStickX.Text = "Right Stick X:";
            // 
            // lblLeftTrigger
            // 
            this.lblLeftTrigger.AutoSize = true;
            this.lblLeftTrigger.Location = new System.Drawing.Point(13, 330);
            this.lblLeftTrigger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeftTrigger.Name = "lblLeftTrigger";
            this.lblLeftTrigger.Size = new System.Drawing.Size(86, 17);
            this.lblLeftTrigger.TabIndex = 13;
            this.lblLeftTrigger.Text = "Left Trigger:";
            // 
            // lblRightTrigger
            // 
            this.lblRightTrigger.AutoSize = true;
            this.lblRightTrigger.Location = new System.Drawing.Point(13, 378);
            this.lblRightTrigger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRightTrigger.Name = "lblRightTrigger";
            this.lblRightTrigger.Size = new System.Drawing.Size(95, 17);
            this.lblRightTrigger.TabIndex = 14;
            this.lblRightTrigger.Text = "Right Trigger:";
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.ForeColor = System.Drawing.Color.Red;
            this.lblConnected.Location = new System.Drawing.Point(75, 11);
            this.lblConnected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(94, 17);
            this.lblConnected.TabIndex = 15;
            this.lblConnected.Text = "Disconnected";
            // 
            // pbLeftStickX
            // 
            this.pbLeftStickX.Location = new System.Drawing.Point(17, 158);
            this.pbLeftStickX.Margin = new System.Windows.Forms.Padding(4);
            this.pbLeftStickX.Name = "pbLeftStickX";
            this.pbLeftStickX.Size = new System.Drawing.Size(296, 25);
            this.pbLeftStickX.TabIndex = 16;
            // 
            // pbLeftStickY
            // 
            this.pbLeftStickY.Location = new System.Drawing.Point(17, 206);
            this.pbLeftStickY.Margin = new System.Windows.Forms.Padding(4);
            this.pbLeftStickY.Name = "pbLeftStickY";
            this.pbLeftStickY.Size = new System.Drawing.Size(296, 25);
            this.pbLeftStickY.TabIndex = 17;
            // 
            // pbRightStickX
            // 
            this.pbRightStickX.Location = new System.Drawing.Point(17, 254);
            this.pbRightStickX.Margin = new System.Windows.Forms.Padding(4);
            this.pbRightStickX.Name = "pbRightStickX";
            this.pbRightStickX.Size = new System.Drawing.Size(296, 25);
            this.pbRightStickX.TabIndex = 18;
            // 
            // pbRightStickY
            // 
            this.pbRightStickY.Location = new System.Drawing.Point(17, 302);
            this.pbRightStickY.Margin = new System.Windows.Forms.Padding(4);
            this.pbRightStickY.Name = "pbRightStickY";
            this.pbRightStickY.Size = new System.Drawing.Size(296, 25);
            this.pbRightStickY.TabIndex = 19;
            // 
            // pbLeftTrigger
            // 
            this.pbLeftTrigger.Location = new System.Drawing.Point(17, 350);
            this.pbLeftTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.pbLeftTrigger.Name = "pbLeftTrigger";
            this.pbLeftTrigger.Size = new System.Drawing.Size(296, 25);
            this.pbLeftTrigger.TabIndex = 20;
            // 
            // pbRightTrigger
            // 
            this.pbRightTrigger.Location = new System.Drawing.Point(17, 398);
            this.pbRightTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.pbRightTrigger.Name = "pbRightTrigger";
            this.pbRightTrigger.Size = new System.Drawing.Size(296, 25);
            this.pbRightTrigger.TabIndex = 21;
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Location = new System.Drawing.Point(353, 92);
            this.cbA.Margin = new System.Windows.Forms.Padding(4);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(39, 21);
            this.cbA.TabIndex = 22;
            this.cbA.Text = "A";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Location = new System.Drawing.Point(353, 121);
            this.cbB.Margin = new System.Windows.Forms.Padding(4);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(39, 21);
            this.cbB.TabIndex = 23;
            this.cbB.Text = "B";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbY
            // 
            this.cbY.AutoSize = true;
            this.cbY.Location = new System.Drawing.Point(353, 177);
            this.cbY.Margin = new System.Windows.Forms.Padding(4);
            this.cbY.Name = "cbY";
            this.cbY.Size = new System.Drawing.Size(39, 21);
            this.cbY.TabIndex = 25;
            this.cbY.Text = "Y";
            this.cbY.UseVisualStyleBackColor = true;
            // 
            // cbX
            // 
            this.cbX.AutoSize = true;
            this.cbX.Location = new System.Drawing.Point(353, 149);
            this.cbX.Margin = new System.Windows.Forms.Padding(4);
            this.cbX.Name = "cbX";
            this.cbX.Size = new System.Drawing.Size(39, 21);
            this.cbX.TabIndex = 24;
            this.cbX.Text = "X";
            this.cbX.UseVisualStyleBackColor = true;
            // 
            // cbRightStick
            // 
            this.cbRightStick.AutoSize = true;
            this.cbRightStick.Location = new System.Drawing.Point(353, 290);
            this.cbRightStick.Margin = new System.Windows.Forms.Padding(4);
            this.cbRightStick.Name = "cbRightStick";
            this.cbRightStick.Size = new System.Drawing.Size(97, 21);
            this.cbRightStick.TabIndex = 29;
            this.cbRightStick.Text = "Right Stick";
            this.cbRightStick.UseVisualStyleBackColor = true;
            // 
            // cbLeftStick
            // 
            this.cbLeftStick.AutoSize = true;
            this.cbLeftStick.Location = new System.Drawing.Point(353, 262);
            this.cbLeftStick.Margin = new System.Windows.Forms.Padding(4);
            this.cbLeftStick.Name = "cbLeftStick";
            this.cbLeftStick.Size = new System.Drawing.Size(88, 21);
            this.cbLeftStick.TabIndex = 28;
            this.cbLeftStick.Text = "Left Stick";
            this.cbLeftStick.UseVisualStyleBackColor = true;
            // 
            // cbRB
            // 
            this.cbRB.AutoSize = true;
            this.cbRB.Location = new System.Drawing.Point(353, 234);
            this.cbRB.Margin = new System.Windows.Forms.Padding(4);
            this.cbRB.Name = "cbRB";
            this.cbRB.Size = new System.Drawing.Size(49, 21);
            this.cbRB.TabIndex = 27;
            this.cbRB.Text = "RB";
            this.cbRB.UseVisualStyleBackColor = true;
            // 
            // cbLB
            // 
            this.cbLB.AutoSize = true;
            this.cbLB.Location = new System.Drawing.Point(353, 206);
            this.cbLB.Margin = new System.Windows.Forms.Padding(4);
            this.cbLB.Name = "cbLB";
            this.cbLB.Size = new System.Drawing.Size(47, 21);
            this.cbLB.TabIndex = 26;
            this.cbLB.Text = "LB";
            this.cbLB.UseVisualStyleBackColor = true;
            // 
            // cbStart
            // 
            this.cbStart.AutoSize = true;
            this.cbStart.Location = new System.Drawing.Point(353, 347);
            this.cbStart.Margin = new System.Windows.Forms.Padding(4);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(60, 21);
            this.cbStart.TabIndex = 31;
            this.cbStart.Text = "Start";
            this.cbStart.UseVisualStyleBackColor = true;
            // 
            // cbBack
            // 
            this.cbBack.AutoSize = true;
            this.cbBack.Location = new System.Drawing.Point(353, 319);
            this.cbBack.Margin = new System.Windows.Forms.Padding(4);
            this.cbBack.Name = "cbBack";
            this.cbBack.Size = new System.Drawing.Size(61, 21);
            this.cbBack.TabIndex = 30;
            this.cbBack.Text = "Back";
            this.cbBack.UseVisualStyleBackColor = true;
            // 
            // tbLeftMotor
            // 
            this.tbLeftMotor.Location = new System.Drawing.Point(17, 480);
            this.tbLeftMotor.Margin = new System.Windows.Forms.Padding(4);
            this.tbLeftMotor.Maximum = 100;
            this.tbLeftMotor.Name = "tbLeftMotor";
            this.tbLeftMotor.Size = new System.Drawing.Size(124, 56);
            this.tbLeftMotor.TabIndex = 33;
            this.tbLeftMotor.TickFrequency = 10;
            // 
            // tbRightMotor
            // 
            this.tbRightMotor.Location = new System.Drawing.Point(149, 480);
            this.tbRightMotor.Margin = new System.Windows.Forms.Padding(4);
            this.tbRightMotor.Maximum = 100;
            this.tbRightMotor.Name = "tbRightMotor";
            this.tbRightMotor.Size = new System.Drawing.Size(124, 56);
            this.tbRightMotor.TabIndex = 34;
            this.tbRightMotor.TickFrequency = 10;
            // 
            // lblLeftMotor
            // 
            this.lblLeftMotor.AutoSize = true;
            this.lblLeftMotor.Location = new System.Drawing.Point(13, 460);
            this.lblLeftMotor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeftMotor.Name = "lblLeftMotor";
            this.lblLeftMotor.Size = new System.Drawing.Size(72, 17);
            this.lblLeftMotor.TabIndex = 35;
            this.lblLeftMotor.Text = "Left Motor";
            // 
            // lblRightMotor
            // 
            this.lblRightMotor.AutoSize = true;
            this.lblRightMotor.Location = new System.Drawing.Point(145, 460);
            this.lblRightMotor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRightMotor.Name = "lblRightMotor";
            this.lblRightMotor.Size = new System.Drawing.Size(81, 17);
            this.lblRightMotor.TabIndex = 36;
            this.lblRightMotor.Text = "Right Motor";
            // 
            // cbDL
            // 
            this.cbDL.AutoSize = true;
            this.cbDL.Location = new System.Drawing.Point(353, 375);
            this.cbDL.Margin = new System.Windows.Forms.Padding(4);
            this.cbDL.Name = "cbDL";
            this.cbDL.Size = new System.Drawing.Size(68, 21);
            this.cbDL.TabIndex = 37;
            this.cbDL.Text = "D Left";
            this.cbDL.UseVisualStyleBackColor = true;
            // 
            // cbDD
            // 
            this.cbDD.AutoSize = true;
            this.cbDD.Location = new System.Drawing.Point(353, 460);
            this.cbDD.Margin = new System.Windows.Forms.Padding(4);
            this.cbDD.Name = "cbDD";
            this.cbDD.Size = new System.Drawing.Size(79, 21);
            this.cbDD.TabIndex = 38;
            this.cbDD.Text = "D Down";
            this.cbDD.UseVisualStyleBackColor = true;
            // 
            // cbDR
            // 
            this.cbDR.AutoSize = true;
            this.cbDR.Location = new System.Drawing.Point(353, 432);
            this.cbDR.Margin = new System.Windows.Forms.Padding(4);
            this.cbDR.Name = "cbDR";
            this.cbDR.Size = new System.Drawing.Size(77, 21);
            this.cbDR.TabIndex = 39;
            this.cbDR.Text = "D Right";
            this.cbDR.UseVisualStyleBackColor = true;
            // 
            // cbDU
            // 
            this.cbDU.AutoSize = true;
            this.cbDU.Location = new System.Drawing.Point(353, 404);
            this.cbDU.Margin = new System.Windows.Forms.Padding(4);
            this.cbDU.Name = "cbDU";
            this.cbDU.Size = new System.Drawing.Size(62, 21);
            this.cbDU.TabIndex = 40;
            this.cbDU.Text = "D Up";
            this.cbDU.UseVisualStyleBackColor = true;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(13, 43);
            this.lblBattery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(95, 17);
            this.lblBattery.TabIndex = 41;
            this.lblBattery.Text = "Battery Level:";
            // 
            // lblBatteryLevel
            // 
            this.lblBatteryLevel.AutoSize = true;
            this.lblBatteryLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblBatteryLevel.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBatteryLevel.Location = new System.Drawing.Point(117, 43);
            this.lblBatteryLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatteryLevel.Name = "lblBatteryLevel";
            this.lblBatteryLevel.Size = new System.Drawing.Size(47, 17);
            this.lblBatteryLevel.TabIndex = 42;
            this.lblBatteryLevel.Text = "Empty";
            // 
            // lblBatteryType
            // 
            this.lblBatteryType.AutoSize = true;
            this.lblBatteryType.Location = new System.Drawing.Point(13, 75);
            this.lblBatteryType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatteryType.Name = "lblBatteryType";
            this.lblBatteryType.Size = new System.Drawing.Size(93, 17);
            this.lblBatteryType.TabIndex = 43;
            this.lblBatteryType.Text = "Battery Type:";
            // 
            // controllerCombo
            // 
            this.controllerCombo.FormattingEnabled = true;
            this.controllerCombo.Location = new System.Drawing.Point(330, 8);
            this.controllerCombo.Name = "controllerCombo";
            this.controllerCombo.Size = new System.Drawing.Size(121, 24);
            this.controllerCombo.TabIndex = 44;
            this.controllerCombo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.controllerCombo_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Controller:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controllerCombo);
            this.Controls.Add(this.lblBatteryType);
            this.Controls.Add(this.lblBatteryLevel);
            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.cbDU);
            this.Controls.Add(this.cbDR);
            this.Controls.Add(this.cbDD);
            this.Controls.Add(this.cbDL);
            this.Controls.Add(this.lblRightMotor);
            this.Controls.Add(this.lblLeftMotor);
            this.Controls.Add(this.tbRightMotor);
            this.Controls.Add(this.tbLeftMotor);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.cbBack);
            this.Controls.Add(this.cbRightStick);
            this.Controls.Add(this.cbLeftStick);
            this.Controls.Add(this.cbRB);
            this.Controls.Add(this.cbLB);
            this.Controls.Add(this.cbY);
            this.Controls.Add(this.cbX);
            this.Controls.Add(this.cbB);
            this.Controls.Add(this.cbA);
            this.Controls.Add(this.pbRightTrigger);
            this.Controls.Add(this.pbLeftTrigger);
            this.Controls.Add(this.pbRightStickY);
            this.Controls.Add(this.pbRightStickX);
            this.Controls.Add(this.pbLeftStickY);
            this.Controls.Add(this.pbLeftStickX);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.lblRightTrigger);
            this.Controls.Add(this.lblLeftTrigger);
            this.Controls.Add(this.lblRightStickY);
            this.Controls.Add(this.lblRightStickX);
            this.Controls.Add(this.lblLeftStickY);
            this.Controls.Add(this.lblLeftStickX);
            this.Controls.Add(this.lblStatus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Xbox260ControllerTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblLeftStickX;
        private System.Windows.Forms.Label lblLeftStickY;
        private System.Windows.Forms.Label lblRightStickY;
        private System.Windows.Forms.Label lblRightStickX;
        private System.Windows.Forms.Label lblLeftTrigger;
        private System.Windows.Forms.Label lblRightTrigger;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.ProgressBar pbLeftStickX;
        private System.Windows.Forms.ProgressBar pbLeftStickY;
        private System.Windows.Forms.ProgressBar pbRightStickX;
        private System.Windows.Forms.ProgressBar pbRightStickY;
        private System.Windows.Forms.ProgressBar pbLeftTrigger;
        private System.Windows.Forms.ProgressBar pbRightTrigger;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbY;
        private System.Windows.Forms.CheckBox cbX;
        private System.Windows.Forms.CheckBox cbRightStick;
        private System.Windows.Forms.CheckBox cbLeftStick;
        private System.Windows.Forms.CheckBox cbRB;
        private System.Windows.Forms.CheckBox cbLB;
        private System.Windows.Forms.CheckBox cbStart;
        private System.Windows.Forms.CheckBox cbBack;
        private System.Windows.Forms.TrackBar tbLeftMotor;
        private System.Windows.Forms.TrackBar tbRightMotor;
        private System.Windows.Forms.Label lblLeftMotor;
        private System.Windows.Forms.Label lblRightMotor;
        private System.Windows.Forms.CheckBox cbDL;
        private System.Windows.Forms.CheckBox cbDD;
        private System.Windows.Forms.CheckBox cbDR;
        private System.Windows.Forms.CheckBox cbDU;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblBatteryLevel;
        private System.Windows.Forms.Label lblBatteryType;
        private System.Windows.Forms.ComboBox controllerCombo;
        private System.Windows.Forms.Label label1;
    }
}

