using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Books
{
    public partial class FormProcedure : Form
    {
        public FormProcedure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count_save;
            sqlCommand1.Parameters["@d1"].Value = Convert.ToDateTime(textBox2.Text);
            sqlCommand1.Parameters["@d2"].Value = Convert.ToDateTime(textBox3.Text);
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            count_save = (int)sqlCommand1.Parameters["@c"].Value;
            textBox1.Text = Convert.ToString(count_save);

        }
    }
}
