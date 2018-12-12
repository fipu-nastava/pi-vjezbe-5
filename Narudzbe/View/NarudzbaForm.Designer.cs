namespace Narucivanje
{
    partial class NarudzbaForm
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
            this.dgNarudzba = new System.Windows.Forms.DataGridView();
            this.bsNarudzba = new System.Windows.Forms.BindingSource(this.components);
            this.dgStavka = new System.Windows.Forms.DataGridView();
            this.narudzbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datumDostaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakljucenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.narudzbaStavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblStavke = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNarudzba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPresenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNarudzba
            // 
            this.dgNarudzba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgNarudzba.AutoGenerateColumns = false;
            this.dgNarudzba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNarudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNarudzba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDostaveDataGridViewTextBoxColumn,
            this.brojDokumentaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.zakljucenDataGridViewCheckBoxColumn});
            this.dgNarudzba.DataSource = this.narudzbaBindingSource;
            this.dgNarudzba.Location = new System.Drawing.Point(12, 12);
            this.dgNarudzba.Name = "dgNarudzba";
            this.dgNarudzba.Size = new System.Drawing.Size(519, 292);
            this.dgNarudzba.TabIndex = 0;
            this.dgNarudzba.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNarudzba_RowEnter);
            // 
            // dgStavka
            // 
            this.dgStavka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStavka.AutoGenerateColumns = false;
            this.dgStavka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStavka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dgStavka.DataSource = this.stavkaPresenterBindingSource;
            this.dgStavka.Location = new System.Drawing.Point(12, 352);
            this.dgStavka.Name = "dgStavka";
            this.dgStavka.Size = new System.Drawing.Size(519, 239);
            this.dgStavka.TabIndex = 1;
            // 
            // narudzbaBindingSource
            // 
            this.narudzbaBindingSource.DataSource = typeof(NarucivanjeModel.Narudzba);
            // 
            // datumDostaveDataGridViewTextBoxColumn
            // 
            this.datumDostaveDataGridViewTextBoxColumn.DataPropertyName = "DatumDostave";
            this.datumDostaveDataGridViewTextBoxColumn.HeaderText = "DatumDostave";
            this.datumDostaveDataGridViewTextBoxColumn.Name = "datumDostaveDataGridViewTextBoxColumn";
            // 
            // brojDokumentaDataGridViewTextBoxColumn
            // 
            this.brojDokumentaDataGridViewTextBoxColumn.DataPropertyName = "BrojDokumenta";
            this.brojDokumentaDataGridViewTextBoxColumn.HeaderText = "BrojDokumenta";
            this.brojDokumentaDataGridViewTextBoxColumn.Name = "brojDokumentaDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // zakljucenDataGridViewCheckBoxColumn
            // 
            this.zakljucenDataGridViewCheckBoxColumn.DataPropertyName = "Zakljucen";
            this.zakljucenDataGridViewCheckBoxColumn.HeaderText = "Zakljucen";
            this.zakljucenDataGridViewCheckBoxColumn.Name = "zakljucenDataGridViewCheckBoxColumn";
            // 
            // narudzbaStavkaBindingSource
            // 
            this.narudzbaStavkaBindingSource.DataSource = typeof(NarucivanjeModel.NarudzbaStavka);
            // 
            // stavkaPresenterBindingSource
            // 
            this.stavkaPresenterBindingSource.DataSource = typeof(Narudzbe.Presenter.StavkaPresenter);
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum narudžbe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj stavaka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(153, 310);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 13);
            this.lblDatum.TabIndex = 5;
            // 
            // lblStavke
            // 
            this.lblStavke.AutoSize = true;
            this.lblStavke.Location = new System.Drawing.Point(153, 336);
            this.lblStavke.Name = "lblStavke";
            this.lblStavke.Size = new System.Drawing.Size(13, 13);
            this.lblStavke.TabIndex = 6;
            this.lblStavke.Text = "0";
            // 
            // NarudzbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 603);
            this.Controls.Add(this.lblStavke);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgStavka);
            this.Controls.Add(this.dgNarudzba);
            this.Name = "NarudzbaForm";
            this.Text = "Naručivanje v0.1";
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNarudzba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPresenterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNarudzba;
        private System.Windows.Forms.DataGridView dgStavka;
        private System.Windows.Forms.BindingSource bsNarudzba;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDostaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn zakljucenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource narudzbaBindingSource;
        private System.Windows.Forms.BindingSource narudzbaStavkaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stavkaPresenterBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblStavke;
    }
}

