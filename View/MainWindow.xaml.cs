using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfMvvmSample.ViewModel;

namespace WpfMvvmSample.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // DataContext = new MainWindowVM();
            // Если мы объявляем vm в ресурсах через xaml
            // то тут нам ничего не надо писать
            /* подключение в xaml выглядит примерно так:
            <window
            ...
            DataContext = "{DynamicResource vm}"
            ...
            >
            <Window.Resources >
                <vm:MainWindowVM x:Key = "vm" />
            </Window.Resources >
            */
            // Паттерн MVVM - Model - View - ViewModel 
            // Model - слой бизнес-логики (обращение к бд, вычисления и пр)
            // View - слой представления (Окна, страницы, визуальные компоненты)
            // ViewModel - слой связи между слоями выше. 

            // MVC - model - view - controller - используется на сайтах
            // MVP - model - view - presenter - Windows Forms

        }
    }
}
