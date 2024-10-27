using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using NAudio.Wave;

namespace Caro
{
    internal class ChessBoardManager
    {
        #region Properties
        private WaveOutEvent backgroundPlayer;
        private AudioFileReader backgroundReader;

        private Panel chessBoard;
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox playerMark;
        private List<List<Button>> matrix;

        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }

        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }


        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }



        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark) 
        {
            this.chessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;
            this.player = new List<Player>()
            { 
                new Player("Người chơi A", Image.FromFile(Application.StartupPath + "\\Resources\\O_caro.jpg")),
                new Player("Người chơi B", Image.FromFile(Application.StartupPath + "\\Resources\\X_caro.jpg"))
            };
            
        }
        #endregion

        #region Methods
        public void DrawGameBoard()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

            CurrentPlayer = 0;

            ChangePlayer();

            string path = Application.StartupPath + "\\Resources\\background.wav";
            backgroundReader = new AudioFileReader(path);
            backgroundPlayer = new WaveOutEvent();
            backgroundPlayer.Init(backgroundReader);
            backgroundPlayer.PlaybackStopped += BackgroundPlaybackStopped; // Đăng ký sự kiện khi phát xong
            backgroundPlayer.Play();

            Matrix =  new List<List<Button>> ();

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constance.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Constance.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constance.CHESS_WIDTH,
                        Height = Constance.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += btn_Click;

                    chessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Constance.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        // Sự kiện khi nhạc nền phát hết
        private void BackgroundPlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Reset lại vị trí phát và phát lại từ đầu
            backgroundReader.Position = 0;
            backgroundPlayer.Play();
        }

        private void btn_Click(object sender, EventArgs e)        
        {
            string path = Application.StartupPath + "\\Resources\\bubble_sound.wav";
            Button btn = sender as Button;
            SoundPlayer sPlayer = new SoundPlayer(path);
            sPlayer.Play();


            if (btn.BackgroundImage != null) 
                return;

            Mark(btn);
            ChangePlayer();
            if (playerMarked != null)
                playerMarked(this, new EventArgs());
            if (isEndGame(btn))
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndMainDiag(btn) || isEndExtraDiag(btn);
        }

        private Point GetChessPoint(Button btn)
        {

            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);


            Point point = new Point(horizontal, vertical);

            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for(int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }
            int countRight = 0;
            for (int i = point.X + 1; i < Constance.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }


            return countLeft + countRight == 5;
        }

        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Constance.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }


            return countTop + countBottom == 5;
        }

        private bool isEndMainDiag(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }
            int countBottom = 0;
            for (int i = 1; i <= Constance.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Constance.CHESS_BOARD_HEIGHT || point.X + i >= Constance.CHESS_BOARD_WIDTH)
                    break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countTop + countBottom == 5;
        }

        private bool isEndExtraDiag(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Constance.CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }
            int countBottom = 0;
            for (int i = 1; i <= Constance.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Constance.CHESS_BOARD_HEIGHT || point.X - i < 0)
                    break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }


            return countTop + countBottom == 5;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }

        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;

            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion
    }
}
