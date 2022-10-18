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
    public partial class AlbumForm : Form
    {
        Album album = null;
        public AlbumForm()
        {
            InitializeComponent();
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {
            FillForm();
        }
        
        private void FillForm()
        {
            GetAlbum();
        }

        private void GetAlbum()
        {
            using (PlakDbContext DB = new PlakDbContext())
            {
                int albumId = Convert.ToInt32(this.Tag);


                if (albumId != 0)
                {

                    album = DB.Albums.FirstOrDefault(t0 => t0.ProductId == albumId);
                    txtAlbumName.Text = album.AlbumName;
                    txtProductCode.Text = album.ProductCode;
                    numCriticalAlert.Value = Convert.ToInt32(album.CriticalLevel);
                    numDİscount.Value = Convert.ToDecimal(album.Discount);
                    numPrice.Value = Convert.ToDecimal(album.Price);
                    numUnitsInStock.Value = Convert.ToInt32(album.UnitsInStock);
                    if (album.Discontinued == true)
                    {

                    }
                    else
                    {
                        chkDiscontinued.Checked = true;
                    }
                    GetCategory(comboBox1);
                    GetArtist(cmbArtist);
                }

            }
        }

        private void GetCategory(ComboBox combo)
        {
            using (PlakDbContext DB = new PlakDbContext())
            {
                var result = DB.Categories.Select(t0 => new { Value = t0.CategoryId, Text = t0.CategoryName }).ToList();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                combo.DataSource = result;
            }
            
        }

        private void GetArtist(ComboBox combo)
        {
            using (PlakDbContext DB = new PlakDbContext())
            {
                var result = DB.Artists.Select(t0=> new {Value = t0.ArtistId, Text = t0.ArtistName}).ToList();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                combo.DataSource = result;
            }
        }

        private void SaveForm(ref Album album)
        {
            using (PlakDbContext DB = new PlakDbContext())
            {
                int albumId = Convert.ToInt32(this.Tag);

                if (albumId != 0)
                {

                }
                else
                {
                    album = new Album();
                    DB.Albums.Add(album);

                }
                SaveData(album);
               
                DB.SaveChanges();

            }
        }

        private void SaveData(Album album)
        {
            album.ArtistId = Convert.ToInt32(cmbArtist.SelectedValue);
            album.AlbumName = txtAlbumName.Text;
            if (chkDiscontinued.Checked)
            {
                album.Discontinued = true;
            }
            else
            {
                album.Discontinued = false;

            }
            album.UnitsInStock = Convert.ToInt32(numUnitsInStock.Value);
            album.Discount = Convert.ToSingle(numDİscount.Value);
            album.CategoryId = Convert.ToInt32(comboBox1.SelectedValue);
            album.CriticalLevel = Convert.ToInt32(numCriticalAlert.Value);
            album.ModifiedDate = DateTime.Now;
            album.RecordDate = DateTime.Now;
            album.ReleaseDate = dtReleaseDate.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveForm(ref album);
            this.Close();

        }
    }
}
