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
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            List<string> Types = new List<string>();
            Types.Add("Single");
            Types.Add("Double");
            Types.Add("Lux");
            ChangeTypeCB.DataSource = Types;
        }
    }
}
