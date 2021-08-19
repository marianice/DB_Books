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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.dB_BOOKSDataSet.Purchases);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Publishing_house". При необходимости она может быть перемещена или удалена.
            this.publishing_houseTableAdapter.Fill(this.dB_BOOKSDataSet.Publishing_house);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this.dB_BOOKSDataSet.Deliveries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.dB_BOOKSDataSet.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.dB_BOOKSDataSet.Authors);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAuthors myForm2 = new FormAuthors();
            myForm2.Show();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormBooks myForm3 = new FormBooks();
            myForm3.Show();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPublish_house myForm4 = new FormPublish_house();
            myForm4.Show();

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormDeliveries myForm6 = new FormDeliveries();
            myForm6.Show();

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            FormPurchases myForm5 = new FormPurchases();
            myForm5.Show();

        }

        private void работаСПроцедурамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcedure myForm7 = new FormProcedure();
            myForm7.Show();
        }

        private void работаСТаблицамиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuthors myForm2 = new FormAuthors();
            myForm2.Show();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBooks myForm3 = new FormBooks();
            myForm3.Show();
        }

        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPublish_house myForm4 = new FormPublish_house();
            myForm4.Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPurchases myForm5 = new FormPurchases();
            myForm5.Show();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeliveries myForm6 = new FormDeliveries();
            myForm6.Show();
        }
    }
}
