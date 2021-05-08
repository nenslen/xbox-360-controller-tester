using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.XInput;


using System.Threading;
//using SharpDX.XInput;


namespace XboxControllerTest {
    public partial class frmMain : Form {

        Xbox360Controller controller;

        Controller[] controllers = new[] {
            new Controller(UserIndex.One),
            new Controller(UserIndex.Two),
            new Controller(UserIndex.Three),
            new Controller(UserIndex.Four)
        };

        public frmMain() {
            InitializeComponent();
            controllerCombo.DataSource = controllers;
            controllerCombo.SelectedValueChanged += new EventHandler(this.comboBox1_SelectedValueChanged);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            controller.setController((Controller)controllerCombo.SelectedItem);
        }


        private void Form1_Load(object sender, EventArgs e) {
            controller = new Xbox360Controller((Controller)controllerCombo.SelectedItem);
            tmrUpdate.Start();
        }


        // Update values on form
        private void tmrUpdate_Tick(object sender, EventArgs e) {

            // Get current values
            controller.update();


            // Thumbsticks
            Point ls = controller.leftThumb;
            Point rs = controller.rightThumb;

            lblLeftStickX.Text = "Left Stick X: " + ls.X.ToString();
            pbLeftStickX.Value = 50 + (ls.X / 2);
            if (pbLeftStickX.Value > 1) { pbLeftStickX.Value -= 1; }

            lblLeftStickY.Text = "Left Stick Y: " + ls.Y.ToString();
            pbLeftStickY.Value = 50 + (ls.Y / 2);
            if (pbLeftStickY.Value > 1) { pbLeftStickY.Value -= 1; }

            lblRightStickX.Text = "Right Stick X: " + rs.X.ToString();
            pbRightStickX.Value = 50 + (rs.X / 2);
            if (pbRightStickX.Value > 1) { pbRightStickX.Value -= 1; }

            lblRightStickY.Text = "Right Stick Y: " + rs.Y.ToString();
            pbRightStickY.Value = 50 + (rs.Y / 2);
            if (pbRightStickY.Value > 1) { pbRightStickY.Value -= 1; }

            // Triggers
            float lt = controller.leftTrigger;
            float rt = controller.rightTrigger;

            lblLeftTrigger.Text = "Left Trigger: " + lt.ToString();
            pbLeftTrigger.Value = Convert.ToInt32(lt / 255 * 100);
            if (pbLeftTrigger.Value > 1) { pbLeftTrigger.Value -= 1; }

            lblRightTrigger.Text = "Right Trigger: " + rt.ToString();
            pbRightTrigger.Value = Convert.ToInt32(rt / 255 * 100);
            if (pbRightTrigger.Value > 1) { pbRightTrigger.Value -= 1; }

            // A, B, X, Y
            cbA.Checked = controller.buttons.A;
            cbB.Checked = controller.buttons.B;
            cbX.Checked = controller.buttons.X;
            cbY.Checked = controller.buttons.Y;

            // Left and Right bumpers
            cbLB.Checked = controller.buttons.LB;
            cbRB.Checked = controller.buttons.RB;

            // Clicking left and right thumbsticks
            cbLeftStick.Checked = controller.buttons.LeftStick;
            cbRightStick.Checked = controller.buttons.RightStick;

            // Start & Back
            cbBack.Checked = controller.buttons.Back;
            cbStart.Checked = controller.buttons.Start;

            // D-Pad
            cbDL.Checked = controller.buttons.DLeft;
            cbDU.Checked = controller.buttons.DUp;
            cbDR.Checked = controller.buttons.DRight;
            cbDD.Checked = controller.buttons.DDown;

            // Status & battery
            lblConnected.Text = controller.connected ? "Connected" : "Disconnected";
            lblConnected.ForeColor = controller.connected ? Color.Green : Color.Red;
            lblBatteryLevel.Text = controller.batteryLevel;
            lblBatteryLevel.ForeColor = controller.batteryColor;
            lblBatteryType.Text = "Battery Type: " + controller.batteryType;
            
            // Set vibration on controller
            controller.setVibration(tbLeftMotor.Value, tbRightMotor.Value);
        }

        private void controllerCombo_Format(object sender, ListControlConvertEventArgs e)
        {
            string Name = Enum.GetName(typeof(UserIndex), ((Controller)e.ListItem).UserIndex);
            e.Value = Name;
        }
    }
}
