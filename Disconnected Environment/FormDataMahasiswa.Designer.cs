
namespace Disconnected_Environment
{
    partial class formDataMahasiswa
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
            System.Windows.Forms.Label nimLabel;
            System.Windows.Forms.Label nama_mahasiswaLabel;
            System.Windows.Forms.Label jenis_kelLabel;
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label tgl_lahirLabel;
            System.Windows.Forms.Label id_prodiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDataMahasiswa));
            this.mahasiswaDataSet1 = new Disconnected_Environment.MahasiswaDataSet();
            this.mahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter1 = new Disconnected_Environment.MahasiswaDataSetTableAdapters.MahasiswaTableAdapter();
            this.tableAdapterManager1 = new Disconnected_Environment.MahasiswaDataSetTableAdapters.TableAdapterManager();
            this.bnMahasiswa = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mahasiswaBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cbxJenisKelamin = new System.Windows.Forms.ComboBox();
            this.dtTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.cbxProdi = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            nimLabel = new System.Windows.Forms.Label();
            nama_mahasiswaLabel = new System.Windows.Forms.Label();
            jenis_kelLabel = new System.Windows.Forms.Label();
            alamatLabel = new System.Windows.Forms.Label();
            tgl_lahirLabel = new System.Windows.Forms.Label();
            id_prodiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMahasiswa)).BeginInit();
            this.bnMahasiswa.SuspendLayout();
            this.SuspendLayout();
            // 
            // nimLabel
            // 
            nimLabel.AutoSize = true;
            nimLabel.Location = new System.Drawing.Point(232, 81);
            nimLabel.Name = "nimLabel";
            nimLabel.Size = new System.Drawing.Size(25, 13);
            nimLabel.TabIndex = 1;
            nimLabel.Text = "Nim";
            // 
            // nama_mahasiswaLabel
            // 
            nama_mahasiswaLabel.AutoSize = true;
            nama_mahasiswaLabel.Location = new System.Drawing.Point(232, 107);
            nama_mahasiswaLabel.Name = "nama_mahasiswaLabel";
            nama_mahasiswaLabel.Size = new System.Drawing.Size(35, 13);
            nama_mahasiswaLabel.TabIndex = 3;
            nama_mahasiswaLabel.Text = "Nama";
            // 
            // jenis_kelLabel
            // 
            jenis_kelLabel.AutoSize = true;
            jenis_kelLabel.Location = new System.Drawing.Point(232, 133);
            jenis_kelLabel.Name = "jenis_kelLabel";
            jenis_kelLabel.Size = new System.Drawing.Size(71, 13);
            jenis_kelLabel.TabIndex = 5;
            jenis_kelLabel.Text = "Jenis Kelamin";
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(232, 160);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(39, 13);
            alamatLabel.TabIndex = 7;
            alamatLabel.Text = "Alamat";
            // 
            // tgl_lahirLabel
            // 
            tgl_lahirLabel.AutoSize = true;
            tgl_lahirLabel.Location = new System.Drawing.Point(232, 187);
            tgl_lahirLabel.Name = "tgl_lahirLabel";
            tgl_lahirLabel.Size = new System.Drawing.Size(68, 13);
            tgl_lahirLabel.TabIndex = 9;
            tgl_lahirLabel.Text = "Tanggal lahir";
            // 
            // id_prodiLabel
            // 
            id_prodiLabel.AutoSize = true;
            id_prodiLabel.Location = new System.Drawing.Point(232, 212);
            id_prodiLabel.Name = "id_prodiLabel";
            id_prodiLabel.Size = new System.Drawing.Size(31, 13);
            id_prodiLabel.TabIndex = 11;
            id_prodiLabel.Text = "Prodi";
            // 
            // mahasiswaDataSet1
            // 
            this.mahasiswaDataSet1.DataSetName = "MahasiswaDataSet";
            this.mahasiswaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource1
            // 
            this.mahasiswaBindingSource1.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource1.DataSource = this.mahasiswaDataSet1;
            // 
            // mahasiswaTableAdapter1
            // 
            this.mahasiswaTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MahasiswaTableAdapter = this.mahasiswaTableAdapter1;
            this.tableAdapterManager1.ProdiTableAdapter = null;
            this.tableAdapterManager1.status_mahasiswaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Disconnected_Environment.MahasiswaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bnMahasiswa
            // 
            this.bnMahasiswa.AddNewItem = this.toolStripButton5;
            this.bnMahasiswa.BindingSource = this.mahasiswaBindingSource1;
            this.bnMahasiswa.CountItem = this.toolStripLabel1;
            this.bnMahasiswa.DeleteItem = this.toolStripButton6;
            this.bnMahasiswa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.mahasiswaBindingSource1BindingNavigatorSaveItem});
            this.bnMahasiswa.Location = new System.Drawing.Point(0, 0);
            this.bnMahasiswa.MoveFirstItem = this.toolStripButton1;
            this.bnMahasiswa.MoveLastItem = this.toolStripButton4;
            this.bnMahasiswa.MoveNextItem = this.toolStripButton3;
            this.bnMahasiswa.MovePreviousItem = this.toolStripButton2;
            this.bnMahasiswa.Name = "bnMahasiswa";
            this.bnMahasiswa.PositionItem = this.toolStripTextBox1;
            this.bnMahasiswa.Size = new System.Drawing.Size(798, 25);
            this.bnMahasiswa.TabIndex = 0;
            this.bnMahasiswa.Text = "bindingNavigator2";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mahasiswaBindingSource1BindingNavigatorSaveItem
            // 
            this.mahasiswaBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mahasiswaBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mahasiswaBindingSource1BindingNavigatorSaveItem.Image")));
            this.mahasiswaBindingSource1BindingNavigatorSaveItem.Name = "mahasiswaBindingSource1BindingNavigatorSaveItem";
            this.mahasiswaBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mahasiswaBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.mahasiswaBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.mahasiswaBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // txtNIM
            // 
            this.txtNIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "nim", true));
            this.txtNIM.Location = new System.Drawing.Point(329, 78);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(283, 20);
            this.txtNIM.TabIndex = 2;
            // 
            // txtNama
            // 
            this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "nama_mahasiswa", true));
            this.txtNama.Location = new System.Drawing.Point(329, 104);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(283, 20);
            this.txtNama.TabIndex = 4;
            // 
            // cbxJenisKelamin
            // 
            this.cbxJenisKelamin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "jenis_kel", true));
            this.cbxJenisKelamin.FormattingEnabled = true;
            this.cbxJenisKelamin.Location = new System.Drawing.Point(329, 130);
            this.cbxJenisKelamin.Name = "cbxJenisKelamin";
            this.cbxJenisKelamin.Size = new System.Drawing.Size(283, 21);
            this.cbxJenisKelamin.TabIndex = 6;
            // 
            // dtTanggalLahir
            // 
            this.dtTanggalLahir.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mahasiswaBindingSource1, "tgl_lahir", true));
            this.dtTanggalLahir.Location = new System.Drawing.Point(329, 183);
            this.dtTanggalLahir.Name = "dtTanggalLahir";
            this.dtTanggalLahir.Size = new System.Drawing.Size(283, 20);
            this.dtTanggalLahir.TabIndex = 10;
            // 
            // cbxProdi
            // 
            this.cbxProdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "id_prodi", true));
            this.cbxProdi.FormattingEnabled = true;
            this.cbxProdi.Location = new System.Drawing.Point(329, 209);
            this.cbxProdi.Name = "cbxProdi";
            this.cbxProdi.Size = new System.Drawing.Size(283, 21);
            this.cbxProdi.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(391, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(537, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(329, 157);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(283, 20);
            this.txtAlamat.TabIndex = 16;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 43);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formDataMahasiswa
            // 
            this.ClientSize = new System.Drawing.Size(798, 444);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(nimLabel);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(nama_mahasiswaLabel);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(jenis_kelLabel);
            this.Controls.Add(this.cbxJenisKelamin);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(tgl_lahirLabel);
            this.Controls.Add(this.dtTanggalLahir);
            this.Controls.Add(id_prodiLabel);
            this.Controls.Add(this.cbxProdi);
            this.Controls.Add(this.bnMahasiswa);
            this.Name = "formDataMahasiswa";
            this.Load += new System.EventHandler(this.formDataMahasiswa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMahasiswa)).EndInit();
            this.bnMahasiswa.ResumeLayout(false);
            this.bnMahasiswa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private MahasiswaDataSet mahasiswaDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private MahasiswaDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private MahasiswaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MahasiswaDataSet mahasiswaDataSet1;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource1;
        private MahasiswaDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter1;
        private MahasiswaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator bnMahasiswa;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton mahasiswaBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cbxJenisKelamin;
        private System.Windows.Forms.DateTimePicker dtTanggalLahir;
        private System.Windows.Forms.ComboBox cbxProdi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnBack;
    }
}