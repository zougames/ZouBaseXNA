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

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace org.zougames.Input
{
    /// <summary>
    /// Classe que escuta e configura o controle 2.
    /// </summary>
    class InputHandlerPlayer2 : InputHandler
    {

        public InputHandlerPlayer2(Game g, PlayerIndex playerIndex)
            : base(g, playerIndex)
        {
        
        }

        protected override void mapKeyboard()
        {
            _keyboardMap = new Dictionary<GameKeys, Keys>();
            _keyboardMap.Add(GameKeys.Up, Keys.Up);
            _keyboardMap.Add(GameKeys.Left, Keys.Left);
            _keyboardMap.Add(GameKeys.Down, Keys.Down);
            _keyboardMap.Add(GameKeys.Right, Keys.Right);

            _keyboardMap.Add(GameKeys.X, Keys.Home);
            _keyboardMap.Add(GameKeys.Y, Keys.PageUp);
            _keyboardMap.Add(GameKeys.A, Keys.End);
            _keyboardMap.Add(GameKeys.B, Keys.PageDown);

            _keyboardMap.Add(GameKeys.Start, Keys.Insert);
            _keyboardMap.Add(GameKeys.Back, Keys.Subtract);

            _keyboardMap.Add(GameKeys.LeftStick, Keys.NumPad7);
            _keyboardMap.Add(GameKeys.RightStick, Keys.NumPad9);

            _keyboardMap.Add(GameKeys.T2Up, Keys.NumPad8);
            _keyboardMap.Add(GameKeys.T2Left, Keys.NumPad4);
            _keyboardMap.Add(GameKeys.T2Down, Keys.NumPad5);
            _keyboardMap.Add(GameKeys.T2Right, Keys.NumPad6);

        }

    }
}