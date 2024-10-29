using GameCaro;
using Microsoft.VisualBasic.Devices;
using System.Net.NetworkInformation;

namespace Caro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        SocketManager socket;
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
            socket = new SocketManager();
            NewGame();
        }

        #region Methods
        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
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
            ChessBoard.Undo();
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

        private void btnLAN_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;

            if (!socket.ConnectServer()) // Nếu không kết nối được tới server
            {
                try
                {
                    socket.CreateServer(); // Tạo server nếu không tìm thấy server nào
                    MessageBox.Show("Server đã được tạo thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tạo server: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kết nối đến server thành công.");
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }

            if (socket.isServer)
            {
                MessageBox.Show("Đang chờ kết nối từ client...");
            }
            else
            {
                try
                {
                    socket.Send("Thông tin từ client");
                    MessageBox.Show("Gửi dữ liệu đến server thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi gửi dữ liệu: " + ex.Message);
                }
            }

            Thread listenThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(500);
                    try
                    {
                        Listen();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error during listening: " + ex.Message);
                    }
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        void Listen()
        {
            try
            {
                string data = (string)socket.Receive();
                if (data != null)
                {
                    MessageBox.Show("Nhận dữ liệu: " + data);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nhận được.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhận dữ liệu: " + ex.Message);
            }
        }




    }
}

