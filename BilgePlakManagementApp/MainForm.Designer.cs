namespace BilgePlakManagementApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.albumMenubtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addAlbumMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.albumListMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.continuedAlbumsMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.discontinuedAlbumsMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.discounteAlbumsMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.artistMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.artistListMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addArtistMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumMenubtn,
            this.artistMenuBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // albumMenubtn
            // 
            this.albumMenubtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAlbumMenuBtn,
            this.albumListMenuBtn,
            this.continuedAlbumsMenuBtn,
            this.discontinuedAlbumsMenuBtn,
            this.discounteAlbumsMenuBtn});
            this.albumMenubtn.Name = "albumMenubtn";
            this.albumMenubtn.Size = new System.Drawing.Size(102, 20);
            this.albumMenubtn.Text = "Albüm İşlemleri";
            // 
            // addAlbumMenuBtn
            // 
            this.addAlbumMenuBtn.Name = "addAlbumMenuBtn";
            this.addAlbumMenuBtn.Size = new System.Drawing.Size(198, 22);
            this.addAlbumMenuBtn.Text = "Albüm Ekleme";
            this.addAlbumMenuBtn.Click += new System.EventHandler(this.addAlbumMenuBtn_Click);
            // 
            // albumListMenuBtn
            // 
            this.albumListMenuBtn.Name = "albumListMenuBtn";
            this.albumListMenuBtn.Size = new System.Drawing.Size(198, 22);
            this.albumListMenuBtn.Text = "Albüm Listesi";
            this.albumListMenuBtn.Click += new System.EventHandler(this.albumListMenuBtn_Click);
            // 
            // continuedAlbumsMenuBtn
            // 
            this.continuedAlbumsMenuBtn.Name = "continuedAlbumsMenuBtn";
            this.continuedAlbumsMenuBtn.Size = new System.Drawing.Size(198, 22);
            this.continuedAlbumsMenuBtn.Text = "Satıştaki Albümler";
            this.continuedAlbumsMenuBtn.Click += new System.EventHandler(this.continuedAlbumsMenuBtn_Click);
            // 
            // discontinuedAlbumsMenuBtn
            // 
            this.discontinuedAlbumsMenuBtn.Name = "discontinuedAlbumsMenuBtn";
            this.discontinuedAlbumsMenuBtn.Size = new System.Drawing.Size(198, 22);
            this.discontinuedAlbumsMenuBtn.Text = "Satışı Durmuş Albümler";
            this.discontinuedAlbumsMenuBtn.Click += new System.EventHandler(this.discontinuedAlbumsMenuBtn_Click);
            // 
            // discounteAlbumsMenuBtn
            // 
            this.discounteAlbumsMenuBtn.Name = "discounteAlbumsMenuBtn";
            this.discounteAlbumsMenuBtn.Size = new System.Drawing.Size(198, 22);
            this.discounteAlbumsMenuBtn.Text = "İndirimdeki Albümler";
            this.discounteAlbumsMenuBtn.Click += new System.EventHandler(this.discounteAlbumsMenuBtn_Click);
            // 
            // artistMenuBtn
            // 
            this.artistMenuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistListMenuBtn,
            this.addArtistMenuBtn});
            this.artistMenuBtn.Name = "artistMenuBtn";
            this.artistMenuBtn.Size = new System.Drawing.Size(135, 20);
            this.artistMenuBtn.Text = "Sanatçı/Grup İşlemleri";
            // 
            // artistListMenuBtn
            // 
            this.artistListMenuBtn.Name = "artistListMenuBtn";
            this.artistListMenuBtn.Size = new System.Drawing.Size(184, 22);
            this.artistListMenuBtn.Text = "Sanatçı/Grup Listesi";
            // 
            // addArtistMenuBtn
            // 
            this.addArtistMenuBtn.Name = "addArtistMenuBtn";
            this.addArtistMenuBtn.Size = new System.Drawing.Size(184, 22);
            this.addArtistMenuBtn.Text = "Sanatçı/Grup Ekleme";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem albumMenubtn;
        private ToolStripMenuItem addAlbumMenuBtn;
        private ToolStripMenuItem albumListMenuBtn;
        private ToolStripMenuItem continuedAlbumsMenuBtn;
        private ToolStripMenuItem discontinuedAlbumsMenuBtn;
        private ToolStripMenuItem discounteAlbumsMenuBtn;
        private ToolStripMenuItem artistMenuBtn;
        private ToolStripMenuItem artistListMenuBtn;
        private ToolStripMenuItem addArtistMenuBtn;
    }
}