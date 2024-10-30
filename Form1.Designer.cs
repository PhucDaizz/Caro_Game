namespace Game_Caro
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
            pnlChessBeard = new Panel();
            panel2 = new Panel();
            pctbAvatar = new PictureBox();
            pctbXO = new PictureBox();
            lbNameXO = new Label();
            lbRole = new Label();
            panel3 = new Panel();
            lbLoading = new Label();
            btnLan = new Button();
            prcbCoolDown = new ProgressBar();
            txbIP = new TextBox();
            txbPlayerName = new TextBox();
            pctbMark = new PictureBox();
            tmCoolDown = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbXO).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChessBeard
            // 
            pnlChessBeard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChessBeard.BackColor = SystemColors.Control;
            pnlChessBeard.Location = new Point(15, 34);
            pnlChessBeard.Margin = new Padding(4);
            pnlChessBeard.Name = "pnlChessBeard";
            pnlChessBeard.Size = new Size(953, 682);
            pnlChessBeard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pctbAvatar);
            panel2.Controls.Add(pctbXO);
            panel2.Controls.Add(lbNameXO);
            panel2.Controls.Add(lbRole);
            panel2.Location = new Point(1086, 39);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 109);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // pctbAvatar
            // 
            pctbAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pctbAvatar.BackgroundImage = (Image)resources.GetObject("pctbAvatar.BackgroundImage");
            pctbAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pctbAvatar.Location = new Point(8, 2);
            pctbAvatar.Margin = new Padding(4);
            pctbAvatar.Name = "pctbAvatar";
            pctbAvatar.Size = new Size(134, 109);
            pctbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbAvatar.TabIndex = 0;
            pctbAvatar.TabStop = false;
            pctbAvatar.Click += pctbAvatar_Click;
            // 
            // pctbXO
            // 
            pctbXO.BackColor = SystemColors.ButtonHighlight;
            pctbXO.Location = new Point(82, 111);
            pctbXO.Margin = new Padding(4);
            pctbXO.Name = "pctbXO";
            pctbXO.Size = new Size(31, 31);
            pctbXO.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbXO.TabIndex = 4;
            pctbXO.TabStop = false;
            // 
            // lbNameXO
            // 
            lbNameXO.AutoSize = true;
            lbNameXO.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbNameXO.Location = new Point(8, 111);
            lbNameXO.Margin = new Padding(4, 0, 4, 0);
            lbNameXO.Name = "lbNameXO";
            lbNameXO.Size = new Size(0, 22);
            lbNameXO.TabIndex = 4;
            // 
            // lbRole
            // 
            lbRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbRole.ForeColor = Color.Crimson;
            lbRole.Location = new Point(25, 2);
            lbRole.Margin = new Padding(4, 0, 4, 0);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(0, 29);
            lbRole.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(lbLoading);
            panel3.Controls.Add(btnLan);
            panel3.Controls.Add(prcbCoolDown);
            panel3.Controls.Add(txbIP);
            panel3.Controls.Add(txbPlayerName);
            panel3.Location = new Point(976, 154);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 562);
            panel3.TabIndex = 0;
            // 
            // lbLoading
            // 
            lbLoading.AutoSize = true;
            lbLoading.Location = new Point(444, 62);
            lbLoading.Margin = new Padding(4, 0, 4, 0);
            lbLoading.Name = "lbLoading";
            lbLoading.Size = new Size(0, 25);
            lbLoading.TabIndex = 4;
            // 
            // btnLan
            // 
            btnLan.Location = new Point(17, 101);
            btnLan.Margin = new Padding(4);
            btnLan.Name = "btnLan";
            btnLan.Size = new Size(227, 36);
            btnLan.TabIndex = 3;
            btnLan.Text = "Kết nối";
            btnLan.UseVisualStyleBackColor = true;
            btnLan.Click += btnLan_Click;
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.Location = new Point(14, 43);
            prcbCoolDown.Margin = new Padding(4);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.Size = new Size(230, 11);
            prcbCoolDown.TabIndex = 1;
            prcbCoolDown.Click += prcbCoolDown_Click;
            // 
            // txbIP
            // 
            txbIP.Location = new Point(15, 62);
            txbIP.Margin = new Padding(4);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(229, 31);
            txbIP.TabIndex = 0;
            txbIP.Text = "127.0.0.1";
            txbIP.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPlayerName
            // 
            txbPlayerName.Location = new Point(15, 4);
            txbPlayerName.Margin = new Padding(4);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.ReadOnly = true;
            txbPlayerName.Size = new Size(229, 31);
            txbPlayerName.TabIndex = 0;
            txbPlayerName.TextChanged += txbPlayerName_TextChanged;
            // 
            // pctbMark
            // 
            pctbMark.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pctbMark.Location = new Point(974, 41);
            pctbMark.Margin = new Padding(4);
            pctbMark.Name = "pctbMark";
            pctbMark.Size = new Size(104, 107);
            pctbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark.TabIndex = 2;
            pctbMark.TabStop = false;
            pctbMark.Click += pctbMark_Click;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1233, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, undoToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(270, 34);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(270, 34);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
            quitToolStripMenuItem.Size = new Size(270, 34);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(16, 29);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 749);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pctbMark);
            Controls.Add(pnlChessBeard);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Game Caro Fun ( Line up 5 )";
            FormClosing += Form1_FormClosed;
            Shown += Form1_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbXO).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChessBeard;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pctbAvatar;
        private PictureBox pctbMark;
        private ProgressBar prcbCoolDown;
        private TextBox textBox2;
        private TextBox txbPlayerName;
        private Button btnLan;
        private PictureBox pictureBox2;
        private TextBox txbIP;
        private Label lbRole;
        private System.Windows.Forms.Timer tmCoolDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label lbNameXO;
        private PictureBox pctbXO;
        private Label lbLoading;
    }
}