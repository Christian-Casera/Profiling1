namespace BookMonitoring
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, completeBookDetailsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(318, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 4, 2, 4);
            menuStrip1.Size = new Size(1097, 66);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(149, 58);
            booksToolStripMenuItem.Text = "Attendance";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(193, 58);
            issueBooksToolStripMenuItem.Text = "Evaluation Record";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.OldLace;
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(152, 58);
            returnBooksToolStripMenuItem.Text = "CAF records";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            completeBookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailsToolStripMenuItem.Image");
            completeBookDetailsToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            completeBookDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            completeBookDetailsToolStripMenuItem.Size = new Size(143, 58);
            completeBookDetailsToolStripMenuItem.Text = "Promotion";
            completeBookDetailsToolStripMenuItem.Click += completeBookDetailsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.OldLace;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(87, 58);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Bisque;
            panel1.Location = new Point(39, 191);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 828);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(-7, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(1517, 66);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(293, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(872, 48);
            textBox1.TabIndex = 0;
            textBox1.Text = "Comprehensive Staff Profiling and Promotion Analytics System";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PeachPuff;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(39, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1433, 75);
            panel3.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1611, 1052);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel3;
    }
}