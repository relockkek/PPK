using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp20.Models
{
    public class Curator : ISaveModel
    {
        public string FIO { get; set; }
        public string AdminGroup { get; set; }
        public string Weight { get; set; }

        public void Save()
        {
            MessageBox.Show("Обращение к бд, отправка изменений куратора, йоу");
        }
    }
}
