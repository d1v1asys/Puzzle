namespace Puzzle_Game
{
    partial class write_result
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
            this.text_write_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_write_result
            // 
            this.text_write_result.AutoSize = true;
            this.text_write_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.text_write_result.Location = new System.Drawing.Point(12, 9);
            this.text_write_result.Name = "text_write_result";
            this.text_write_result.Size = new System.Drawing.Size(120, 17);
            this.text_write_result.TabIndex = 0;
            this.text_write_result.Text = "Рейтинг игроков:";
            // 
            // write_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.text_write_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "write_result";
            this.Text = "Puzzle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.write_result_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_write_result;
    }
}