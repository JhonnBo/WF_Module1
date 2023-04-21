using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] // Указывает, что потоковой моделью COM для приложения является
                    // однопотоковaя модель.
        static void Main()
        {
            // Этот метод включает визуальные стили для приложения.
            // Стили визуальных элементов — это цвета, шрифты и другие визуальные элементы,
            // образующие тему операционной системы. Элементы управления будут
            // рисовать с помощью визуальных стилей,
            // если элемент управления и операционная система поддерживают их. 
            Application.EnableVisualStyles();
            // Задает значение по умолчанию для всего приложения для свойства,
            // определенного UseCompatibleTextRendering для определенных элементов управления.
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}
