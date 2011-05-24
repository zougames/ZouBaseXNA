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
    /// Representa um conjunto de movimentos disponíveis. O amazenamento interno 
    /// é otimizado para a busca do jogo.
    /// </summary>
    public class MoveList
    {
        /// <summary>
        /// Movimentos disponíveis nesta lista.
        /// </summary>
        private Move[] moves;

        public Move[] Moves
        {
            get { return moves; }
            set { moves = value; }
        }
        
        public MoveList(IEnumerable<Move> moves)
        {
            // Amazena esta lista de movimentos em ordem decrescente do tamanho do movimento.
            // Isto é um ótimo simplicador da lógica do método DectectMove.
            this.moves = moves.OrderByDescending(m => m.Sequence.Length).ToArray();
        }

        /// <summary>
        /// Localiza o mais longo movimento que coincide com o dado de entrada, se houver.
        /// </summary>
        /// <param name="inputMoveHandler">InputMoveHandler</param>
        /// <returns>Move</returns>
        public Move DetectMove(InputMoveHandler inputMoveHandler)
        {
            // Faz uma busca linear por movimentos que coincidem com o buffer do input.
            // Isso depende do vetor passado que é por ordem decrescente de comprimento da seqüência.
            foreach (Move move in moves)
            {
                if (inputMoveHandler.Matches(move))
                {
                    return move;
                }
            }
            return null;
        }

        /// <summary>
        /// Retorna o tamanho inteiro do maior movimento
        /// </summary>
        public int LongestMoveLength
        {
            get
            {
                // Desde que esteja em ordem decrescente,
                // o primeiro movimento é sempre o maior.
                return moves[0].Sequence.Length;
            }
        }

    }
}
