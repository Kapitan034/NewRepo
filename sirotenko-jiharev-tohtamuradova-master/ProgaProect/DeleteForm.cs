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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteItemBTN_Click(object sender, EventArgs e)
        {
            var context = new Context();
            //context = DeleteDataTable.SelectedRows;

        }
    }
}
//заработай наконец