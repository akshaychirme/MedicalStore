using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStore
{
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }

        function fn = new function();
        string addCompanyQ, companyList;

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Company Query
            addCompanyQ = $"INSERT INTO company (companyName, contact, location)VALUES('{textBoxComName.Text}','{textBoxContact.Text}','{textBoxComAddress.Text}')";

            //Checking Alredy Exist Query
            companyList = $"SELECT companyName from company WHERE companyName = '{textBoxComName.Text}'";
            SqlDataReader sdReader = fn.getSingleData(companyList);


            if(textBoxComName.Text != "")
            {
                if (!sdReader.Read())
                {
                    if (textBoxContact.Text != "")
                    {
                        if (textBoxComAddress.Text != "")
                        {
                            try
                            {
                                fn.setData(addCompanyQ);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Company Address.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Company Contact Number.");
                    }
                }
                else
                {
                    MessageBox.Show("Company Already Exist.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Company Name.");
            }

        }
    }
}
