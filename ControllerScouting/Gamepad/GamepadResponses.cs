using ControllerScouting.Utilities;

namespace ControllerScouting.Gamepad
{
    class Controllers2
    {
        public void ReadStick(GamePad[] gpArray, int controllerNumber)
        {
            GamePad gamepad = gpArray[controllerNumber];

            RobotState robot = BackgroundCode.Robots[controllerNumber];

            if (gamepad != null && !robot.NoSho)
            {
                gamepad.Update();

            }
        }
    }
}
