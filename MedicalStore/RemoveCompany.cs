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
    public partial class RemoveCompany : Form
    {
        public RemoveCompany()
        {
            InitializeComponent();
        }
        function fn = new function();
        string loadAllComListQ, searchComQ, deleteQ;
        private void RemoveCompany_Load(object sender, EventArgs e)
        {
            loadAllComListQ = "SELECT * FROM company";
            DataSet ds = fn.getTableData(loadAllComListQ);
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        string companyName;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                companyName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cell click event Error. ");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?"," Delete this Company !", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                deleteQ = $"DELETE FROM company WHERE company = '{companyName}'";
                fn.setData(deleteQ);
            }
            else
            {

            }
        }

        private void textBoxSearchComName_TextChanged(object sender, EventArgs e)
        {
            searchComQ = $"SELECT * FROM company WHERE companyName like '{textBoxSearchComName.Text}%'";
            DataSet ds = fn.getTableData(searchComQ);
            dataGridView1.DataSource= ds.Tables[0];
        }
    }
}
