namespace Caro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {

            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard, playerName, avatar);

            ChessBoard = new ChessBoardManager(pnlChessBoard, playerName, avatar);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCoolDown.Step = Constance.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Constance.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;

            tmCoolDown.Interval = Constance.COOL_DOWN_INTERVAL;

            ChessBoard.DrawGameBoard();
          
        }

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Kết Thúc");
        }
        void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }

        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void tmCoolDown_Tick_1(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                EndGame();
                
            }

        }



        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void avatar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
