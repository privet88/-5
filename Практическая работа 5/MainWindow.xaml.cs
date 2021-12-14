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


namespace Практическая_работа_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Triad plus1 = new Triad();//обьект, содержащий результат увеличения чисел на 1
        Triad param = new Triad();//обьект, содержащий результат увеличения чисел на 10
        Triad chisla = new Triad();//объект, содержащий числа

        private void Сброс_Click(object sender, RoutedEventArgs e)
        {
            Ch1.Text = null;
            Ch2.Text = null;
            Ch3.Text = null;
            Plus1.Text = null;
            Plus10.Text = null;
        }

        private void Опрограмме_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("выполнил Потапкин Исп-31. Задание:Создать класс Triad (тройка отрицательных чисел). Создать необходимые методы и свойства.Определить метод увеличения полей на 1.Создать перегруженныеметоды SetParams, для установки параметров объекта, в том числе увеличения всехчисел на 10");
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Plus1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                chisla.One = Convert.ToInt32(Ch1.Text);//присваиваем значение из текст бокса
                chisla.Second = Convert.ToInt32(Ch2.Text);//присваиваем значение из текст бокса
                chisla.Third = Convert.ToInt32(Ch3.Text);//присваиваем значение из текст бокса
                plus1 = plus1.Plus1(chisla.One, chisla.Second, chisla.Third);//используем функцию
                Plus1.Text = plus1.One.ToString() + ";" + plus1.Second.ToString() + ";" + plus1.Third.ToString();//записывем результат вычислений в текст бокс

            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }
            }

        private void Plus10_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                chisla.One = Convert.ToInt32(Ch1.Text);//присваиваем значение из текст бокса
                chisla.Second = Convert.ToInt32(Ch2.Text);//присваиваем значение из текст бокса
                chisla.Third = Convert.ToInt32(Ch3.Text);//присваиваем значение из текст бокса
                param.SetParams(chisla.One, chisla.Second, chisla.Third,out string rez1);//используем функцию
                Plus10.Text = rez1;//записывем результат вычислений в текст бокс

            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }

        }
    }
}
