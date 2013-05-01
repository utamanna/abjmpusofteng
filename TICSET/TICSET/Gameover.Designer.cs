namespace TICSET
{
    partial class Gameover
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
            this.Result = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_leaderboard = new System.Windows.Forms.Label();
            this.lbl_won = new System.Windows.Forms.Label();
            this.lbl_lost = new System.Windows.Forms.Label();
            this.Result.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Controls.Add(this.lbl_lost);
            this.Result.Controls.Add(this.lbl_won);
            this.Result.Location = new System.Drawing.Point(18, 18);
            this.Result.Margin = new System.Windows.Forms.Padding(4);
            this.Result.Name = "Result";
            this.Result.Padding = new System.Windows.Forms.Padding(4);
            this.Result.Size = new System.Drawing.Size(272, 94);
            this.Result.TabIndex = 0;
            this.Result.TabStop = false;
            this.Result.Text = "Result";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(298, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_leaderboard);
            this.groupBox1.Location = new System.Drawing.Point(18, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leaderboard";
            // 
            // lbl_leaderboard
            // 
            this.lbl_leaderboard.Location = new System.Drawing.Point(8, 28);
            this.lbl_leaderboard.Name = "lbl_leaderboard";
            this.lbl_leaderboard.Size = new System.Drawing.Size(450, 192);
            this.lbl_leaderboard.TabIndex = 0;
            this.lbl_leaderboard.Text = "label1";
            // 
            // lbl_won
            // 
            this.lbl_won.Location = new System.Drawing.Point(8, 24);
            this.lbl_won.Name = "lbl_won";
            this.lbl_won.Size = new System.Drawing.Size(257, 27);
            this.lbl_won.TabIndex = 0;
            this.lbl_won.Text = "Won";
            // 
            // lbl_lost
            // 
            this.lbl_lost.Location = new System.Drawing.Point(8, 51);
            this.lbl_lost.Name = "lbl_lost";
            this.lbl_lost.Size = new System.Drawing.Size(257, 29);
            this.lbl_lost.TabIndex = 1;
            this.lbl_lost.Text = "Lost";
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gameover";
            this.Text = "Gameover";
            this.Result.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.Label lbl_lost;
        private System.Windows.Forms.Label lbl_won;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_leaderboard;
    }
}