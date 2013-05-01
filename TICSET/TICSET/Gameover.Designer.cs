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
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(18, 18);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Result.Name = "Result";
            this.Result.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Result.Size = new System.Drawing.Size(592, 94);
            this.Result.TabIndex = 0;
            this.Result.TabStop = false;
            this.Result.Text = "groupBox1";
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 367);
            this.Controls.Add(this.Result);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gameover";
            this.Text = "Gameover";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Result;
    }
}