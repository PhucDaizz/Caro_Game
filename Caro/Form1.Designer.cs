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
            components = new System.ComponentModel.Container();
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
            tmCoolDown = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlChessBoard.Location = new Point(11, 26);
            pnlChessBoard.Margin = new Padding(2);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(1059, 670);
            pnlChessBoard.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(1074, 275);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 420);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 382);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(249, 20);
            label3.TabIndex = 7;
            label3.Text = "Người chơi nào có 5 đướngex thắng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.Location = new Point(12, 109);
            prcbCoolDown.Margin = new Padding(2);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.Size = new Size(202, 10);
            prcbCoolDown.TabIndex = 0;
            prcbCoolDown.Click += progressBar1_Click;
            // 
            // playerName
            // 
            playerName.Location = new Point(12, 124);
            playerName.Margin = new Padding(2);
            playerName.Name = "playerName";
            playerName.ReadOnly = true;
            playerName.Size = new Size(202, 27);
            playerName.TabIndex = 3;
            // 
            // txbIP
            // 
            txbIP.Location = new Point(12, 161);
            txbIP.Margin = new Padding(2);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(202, 27);
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
            panel4.Location = new Point(1074, 11);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 255);
            panel4.TabIndex = 3;
            // 
            // avatar
            // 
            avatar.Location = new Point(12, 10);
            avatar.Margin = new Padding(2);
            avatar.Name = "avatar";
            avatar.Size = new Size(117, 94);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 7;
            avatar.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Logo_UTH;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(144, 10);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 94);
            panel2.TabIndex = 6;
            // 
            // btnLAN
            // 
            btnLAN.Location = new Point(12, 190);
            btnLAN.Margin = new Padding(2);
            btnLAN.Name = "btnLAN";
            btnLAN.Size = new Size(202, 27);
            btnLAN.TabIndex = 5;
            btnLAN.Text = "Kết nối";
            btnLAN.UseVisualStyleBackColor = true;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1372, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, undoToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "New game";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(224, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click_1;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(224, 26);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 714);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pnlChessBoard);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Game Caro";
            FormClosing += Form1_FormClosing;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Timer tmCoolDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}
