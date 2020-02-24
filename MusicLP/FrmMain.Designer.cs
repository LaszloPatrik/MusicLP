namespace MusicLP
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Albu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbAlbumDatas = new System.Windows.Forms.RichTextBox();
            this.btnDisco = new System.Windows.Forms.Button();
            this.btnUrl = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lLink = new System.Windows.Forms.LinkLabel();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(159, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search in track\'s title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(339, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "URL (if any):";
            // 
            // cbArtist
            // 
            this.cbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(12, 43);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(121, 21);
            this.cbArtist.TabIndex = 4;
            this.cbArtist.SelectedIndexChanged += new System.EventHandler(this.CbArtist_SelectedIndexChanged);
            // 
            // cbAlbum
            // 
            this.cbAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlbum.Enabled = false;
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(163, 43);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(121, 21);
            this.cbAlbum.TabIndex = 5;
            this.cbAlbum.SelectedIndexChanged += new System.EventHandler(this.CbAlbum_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Enabled = false;
            this.tbSearch.Location = new System.Drawing.Point(12, 95);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(272, 20);
            this.tbSearch.TabIndex = 6;
            // 
            // dgvTracks
            // 
            this.dgvTracks.AllowUserToAddRows = false;
            this.dgvTracks.AllowUserToDeleteRows = false;
            this.dgvTracks.AllowUserToResizeColumns = false;
            this.dgvTracks.AllowUserToResizeRows = false;
            this.dgvTracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Length,
            this.URL,
            this.Albu,
            this.Idd});
            this.dgvTracks.Location = new System.Drawing.Point(12, 133);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.RowHeadersVisible = false;
            this.dgvTracks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTracks.Size = new System.Drawing.Size(272, 305);
            this.dgvTracks.TabIndex = 7;
            this.dgvTracks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTracks_CellClick);
            // 
            // Title
            // 
            this.Title.FillWeight = 20F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Length
            // 
            this.Length.FillWeight = 10F;
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Visible = false;
            // 
            // Albu
            // 
            this.Albu.HeaderText = "Album";
            this.Albu.Name = "Albu";
            this.Albu.Visible = false;
            // 
            // Idd
            // 
            this.Idd.HeaderText = "Id";
            this.Idd.Name = "Idd";
            this.Idd.Visible = false;
            // 
            // rtbAlbumDatas
            // 
            this.rtbAlbumDatas.Enabled = false;
            this.rtbAlbumDatas.Location = new System.Drawing.Point(420, 133);
            this.rtbAlbumDatas.Name = "rtbAlbumDatas";
            this.rtbAlbumDatas.Size = new System.Drawing.Size(206, 96);
            this.rtbAlbumDatas.TabIndex = 9;
            this.rtbAlbumDatas.Text = "";
            // 
            // btnDisco
            // 
            this.btnDisco.Location = new System.Drawing.Point(314, 379);
            this.btnDisco.Name = "btnDisco";
            this.btnDisco.Size = new System.Drawing.Size(100, 59);
            this.btnDisco.TabIndex = 10;
            this.btnDisco.Text = "Add Discography";
            this.btnDisco.UseVisualStyleBackColor = true;
            this.btnDisco.Click += new System.EventHandler(this.BtnDisco_Click);
            // 
            // btnUrl
            // 
            this.btnUrl.Enabled = false;
            this.btnUrl.Location = new System.Drawing.Point(420, 379);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(100, 59);
            this.btnUrl.TabIndex = 11;
            this.btnUrl.Text = "Add URL";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.BtnUrl_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(526, 379);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 59);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lLink
            // 
            this.lLink.AutoSize = true;
            this.lLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLink.Location = new System.Drawing.Point(352, 310);
            this.lLink.Name = "lLink";
            this.lLink.Size = new System.Drawing.Size(46, 16);
            this.lLink.TabIndex = 13;
            this.lLink.TabStop = true;
            this.lLink.Text = "NOPE";
            this.lLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLink_LinkClicked);
            // 
            // pbAlbum
            // 
            this.pbAlbum.Location = new System.Drawing.Point(314, 133);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(100, 100);
            this.pbAlbum.TabIndex = 8;
            this.pbAlbum.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.lLink);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUrl);
            this.Controls.Add(this.btnDisco);
            this.Controls.Add(this.rtbAlbumDatas);
            this.Controls.Add(this.pbAlbum);
            this.Controls.Add(this.dgvTracks);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.cbArtist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Discography Tracker";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.RichTextBox rtbAlbumDatas;
        private System.Windows.Forms.Button btnDisco;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.LinkLabel lLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Albu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idd;
    }
}

