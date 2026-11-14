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
    }
}
