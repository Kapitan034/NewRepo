using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProgaProect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();         
            List<string> Types = new List<string>();
            Types.Add("Single");
            Types.Add("Double");
            Types.Add("Lux");
            TypeCB.DataSource = Types;
            var context = new Context();
            context.Clients.Add(new Client { Name = "Кадгар", Surname = "Великий", Otchestvo = "Архимаг", BirthDate = DateTime.Parse("1777, 7, 7"), PasportNumber = 777777777, ArrivalTime = DateTime.Parse("2014, 7, 7"), Room = new Room { Number = 25, Type = "Single", Zanat = true } });
            context.Clients.Add(new Client { Name = "Иван", Surname = "Иванов", Otchestvo = "Иванович", BirthDate = DateTime.Parse("1934, 5, 29"), PasportNumber = 125436785, ArrivalTime = DateTime.Parse("2014, 8, 12"), Room = new Room { Number = 5, Type = "Double", Zanat = true } });
            context.Clients.Add(new Client { Name = "Олег", Surname = "Гаврилов", Otchestvo = "Андреевич", BirthDate = DateTime.Parse("1986, 6, 20"), PasportNumber = 125696333, ArrivalTime = DateTime.Parse("2014, 6, 13"), Room = new Room { Number = 13, Type = "Double", Zanat = true } });
            context.Clients.Add(new Client { Name = "Ирина", Surname = "Кайзер", Otchestvo = "Генадиевна", BirthDate = DateTime.Parse("1995, 11, 15"), PasportNumber = 158856452, ArrivalTime = DateTime.Parse("2014, 9, 14"), Room = new Room { Number = 17, Type = "Single", Zanat = true } });
            context.Clients.Add(new Client { Name = "Илья", Surname = "Репин", Otchestvo = "Олегович", BirthDate = DateTime.Parse("1956, 1, 11"), PasportNumber = 120042325, ArrivalTime = DateTime.Parse("2014, 3, 15"), Room = new Room { Number = 65, Type = "Single", Zanat = true } });
            context.Clients.Add(new Client { Name = "Василий", Surname = "Карамазов", Otchestvo = "Александорович", BirthDate = DateTime.Parse("1941, 10, 12"), PasportNumber = 155225225, ArrivalTime = DateTime.Parse("2014, 10, 16"), Room = new Room { Number = 32, Type = "Lux", Zanat = true } });            
            context.SaveChanges();

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            AddForm addfrm = new AddForm();
            addfrm.ShowDialog();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm();
            delete.ShowDialog();
        }

        private void ChangeBTN_Click(object sender, EventArgs e)
        {
            ChangeForm changefrm = new ChangeForm();
            changefrm.ShowDialog();
        }
    }
}
