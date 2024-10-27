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
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            prcbCoolDown.Step = Constance.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Constance.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;
            tmCoolDown.Interval = Constance.COOL_DOWN_INTERVAL;
            NewGame();
        }

        #region Methods
        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Kết Thúc");
        }

        void NewGame()
        {
            prcbCoolDown.Value = 0;
            tmCoolDown.Stop();

            ChessBoard.DrawGameBoard();

           
        }

        void Quit()
        {
            Application.Exit();
        }

        void Undo()
        {
            // Add your undo logic here
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

        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Quit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Undo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}

