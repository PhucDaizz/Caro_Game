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

            ChessBoard = new ChessBoardManager(pnlChessBoard);

            ChessBoard.DrawGameBoard();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void avatar_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
