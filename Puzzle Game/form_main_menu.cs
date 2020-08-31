using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Puzzle_Game
{
    public partial class form_main_menu : Form
    {
        public form_main_menu()
        {
            InitializeComponent();
        }

        private void button_play_Click(object sender, EventArgs e)//Событие кнопки "Играть" (button_play)
        {
            form_select_picture_menu form_select_picture_menu = new form_select_picture_menu();
            form_select_picture_menu.Show();//Открывает форму выбора картинки

            this.Hide();//Закрывает данную форму
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            write_result write_result = new write_result();
            write_result.Show();//Открывает форму рейтинга

            this.Hide();//Закрывает данную форму
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();//Выход из приложения
        }

        
    }
}
