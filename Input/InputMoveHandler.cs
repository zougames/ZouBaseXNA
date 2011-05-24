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

namespace org.zougames.Input
{

    public class KeyBuffer
    {
        public GameKeys Key;
        public bool Consumed;

        public KeyBuffer(GameKeys key)
        {
            Key = key;
            Consumed = false;
        }

    }

    /// <summary>
    /// Classe que vai amazenar o buffer das teclas precionadas disparadas pelo InputHandler.
    /// Com essa classe é possível saber se uma determinada sequecia de botões foi ativada ou não.
    /// </summary>
    public class InputMoveHandler
    {

        #region Eventos
        public delegate void gameInputMoveHandler(InputMoveHandler sender, Move move);
        public event gameInputMoveHandler onMoveMatch;

        #endregion Eventos

        /// <summary>
        /// Manipulador de Input. De onde vem os movimentos.
        /// </summary>
        public InputHandler InputHandler { get; private set; }

        /// <summary>
        /// A última vez em tempo real que um botão foi precionado.
        /// </summary>
        public TimeSpan LastInputTime { get; private set; }

        /// <summary>
        /// A sequencia corrente das botões precionados.
        /// </summary>
        public List<KeyBuffer> Buffer;

        /// <summary>
        /// Isto é quanto tempo vai esperar antes de marca os dados como expirados.
        /// Isto previne o jogador de fazer a metade de uma Move, esperar, e depois
        /// completar o resto da Move.
        /// </summary>
        public readonly TimeSpan BufferTimeOut = TimeSpan.FromMilliseconds(600); // Default: 500

        /// <summary>
        /// Isto é o tamanho da "Janela de mesclar" para combinar os botões precionados
        /// que estão quase no mesmo tempo.
        /// Se isto é um tempo muito curto, os jogadoes irão encontrar dificuldade para 
        /// fazer os Moves que requerem muitos botões precionados ao mesmo tempo.
        /// Se for muito longo, os jogadores irão encontrar dificuldades de fazer Move
        /// que requerem muitos botões em sequencia.
        /// </summary>
        public readonly TimeSpan MergeInputTime = TimeSpan.FromMilliseconds(150); // Default: 100

        /// <summary>
        /// Some para as outras funções além do update ter acesso ao GameTime.
        /// </summary>
        private GameTime _gameTime;

        /// <summary>
        /// Para evitar calcular novamente nas funções fora do Update.
        /// </summary>
        private TimeSpan _timeSinceLast;

        /// <summary>
        /// Lista de movimentos para detecção.
        /// </summary>
        public MoveList MoveList;

        /// <summary>
        /// Inicia o manipulador de movimentos.
        /// </summary>
        /// <param name="bufferSize">Tamanho máximo do buffer.</param>
        /// <param name="inputHandler">Manipulador do input</param>
        public InputMoveHandler(int bufferSize, InputHandler inputHandler, MoveList moveList)
        {
            // Inicializa o buffer com a capacidade estimada.
            Buffer = new List<KeyBuffer>(bufferSize);
            InputHandler = inputHandler;
            MoveList = moveList;

            // Adiciona o ouvinte para que possa coletar os botões precionados.
            InputHandler.onAnyButtonPressed += NewButtonPressed;
        }


        public void Update(GameTime gameTime)
        {
            _gameTime = gameTime;

            // Expira o inputs antigos.
            TimeSpan time = gameTime.TotalRealTime;
            _timeSinceLast = time - LastInputTime;
            if (_timeSinceLast > BufferTimeOut)
            {
                Buffer.Clear();
            }

            _timeSinceLast = time;

            Move move = MoveList.DetectMove(this);
            if (move != null)
            {
                if (onMoveMatch != null)
                    onMoveMatch(this, move);
            }

        }

        /// <summary>
        /// Recebe um novo botão precionado e adiciona no buffer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void NewButtonPressed(object sender, InputHandlerEventArgs args)
        {
            if (_gameTime == null) return;
            // É muito difícil precionar dois botões extamente no mesmo tempo.
            // Se eles são precionados perto o suficiente, então vamos considera-los
            // que são precionados ao mesmo tempo.
            bool mergeInput = (Buffer.Count > 0 && _timeSinceLast < MergeInputTime && !InputHandler.GameKeysIsDirection(args.key));

            if (args.key != GameKeys.NoneDirection)
            {
                if (mergeInput)
                {
                    // Usa bitwise-or para mesclar com o input anterior
                    // O LastInputTime não é atualizado para previnir que o tempo
                    // da "janela de mesclar" seja aumentatado.
                    Buffer[Buffer.Count - 1].Key |= args.key;
                }
                else
                {
                    // Adiciona este botão ao buffer, expirando um botão antigo se necessário.
                    if (Buffer.Count == Buffer.Capacity)
                    {
                        Buffer.RemoveAt(0);
                    }
                    Buffer.Add(new KeyBuffer(args.key));
                    
                    // Grava o ultima vez que o botão foi precionado para começar a "janela de mesclagem".
                    LastInputTime = _gameTime.TotalRealTime;
                }
            }

        }
        /// <summary>
        /// Determina se um movimento coincide com um historia de input corrente.
        /// A menos que o movimento é um sub-movimento, a história é "consumida" para evitar
        /// que ela coincida duplamente.
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public bool Matches(Move move)
        {
            //Se o movimento é maior que o buffer, não é possível coincidir.
            if (Buffer.Count < move.Sequence.Length) return false;

            // Verifica do input mais recente para o mais antigo se há coincidencia em todas as teclas.
            bool consumedAll = true;
            for (int i = 1; i <= move.Sequence.Length; ++i)
            {
                
                if (!Buffer[Buffer.Count - i].Consumed) consumedAll = false;

                if (Buffer[Buffer.Count - i].Key != move.Sequence[move.Sequence.Length - i])
                {
                    return false;
                }
            }
            //Se já consumiu as teclas tudo retorna false
            if (consumedAll) return false;

            //Se este não é um componente de uma outra sequencia,
            if (!move.IsSubMove)
            {
                // consome os inputs usados.
                Buffer.Clear();
            }
            else
            {
                foreach (KeyBuffer k in Buffer)
                    k.Consumed = true;
            }

            return true;

        }


    }
}
