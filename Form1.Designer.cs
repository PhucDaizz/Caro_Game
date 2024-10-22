namespace Caro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlChessBoard = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            prcbCoolDown = new ProgressBar();
            playerName = new TextBox();
            txbIP = new TextBox();
            panel4 = new Panel();
            avatar = new PictureBox();
            panel2 = new Panel();
            btnLAN = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlChessBoard.Location = new Point(12, 12);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(1300, 857);
            pnlChessBoard.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(1343, 344);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 525);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 478);
            label3.Name = "label3";
            label3.Size = new Size(301, 25);
            label3.TabIndex = 7;
            label3.Text = "Người chơi nào có 5 đướngex thắng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 30);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.Location = new Point(15, 136);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.Size = new Size(252, 13);
            prcbCoolDown.TabIndex = 0;
            prcbCoolDown.Click += progressBar1_Click;
            // 
            // playerName
            // 
            playerName.Location = new Point(15, 155);
            playerName.Name = "playerName";
            playerName.ReadOnly = true;
            playerName.Size = new Size(252, 31);
            playerName.TabIndex = 3;
            // 
            // txbIP
            // 
            txbIP.Location = new Point(15, 201);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(252, 31);
            txbIP.TabIndex = 4;
            txbIP.Text = "127.0.0.112";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(avatar);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(btnLAN);
            panel4.Controls.Add(txbIP);
            panel4.Controls.Add(playerName);
            panel4.Controls.Add(prcbCoolDown);
            panel4.Location = new Point(1343, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 319);
            panel4.TabIndex = 3;
            // 
            // avatar
            // 
            avatar.Location = new Point(15, 13);
            avatar.Name = "avatar";
            avatar.Size = new Size(146, 117);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 7;
            avatar.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Logo_UTH;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(180, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 117);
            panel2.TabIndex = 6;
            // 
            // btnLAN
            // 
            btnLAN.Location = new Point(15, 238);
            btnLAN.Name = "btnLAN";
            btnLAN.Size = new Size(252, 34);
            btnLAN.TabIndex = 5;
            btnLAN.Text = "Kết nối";
            btnLAN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 893);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pnlChessBoard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Game Caro";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel panel3;
        private TextBox txbIP;
        private TextBox playerName;
        private ProgressBar prcbCoolDown;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Button btnLAN;
        private Label label3;
        private Panel panel2;
        private PictureBox avatar;
    }
}
