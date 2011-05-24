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
    /// Representa o estado ligado - desligado do controle. 
    /// Neste caso apenas para o GamePad.
    /// </summary>
    public enum ControllerState
    {
        Off,
        On
    }

    /// <summary>
    /// Classe que controla os indices dos players e que escuta o estado do controle.
    /// Responsável por gerênciar o que deve ocorrer baseado nos eventos e indices dos controles.
    /// </summary>
    /// <author>Sadjow</author>
    public class ControllerHandler : GameComponent
    {

        /// <summary>
        /// Constante para o número máximo de controles(inputs).
        /// </summary>
        const int MAX_INPUTS_COUNTER = 4;

        public delegate void InputManagerHandler(PlayerIndex playerIndex);
        public event InputManagerHandler onTurnOn;
        public event InputManagerHandler onTurnOff;


        private ControllerState[] _currentStates;
        internal ControllerState[] CurrentStates
        {
            get { return _currentStates; }
            set { _currentStates = value; }
        }
        private ControllerState[] _previousStates;
        internal ControllerState[] PreviousStates
        {
            get { return _previousStates; }
            set { _previousStates = value; }
        }


        /// <summary>
        /// Contrutor do GameComponent.
        /// </summary>
        /// <param name="g"></param>
        public ControllerHandler(Game g) : base(g)
        {
            _currentStates = new ControllerState[MAX_INPUTS_COUNTER];
            _previousStates = new ControllerState[MAX_INPUTS_COUNTER];
        }

        /// <summary>
        /// Escuta os controles e dispara eventos conforme mudanças de seus estados.
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {

            /* Verifica o estado dos controles diretamente e compara
             * com o estado anterior se algo estiver diferente são disparados
             * o eventos.
             */
            for (int i = 0; i < MAX_INPUTS_COUNTER; i++)
            {
                PlayerIndex index = (PlayerIndex)i;
                _currentStates[i] = GamePad.GetState(index).IsConnected ? ControllerState.On : ControllerState.Off;
                
                if (_currentStates[i] != _previousStates[i])
                {
                    if (_currentStates[i] == ControllerState.On)
                    {
                        if (onTurnOn != null)
                            onTurnOn(index);
                        _previousStates[i] = ControllerState.On;
                    }
                    else
                    {
                        if (onTurnOn != null)
                            onTurnOff(index);
                        _previousStates[i] = ControllerState.Off;
                    }
                }
            }
            base.Update(gameTime);
        }

    }
}