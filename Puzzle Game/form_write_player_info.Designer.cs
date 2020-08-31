namespace Puzzle_Game
{
    partial class form_write_player_info
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
            this.info_text_1 = new System.Windows.Forms.Label();
            this.tb_write_name = new System.Windows.Forms.TextBox();
            this.button_level_easy = new System.Windows.Forms.Button();
            this.button_level_medium = new System.Windows.Forms.Button();
            this.button_level_hard = new System.Windows.Forms.Button();
            this.info_text_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // info_text_1
            // 
            this.info_text_1.AutoSize = true;
            this.info_text_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_text_1.Location = new System.Drawing.Point(35, 24);
            this.info_text_1.Name = "info_text_1";
            this.info_text_1.Size = new System.Drawing.Size(188, 25);
            this.info_text_1.TabIndex = 0;
            this.info_text_1.Text = "Введите свое имя:";
            // 
            // tb_write_name
            // 
            this.tb_write_name.ForeColor = System.Drawing.Color.Black;
            this.tb_write_name.HideSelection = false;
            this.tb_write_name.Location = new System.Drawing.Point(241, 29);
            this.tb_write_name.Name = "tb_write_name";
            this.tb_write_name.Size = new System.Drawing.Size(201, 20);
            this.tb_write_name.TabIndex = 1;
            this.tb_write_name.Text = "Ввод...";
            // 
            // button_level_easy
            // 
            this.button_level_easy.Location = new System.Drawing.Point(12, 149);
            this.button_level_easy.Name = "button_level_easy";
            this.button_level_easy.Size = new System.Drawing.Size(150, 100);
            this.button_level_easy.TabIndex = 2;
            this.button_level_easy.Text = "Легкая";
            this.button_level_easy.UseVisualStyleBackColor = true;
            this.button_level_easy.Click += new System.EventHandler(this.button_level_easy_Click);
            // 
            // button_level_medium
            // 
            this.button_level_medium.Location = new System.Drawing.Point(168, 149);
            this.button_level_medium.Name = "button_level_medium";
            this.button_level_medium.Size = new System.Drawing.Size(150, 100);
            this.button_level_medium.TabIndex = 2;
            this.button_level_medium.Text = "Средняя";
            this.button_level_medium.UseVisualStyleBackColor = true;
            this.button_level_medium.Click += new System.EventHandler(this.button_level_medium_Click);
            // 
            // button_level_hard
            // 
            this.button_level_hard.Location = new System.Drawing.Point(324, 149);
            this.button_level_hard.Name = "button_level_hard";
            this.button_level_hard.Size = new System.Drawing.Size(150, 100);
            this.button_level_hard.TabIndex = 2;
            this.button_level_hard.Text = "Тяжелая";
            this.button_level_hard.UseVisualStyleBackColor = true;
            this.button_level_hard.Click += new System.EventHandler(this.button_level_hard_Click);
            // 
            // info_text_2
            // 
            this.info_text_2.AutoSize = true;
            this.info_text_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_text_2.Location = new System.Drawing.Point(35, 102);
            this.info_text_2.Name = "info_text_2";
            this.info_text_2.Size = new System.Drawing.Size(416, 25);
            this.info_text_2.TabIndex = 3;
            this.info_text_2.Text = "Выберите уровень сложности сбора пазла!";
            // 
            // form_write_player_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.info_text_2);
            this.Controls.Add(this.button_level_hard);
            this.Controls.Add(this.button_level_medium);
            this.Controls.Add(this.button_level_easy);
            this.Controls.Add(this.tb_write_name);
            this.Controls.Add(this.info_text_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_write_player_info";
            this.Text = "Puzzle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_write_player_info_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_text_1;
        private System.Windows.Forms.TextBox tb_write_name;
        private System.Windows.Forms.Button button_level_easy;
        private System.Windows.Forms.Button button_level_medium;
        private System.Windows.Forms.Button button_level_hard;
        private System.Windows.Forms.Label info_text_2;
    }
}