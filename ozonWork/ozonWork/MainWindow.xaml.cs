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



namespace ozonWork
{
    // Простой класс "Товар" — описывает одну строку таблицы товаров.
    // Обычные публичные свойства, чтобы DataGrid мог сам построить колонки.
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // При открытии окна сразу показываем список товаров
            ShowProducts();
        }

        // Метод, который срабатывает при нажатии на кнопку Exit
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            // Закрывает текущее окно
            this.Close();
        }

        // Кнопка "Товары" — показывает список товаров в таблице
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowProducts();
        }

        // Кнопка "Заказы"/"Профиль" — пока просто заглушка
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Этот раздел ещё в разработке :)", "Ozon пре-альфа");
        }

        // Простейший метод — создаёт список товаров и выводит его в таблицу
        private void ShowProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Ноутбук Lenovo",   Category = "Электроника", Price = 45990, Quantity = 3 },
                new Product { Name = "Кроссовки Nike",    Category = "Обувь",       Price = 6990,  Quantity = 12 },
                new Product { Name = "Чайник Xiaomi",     Category = "Дом",         Price = 2490,  Quantity = 20 },
                new Product { Name = "Книга \"C# для начинающих\"", Category = "Книги", Price = 890, Quantity = 50 },
                new Product { Name = "Наушники JBL",      Category = "Электроника", Price = 3990,  Quantity = 8 },
            };

            // ItemsSource — источник данных для таблицы (DataGrid сам построит колонки)
            MyTable.ItemsSource = products;
        }
    }
}
