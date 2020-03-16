using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.InheritTheWin
{
    class InheritTheWin : Window
    {
        [STAThread]
        public static void Main() 
        {
            Application app = new Application();// создание нового приложение
            app.Run(new InheritTheWin()); // запуск(показать)
        }
        public InheritTheWin()
        {
            Title = "Inherit the Win";//название окошка
        }
    }
}