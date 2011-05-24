/* 
 * (MIT License)
 * Author: Sadjow Medeiros Le�o <sadjow@gmail.com>
 * Author: Waldson Patr�cio do Nascimento Leandro <waldsonpatricio@gmail.com>
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
    /// Classe respons�vel por enviar as informa��es dos eventos no InputHandler.
    /// </summary>
    public class InputHandlerEventArgs : EventArgs
    {
        /// <summary>
        /// Estado do bot�es do jogo
        /// </summary>
        public readonly GameKeysState gameKeysState;
        
        /// <summary>
        /// A key que participa do evento dos jogos.
        /// </summary>
        public readonly GameKeys key;

        /// <summary>
        /// Construtor dos argumentos 
        /// </summary>
        /// <param name="state">Estado dos bot�es</param>
        /// <param name="key">Key envolvida no evento</param>
        public InputHandlerEventArgs(GameKeysState state, GameKeys key)
        {
            this.gameKeysState = state;
            this.key = key;
        }
    }
}