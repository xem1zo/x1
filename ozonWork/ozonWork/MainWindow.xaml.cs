using System;
using System.Collections.Generic;
using System.Windows;

namespace ozonWork
{
    // Класс товара
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

            // При запуске показываем товары
            ShowProducts();
        }

        // Кнопка выхода
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Кнопка "Товары"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowProducts();
        }

        // Кнопка "Заказы / Профиль"
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Этот раздел ещё в разработке :)",
                "Ozon пре-альфа",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        // Кнопка "Корзина"
        private void CartBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Корзина пока пуста.",
                "Корзина",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        // Кнопка "Поиск"
        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Функция поиска пока находится в разработке.",
                "Поиск",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        // Вывод товаров в таблицу
        private void ShowProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Name = "Ноутбук Lenovo",
                    Category = "Электроника",
                    Price = 45990,
                    Quantity = 3
                },

                new Product
                {
                    Name = "Кроссовки Nike",
                    Category = "Обувь",
                    Price = 6990,
                    Quantity = 12
                },

                new Product
                {
                    Name = "Чайник Xiaomi",
                    Category = "Дом",
                    Price = 2490,
                    Quantity = 20
                },

                new Product
                {
                    Name = "Книга \"C# для начинающих\"",
                    Category = "Книги",
                    Price = 890,
                    Quantity = 50
                },

                new Product
                {
                    Name = "Наушники JBL",
                    Category = "Электроника",
                    Price = 3990,
                    Quantity = 8
                }
            };

            MyTable.ItemsSource = products;
        }
    }
}