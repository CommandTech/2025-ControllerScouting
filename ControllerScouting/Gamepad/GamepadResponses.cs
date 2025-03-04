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

                //Every mode actions
                var robotActions = new (Func<bool> buttonPress, Action action)[]{
                    (() => gamepad.RTHRight_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Up)),
                    (() => gamepad.RTHLeft_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Down)),
                    (() => gamepad.R3_Press, () => robot.Transact(robot, controllerNumber)),
                    (() => gamepad.LeftButton_Press, () => robot.CoralDelivery(0,robot)),
                    (() => gamepad.RightButton_Press, () => robot.AlgaeDelivery(0, robot)),
                    (() => gamepad.RightButton_Down, () => robot.AlgaeFlag(robot, gamepad.RightButton_Down))
                };

                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    //Scouter Name
                    robotActions.Append((() => gamepad.LTHRight_Press && gamepad.BButton_Down, () => robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Up)));
                    robotActions.Append((() => gamepad.LTHLeft_Press && gamepad.BButton_Down, () => robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Down)));

                    //Coral Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press, () => robot.CoralDelivery(4, robot)));
                    robotActions.Append((() => gamepad.DpadRight_Press, () => robot.CoralDelivery(3, robot)));
                    robotActions.Append((() => gamepad.DpadDown_Press, () => robot.CoralDelivery(2, robot)));
                    robotActions.Append((() => gamepad.DpadLeft_Press, () => robot.CoralDelivery(1, robot)));

                    //Algae Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2, robot)));
                    robotActions.Append((() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1, robot)));
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)
                {
                    //Coral Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press, () => robot.CoralDelivery(4, robot)));
                    robotActions.Append((() => gamepad.DpadRight_Press, () => robot.CoralDelivery(3, robot)));
                    robotActions.Append((() => gamepad.DpadDown_Press, () => robot.CoralDelivery(2, robot)));
                    robotActions.Append((() => gamepad.DpadLeft_Press, () => robot.CoralDelivery(1, robot)));

                    //Algae Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2, robot)));
                    robotActions.Append((() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1, robot)));
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Defense)
                {
                    //Algae Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2, robot)));
                    robotActions.Append((() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1, robot)));
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