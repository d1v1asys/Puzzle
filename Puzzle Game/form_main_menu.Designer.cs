namespace Puzzle_Game
{
    partial class form_main_menu
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
            this.button_play = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_play.Location = new System.Drawing.Point(12, 12);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(200, 100);
            this.button_play.TabIndex = 0;
            this.button_play.Text = "Играть";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_result
            // 
            this.button_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_result.Location = new System.Drawing.Point(12, 118);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(200, 100);
            this.button_result.TabIndex = 1;
            this.button_result.Text = "Результаты";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_exit.Location = new System.Drawing.Point(12, 224);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(200, 100);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // form_main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 336);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_main_menu";
            this.Text = "Puzzle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_exit;
    }
}

