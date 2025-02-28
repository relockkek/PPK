using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp20.Models;

namespace WpfApp20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private object items;
        private object item;

        public object Items { 
            get => items;
            set
            {
                items = value;
                Signal();
            }
        }

        public object Item { 
            get => item;
            set
            {
                item = value;
                Signal();
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        void Signal([CallerMemberName] string prop = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        private void GetStudentList(object sender, RoutedEventArgs e)
        {
            Items = new List<Student>()
            {
                new Student{ FIO = "Максим Петров Олегович", Group = "1125", Weight = 78.9 },
                new Student{ FIO = "Смакотин Виталий Алексеевич", Group = "1125", Weight = 82 },
            };
        }

        private void GetGroupList(object sender, RoutedEventArgs e)
        {
            Items = new List<Groups>()
            {
                new Groups{ Name = "Программисты", Cource="2", NumOfStud=35},
                new Groups{ Name = "Логисты", Cource="1", NumOfStud=52},
            };
        }
        private void GetCuratorList(object sender, RoutedEventArgs e)
        {
            Items = new List<Curator>()
            {
                new Curator{FIO = "Довгань Сергей Витальевич", AdminGroup="1115, 1125", Weight="Имеет"},
            };
        }

        private void EditItem(object sender, RoutedEventArgs e)
        {
            if (Item != null)
                new WinEdit(Item).ShowDialog();

        }
    }
}