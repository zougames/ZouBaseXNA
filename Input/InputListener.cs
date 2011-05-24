/* 
 * (MIT License)
 * Author: Sadjow Medeiros Leão <sadjow@gmail.com>
 * Author: Waldson Patrício do Nascimento Leandro <waldsonpatricio@gmail.com>
 * Created on Monday - 23/05/2011
 * http://zougames.org
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace org.zougames.Input
{
    /// <summary>
    /// Interface para classes que escutarão o InputHandler.
    /// </summary>
    public interface InputListener
    {

        void onAnyButtonPressed(object sender, InputHandlerEventArgs args);
        void onAnyButtonReleased(object sender, InputHandlerEventArgs args);

        void onNoneDirectionPressed(object sender, InputHandlerEventArgs args);
        void onNoneDirectionReleased(object sender, InputHandlerEventArgs args);
        void onNoneDirectionIsDown(object sender, InputHandlerEventArgs args);

        void onButtonAPressed(object sender, InputHandlerEventArgs args);
        void onButtonAReleased(object sender, InputHandlerEventArgs args);
        void onButtonAIsDown(object sender, InputHandlerEventArgs args);

        void onButtonBPressed(object sender, InputHandlerEventArgs args);
        void onButtonBReleased(object sender, InputHandlerEventArgs args);
        void onButtonBIsDown(object sender, InputHandlerEventArgs args);

        void onButtonXPressed(object sender, InputHandlerEventArgs args);
        void onButtonXReleased(object sender, InputHandlerEventArgs args);
        void onButtonXIsDown(object sender, InputHandlerEventArgs args);

        void onButtonYPressed(object sender, InputHandlerEventArgs args);
        void onButtonYReleased(object sender, InputHandlerEventArgs args);
        void onButtonYIsDown(object sender, InputHandlerEventArgs args);

        void onButtonL1Pressed(object sender, InputHandlerEventArgs args);
        void onButtonL1Released(object sender, InputHandlerEventArgs args);
        void onButtonL1IsDown(object sender, InputHandlerEventArgs args);

        void onButtonL2Pressed(object sender, InputHandlerEventArgs args);
        void onButtonL2Released(object sender, InputHandlerEventArgs args);
        void onButtonL2IsDown(object sender, InputHandlerEventArgs args);

        void onButtonR1Pressed(object sender, InputHandlerEventArgs args);
        void onButtonR1Released(object sender, InputHandlerEventArgs args);
        void onButtonR1IsDown(object sender, InputHandlerEventArgs args);

        void onButtonR2Pressed(object sender, InputHandlerEventArgs args);
        void onButtonR2Released(object sender, InputHandlerEventArgs args);
        void onButtonR2IsDown(object sender, InputHandlerEventArgs args);

        void onButtonUpPressed(object sender, InputHandlerEventArgs args);
        void onButtonUpReleased(object sender, InputHandlerEventArgs args);
        void onButtonUpIsDown(object sender, InputHandlerEventArgs args);

        void onButtonDownPressed(object sender, InputHandlerEventArgs args);
        void onButtonDownReleased(object sender, InputHandlerEventArgs args);
        void onButtonDownIsDown(object sender, InputHandlerEventArgs args);

        void onButtonLeftPressed(object sender, InputHandlerEventArgs args);
        void onButtonLeftReleased(object sender, InputHandlerEventArgs args);
        void onButtonLeftIsDown(object sender, InputHandlerEventArgs args);

        void onButtonRightPressed(object sender, InputHandlerEventArgs args);
        void onButtonRightReleased(object sender, InputHandlerEventArgs args);
        void onButtonRightIsDown(object sender, InputHandlerEventArgs args);

        void onButtonUpRightPressed(object sender, InputHandlerEventArgs args);
        void onButtonUpRightReleased(object sender, InputHandlerEventArgs args);
        void onButtonUpRightIsDown(object sender, InputHandlerEventArgs args);

        void onButtonUpLeftPressed(object sender, InputHandlerEventArgs args);
        void onButtonUpLeftReleased(object sender, InputHandlerEventArgs args);
        void onButtonUpLeftIsDown(object sender, InputHandlerEventArgs args);

        void onButtonDownRightPressed(object sender, InputHandlerEventArgs args);
        void onButtonDownRightReleased(object sender, InputHandlerEventArgs args);
        void onButtonDownRightIsDown(object sender, InputHandlerEventArgs args);

        void onButtonDownLeftPressed(object sender, InputHandlerEventArgs args);
        void onButtonDownLeftReleased(object sender, InputHandlerEventArgs args);
        void onButtonDownLeftIsDown(object sender, InputHandlerEventArgs args);

        void onButtonStartPressed(object sender, InputHandlerEventArgs args);
        void onButtonStartReleased(object sender, InputHandlerEventArgs args);
        void onButtonStartIsDown(object sender, InputHandlerEventArgs args);

        void onButtonBackPressed(object sender, InputHandlerEventArgs args);
        void onButtonBackReleased(object sender, InputHandlerEventArgs args);
        void onButtonBackIsDown(object sender, InputHandlerEventArgs args);

    }
}