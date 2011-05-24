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
    /// Classe responsável por enviar as informações dos eventos no InputHandler.
    /// </summary>
    public class InputHandlerEventArgs : EventArgs
    {
        /// <summary>
        /// Estado do botões do jogo
        /// </summary>
        public readonly GameKeysState gameKeysState;
        
        /// <summary>
        /// A key que participa do evento dos jogos.
        /// </summary>
        public readonly GameKeys key;

        /// <summary>
        /// Construtor dos argumentos 
        /// </summary>
        /// <param name="state">Estado dos botões</param>
        /// <param name="key">Key envolvida no evento</param>
        public InputHandlerEventArgs(GameKeysState state, GameKeys key)
        {
            this.gameKeysState = state;
            this.key = key;
        }
    }
}