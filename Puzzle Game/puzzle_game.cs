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
    public partial class puzzle_game : Form
    {
        /*------------------------- Переменные -------------------------*/
        PictureBox[] picture_fragment = new PictureBox[16];//Массив, который в дальнейшем будет содержать в себе все фрагменты

        Label[] info_text = new Label[3];//Массив, который будет выводиться в нижней панели игры с информацией

        int[] picture_position = new int[16];//Массив, который определяет местоположение фрагмента

        int max_frag = 0//Макс. количество фрагментов
            , fragment_select = -1//Выбранный фрагмент
            , fragment_ready = 0//Количество фрагментов, которые находятся на своих местах
            ;
        /*--------------------------------------------------------------*/


        public puzzle_game()
        {
            InitializeComponent();

            int frag_line = global_variables.player_level + 2//Количество фрагментов в одной линии
                , line_lenght_Width = global_variables.picture_main.Width / frag_line//Размер фрагмента по ширине
                , line_lenght_Height = global_variables.picture_main.Height / frag_line//Размер фрагмента по длине
                , pos_h = 0//Позиция фрагмента по высоте
                , pos_w = 0//Позиция фрагмента по ширине
                ;
           
            Point[] fragment_position = new Point[
                    max_frag = (int)(Math.Pow(frag_line, 2))//Максимальное количество фрагментов
                    ];//Массив из позиции фрагментов

            Random rand = new Random();

            
            this.ClientSize = new Size(global_variables.picture_main.Width, global_variables.picture_main.Height + 20);

            
            for (int i = 0; i < max_frag; i++)
            {
                picture_fragment[i] = new PictureBox();

                

                Bitmap main_btm = 
                    new Bitmap(global_variables.picture_main.Image,
                    global_variables.picture_main.Width,
                    global_variables.picture_main.Height);//Битмап с помощью которого выразаем картинки из основной картинки

                Rectangle perim = 
                    new Rectangle(new Point(pos_w, pos_h), 
                    new Size(line_lenght_Width, line_lenght_Height));//Устанавливаем размер и позицию исходя из которых будур вырезаны фрагменты

                Graphics g = Graphics.FromImage(main_btm);//Создаем объект графики
                g.DrawImage(main_btm, 0, 0, perim, GraphicsUnit.Pixel);//Вырезаем фрагмент

                fragment_position[i] = new Point(pos_w, pos_h);//Сохраняем позицию в массив 
                picture_position[i] = i;//Сохраняем стандартные позиции

                pos_w += line_lenght_Width;//Изменяем координату по ширине, чтобы вырезать новый фргамент из картинки
                if (((i + 1) % frag_line) == 0)//Если линия закончилась, то спускаемся по координате pos_h ниже, а pos_w смещаем к 0
                {
                    pos_h += line_lenght_Height;
                    pos_w = 0;
                }

                picture_fragment[i].Image = main_btm;//Сохраняем картинку фрагмента
                this.Controls.Add(picture_fragment[i]);//Добавляем фрагмент на форму
            }

            for (int i = 0; i < max_frag; i++)//Цикл, который раскидывает фрагменты по разным координатам
            {
                int 
                    save_Rand = rand.Next(max_frag - 1)
                    , temp_i = picture_position[i];
                var 
                    temp = fragment_position[save_Rand];

                fragment_position[save_Rand] = fragment_position[i];
                fragment_position[i] = temp;

                picture_position[i] = picture_position[save_Rand];
                picture_position[save_Rand] = temp_i;       
                //Выше алгоритм цикла, который меняет местами элементы массивов
            }

            for(int i = 0; i < max_frag; i++)//Проверка фрагментов, которые стоят на своих местах
                if (picture_position[i] == i)
                    fragment_ready++;

            for (int i = 0; i < max_frag; i++)//Цикл устанавливает позицию фрагментов и его свойства
            {
                picture_fragment[i].Location = new Point(fragment_position[i].X + 1, fragment_position[i].Y + 1);
                picture_fragment[i].Size = new Size(line_lenght_Width, line_lenght_Height);
                picture_fragment[i].Click += new System.EventHandler(picture_fragment_Click);//Устанавливаем кликабельность фрагментам
                picture_fragment[i].Cursor = System.Windows.Forms.Cursors.Hand;
            }

            


            for (int i = 0; i < 3; i++)//Устанавливаем свойства для информационного текста
            {
                info_text[i] = new Label();
                info_text[i].ForeColor = System.Drawing.Color.Black;
                info_text[i].TextAlign = ContentAlignment.MiddleCenter;
                info_text[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                info_text[i].BackColor = System.Drawing.Color.Transparent;
                info_text[i].AutoSize = true;

                this.Controls.Add(info_text[i]);
            }

            

            info_text[0].Text = "Игрок: " + global_variables.player_name;
            info_text[1].Text = "Уровень сложности: " + global_variables.GetLevelName(global_variables.player_level);  
            info_text[2].Text = "Прошло времени: 0 сек.";
            
            info_text[0].Location = new Point(5, this.ClientSize.Height - 20);
            info_text[1].Location = new Point(this.ClientSize.Width / 2 - info_text[1].Width/2, this.ClientSize.Height - 20);
            info_text[2].Location = new Point(this.ClientSize.Width - info_text[2].Width - 5, this.ClientSize.Height - 20);

            timer.Enabled = true;//Включаем таймер

        }

        private void timer_Tick(object sender, EventArgs e)//Таймер
        {
            global_variables.player_time++;//Каждую секунду к времени игрока добавляем еденицу
            info_text[2].Text = "Прошло времени: " + global_variables.player_time + " сек.";//Меняем текст 
            info_text[2].Location = new Point(this.ClientSize.Width - info_text[2].Width - 5, this.ClientSize.Height - 20);//Меняем позицию, чтобы текст не выходил за рамки
        }

        private void picture_fragment_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < max_frag; i++)//Запускаем цикл, для проверки каждого элемента
            {
                if (picture_fragment[i] == sender)//Инициализация фрагмента
                {
                    if (fragment_select == i)//Если выбран тот же фрагмент
                        break;
                    if (fragment_select != -1)//Если фрагмент выбран
                    {
                        if (picture_position[i] == i)//Если фрагмент находился на верном месте, то вычитаем количество готовых фрагментов
                            fragment_ready--;

                        if (picture_position[fragment_select] == fragment_select)//Если фрагмент находился на верном месте, то вычитаем количество готовых фрагментов
                            fragment_ready--;

                        picture_fragment[fragment_select].Size = new Size(picture_fragment[fragment_select].Width + 6, picture_fragment[fragment_select].Height + 6);//Изменяем свойства фрагмента, визуально снимаем выделение
                        picture_fragment[fragment_select].Location = new Point(picture_fragment[fragment_select].Left - 3, picture_fragment[fragment_select].Top - 3);//Изменяем свойства фрагмента, визуально снимаем выделение

                        var temp_l = picture_fragment[i].Location;
                        int temp_i = picture_position[i];

                        //
                        picture_fragment[i].Location = picture_fragment[fragment_select].Location;
                        picture_fragment[fragment_select].Location = temp_l;

                        picture_position[i] = picture_position[fragment_select];
                        picture_position[fragment_select] = temp_i;
                        //Выше алгоритм переноса эелементов массивов

                        if (picture_position[i] == i)//Если после перестановки фрагментов позиция стала верной, то добавляем еденицу к готовым фрагментам
                            fragment_ready++;

                        if (picture_position[fragment_select] == fragment_select)//Если после перестановки фрагментов позиция стала верной, то добавляем еденицу к готовым фрагментам
                            fragment_ready++;

                        fragment_select = -1;

                        
                        if (fragment_ready == max_frag)//Если количество готовых фрагментов равно количеству всех фрагментов, то победа
                        {
                            timer.Enabled = false;//Выключаем таймер

                            using (StreamWriter database = new StreamWriter("database.txt", true))//Создаем или сразу записываем данные игрока в файл
                            {
                                database.WriteLine( 
                                                    global_variables.player_name
                                                    + "-" + global_variables.player_level
                                                    + "-" + global_variables.player_time);
                            }

                            string message_win = "Вы успешно собрали пазл!"
                                                    + "\n\nИмя игрока: " + global_variables.player_name
                                                    + "\nУровень сложности: " + global_variables.GetLevelName(global_variables.player_level)
                                                    + "\nВремя: " + global_variables.player_time + " сек."
                                                    + "\n\nНажмите 'OK' чтобы выйти сохранить результат и вернуться в главное меню"
                                                    ;//Текст сообщения о выйгрыше

                            if(MessageBox.Show(message_win, "Победа!") == DialogResult.OK)//Выводим диалог с сообщение о победе и информации об игре
                            {
                                global_variables.player_name = null;
                                global_variables.player_level = 0;
                                global_variables.player_time = 0;
                                //Обнуляем данные игры


                                form_main_menu form_main_menu = new form_main_menu();
                                form_main_menu.Show();

                                this.Hide();

                                return;
                            } 
                        }

                        break;
                    }
                    else
                    {
                        picture_fragment[i].Size = new Size(picture_fragment[i].Width - 6, picture_fragment[i].Height - 6);//Изменяем свойства фрагмента, визуально показывая выделение
                        picture_fragment[i].Location = new Point(picture_fragment[i].Left + 3, picture_fragment[i].Top + 3);//Изменяем свойства фрагмента, визуально показывая выделение

                        fragment_select = i;

                        break;
                    }
                }
            }

            return;
        }

        private void puzzle_game_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_main_menu form_main_menu = new form_main_menu();
            form_main_menu.Show();
        }       
    }
}
