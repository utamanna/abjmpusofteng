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
            this.lbl_lost = new System.Windows.Forms.Label();
            this.lbl_won = new System.Windows.Forms.Label();
            this.btn_gameover_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_leaderboard_username = new System.Windows.Forms.Label();
            this.lbl_leaderboard_wins = new System.Windows.Forms.Label();
            this.lbl_leaderboard_losses = new System.Windows.Forms.Label();
            this.lbl_leaderboard_number = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Result.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // lbl_lost
            // 
            this.lbl_lost.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_lost.ForeColor = System.Drawing.Color.Red;
            this.lbl_lost.Location = new System.Drawing.Point(8, 51);
            this.lbl_lost.Name = "lbl_lost";
            this.lbl_lost.Size = new System.Drawing.Size(257, 29);
            this.lbl_lost.TabIndex = 1;
            this.lbl_lost.Text = "Lost";
            // 
            // lbl_won
            // 
            this.lbl_won.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_won.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_won.Location = new System.Drawing.Point(8, 24);
            this.lbl_won.Name = "lbl_won";
            this.lbl_won.Size = new System.Drawing.Size(257, 27);
            this.lbl_won.TabIndex = 0;
            this.lbl_won.Text = "Won";
            // 
            // btn_gameover_exit
            // 
            this.btn_gameover_exit.BackColor = System.Drawing.Color.Red;
            this.btn_gameover_exit.ForeColor = System.Drawing.Color.White;
            this.btn_gameover_exit.Location = new System.Drawing.Point(298, 29);
            this.btn_gameover_exit.Name = "btn_gameover_exit";
            this.btn_gameover_exit.Size = new System.Drawing.Size(185, 83);
            this.btn_gameover_exit.TabIndex = 1;
            this.btn_gameover_exit.Text = "Exit";
            this.btn_gameover_exit.UseVisualStyleBackColor = false;
            this.btn_gameover_exit.Click += new System.EventHandler(this.btn_gameover_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leaderboard";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "#      Name                  Wins          Losses";
            // 
            // lbl_leaderboard_username
            // 
            this.lbl_leaderboard_username.AutoSize = true;
            this.lbl_leaderboard_username.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_leaderboard_username.Location = new System.Drawing.Point(47, 8);
            this.lbl_leaderboard_username.Name = "lbl_leaderboard_username";
            this.lbl_leaderboard_username.Size = new System.Drawing.Size(117, 23);
            this.lbl_leaderboard_username.TabIndex = 2;
            this.lbl_leaderboard_username.Text = "User Name";
            // 
            // lbl_leaderboard_wins
            // 
            this.lbl_leaderboard_wins.AutoSize = true;
            this.lbl_leaderboard_wins.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_leaderboard_wins.Location = new System.Drawing.Point(233, 8);
            this.lbl_leaderboard_wins.Name = "lbl_leaderboard_wins";
            this.lbl_leaderboard_wins.Size = new System.Drawing.Size(52, 23);
            this.lbl_leaderboard_wins.TabIndex = 3;
            this.lbl_leaderboard_wins.Text = "wins";
            // 
            // lbl_leaderboard_losses
            // 
            this.lbl_leaderboard_losses.AutoSize = true;
            this.lbl_leaderboard_losses.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_leaderboard_losses.Location = new System.Drawing.Point(343, 8);
            this.lbl_leaderboard_losses.Name = "lbl_leaderboard_losses";
            this.lbl_leaderboard_losses.Size = new System.Drawing.Size(68, 23);
            this.lbl_leaderboard_losses.TabIndex = 4;
            this.lbl_leaderboard_losses.Text = "losses";
            // 
            // lbl_leaderboard_number
            // 
            this.lbl_leaderboard_number.AutoSize = true;
            this.lbl_leaderboard_number.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_leaderboard_number.Location = new System.Drawing.Point(5, 8);
            this.lbl_leaderboard_number.Name = "lbl_leaderboard_number";
            this.lbl_leaderboard_number.Size = new System.Drawing.Size(22, 23);
            this.lbl_leaderboard_number.TabIndex = 0;
            this.lbl_leaderboard_number.Text = "#";
            this.lbl_leaderboard_number.Click += new System.EventHandler(this.lbl_leaderboard_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl_leaderboard_losses);
            this.panel1.Controls.Add(this.lbl_leaderboard_username);
            this.panel1.Controls.Add(this.lbl_leaderboard_wins);
            this.panel1.Controls.Add(this.lbl_leaderboard_number);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 165);
            this.panel1.TabIndex = 5;
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_gameover_exit);
            this.Controls.Add(this.Result);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gameover";
            this.Text = "Gameover";
            this.Result.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.Label lbl_lost;
        private System.Windows.Forms.Label lbl_won;
        private System.Windows.Forms.Button btn_gameover_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_leaderboard_losses;
        private System.Windows.Forms.Label lbl_leaderboard_wins;
        private System.Windows.Forms.Label lbl_leaderboard_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_leaderboard_number;
    }
}