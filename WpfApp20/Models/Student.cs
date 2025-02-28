using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace WpfApp20.Models
{
    public class Student : ISaveModel
    {
        public string FIO { get; set; }
        public string Group { get; set; }
        public double Weight { get; set; }

        public void Save()
        {
            MessageBox.Show("Обращение к бд, отправка изменений студента-питомца");
        }
    }
}
