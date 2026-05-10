using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Ass_App
{
    public partial class Ingredient : Form
    {
        public Ingredient()
        {
            InitializeComponent();
        }

        private void Ingredient_Load(object sender, EventArgs e)
        {

        }

        // Navigate between Forms
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student form = new Student();
            form.Show();
            this.Hide();
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

    }
}
