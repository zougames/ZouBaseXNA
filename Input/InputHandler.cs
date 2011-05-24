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
    /// Enums que representa todos os possíveis botões.
    /// </summary>
    public enum GameKeys
    {
        A           = Buttons.A,
        B           = Buttons.B,
        X           = Buttons.X,
        Y           = Buttons.Y,

        LB          = Buttons.LeftShoulder,
        LT          = Buttons.LeftTrigger,
        RB          = Buttons.RightShoulder,
        RT          = Buttons.RightTrigger,

        LeftStick   = Buttons.LeftStick,
        RightStick  = Buttons.RightStick,

        Start       = Buttons.Start,
        Back        = Buttons.Back,
        Up          = Direction.Up,
        Down        = Direction.Down,
        Left        = Direction.Left,
        Right       = Direction.Right,
        UpLeft      = Direction.UpLeft,
        UpRight     = Direction.UpRight,
        DownLeft    = Direction.DownLeft,
        DownRight   = Direction.DownRight,

        NoneDirection = Direction.None,

        T2Up = Direction.T2Up,
        T2Down = Direction.T2Down,
        T2Left = Direction.T2Left,
        T2Right = Direction.T2Right,
        T2UpLeft = Direction.T2UpLeft,
        T2UpRight = Direction.T2UpRight,
        T2DownLeft = Direction.T2DownLeft,
        T2DownRight = Direction.T2DownRight,

        T2NoneDirection = Direction.None
    };

    /// <summary>
    /// Enum que representa os estados do botões.
    /// </summary>
    public enum GameKeyState
    {
        Pressed, Released
    };

    /// <summary>
    /// Estrutura que representa um estado dos botões do controle.
    /// </summary>
    public struct GameKeysState
    {
        public GameKeyState A;
        public GameKeyState B;
        public GameKeyState X;
        public GameKeyState Y;
        public GameKeyState L1;
        public GameKeyState L2;
        public GameKeyState R1;
        public GameKeyState R2;
        public GameKeyState Start;
        public GameKeyState Back;
        public GameKeyState Up;
        public GameKeyState Down;
        public GameKeyState Left;
        public GameKeyState Right;
        public GameKeyState UpLeft;
        public GameKeyState UpRight;
        public GameKeyState DownLeft;
        public GameKeyState DownRight;
        public GameKeyState NoneDirection;
        public GameKeyState T2Up;
        public GameKeyState T2Down;
        public GameKeyState T2Left;
        public GameKeyState T2Right;
        public GameKeyState T2UpLeft;
        public GameKeyState T2UpRight;
        public GameKeyState T2DownLeft;
        public GameKeyState T2DownRight;
        public GameKeyState T2NoneDirection;
        public GameKeyState LeftStick;
        public GameKeyState RightStick;

        public GameKeysState(GameKeyState A,
                             GameKeyState B,
                             GameKeyState X,
                             GameKeyState Y,
                             GameKeyState L1,
                             GameKeyState L2,
                             GameKeyState R1,
                             GameKeyState R2,
                             GameKeyState Start,
                             GameKeyState Back,
                             GameKeyState Up,
                             GameKeyState Down,
                             GameKeyState Left,
                             GameKeyState Right,
                             GameKeyState UpLeft,
                             GameKeyState UpRight,
                             GameKeyState DownLeft,
                             GameKeyState DownRight,
                             GameKeyState NoneDirection,
                             GameKeyState T2Up,
                             GameKeyState T2Down,
                             GameKeyState T2Left,
                             GameKeyState T2Right,
                             GameKeyState T2UpLeft,
                             GameKeyState T2UpRight,
                             GameKeyState T2DownLeft,
                             GameKeyState T2DownRight,
                             GameKeyState T2NoneDirection,
                             GameKeyState LeftStick,
                             GameKeyState RightStick)
        {
            this.A = A;
            this.B = B;
            this.X = X;
            this.Y = Y;

            this.L1 = L1;
            this.L2 = L2;
            this.R1 = R1;
            this.R2 = R2;

            this.LeftStick = LeftStick;
            this.RightStick = RightStick;

            this.Start = Start;
            this.Back = Back;
            this.Up = Up;
            this.Down = Down;
            this.Left = Left;
            this.Right = Right;

            this.UpLeft = UpLeft;
            this.UpRight = UpRight;
            this.DownRight = DownRight;
            this.DownLeft = DownLeft;

            this.NoneDirection = NoneDirection;


            this.T2Up = T2Up;
            this.T2Down = T2Down;
            this.T2Left = T2Left;
            this.T2Right = T2Right;

            this.T2UpLeft = T2UpLeft;
            this.T2UpRight = T2UpRight;
            this.T2DownRight = T2DownRight;
            this.T2DownLeft = T2DownLeft;

            this.T2NoneDirection = T2NoneDirection;
        }

    }

    public class InputHandler : GameComponent
    {
        #region Eventos

        public delegate void gameInputHandler(object sender, InputHandlerEventArgs args);

        public event gameInputHandler onAnyButtonPressed;
        public event gameInputHandler onAnyButtonReleased;
        public event gameInputHandler onAnyButtonIsDown;

        public event gameInputHandler onNoneDirectionPressed;
        public event gameInputHandler onNoneDirectionReleased;
        public event gameInputHandler onNoneDirectionIsDown;

        public event gameInputHandler onButtonAPressed;
        public event gameInputHandler onButtonAReleased;
        public event gameInputHandler onButtonAIsDown;

        public event gameInputHandler onButtonBPressed;
        public event gameInputHandler onButtonBReleased;
        public event gameInputHandler onButtonBIsDown;

        public event gameInputHandler onButtonXPressed;
        public event gameInputHandler onButtonXReleased;
        public event gameInputHandler onButtonXIsDown;

        public event gameInputHandler onButtonYPressed;
        public event gameInputHandler onButtonYReleased;
        public event gameInputHandler onButtonYIsDown;

        public event gameInputHandler onButtonL1Pressed;
        public event gameInputHandler onButtonL1Released;
        public event gameInputHandler onButtonL1IsDown;

        public event gameInputHandler onButtonL2Pressed;
        public event gameInputHandler onButtonL2Released;
        public event gameInputHandler onButtonL2IsDown;

        public event gameInputHandler onButtonR1Pressed;
        public event gameInputHandler onButtonR1Released;
        public event gameInputHandler onButtonR1IsDown;

        public event gameInputHandler onButtonR2Pressed;
        public event gameInputHandler onButtonR2Released;
        public event gameInputHandler onButtonR2IsDown;


        public event gameInputHandler onButtonUpPressed;
        public event gameInputHandler onButtonUpReleased;
        public event gameInputHandler onButtonUpIsDown;

        public event gameInputHandler onButtonDownPressed;
        public event gameInputHandler onButtonDownReleased;
        public event gameInputHandler onButtonDownIsDown;

        public event gameInputHandler onButtonLeftPressed;
        public event gameInputHandler onButtonLeftReleased;
        public event gameInputHandler onButtonLeftIsDown;

        public event gameInputHandler onButtonRightPressed;
        public event gameInputHandler onButtonRightReleased;
        public event gameInputHandler onButtonRightIsDown;

        public event gameInputHandler onButtonUpLeftPressed;
        public event gameInputHandler onButtonUpLeftReleased;
        public event gameInputHandler onButtonUpLeftIsDown;

        public event gameInputHandler onButtonUpRightPressed;
        public event gameInputHandler onButtonUpRightReleased;
        public event gameInputHandler onButtonUpRightIsDown;

        public event gameInputHandler onButtonDownLeftPressed;
        public event gameInputHandler onButtonDownLeftReleased;
        public event gameInputHandler onButtonDownLeftIsDown;

        public event gameInputHandler onButtonDownRightPressed;
        public event gameInputHandler onButtonDownRightReleased;
        public event gameInputHandler onButtonDownRightIsDown;

        public event gameInputHandler onButtonStartPressed;
        public event gameInputHandler onButtonStartReleased;
        public event gameInputHandler onButtonStartIsDown;

        public event gameInputHandler onButtonBackPressed;
        public event gameInputHandler onButtonBackReleased;
        public event gameInputHandler onButtonBackIsDown;

        #endregion Events
        
        /// <summary>
        /// Input espelhado, direita vira esquerda, esquerda vira direita.
        /// </summary>
        private bool _isMirrored = false;
        public bool IsMirrored
        {
            get
            {
                return _isMirrored;
            }
            set
            {
                _isMirrored = value;
            }
        }

        /// <summary>
        /// PlayerIndex(Número do controle) que este InputHandler deve trabalhar.
        /// </summary>
        private PlayerIndex _playerIndex;
        public PlayerIndex PlayerIndex
        {
            get
            {
                return _playerIndex;
            }
            set
            {
                _playerIndex = value;
            }
        }

        /// <summary>
        /// Mapa para testar o jogo no windows.
        /// </summary>
        protected Dictionary<GameKeys, Keys> _keyboardMap;

        /// <summary>
        /// GameKeysState corrente.
        /// </summary>
        private GameKeysState _currentGameKeysState;

        public GameKeysState CurrentGameKeysState
        {
            get { return _currentGameKeysState; }
            set { _currentGameKeysState = value; }
        }

        public GameKeys PressedButtons
        {
            get
            {
                GameKeys temp = GameKeys.NoneDirection;
                if (CurrentGameKeysState.A == GameKeyState.Pressed)
                    temp |= GameKeys.A;
                if (CurrentGameKeysState.B == GameKeyState.Pressed)
                    temp |= GameKeys.B;
                if (CurrentGameKeysState.X == GameKeyState.Pressed)
                    temp |= GameKeys.X;
                if (CurrentGameKeysState.Y == GameKeyState.Pressed)
                    temp |= GameKeys.Y;
                return temp;
            }
        }

        /// <summary>
        /// GameKeysState anterior
        /// Serve para ser comparado com o corrente e disparar os eventos.
        /// </summary>
        private GameKeysState _previousGameKeysState;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g">Game para o GameComponent trabalhar.</param>
        /// <param name="playerIndex">PlayerIndex(Número do controle) que este InputHandler deve
        /// trabalhar.</param>
        public InputHandler(Game g, PlayerIndex playerIndex) : base(g)
        {
            PlayerIndex = playerIndex;
            Game.Components.Add(this);
            Initialize();
        }

        protected override void Dispose(bool disposing)
        {
            Game.Components.Remove(this);
            base.Dispose(disposing);
        }



        /// <summary>
        /// Inicializa o InputHandler.
        /// </summary>
        /// 

        private bool _initialized = false;
        public override void Initialize()
        {
            if (_initialized) return;

            _previousGameKeysState = createEmptyGameKeysState();
            // Mapeia o teclado para jogar.
            mapKeyboard();

            _initialized = true;
        }

        /// <summary>
        /// Função para mapear as instâncias de teclado.
        /// </summary>
        protected virtual void mapKeyboard()
        {

            _keyboardMap = new Dictionary<GameKeys, Keys>();

            _keyboardMap.Add(GameKeys.Up, Keys.W);
            _keyboardMap.Add(GameKeys.Left, Keys.A);
            _keyboardMap.Add(GameKeys.Down, Keys.S);
            _keyboardMap.Add(GameKeys.Right, Keys.D);
            _keyboardMap.Add(GameKeys.X, Keys.T);
            _keyboardMap.Add(GameKeys.Y, Keys.Y);
            _keyboardMap.Add(GameKeys.A, Keys.G);
            _keyboardMap.Add(GameKeys.B, Keys.H);
            _keyboardMap.Add(GameKeys.Start, Keys.Space);
            _keyboardMap.Add(GameKeys.Back, Keys.Back);

            _keyboardMap.Add(GameKeys.LeftStick, Keys.U);
            _keyboardMap.Add(GameKeys.RightStick, Keys.O);
            
            
            _keyboardMap.Add(GameKeys.T2Up, Keys.I);
            _keyboardMap.Add(GameKeys.T2Left, Keys.J);
            _keyboardMap.Add(GameKeys.T2Down, Keys.K);
            _keyboardMap.Add(GameKeys.T2Right, Keys.L);

        }

        /// <summary>
        /// Retorna o botao do jogo relacionado a tecla pressionada no teclado ou nulo se a tecla
        /// não estiver mapeada.
        /// </summary>
        /// <returns>GameKeys</returns>
        private GameKeys getGameKeyByKeyboardKey(Keys key)
        {
            if (_keyboardMap.ContainsValue(key))
            {
                int index = _keyboardMap.Values.ToList().IndexOf(key);
                return _keyboardMap.Keys.ElementAt(index);
            }
            return GameKeys.NoneDirection;
        }

        /// <summary>
        /// Dispacha o evento da tecla.
        /// </summary>
        /// <param name="evt">Evento</param>
        /// <param name="key">Tecla envolvida</param>
        private void dispatchEvent(gameInputHandler evt, GameKeys key)
        {
            if (evt != null)
                evt(this, getEventArgs(key));
        }

        /// <summary>
        /// Cria os argumentos do evento.
        /// </summary>
        /// <param name="key">Tecla envolvida</param>
        /// <returns>InputHandlerEventArgs</returns>
        private InputHandlerEventArgs getEventArgs(GameKeys key)
        {
            return new InputHandlerEventArgs(_currentGameKeysState, key);
        }

        /// <summary>
        /// Criar um estado dos botões em branco. Todos os botões em estado Released.
        /// </summary>
        /// <returns>GameKeysState</returns>
        private GameKeysState createEmptyGameKeysState()
        {
            GameKeysState g = new GameKeysState(GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released, GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released, GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released, GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released, GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released, GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released, GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released, GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released, GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released, GameKeyState.Released,
                GameKeyState.Released, GameKeyState.Released);
            return g;
        }

        public void ResetState(){
            _currentGameKeysState = createEmptyGameKeysState();
            _previousGameKeysState = createEmptyGameKeysState();
        }

        /// <summary>
        /// Atualiza um estado de acordo com a direção atual.
        /// </summary>
        /// <param name="direction">Direção atual</param>
        /// <param name="state">state a ser atualizado</param>
        private GameKeysState updateStateDirection(Buttons direction, GameKeysState state)
        {
            // Calcula estado a parti da direção
            switch (direction)
            {
                case Direction.Up:
                    state.Up = GameKeyState.Pressed;
                    break;
                case Direction.Down:
                    state.Down = GameKeyState.Pressed;
                    break;
                case Direction.Left:
                    state.Left = GameKeyState.Pressed;
                    break;
                case Direction.Right:
                    state.Right = GameKeyState.Pressed;
                    break;
                case Direction.UpLeft:
                    state.UpLeft = GameKeyState.Pressed;
                    break;
                case Direction.UpRight:
                    state.UpRight = GameKeyState.Pressed;
                    break;
                case Direction.DownLeft:
                    state.DownLeft = GameKeyState.Pressed;
                    break;
                case Direction.DownRight:
                    state.DownRight = GameKeyState.Pressed;
                    break;
                case Direction.None:
                    state.NoneDirection = GameKeyState.Pressed;
                    break;
            }
            return state;
        }

        private GameKeysState updateStateDirectionRight(Buttons direction, GameKeysState state)
        {
            // Calcula estado a parti da direção
            switch (direction)
            {
                case Direction.T2Up:
                    state.T2Up = GameKeyState.Pressed;
                    break;
                case Direction.T2Down:
                    state.T2Down = GameKeyState.Pressed;
                    break;
                case Direction.T2Left:
                    state.T2Left = GameKeyState.Pressed;
                    break;
                case Direction.T2Right:
                    state.T2Right = GameKeyState.Pressed;
                    break;
                case Direction.T2UpLeft:
                    state.T2UpLeft = GameKeyState.Pressed;
                    break;
                case Direction.T2UpRight:
                    state.T2UpRight = GameKeyState.Pressed;
                    break;
                case Direction.T2DownLeft:
                    state.T2DownLeft = GameKeyState.Pressed;
                    break;
                case Direction.T2DownRight:
                    state.T2DownRight = GameKeyState.Pressed;
                    break;
                case Direction.None:
                    state.T2NoneDirection = GameKeyState.Pressed;
                    break;
            }
            return state;
        }

        public void SetVibration(float f)
        {
            GamePad.SetVibration(this.PlayerIndex, f, f);
        }

        /// <summary>
        /// Retorna o GameKeysState do teclado.
        /// </summary>
        /// <returns>GameKeysState</returns>
        private GameKeysState getGameKeysStateFromKeyBoard()
        {
            KeyboardState kbst = Keyboard.GetState();
            Keys[] pressedKeys = kbst.GetPressedKeys();

            GameKeysState state = createEmptyGameKeysState();

            // Captura a direção e envia para o métodos responsáveis.
            Buttons direction = Direction.FromInput(GamePad.GetState(PlayerIndex), Keyboard.GetState(), _keyboardMap);
            // Captura a direção do Thumbstick da direita.
            Buttons T2direction = Direction.FromInputRight(GamePad.GetState(PlayerIndex), Keyboard.GetState(), _keyboardMap);

            state = updateStateDirection(direction, state);
            state = updateStateDirectionRight(T2direction, state);

            foreach (Keys pressedKey in pressedKeys)
            {
                GameKeys gameKey = getGameKeyByKeyboardKey(pressedKey);
                if (gameKey == GameKeys.NoneDirection)
                    continue;
                switch (gameKey)
                {
                    case GameKeys.A:
                        state.A = GameKeyState.Pressed;
                        break;
                    case GameKeys.B:
                        state.B = GameKeyState.Pressed;
                        break;
                    case GameKeys.Y:
                        state.Y = GameKeyState.Pressed;
                        break;
                    case GameKeys.X:
                        state.X = GameKeyState.Pressed;
                        break;
                    case GameKeys.Start:
                        state.Start = GameKeyState.Pressed;
                        break;
                    case GameKeys.Back:
                        state.Back = GameKeyState.Pressed;
                        break;
                    case GameKeys.LB:
                        state.L1 = GameKeyState.Pressed;
                        break;
                    case GameKeys.LT:
                        state.L2 = GameKeyState.Pressed;
                        break;
                    case GameKeys.RB:
                        state.R1 = GameKeyState.Pressed;
                        break;
                    case GameKeys.RT:
                        state.R2 = GameKeyState.Pressed;
                        break;
                    case GameKeys.LeftStick:
                        state.LeftStick = GameKeyState.Pressed;
                        break;
                    case GameKeys.RightStick:
                        state.RightStick = GameKeyState.Pressed;
                        break;
                }
            }
            return state;
        }

        /// <summary>
        /// Retorna o GameKeysState do GamePad
        /// </summary>
        /// <returns>GameKeysState</returns>
        private GameKeysState getGameKeysStateFromGamepad()
        {
            GamePadState gpst = GamePad.GetState(this.PlayerIndex);

            GameKeysState state = createEmptyGameKeysState();

            // Captura a direção e envia para o métodos responsáveis.
            Buttons direction = Direction.FromInput(GamePad.GetState(PlayerIndex), Keyboard.GetState(), _keyboardMap);
            Buttons T2direction = Direction.FromInputRight(GamePad.GetState(PlayerIndex), Keyboard.GetState(), _keyboardMap);

            state = updateStateDirection(direction, state);
            state = updateStateDirectionRight(T2direction, state);

            if (gpst.IsButtonDown(Buttons.A))
            {
                state.A = GameKeyState.Pressed;
            }
            if (gpst.IsButtonDown(Buttons.B))
            {
                state.B = GameKeyState.Pressed;
            }
            if (gpst.IsButtonDown(Buttons.Y))
            {
                state.Y = GameKeyState.Pressed;
            }
            if (gpst.IsButtonDown(Buttons.X))
            {
                state.X = GameKeyState.Pressed;
            }
            if (gpst.IsButtonDown(Buttons.Start))
            {
                state.Start = GameKeyState.Pressed;
            }
            if (gpst.IsButtonDown(Buttons.Back))
            {
                state.Back = GameKeyState.Pressed;
            }
            if (gpst.IsButtonDown(Buttons.LeftStick))
            {
                state.LeftStick = GameKeyState.Pressed;
            }
            if (gpst.IsButtonDown(Buttons.RightStick))
            {
                state.RightStick = GameKeyState.Pressed;
            }

            state.L1 = GameKeyState.Released;
            state.L2 = GameKeyState.Released;
            state.R1 = GameKeyState.Released;
            state.R2 = GameKeyState.Released;

            return state;

        }

        /// <summary>
        /// Se o input está espelhado troca a direita pela esquerda e vice versa.
        /// </summary>
        /// <param name="keysState">Estados das teclas atuais</param>
        /// <returns>GameKeysState</returns>
        private GameKeysState changeStateIfMirrored(GameKeysState keysState)
        {
            GameKeysState newKeysState = keysState;
            if (IsMirrored)
            {
                newKeysState.Left = keysState.Right;
                newKeysState.Right = keysState.Left;

                newKeysState.UpRight = keysState.UpLeft;
                newKeysState.UpLeft = keysState.UpRight;

                newKeysState.DownRight = keysState.DownLeft;
                newKeysState.DownLeft = keysState.DownRight;
            }
            return newKeysState;
        }

        private TimeSpan _lastUpdateState = TimeSpan.Zero;
        private TimeSpan _updateStateDelay = TimeSpan.FromMilliseconds(0);

        /// <summary>
        /// Checa o estado
        /// </summary>
        private void updateState(GameTime gameTime)
        {

            if (_lastUpdateState.Add(_updateStateDelay).CompareTo(gameTime.TotalGameTime) >= 0)
                return;
            else
                _lastUpdateState = gameTime.TotalGameTime;

#if XBOX
            _currentGameKeysState = getGameKeysStateFromGamepad();
#elif WINDOWS
            //if(ZouInfo.Controllers.CurrentStates[(int)PlayerIndex] == ControllerState.On)
                //_currentGameKeysState = getGameKeysStateFromGamepad();
            //else
                _currentGameKeysState = getGameKeysStateFromKeyBoard();
#endif

            _currentGameKeysState = changeStateIfMirrored(_currentGameKeysState);


            // Corrige problema de precionado.
            if (_currentGameKeysState.UpLeft == GameKeyState.Pressed)
            {
                _currentGameKeysState.Up = GameKeyState.Pressed;
                _currentGameKeysState.Left = GameKeyState.Pressed;
            }

            if (_currentGameKeysState.UpRight == GameKeyState.Pressed)
            {
                _currentGameKeysState.Up = GameKeyState.Pressed;
                _currentGameKeysState.Right = GameKeyState.Pressed;
            }

            if (_currentGameKeysState.DownLeft == GameKeyState.Pressed)
            {
                _currentGameKeysState.Down = GameKeyState.Pressed;
                _currentGameKeysState.Left = GameKeyState.Pressed;
            }

            if (_currentGameKeysState.DownRight == GameKeyState.Pressed)
            {
                _currentGameKeysState.Down = GameKeyState.Pressed;
                _currentGameKeysState.Right = GameKeyState.Pressed;
            }

            

            checkKeyState(GameKeys.A, _previousGameKeysState.A, _currentGameKeysState.A);
            checkKeyState(GameKeys.B, _previousGameKeysState.B, _currentGameKeysState.B);
            checkKeyState(GameKeys.X, _previousGameKeysState.X, _currentGameKeysState.X);
            checkKeyState(GameKeys.Y, _previousGameKeysState.Y, _currentGameKeysState.Y);

            checkKeyState(GameKeys.LB, _previousGameKeysState.L1, _currentGameKeysState.L1);
            checkKeyState(GameKeys.LT, _previousGameKeysState.L2, _currentGameKeysState.L2);
            checkKeyState(GameKeys.RB, _previousGameKeysState.R1, _currentGameKeysState.R1);
            checkKeyState(GameKeys.RT, _previousGameKeysState.R2, _currentGameKeysState.R2);

            checkKeyState(GameKeys.Start, _previousGameKeysState.Start, _currentGameKeysState.Start);
            checkKeyState(GameKeys.Back, _previousGameKeysState.Back, _currentGameKeysState.Back);


            checkKeyState(GameKeys.UpRight, _previousGameKeysState.UpRight, _currentGameKeysState.UpRight);
            checkKeyState(GameKeys.UpLeft, _previousGameKeysState.UpLeft, _currentGameKeysState.UpLeft);
            checkKeyState(GameKeys.DownLeft, _previousGameKeysState.DownLeft, _currentGameKeysState.DownLeft);
            checkKeyState(GameKeys.DownRight, _previousGameKeysState.DownRight, _currentGameKeysState.DownRight);


            checkKeyState(GameKeys.Up, _previousGameKeysState.Up, _currentGameKeysState.Up);
            checkKeyState(GameKeys.Down, _previousGameKeysState.Down, _currentGameKeysState.Down);
            checkKeyState(GameKeys.Left, _previousGameKeysState.Left, _currentGameKeysState.Left);
            checkKeyState(GameKeys.Right, _previousGameKeysState.Right, _currentGameKeysState.Right);

            checkKeyState(GameKeys.NoneDirection, _previousGameKeysState.NoneDirection, _currentGameKeysState.NoneDirection);

            //T2
            checkKeyState(GameKeys.T2UpRight, _previousGameKeysState.T2UpRight, _currentGameKeysState.T2UpRight);
            checkKeyState(GameKeys.T2UpLeft, _previousGameKeysState.T2UpLeft, _currentGameKeysState.T2UpLeft);
            checkKeyState(GameKeys.T2DownLeft, _previousGameKeysState.T2DownLeft, _currentGameKeysState.T2DownLeft);
            checkKeyState(GameKeys.T2DownRight, _previousGameKeysState.T2DownRight, _currentGameKeysState.T2DownRight);


            checkKeyState(GameKeys.T2Up, _previousGameKeysState.T2Up, _currentGameKeysState.T2Up);
            checkKeyState(GameKeys.T2Down, _previousGameKeysState.T2Down, _currentGameKeysState.T2Down);
            checkKeyState(GameKeys.T2Left, _previousGameKeysState.T2Left, _currentGameKeysState.T2Left);
            checkKeyState(GameKeys.T2Right, _previousGameKeysState.T2Right, _currentGameKeysState.T2Right);
        
            checkKeyState(GameKeys.T2NoneDirection, _previousGameKeysState.T2NoneDirection, _currentGameKeysState.T2NoneDirection);

            checkKeyState(GameKeys.LeftStick, _previousGameKeysState.LeftStick, _currentGameKeysState.LeftStick);
            checkKeyState(GameKeys.RightStick, _previousGameKeysState.RightStick, _currentGameKeysState.RightStick);

            _previousGameKeysState = _currentGameKeysState;

        }

        /// <summary>
        /// Checa o estado da tecla e dispara os eventos.
        /// </summary>
        /// <param name="key">Tecla</param>
        /// <param name="prevState">Estado anterior</param>
        /// <param name="currState">Estado corrente</param>
        private void checkKeyState(GameKeys key, GameKeyState prevState, GameKeyState currState)
        {
            //Se o estado anterior era Released e o estado corrente é Pressed
            // dispara os dois eventos de Pressed e IsDown.
            if (prevState == GameKeyState.Released && currState == GameKeyState.Pressed)
            {
                handleGameKeyPressed(key);
                handleGameKeyIsDown(key);
            }
            // Se o estado anterior era pressed e o estado corrente é Released
            // dispara o evento Released.
            if (prevState == GameKeyState.Pressed && currState == GameKeyState.Released)
                handleGameKeyReleased(key);
            //Se o estado anterior é pressed e o corrente é pressed
            // dispara o evento Pressed.
            if (prevState == GameKeyState.Pressed && currState == GameKeyState.Pressed)
                handleGameKeyIsDown(key);
        }
        

        /// <summary>
        /// Update para atualizar os estados dos botões do controle.
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (_initialized)
            {
                //Atualiza o estado.
                if (Enabled)
                    updateState(gameTime);
            }
        }


        #region Disparadores de eventos

        private void handleGameKeyPressed(GameKeys key)
        {
            gameInputHandler gih = null;
            switch (key)
            {
                case GameKeys.Down:
                    gih = onButtonDownPressed;
                    break;
                case GameKeys.Up:
                    gih = onButtonUpPressed;
                    break;
                case GameKeys.Left:
                    gih = onButtonLeftPressed;
                    break;
                case GameKeys.Right:
                    gih = onButtonRightPressed;
                    break;
                case GameKeys.A:
                    gih = onButtonAPressed;
                    break;
                case GameKeys.B:
                    gih = onButtonBPressed;
                    break;
                case GameKeys.Y:
                    gih = onButtonYPressed;
                    break;
                case GameKeys.X:
                    gih = onButtonXPressed;
                    break;
                case GameKeys.Start:
                    gih = onButtonStartPressed;
                    break;
                case GameKeys.Back:
                    gih = onButtonBackPressed;
                    break;
                case GameKeys.LB:
                    gih = onButtonL1Pressed;
                    break;
                case GameKeys.LT:
                    gih = onButtonL2Pressed;
                    break;
                case GameKeys.RB:
                    gih = onButtonR1Pressed;
                    break;
                case GameKeys.RT:
                    gih = onButtonR2Pressed;
                    break;
                case GameKeys.UpLeft:
                    gih = onButtonUpLeftPressed;
                    break;
                case GameKeys.UpRight:
                    gih = onButtonUpRightPressed;
                    break;
                case GameKeys.DownLeft:
                    gih = onButtonDownLeftPressed;
                    break;
                case GameKeys.DownRight:
                    gih = onButtonDownRightPressed;
                    break;
                case GameKeys.NoneDirection:
                    gih = onNoneDirectionPressed;
                    break;
            }
            dispatchEvent(onAnyButtonPressed, key);
            dispatchEvent(gih, key);
        }

        private void handleGameKeyIsDown(GameKeys key)
        {
            gameInputHandler gih = null;
            switch (key)
            {
                case GameKeys.Down:
                    gih = onButtonDownIsDown;
                    break;
                case GameKeys.Up:
                    gih = onButtonUpIsDown;
                    break;
                case GameKeys.Left:
                    gih = onButtonLeftIsDown;
                    break;
                case GameKeys.Right:
                    gih = onButtonRightIsDown;
                    break;
                case GameKeys.A:
                    gih = onButtonAIsDown;
                    break;
                case GameKeys.B:
                    gih = onButtonBIsDown;
                    break;
                case GameKeys.Y:
                    gih = onButtonYIsDown;
                    break;
                case GameKeys.X:
                    gih = onButtonXIsDown;
                    break;
                case GameKeys.Start:
                    gih = onButtonStartIsDown;
                    break;
                case GameKeys.Back:
                    gih = onButtonBackIsDown;
                    break;
                case GameKeys.LB:
                    gih = onButtonL1IsDown;
                    break;
                case GameKeys.LT:
                    gih = onButtonL2IsDown;
                    break;
                case GameKeys.RB:
                    gih = onButtonR1IsDown;
                    break;
                case GameKeys.RT:
                    gih = onButtonR2IsDown;
                    break;
                case GameKeys.UpLeft:
                    gih = onButtonUpLeftIsDown;
                    break;
                case GameKeys.UpRight:
                    gih = onButtonUpRightIsDown;
                    break;
                case GameKeys.DownLeft:
                    gih = onButtonDownLeftIsDown;
                    break;
                case GameKeys.DownRight:
                    gih = onButtonDownRightIsDown;
                    break;
                case GameKeys.NoneDirection:
                    gih = onNoneDirectionIsDown;
                    break;
            }
            dispatchEvent(onAnyButtonIsDown, key);
            dispatchEvent(gih, key);
        }

        private void handleGameKeyReleased(GameKeys key)
        {
            gameInputHandler gih = null;
            switch (key)
            {
                case GameKeys.Down:
                    gih = onButtonDownReleased;
                    break;
                case GameKeys.Up:
                    gih = onButtonUpReleased;
                    break;
                case GameKeys.Left:
                    gih = onButtonLeftReleased;
                    break;
                case GameKeys.Right:
                    gih = onButtonRightReleased;
                    break;
                case GameKeys.A:
                    gih = onButtonAReleased;
                    break;
                case GameKeys.B:
                    gih = onButtonBReleased;
                    break;
                case GameKeys.Y:
                    gih = onButtonYReleased;
                    break;
                case GameKeys.X:
                    gih = onButtonXReleased;
                    break;
                case GameKeys.Start:
                    gih = onButtonStartReleased;
                    break;
                case GameKeys.Back:
                    gih = onButtonBackReleased;
                    break;
                case GameKeys.LB:
                    gih = onButtonL1Released;
                    break;
                case GameKeys.LT:
                    gih = onButtonL2Released;
                    break;
                case GameKeys.RB:
                    gih = onButtonR1Released;
                    break;
                case GameKeys.RT:
                    gih = onButtonR2Released;
                    break;
                case GameKeys.UpLeft:
                    gih = onButtonUpLeftReleased;
                    break;
                case GameKeys.UpRight:
                    gih = onButtonUpRightReleased;
                    break;
                case GameKeys.DownLeft:
                    gih = onButtonDownLeftReleased;
                    break;
                case GameKeys.DownRight:
                    gih = onButtonDownRightReleased;
                    break;
                case GameKeys.NoneDirection:
                    gih = onNoneDirectionReleased;
                    break;
            }
            dispatchEvent(onAnyButtonReleased, key);
            dispatchEvent(gih, key);
        }

        #endregion Disparadores de eventos

        /// <summary>
        /// Retorna verdadeiro se uma GameKeys for uma direção.
        /// </summary>
        /// <param name="key">GameKey</param>
        /// <returns>bool</returns>
        public bool GameKeysIsDirection(GameKeys key)
        {
            switch (key)
            {
                case GameKeys.Up:
                case GameKeys.Down:
                case GameKeys.Left:
                case GameKeys.Right:
                case GameKeys.UpLeft:
                case GameKeys.UpRight:
                case GameKeys.DownLeft:
                case GameKeys.DownRight:
                    return true;
                default:
                    return false;
            }
        }

        #region Listener
        public void addListener(InputListener listener)
        {
            if (listener != null)
            {
                // ANY
                this.onAnyButtonPressed += new gameInputHandler(listener.onAnyButtonPressed);
                this.onAnyButtonReleased += new gameInputHandler(listener.onAnyButtonReleased);

                this.onNoneDirectionPressed += new gameInputHandler(listener.onNoneDirectionPressed);
                this.onNoneDirectionReleased += new gameInputHandler(listener.onNoneDirectionReleased);
                this.onNoneDirectionIsDown += new gameInputHandler(listener.onNoneDirectionIsDown);

                // A
                this.onButtonAPressed += new gameInputHandler(listener.onButtonAPressed);
                this.onButtonAReleased += new gameInputHandler(listener.onButtonAReleased);
                this.onButtonAIsDown += new gameInputHandler(listener.onButtonAIsDown);

                // X
                this.onButtonXPressed += new gameInputHandler(listener.onButtonXPressed);
                this.onButtonXReleased += new gameInputHandler(listener.onButtonXReleased);
                this.onButtonXIsDown += new gameInputHandler(listener.onButtonXIsDown);

                // Y
                this.onButtonYPressed += new gameInputHandler(listener.onButtonYPressed);
                this.onButtonYReleased += new gameInputHandler(listener.onButtonYReleased);
                this.onButtonYIsDown += new gameInputHandler(listener.onButtonYIsDown);
                // B
                this.onButtonBPressed += new gameInputHandler(listener.onButtonBPressed);
                this.onButtonBReleased += new gameInputHandler(listener.onButtonBReleased);
                this.onButtonBIsDown += new gameInputHandler(listener.onButtonBIsDown);

                
                

                // Down
                this.onButtonDownPressed += new gameInputHandler(listener.onButtonDownPressed);
                this.onButtonDownReleased += new gameInputHandler(listener.onButtonDownReleased);
                this.onButtonDownIsDown += new gameInputHandler(listener.onButtonDownIsDown);

                // L1
                this.onButtonL1Pressed += new gameInputHandler(listener.onButtonL1Pressed);
                this.onButtonL1Released += new gameInputHandler(listener.onButtonL1Released);
                this.onButtonL1IsDown += new gameInputHandler(listener.onButtonL1IsDown);

                // L2
                this.onButtonL2Pressed += new gameInputHandler(listener.onButtonL2Pressed);
                this.onButtonL2Released += new gameInputHandler(listener.onButtonL2Released);
                this.onButtonL2IsDown += new gameInputHandler(listener.onButtonL2IsDown);

                // LEFT
                this.onButtonLeftPressed += new gameInputHandler(listener.onButtonLeftPressed);
                this.onButtonLeftReleased += new gameInputHandler(listener.onButtonLeftReleased);
                this.onButtonLeftIsDown += new gameInputHandler(listener.onButtonLeftIsDown);

                // R1
                this.onButtonR1Pressed += new gameInputHandler(listener.onButtonR1Pressed);
                this.onButtonR1Released += new gameInputHandler(listener.onButtonR1Released);
                this.onButtonR1IsDown += new gameInputHandler(listener.onButtonR1IsDown);

                // R2
                this.onButtonR2Pressed += new gameInputHandler(listener.onButtonR2Pressed);
                this.onButtonR2Released += new gameInputHandler(listener.onButtonR2Released);
                this.onButtonR2IsDown += new gameInputHandler(listener.onButtonR2IsDown);

                // Right
                this.onButtonRightPressed += new gameInputHandler(listener.onButtonRightPressed);
                this.onButtonRightReleased += new gameInputHandler(listener.onButtonRightReleased);
                this.onButtonRightIsDown += new gameInputHandler(listener.onButtonRightIsDown);

                // Start
                this.onButtonStartPressed += new gameInputHandler(listener.onButtonStartPressed);
                this.onButtonStartReleased += new gameInputHandler(listener.onButtonStartReleased);
                this.onButtonStartIsDown += new gameInputHandler(listener.onButtonStartIsDown);

                // Back
                this.onButtonBackPressed += new gameInputHandler(listener.onButtonBackPressed);
                this.onButtonBackReleased += new gameInputHandler(listener.onButtonBackReleased);
                this.onButtonBackIsDown += new gameInputHandler(listener.onButtonBackIsDown);

                // Up
                this.onButtonUpPressed += new gameInputHandler(listener.onButtonUpPressed);
                this.onButtonUpReleased += new gameInputHandler(listener.onButtonUpReleased);
                this.onButtonUpIsDown += new gameInputHandler(listener.onButtonUpIsDown);

                // UpLeft
                this.onButtonUpLeftPressed += new gameInputHandler(listener.onButtonUpLeftPressed);
                this.onButtonUpLeftReleased += new gameInputHandler(listener.onButtonUpLeftReleased);
                this.onButtonUpLeftIsDown += new gameInputHandler(listener.onButtonUpLeftIsDown);

                // UpRight
                this.onButtonUpRightPressed += new gameInputHandler(listener.onButtonUpRightPressed);
                this.onButtonUpRightReleased += new gameInputHandler(listener.onButtonUpRightReleased);
                this.onButtonUpRightIsDown += new gameInputHandler(listener.onButtonUpRightIsDown);

                // DownLeft
                this.onButtonDownLeftPressed += new gameInputHandler(listener.onButtonDownLeftPressed);
                this.onButtonDownLeftReleased += new gameInputHandler(listener.onButtonDownLeftReleased);
                this.onButtonDownLeftIsDown += new gameInputHandler(listener.onButtonDownLeftIsDown);

                // DownLeft
                this.onButtonDownRightPressed += new gameInputHandler(listener.onButtonDownRightPressed);
                this.onButtonDownRightReleased += new gameInputHandler(listener.onButtonDownRightReleased);
                this.onButtonDownRightIsDown += new gameInputHandler(listener.onButtonDownRightIsDown);


                
            }
        }
        #endregion Listener

    }
}