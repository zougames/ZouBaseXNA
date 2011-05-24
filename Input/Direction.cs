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

using Microsoft.Xna.Framework.Input;

namespace org.zougames.Input
{
    /// <summary>
    /// Classe ajudante para trabalhar com os 8 tipos disponíveis no enum Buttons.
    /// </summary>
    class Direction
    {
        // Máscaras auxiliares para auxiliar no calculos do botões.
        public const Buttons None = 0;
        public const Buttons Up = Buttons.DPadUp | Buttons.LeftThumbstickUp;
        public const Buttons Down = Buttons.DPadDown | Buttons.LeftThumbstickDown;
        public const Buttons Left = Buttons.DPadLeft | Buttons.LeftThumbstickLeft;
        public const Buttons Right = Buttons.DPadRight | Buttons.LeftThumbstickRight;
        public const Buttons UpLeft = Up | Left;
        public const Buttons UpRight = Up | Right;
        public const Buttons DownLeft = Down | Left;
        public const Buttons DownRight = Down | Right;
        public const Buttons Any = Up | Down | Left | Right;

        public const Buttons T2Up = Buttons.RightThumbstickUp;
        public const Buttons T2Down = Buttons.RightThumbstickDown;
        public const Buttons T2Left = Buttons.RightThumbstickLeft;
        public const Buttons T2Right = Buttons.RightThumbstickRight;
        public const Buttons T2UpLeft = T2Up | T2Left;
        public const Buttons T2UpRight = T2Up | T2Right;
        public const Buttons T2DownLeft = T2Down | T2Left;
        public const Buttons T2DownRight = T2Down | T2Right;
        public const Buttons T2Any = T2Up | T2Down | T2Left | T2Right;

        /// <summary>
        /// Esta função reconhece a direção atual do controle a parti do estado do GamePad ou do teclado.
        /// Ela retorna um Button que pode ser comparado com as constantes dessa própria classe.
        /// </summary>
        /// <param name="gamePad">Estado do GamePad</param>
        /// <param name="keyboard">Estado do Teclado</param>
        /// <param name="keyboardMap">Mapa do teclado</param>
        /// <returns></returns>
        public static Buttons FromInput(GamePadState gamePad, KeyboardState keyboard, Dictionary<GameKeys, Keys> keyboardMap)
        {
            Buttons direction = None;

            //Pega a direção vertical.
            if (gamePad.IsButtonDown(Buttons.DPadUp) ||
               gamePad.IsButtonDown(Buttons.LeftThumbstickUp) ||
                keyboard.IsKeyDown(keyboardMap[GameKeys.Up]))
            {
                direction |= Up;
            }
            else if(gamePad.IsButtonDown(Buttons.DPadDown) ||
                gamePad.IsButtonDown(Buttons.LeftThumbstickDown) ||
                keyboard.IsKeyDown(keyboardMap[GameKeys.Down]))
            {
                direction |= Down;
            }


            //Combina com a direção horizontal.

            if (gamePad.IsButtonDown(Buttons.DPadLeft) ||
                gamePad.IsButtonDown(Buttons.LeftThumbstickLeft) ||
                keyboard.IsKeyDown(keyboardMap[GameKeys.Left]))
            {
                direction |= Left;
            } else if(gamePad.IsButtonDown(Buttons.DPadRight) ||
                gamePad.IsButtonDown(Buttons.LeftThumbstickRight) ||
                keyboard.IsKeyDown(keyboardMap[GameKeys.Right]))
            {
                direction |= Right;
            }

            return direction;
        }

        public static Buttons FromInputRight(GamePadState gamePad, KeyboardState keyboard, Dictionary<GameKeys, Keys> keyboardMap)
        {
            Buttons direction = None;

            //Pega a direção vertical.
            if (gamePad.IsButtonDown(Buttons.RightThumbstickUp) ||
                keyboard.IsKeyDown(keyboardMap[GameKeys.T2Up]))
            {
                direction |= T2Up;
            }
            else if (gamePad.IsButtonDown(Buttons.RightThumbstickDown) ||
                keyboard.IsKeyDown(keyboardMap[GameKeys.T2Down]))
            {
                direction |= T2Down;
            }


            //Combina com a direção horizontal.

            if (gamePad.IsButtonDown(Buttons.RightThumbstickLeft) ||
                keyboard.IsKeyDown(keyboardMap[GameKeys.T2Left]))
            {
                direction |= T2Left;
            }
            else if (gamePad.IsButtonDown(Buttons.RightThumbstickRight) ||
                keyboard.IsKeyDown(keyboardMap[GameKeys.T2Right]))
            {
                direction |= T2Right;
            }

            return direction;
        }

    }
}