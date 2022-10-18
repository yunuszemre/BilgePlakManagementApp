using BilgePlakManagementApp.DAL.Context;
using BilgePlakManagementApp.DAL.Entities;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        /// <summary>
        /// Bütün albümleri getirir
        /// </summary>
        private void GetAll()
        {
            using (PlakDbContext DB = new PlakDbContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DB.Albums.ToList();
            }
        }

        private void satıştakiPlaklarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sAatışıOlmayanPlaklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addAlbumMenuBtn_Click(object sender, EventArgs e)
        {
            var form = new AlbumForm();
            form.ShowDialog();
            GetAll();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var album = (dataGridView1.DataSource as List<Album>)[e.RowIndex];
                if (album != null)
                {
                    var form = new AlbumForm();
                    form.Tag = album.ProductId;
                    form.ShowDialog();
                    GetAll();
                }
            }
        }

        private void albumListMenuBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void continuedAlbumsMenuBtn_Click(object sender, EventArgs e)
        {
            var form = new FormOnSale();
            form.Show();
        }

        private void discontinuedAlbumsMenuBtn_Click(object sender, EventArgs e)
        {
            var form = new FormUnsale();
            form.Show();
        }

        private void discounteAlbumsMenuBtn_Click(object sender, EventArgs e)
        {
            var form = new FormDiscountedAlbums();
            form.Show();
        }
    }
}
