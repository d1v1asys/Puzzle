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
    public partial class form_write_player_info : Form
    {
        

        public form_write_player_info()
        {
            InitializeComponent();
        }

        private void button_level_easy_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void button_level_medium_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void button_level_hard_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void form_write_player_info_FormClosed(object sender, FormClosedEventArgs e)//Кнопка закрытия формы
        {
            form_select_picture_menu form_select_picture_menu = new form_select_picture_menu();
            form_select_picture_menu.Show();
        }

        private void StartGame(int i)//Метод старта игры
        {
            if (tb_write_name.Text == "Ввод..." || tb_write_name.Text.Length == 0 || tb_write_name.Text.IndexOf(" ") != -1 || tb_write_name.Text.IndexOf("-") != -1)
                MessageBox.Show("Введите корректное имя игрока!", "Ошибка!");
            //Условие на проверку корректности имени

            global_variables.player_name = tb_write_name.Text;//Записывает текст из поля ввода в переменную имени игрока
            global_variables.player_level = i;//Записывает число полученное при нажатии одной из кнопок в переменную уровня игрока

            puzzle_game puzzle_game = new puzzle_game();
            puzzle_game.Show();

            this.Hide();
        }
    }
}
