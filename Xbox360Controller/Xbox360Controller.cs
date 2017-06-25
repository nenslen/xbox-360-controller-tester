using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using SharpDX.XInput;


// A class to interface with an xbox 360 controller
namespace XboxControllerTest {
    class Xbox360Controller {
        public struct Buttons {
            public bool A;
            public bool B;
            public bool X;
            public bool Y;
            public bool LB;
            public bool RB;
            public bool LeftStick;
            public bool RightStick;
            public bool Back;
            public bool Start;
            public bool DLeft;
            public bool DUp;
            public bool DRight;
            public bool DDown;
        }
        
        // Public variables
        public Buttons buttons;
        public Point leftThumb = new Point(0, 0);
        public Point rightThumb = new Point(0, 0);
        public bool connected = false;
        public int deadband = 2500;
        public float leftTrigger = 0;
        public float rightTrigger = 0;
        public int leftVibration = 0;
        public int rightVibration = 0;
        public string batteryLevel = "";
        public string batteryType = "";
        public Color batteryColor;

        // private variables
        private Controller controller;
        private Gamepad gamepad;
        private Vibration vibration;
        private BatteryInformation batteryInfo;



        // Constructor
        public Xbox360Controller() {
            controller = new Controller(UserIndex.One);
        }


        // Updates the public variables
        public void update() {

            // Make sure controller is connected
            try {
                connected = controller.IsConnected;
            } catch (Exception err) { return; }
            if(connected == false) { return; }

            // Helper variables
            gamepad = controller.GetState().Gamepad;
            GamepadButtonFlags btns = controller.GetState().Gamepad.Buttons;
            batteryInfo = controller.GetBatteryInformation(BatteryDeviceType.Gamepad);


            // Thumbsticks
            leftThumb.X = Convert.ToInt32((Math.Abs((float)gamepad.LeftThumbX) < deadband) ? 0 : (float)gamepad.LeftThumbX / short.MinValue * -100);
            leftThumb.Y = Convert.ToInt32((Math.Abs((float)gamepad.LeftThumbY) < deadband) ? 0 : (float)gamepad.LeftThumbY / short.MaxValue * 100);
            rightThumb.X = Convert.ToInt32((Math.Abs((float)gamepad.RightThumbX) < deadband) ? 0 : (float)gamepad.RightThumbX / short.MaxValue * 100);
            rightThumb.Y = Convert.ToInt32((Math.Abs((float)gamepad.RightThumbY) < deadband) ? 0 : (float)gamepad.RightThumbY / short.MaxValue * 100);

            // Triggers
            leftTrigger = gamepad.LeftTrigger;
            rightTrigger = gamepad.RightTrigger;
            
            // A, B, X, Y
            buttons.A = (btns & GamepadButtonFlags.A) != 0;
            buttons.B = (btns & GamepadButtonFlags.B) != 0;
            buttons.X = (btns & GamepadButtonFlags.X) != 0;
            buttons.Y = (btns & GamepadButtonFlags.Y) != 0;

            // Left and Right bumpers
            buttons.LB = (btns & GamepadButtonFlags.LeftShoulder) != 0;
            buttons.RB = (btns & GamepadButtonFlags.RightShoulder) != 0;

            // Clicking left and right thumbsticks
            buttons.LeftStick = (btns & GamepadButtonFlags.LeftThumb) != 0;
            buttons.RightStick = (btns & GamepadButtonFlags.RightThumb) != 0;

            // Start & Back
            buttons.Back = (btns & GamepadButtonFlags.Back) != 0;
            buttons.Start = (btns & GamepadButtonFlags.Start) != 0;

            // D-Pad
            buttons.DLeft = (btns & GamepadButtonFlags.DPadLeft) != 0;
            buttons.DUp = (btns & GamepadButtonFlags.DPadUp) != 0;
            buttons.DRight = (btns & GamepadButtonFlags.DPadRight) != 0;
            buttons.DDown = (btns & GamepadButtonFlags.DPadDown) != 0;
            
            // Battery
            batteryLevel = batteryInfo.BatteryLevel.ToString();
            Console.WriteLine(batteryLevel);
            batteryType = batteryInfo.BatteryType.ToString();
            
            switch (batteryInfo.BatteryLevel) {
                case BatteryLevel.Empty:
                    batteryColor = Color.DarkGray;
                    break;
                case BatteryLevel.Low:
                    batteryColor = Color.Red;
                    break;
                case BatteryLevel.Medium:
                    batteryColor = Color.Orange;
                    break;
                case BatteryLevel.Full:
                    batteryColor = Color.Green;
                    break;
            }
        }


        // Sets the vibration strength
        public void setVibration(int lv, int rv) {
            if (!connected) { return; }

            vibration.LeftMotorSpeed = Convert.ToUInt16(lv * 655);
            vibration.RightMotorSpeed = Convert.ToUInt16(rv * 655);
            controller.SetVibration(vibration);
        }
    }
}
