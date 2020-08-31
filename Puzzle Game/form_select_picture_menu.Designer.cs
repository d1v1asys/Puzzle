namespace Puzzle_Game
{
    partial class form_select_picture_menu
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
            this.info_text = new System.Windows.Forms.Label();
            this.picturebox_select_1 = new System.Windows.Forms.PictureBox();
            this.picturebox_select_2 = new System.Windows.Forms.PictureBox();
            this.picturebox_select_3 = new System.Windows.Forms.PictureBox();
            this.button_select_other_picture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_select_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_select_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_select_3)).BeginInit();
            this.SuspendLayout();
            // 
            // info_text
            // 
            this.info_text.AutoSize = true;
            this.info_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_text.Location = new System.Drawing.Point(70, 9);
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(337, 29);
            this.info_text.TabIndex = 0;
            this.info_text.Text = "Выбеите картинку для игры";
            // 
            // picturebox_select_1
            // 
            this.picturebox_select_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturebox_select_1.Image = global::Puzzle_Game.Properties.Resources.picture_1;
            this.picturebox_select_1.Location = new System.Drawing.Point(75, 80);
            this.picturebox_select_1.Name = "picturebox_select_1";
            this.picturebox_select_1.Size = new System.Drawing.Size(150, 150);
            this.picturebox_select_1.TabIndex = 1;
            this.picturebox_select_1.TabStop = false;
            this.picturebox_select_1.Click += new System.EventHandler(this.picturebox_select_1_Click);
            // 
            // picturebox_select_2
            // 
            this.picturebox_select_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturebox_select_2.Image = global::Puzzle_Game.Properties.Resources.picture_2;
            this.picturebox_select_2.Location = new System.Drawing.Point(257, 80);
            this.picturebox_select_2.Name = "picturebox_select_2";
            this.picturebox_select_2.Size = new System.Drawing.Size(150, 150);
            this.picturebox_select_2.TabIndex = 1;
            this.picturebox_select_2.TabStop = false;
            this.picturebox_select_2.Click += new System.EventHandler(this.picturebox_select_2_Click);
            // 
            // picturebox_select_3
            // 
            this.picturebox_select_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturebox_select_3.Image = global::Puzzle_Game.Properties.Resources.picture_3;
            this.picturebox_select_3.Location = new System.Drawing.Point(75, 257);
            this.picturebox_select_3.Name = "picturebox_select_3";
            this.picturebox_select_3.Size = new System.Drawing.Size(150, 150);
            this.picturebox_select_3.TabIndex = 1;
            this.picturebox_select_3.TabStop = false;
            this.picturebox_select_3.Click += new System.EventHandler(this.picturebox_select_3_Click);
            // 
            // button_select_other_picture
            // 
            this.button_select_other_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_select_other_picture.Location = new System.Drawing.Point(257, 257);
            this.button_select_other_picture.Name = "button_select_other_picture";
            this.button_select_other_picture.Size = new System.Drawing.Size(150, 150);
            this.button_select_other_picture.TabIndex = 2;
            this.button_select_other_picture.Text = "Выбрать другую картинку";
            this.button_select_other_picture.UseVisualStyleBackColor = true;
            this.button_select_other_picture.Click += new System.EventHandler(this.button_select_other_picture_Click);
            // 
            // form_select_picture_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 417);
            this.Controls.Add(this.button_select_other_picture);
            this.Controls.Add(this.picturebox_select_2);
            this.Controls.Add(this.picturebox_select_3);
            this.Controls.Add(this.picturebox_select_1);
            this.Controls.Add(this.info_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_select_picture_menu";
            this.Text = "Puzzle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_select_picture_menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_select_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_select_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_select_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_text;
        private System.Windows.Forms.PictureBox picturebox_select_1;
        private System.Windows.Forms.PictureBox picturebox_select_2;
        private System.Windows.Forms.PictureBox picturebox_select_3;
        private System.Windows.Forms.Button button_select_other_picture;
    }
}