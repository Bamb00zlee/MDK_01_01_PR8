using Shop_Patrusheva.Classes;
using Shop_Patrusheva.Elements;
using System.Collections.Generic;
using System.Windows;

namespace Shop_Patrusheva
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // полчение данных из репазитория
        List<object> AllItems = RepoItems.AllItems();
        public MainWindow()
        {
            InitializeComponent();
            CreateUI();
        }

        // пребеор документов и добавление в UI
        public void CreateUI()
        {
            foreach (object item in AllItems)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }

        private void Cerch_click(object sender, RoutedEventArgs e)
        {
            string serch_string = For_serch.Text.ToLower();
            parent.Children.Clear();

            foreach (object obj in RepoItems.AllItems())   // или твой AllItems
            {
                if (!(obj is Shop shop)) continue;

                // берем характеристики из базового класса
                string all = $"{shop.Name} {shop.Price}".ToLower();

                // добавляем характеристики из дочернего класса
                if (shop is Sport s)
                    all += $" {s.Size}".ToLower();
                else if (shop is Electronika el)
                    all += $" {el.BatteryCapacity} {el.DrivingSpeed}".ToLower();
                else if (shop is Children c)
                    all += $" {c.Age}".ToLower();

                // содержит ли искомый элемент
                if (all.Contains(serch_string))
                {
                    parent.Children.Add(new Item(shop));
                }
            }
        }
    }
}
