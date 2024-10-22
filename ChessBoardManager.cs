using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    internal class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox playerMark; 


        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }

        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }


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
            CurrentPlayer = 0;

            ChangePlayer();
        }
        #endregion

        #region Methods
        public void DrawGameBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constance.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Constance.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constance.CHESS_WIDTH,
                        Height = Constance.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn.Click += btn_Click;

                    chessBoard.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Constance.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        private void btn_Click(object sender, EventArgs e)        
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null) 
                return;

            Mark(btn);
            ChangePlayer();
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
