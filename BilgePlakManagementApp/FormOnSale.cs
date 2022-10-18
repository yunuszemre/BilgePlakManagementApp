using BilgePlakManagementApp.DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgePlakManagementApp
{
    public partial class FormOnSale : Form
    {
        public FormOnSale()
        {
            InitializeComponent();
        }
        /// <summary>
        /// satıştaki Ürünleri getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormOnSale_Load(object sender, EventArgs e)
        {
            using (PlakDbContext DB = new PlakDbContext())
            {
                var result = DB.Albums.Where(t0 => t0.Discontinued == false).ToList();
                dataGridView1.DataSource = result;
            }
        }
    }
}
