using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_main_menu());
        }

    }

    class global_variables//Переменные и методы, для использования в разных формах
    {
        public static string player_name;//Имя игрока
        public static int player_level;//Уровень игрока
        public static int player_time;//Время игры

        public static PictureBox picture_main = new PictureBox();//Главная картинка

        public static string GetLevelName(int i)//Метод с помощью которого можно получить имя уровня 
        {
            switch (i)
            {
                case 0:
                    return "Легкая";
                case 1:
                    return "Средняя";
                case 2:
                    return "Тяжелая";
                default:
                    return "Ошибка!";
            }      
        }
    }

}
