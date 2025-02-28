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
using System.Windows.Shapes;
using WpfApp20.Models;

namespace WpfApp20
{
    /// <summary>
    /// Логика взаимодействия для WinEdit.xaml
    /// </summary>
    public partial class WinEdit : Window
    {
        public WinEdit(object item)
        {
            InitializeComponent();
            Content = item;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            var save = Content as ISaveModel;
            save.Save();
        }

    }
}
