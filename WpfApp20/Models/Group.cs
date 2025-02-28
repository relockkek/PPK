using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp20.Models
{
    public class Groups
    {
        public string Name { get; set; }
        public string Cource { get; set; }
        public int NumOfStud {  get; set; }
        public void Save()
        {
            MessageBox.Show("Обращение к бд, отправка изменений группы");
        }
    }
}
