using System;
using System.Windows.Forms;

/// <summary>
/// Реализовать шаблон «Приспособленец» при отображении на экране окружностей и прямоугольников в приложении Windows Forms.
/// Выполнил Шадрин А.
/// </summary>
namespace Lesson_5_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
