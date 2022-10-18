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
    public partial class FormDiscountedAlbums : Form
    {
        public FormDiscountedAlbums()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ürünleri indiirm oranlarına göre çoktan aza sıralı şekilde getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDiscountedAlbums_Load(object sender, EventArgs e)
        {
            using (PlakDbContext DB = new PlakDbContext())
            {
                var result = DB.Albums.Where(t0 => t0.Discount > 0).OrderByDescending(t0=>t0.Discount).ToList();
                dataGridView1.DataSource = result;
            }
            
        }
    }
}
