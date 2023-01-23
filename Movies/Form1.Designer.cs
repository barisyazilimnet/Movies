namespace Movies
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgwMovies = new System.Windows.Forms.DataGridView();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.tbxType2Search = new System.Windows.Forms.TextBox();
            this.tbxType2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTypeSearch = new System.Windows.Forms.ComboBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.chkbxIsDownloadedSerach = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxNameSearch = new System.Windows.Forms.TextBox();
            this.chkbxIsDownloaded = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.tbxLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbMoviesDataSet = new Movies.DbMoviesDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new Movies.DbMoviesDataSetTableAdapters.MoviesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbMoviesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMovies
            // 
            this.dgwMovies.AllowUserToAddRows = false;
            this.dgwMovies.AllowUserToDeleteRows = false;
            this.dgwMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwMovies.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMovies.Location = new System.Drawing.Point(0, 149);
            this.dgwMovies.MinimumSize = new System.Drawing.Size(850, 310);
            this.dgwMovies.Name = "dgwMovies";
            this.dgwMovies.ReadOnly = true;
            this.dgwMovies.Size = new System.Drawing.Size(1902, 843);
            this.dgwMovies.TabIndex = 14;
            this.dgwMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMovies_CellClick);
            this.dgwMovies.Sorted += new System.EventHandler(this.Form1_Load);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(40, 17);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(500, 20);
            this.tbxName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxTotal);
            this.groupBox1.Controls.Add(this.tbxType2Search);
            this.groupBox1.Controls.Add(this.tbxType2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxTypeSearch);
            this.groupBox1.Controls.Add(this.btnGetAll);
            this.groupBox1.Controls.Add(this.chkbxIsDownloadedSerach);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.tbxNameSearch);
            this.groupBox1.Controls.Add(this.chkbxIsDownloaded);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.tbxLink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(851, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1902, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİLER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1067, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "TOPLAM";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(1124, 17);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(88, 20);
            this.tbxTotal.TabIndex = 22;
            // 
            // tbxType2Search
            // 
            this.tbxType2Search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxType2Search.Location = new System.Drawing.Point(757, 106);
            this.tbxType2Search.Name = "tbxType2Search";
            this.tbxType2Search.Size = new System.Drawing.Size(426, 20);
            this.tbxType2Search.TabIndex = 13;
            this.tbxType2Search.TextChanged += new System.EventHandler(this.tbxType2Search_TextChanged);
            // 
            // tbxType2
            // 
            this.tbxType2.Location = new System.Drawing.Point(595, 47);
            this.tbxType2.Name = "tbxType2";
            this.tbxType2.Size = new System.Drawing.Size(500, 20);
            this.tbxType2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "TÜRÜ 2";
            // 
            // cbxTypeSearch
            // 
            this.cbxTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeSearch.FormattingEnabled = true;
            this.cbxTypeSearch.Items.AddRange(new object[] {
            "LÜTFEN SEÇİNİZ",
            "TÜRK FİLM",
            "TÜRK DİZİ",
            "YABANCI FİLM",
            "YABANCI DİZİ"});
            this.cbxTypeSearch.Location = new System.Drawing.Point(537, 104);
            this.cbxTypeSearch.Name = "cbxTypeSearch";
            this.cbxTypeSearch.Size = new System.Drawing.Size(215, 21);
            this.cbxTypeSearch.TabIndex = 12;
            this.cbxTypeSearch.SelectedIndexChanged += new System.EventHandler(this.cbxTypeSearch_SelectedIndexChanged);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(978, 71);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(215, 21);
            this.btnGetAll.TabIndex = 9;
            this.btnGetAll.Text = "Tümü";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // chkbxIsDownloadedSerach
            // 
            this.chkbxIsDownloadedSerach.AutoSize = true;
            this.chkbxIsDownloadedSerach.Location = new System.Drawing.Point(10, 106);
            this.chkbxIsDownloadedSerach.Name = "chkbxIsDownloadedSerach";
            this.chkbxIsDownloadedSerach.Size = new System.Drawing.Size(98, 17);
            this.chkbxIsDownloadedSerach.TabIndex = 10;
            this.chkbxIsDownloadedSerach.Text = "İndirme durumu";
            this.chkbxIsDownloadedSerach.UseVisualStyleBackColor = true;
            this.chkbxIsDownloadedSerach.CheckedChanged += new System.EventHandler(this.chkbxIsDownloadedSerach_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(757, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(215, 25);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Kutuları Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxNameSearch
            // 
            this.tbxNameSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxNameSearch.Location = new System.Drawing.Point(105, 104);
            this.tbxNameSearch.Name = "tbxNameSearch";
            this.tbxNameSearch.Size = new System.Drawing.Size(426, 20);
            this.tbxNameSearch.TabIndex = 11;
            this.tbxNameSearch.TextChanged += new System.EventHandler(this.tbxNameSearch_TextChanged);
            // 
            // chkbxIsDownloaded
            // 
            this.chkbxIsDownloaded.AutoSize = true;
            this.chkbxIsDownloaded.Location = new System.Drawing.Point(10, 80);
            this.chkbxIsDownloaded.Name = "chkbxIsDownloaded";
            this.chkbxIsDownloaded.Size = new System.Drawing.Size(80, 17);
            this.chkbxIsDownloaded.TabIndex = 4;
            this.chkbxIsDownloaded.Text = "İndirildi mi ?";
            this.chkbxIsDownloaded.UseVisualStyleBackColor = true;
            this.chkbxIsDownloaded.CheckedChanged += new System.EventHandler(this.chkbxIsDownloaded_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(537, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(321, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(210, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "LÜTFEN SEÇİNİZ",
            "TÜRK FİLM",
            "TÜRK DİZİ",
            "YABANCI FİLM",
            "YABANCI DİZİ"});
            this.cbxType.Location = new System.Drawing.Point(595, 17);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(377, 21);
            this.cbxType.TabIndex = 1;
            // 
            // tbxLink
            // 
            this.tbxLink.Location = new System.Drawing.Point(40, 45);
            this.tbxLink.Name = "tbxLink";
            this.tbxLink.Size = new System.Drawing.Size(500, 20);
            this.tbxLink.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TÜRÜ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LİNK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADI";
            // 
            // dbMoviesDataSet
            // 
            this.dbMoviesDataSet.DataSetName = "DbMoviesDataSet";
            this.dbMoviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.dbMoviesDataSet;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 991);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwMovies);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbMoviesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMovies;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkbxIsDownloaded;
        private System.Windows.Forms.TextBox tbxNameSearch;
        private System.Windows.Forms.Button btnClear;
        private DbMoviesDataSet dbMoviesDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private DbMoviesDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.CheckBox chkbxIsDownloadedSerach;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.ComboBox cbxTypeSearch;
        private System.Windows.Forms.TextBox tbxType2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLink;
        private System.Windows.Forms.TextBox tbxType2Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTotal;
    }
}

