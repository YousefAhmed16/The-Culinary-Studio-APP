using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace DataBase_Ass_App
{
    public partial class Student : Form
    {
        private string selectedRowId;
        private string selectedRowName;
        private string selectedRowPhone;
        private string selectedRowEmail;

        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O07NA9R;Initial Catalog=CookingWorkshopDB;Integrated Security=True;");

            con.Open();

            SqlCommand ubdateCommand = new SqlCommand("INSERT INTO STUDENT VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "')", con);
            ubdateCommand.ExecuteNonQuery();

            con.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            ShowTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O07NA9R;Initial Catalog=CookingWorkshopDB;Integrated Security=True;");

            con.Open();

            SqlCommand deleteCommand = new SqlCommand("Delete from STUDENT Where STUDENT_ID = " + selectedRowId, con);


            deleteCommand.ExecuteNonQuery();

            con.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            ShowTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O07NA9R;Initial Catalog=CookingWorkshopDB;Integrated Security=True;");

            con.Open();

            SqlCommand ubdateCommand = new SqlCommand("UPDATE STUDENT SET STUDENT_NAME = '" + textBox1.Text.ToString() + "', Phone = '" + textBox2.Text.ToString() + "', Email = '" + textBox3.Text.ToString() + "' Where STUDENT_ID = " + selectedRowId, con);
            ubdateCommand.ExecuteNonQuery();

            con.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            ShowTable();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookingWorkshopDBDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.cookingWorkshopDBDataSet.STUDENT);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowTable()
        {
            this.sTUDENTTableAdapter.Fill(this.cookingWorkshopDBDataSet.STUDENT);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedRowId = row.Cells[0].Value.ToString();
                selectedRowName = row.Cells[1].Value.ToString();
                selectedRowPhone = row.Cells[2].Value.ToString();
                selectedRowEmail = row.Cells[3].Value.ToString();
                textBox1.Text = selectedRowName;
                textBox2.Text = selectedRowPhone;
                textBox3.Text = selectedRowEmail;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void workShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workshop form = new Workshop();
            form.Show();
            this.Hide();
        }

        private void chefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chef form = new Chef();
            form.Show();
            this.Hide();
        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitchen form = new Kitchen();
            form.Show();
            this.Hide();
        }

        private void stationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Station form = new Station();
            form.Show();
            this.Hide();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier form = new Supplier();
            form.Show();
            this.Hide();

        }

        private void ingredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingredient form = new Ingredient();
            form.Show();
            this.Hide();
        }
    }
}
