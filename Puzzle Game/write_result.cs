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
    public partial class write_result : Form
    {
        public write_result()
        {
            InitializeComponent();

            

            if (File.Exists("database.txt"))
            {
                string[] database_text = File.ReadAllLines("database.txt");

                for (int i = 0; i < 15; i++)
                {
                    string player_name = null;//Переменная которая будет хранить в себе имя игрока
                    int player_level = -1//Переменная которая будет хранить в себе уровень сложности игрока
                        , player_time = -1;//Переменная которая будет хранить в себе время игры игрока

                    int index_pos = 0;//Переменная отслеживает строку чтобы в будущем очистить её
                    for (int i_t = 0; i_t < database_text.Length; i_t++)
                    {

                        if (database_text[i_t] == null || database_text[i_t].Trim() == string.Empty)//Условие проверяет строку на пустоту
                            continue;//Если строка пустая, то пропускаем итерацию цикла

                        var c_split = database_text[i_t].Split('-');//Записываем аргументы

                        if ((Convert.ToInt32(c_split[1]) > player_level) ||
                            (Convert.ToInt32(c_split[1]) == player_level
                                && Convert.ToInt32(c_split[2]) != -1
                                && Convert.ToInt32(c_split[2]) < player_time))
                        {//Сортировка рейтинга игроков
                            player_name = c_split[0];
                            player_level = Convert.ToInt32(c_split[1]);
                            player_time = Convert.ToInt32(c_split[2]);

                            index_pos = i_t;//Записываем номер строки, которую необходимо удалить.
                        }

                    }

                    database_text[index_pos] = null;//Чистим строку, чтобы она больше не попадалась при сортировке рейтинга

                    if (player_name != null)//Записываем игрока в список, если имя существует в переменной 
                        text_write_result.Text += string.Format("\n{0}. {1} ({2}) | Время: {3} сек."
                                                                , i + 1, player_name, global_variables.GetLevelName(player_level), player_time);
                    else
                        text_write_result.Text += string.Format("\n{0}. Место никто не занял!", i + 1);
                }
            }
            else
                text_write_result.Text = "Рейтинг игроков отстутсвует. Никто не прошел игру!";
            
                
        }

        private void write_result_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_main_menu form_main_menu = new form_main_menu();
            form_main_menu.Show();
        }
    }
}
