using ControllerScouting.Utilities;
using System;
using System.Linq;

namespace ControllerScouting.Gamepad
{
    partial class Controllers
    {
        public void ReadStick(GamePad[] gpArray, int controllerNumber)
        {
            GamePad gamepad = gpArray[controllerNumber];

            RobotState robot = BackgroundCode.Robots[controllerNumber];

            if (gamepad != null && !robot.NoSho)
            {
                gamepad.Update();

                var robotActions = new (Func<bool> buttonPress, Action action)[]{
                    (() => gamepad.RTHRight_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Up)),
                    (() => gamepad.RTHLeft_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Down)),
                    (() => gamepad.R3_Press, () => robot.Transact(robot, controllerNumber)),
                    (() => gamepad.LeftButton_Press, () => robot.CoralDelivery(0,robot)),
                    (() => gamepad.RightButton_Press, () => robot.AlgaeDelivery(robot))
                };

                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    robotActions.Append((() => gamepad.LTHRight_Press && gamepad.BButton_Down, () => robot  .ChangeScouterName(RobotState.CYCLE_DIRECTION.Up)));
                    robotActions.Append((() => gamepad.LTHLeft_Press && gamepad.BButton_Down, () => robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Down)));
                }
                else if (robot.Current_Mode != RobotState.ROBOT_MODE.Surfacing)
                {
                    robotActions.Append((() => gamepad.DpadUp_Press, () => robot.CoralDelivery(4,robot)));
                    robotActions.Append((() => gamepad.DpadRight_Press, () => robot.CoralDelivery(3, robot)));
                    robotActions.Append((() => gamepad.DpadDown_Press, () => robot.CoralDelivery(2, robot)));
                    robotActions.Append((() => gamepad.DpadLeft_Press, () => robot.CoralDelivery(1, robot)));
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing)
                {
                }
                


                foreach (var (buttonPress, action) in robotActions)
                {
                    if (buttonPress())
                    {
                        action();
                    }
                }
            }
        }
    }
}