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
using Shop_Patrusheva.Classes;

namespace Shop_Patrusheva.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(object item)
        {
            InitializeComponent();

            Classes.Shop ShopData = item as Shop; // преобразовываем полученный объект в базовый класс
            // передаем значения в поля
            IName.Content = ShopData.Name;
            IPrice.Content = "Цена: " + ShopData.Price;

            // проверяем можем ли преобразовать в десткие товары
            if (item is Children)
            {
                Children ChildrenData  = item as Children; // преобразовываем в детскеи товары
                ICharackteristic.Content = "Возраст: " + ChildrenData.Age;
            }

            // проверяем можем ли преобразовать в спортивные товары
            else if (item is Sport)
            {
                Sport SportData = item as Sport;
                ICharackteristic.Content = "Рзмер: " + SportData.Size;
            }

        }
    }
}
