using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgaProect
{
    public partial class AddForm : Form
    {
        Methods methods;
        public AddForm()
        {
            InitializeComponent();
            
        }

        private void AddFrom_Load(object sender, EventArgs e)
        {
            List<string> Types = new List<string>();
            Types.Add("Single");
            Types.Add("Double");
            Types.Add("Lux");
            AddTypeCB.DataSource = Types;
        }

        private void AddExitBTN_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void AddItemBTN_Click(object sender, EventArgs e)
        {
            var context = new Context();
            context.Clients.Add(new Client { Name = AddNameTB.Text, Surname = AddSurnameTB.Text, Otchestvo = AddOtchTB.Text, BirthDate = AddBirthdateDTP.Value, PasportNumber = Convert.ToInt64(AddPaspNumberTB.Text), ArrivalTime = AddFromDTP.Value, Room = new Room { Number = Convert.ToInt32(AddRoomNumberNUM.Value), Type = AddTypeCB.Text, Zanat = true } });
            context.SaveChanges();
        }
    }
}
