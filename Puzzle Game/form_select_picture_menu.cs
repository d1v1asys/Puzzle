using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Game
{
    public partial class form_select_picture_menu : Form
    {    
        public form_select_picture_menu()
        {
            InitializeComponent();
        }


        private void picturebox_select_1_Click(object sender, EventArgs e)
        {
            SelectLevelPlayer(Puzzle_Game.Properties.Resources.picture_1);
        }

        private void picturebox_select_2_Click(object sender, EventArgs e)
        {
            SelectLevelPlayer(Puzzle_Game.Properties.Resources.picture_2);
        }

        private void picturebox_select_3_Click(object sender, EventArgs e)
        {
            SelectLevelPlayer(Puzzle_Game.Properties.Resources.picture_3);
        }

        private void button_select_other_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_main_picture = new OpenFileDialog();//Открываем диалог выбора файлов
            open_main_picture.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";//Фильтруем формат файлов

            if (open_main_picture.ShowDialog() == DialogResult.OK)//Если нажата кнопка ok, то сохраняем картинку
                SelectLevelPlayer(Image.FromFile(open_main_picture.FileName));


        }

        private void SelectLevelPlayer(Image image)
        {

            global_variables.picture_main.Image = image;//Сохраняем картинку
            global_variables.picture_main.Size = new System.Drawing.Size(
                Convert.ToInt32(((float) global_variables.picture_main.Image.Width / (float)global_variables.picture_main.Image.Height) * 600), 
                600);
            //Устанавливаем размер картинке

            global_variables.picture_main.Top =
            global_variables.picture_main.Left = 0;//Устанавливаем позицию картинки

            form_write_player_info form_write_player_info = new form_write_player_info();
            form_write_player_info.Show();

            this.Hide();

            return;
        }

        private void form_select_picture_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_main_menu form_main_menu = new form_main_menu();
            form_main_menu.Show();
        }
    }
}
