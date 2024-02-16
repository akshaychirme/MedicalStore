using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStore
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine() {TopLevel = false, TopMost = true};
            addMedicine.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(addMedicine);
            addMedicine.Show();
        }

        //Company--------------------------------------------------------
        private void addCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddCompany addCompany = new AddCompany() { TopLevel = false, TopMost = true };
            addCompany.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(addCompany);
            addCompany.Show();
        }

        private void removeCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCompany removeCompany = new RemoveCompany() { TopLevel = false, TopMost = true };
            removeCompany.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(removeCompany);
            removeCompany.Show();
        }
    }
}
