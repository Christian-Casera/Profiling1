namespace BookMonitoring
{
    partial class dashboardform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardform));
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Wheat;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1215, 110);
            panel4.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(96, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Bold);
            label2.Location = new Point(183, 36);
            label2.Name = "label2";
            label2.Size = new Size(147, 36);
            label2.TabIndex = 0;
            label2.Text = "Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 158);
            panel3.Location = new Point(-2, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(1217, 624);
            panel3.TabIndex = 7;
            // 
            // dashboardform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 599);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboardform";
            Text = "dashboardform";
            Load += dashboardform_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel3;
    }
}