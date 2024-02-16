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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        function fn = new function();
        string unQuery, pwQuery;
        string username,password;

        private void button1_Click(object sender, EventArgs e)
        {
            unQuery = $"select username from admin where username = '{textBoxUsername.Text}'";
            SqlDataReader readerU = fn.getSingleData(unQuery);
            pwQuery = $"select password from admin where username = '{textBoxUsername.Text}'";
            SqlDataReader readerP = fn.getSingleData(pwQuery);

            if (textBoxUsername.Text != "")
            {
                if (readerU.Read())
                {
                    username = readerU.GetValue(0).ToString();

                    if (textBoxPassword.Text != "")
                    {
                        readerP.Read();
                        if (readerP.GetValue(0).ToString() == textBoxPassword.Text)
                        {
                            Dashboard d = new Dashboard();
                            d.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Password.");
                    }
                }
                else
                {
                    MessageBox.Show("User Not Found");
                }
            }
            else
            {
                MessageBox.Show("Enter Username");
            }
        }
    }
}
