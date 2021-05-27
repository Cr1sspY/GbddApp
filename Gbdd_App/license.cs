using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gbdd_App
{
    public partial class license : Form
    {
        public license()
        {
            InitializeComponent();
        }

        private void licensesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.licensesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDriverDataSet);

        }

        private void j_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDriverDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.databaseDriverDataSet.Driver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDriverDataSet.licenses". При необходимости она может быть перемещена или удалена.
            this.licensesTableAdapter.Fill(this.databaseDriverDataSet.licenses);

        }

        private void Driverbtn_Click(object sender, EventArgs e)
        {
            Driver frm = new Driver();
            frm.Show();
            this.Hide();
        }
    }
}
