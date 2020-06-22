namespace Kvantorium_Project
{
    partial class FormGetOborud
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
            this.labelPostav = new System.Windows.Forms.Label();
            this.labelSotr = new System.Windows.Forms.Label();
            this.labelPriceOborud = new System.Windows.Forms.Label();
            this.labelDateVid = new System.Windows.Forms.Label();
            this.comboBoxPostav = new System.Windows.Forms.ComboBox();
            this.comboBoxSotr = new System.Windows.Forms.ComboBox();
            this.textBoxPriceOborud = new System.Windows.Forms.TextBox();
            this.textBoxDateVid = new System.Windows.Forms.TextBox();
            this.listViewGet = new System.Windows.Forms.ListView();
            this.IdPost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamepPost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdSotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamepSotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceOborud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateVid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelOborud = new System.Windows.Forms.Label();
            this.comboBoxOborud = new System.Windows.Forms.ComboBox();
            this.IdOb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameObor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPostav
            // 
            this.labelPostav.AutoSize = true;
            this.labelPostav.Location = new System.Drawing.Point(12, 21);
            this.labelPostav.Name = "labelPostav";
            this.labelPostav.Size = new System.Drawing.Size(90, 19);
            this.labelPostav.TabIndex = 0;
            this.labelPostav.Text = "Поставщик";
            // 
            // labelSotr
            // 
            this.labelSotr.AutoSize = true;
            this.labelSotr.Location = new System.Drawing.Point(12, 94);
            this.labelSotr.Name = "labelSotr";
            this.labelSotr.Size = new System.Drawing.Size(164, 19);
            this.labelSotr.TabIndex = 1;
            this.labelSotr.Text = "Принявший сотрудник";
            // 
            // labelPriceOborud
            // 
            this.labelPriceOborud.AutoSize = true;
            this.labelPriceOborud.Location = new System.Drawing.Point(12, 250);
            this.labelPriceOborud.Name = "labelPriceOborud";
            this.labelPriceOborud.Size = new System.Drawing.Size(141, 19);
            this.labelPriceOborud.TabIndex = 2;
            this.labelPriceOborud.Text = "Цена оборудования";
            // 
            // labelDateVid
            // 
            this.labelDateVid.AutoSize = true;
            this.labelDateVid.Location = new System.Drawing.Point(12, 328);
            this.labelDateVid.Name = "labelDateVid";
            this.labelDateVid.Size = new System.Drawing.Size(184, 19);
            this.labelDateVid.TabIndex = 3;
            this.labelDateVid.Text = "Дата совершения выдачи";
            // 
            // comboBoxPostav
            // 
            this.comboBoxPostav.FormattingEnabled = true;
            this.comboBoxPostav.Location = new System.Drawing.Point(16, 43);
            this.comboBoxPostav.Name = "comboBoxPostav";
            this.comboBoxPostav.Size = new System.Drawing.Size(214, 27);
            this.comboBoxPostav.TabIndex = 4;
            // 
            // comboBoxSotr
            // 
            this.comboBoxSotr.FormattingEnabled = true;
            this.comboBoxSotr.Location = new System.Drawing.Point(16, 116);
            this.comboBoxSotr.Name = "comboBoxSotr";
            this.comboBoxSotr.Size = new System.Drawing.Size(214, 27);
            this.comboBoxSotr.TabIndex = 5;
            // 
            // textBoxPriceOborud
            // 
            this.textBoxPriceOborud.Location = new System.Drawing.Point(16, 272);
            this.textBoxPriceOborud.Name = "textBoxPriceOborud";
            this.textBoxPriceOborud.Size = new System.Drawing.Size(214, 26);
            this.textBoxPriceOborud.TabIndex = 6;
            // 
            // textBoxDateVid
            // 
            this.textBoxDateVid.Location = new System.Drawing.Point(16, 350);
            this.textBoxDateVid.Name = "textBoxDateVid";
            this.textBoxDateVid.Size = new System.Drawing.Size(214, 26);
            this.textBoxDateVid.TabIndex = 7;
            // 
            // listViewGet
            // 
            this.listViewGet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdPost,
            this.NamepPost,
            this.IdSotr,
            this.NamepSotr,
            this.IdOb,
            this.NameObor,
            this.PriceOborud,
            this.DateVid});
            this.listViewGet.FullRowSelect = true;
            this.listViewGet.GridLines = true;
            this.listViewGet.HideSelection = false;
            this.listViewGet.Location = new System.Drawing.Point(257, 21);
            this.listViewGet.MultiSelect = false;
            this.listViewGet.Name = "listViewGet";
            this.listViewGet.Size = new System.Drawing.Size(1270, 361);
            this.listViewGet.TabIndex = 8;
            this.listViewGet.UseCompatibleStateImageBehavior = false;
            this.listViewGet.View = System.Windows.Forms.View.Details;
            this.listViewGet.SelectedIndexChanged += new System.EventHandler(this.listViewGet_SelectedIndexChanged);
            // 
            // IdPost
            // 
            this.IdPost.Text = "Id поставщика";
            this.IdPost.Width = 118;
            // 
            // NamepPost
            // 
            this.NamepPost.Text = "Имя и отчество поставщика";
            this.NamepPost.Width = 222;
            // 
            // IdSotr
            // 
            this.IdSotr.Text = "Id сотрудника";
            this.IdSotr.Width = 109;
            // 
            // NamepSotr
            // 
            this.NamepSotr.Text = "Имя и отчество сотрудника";
            this.NamepSotr.Width = 222;
            // 
            // PriceOborud
            // 
            this.PriceOborud.Text = "Цена оборудования";
            this.PriceOborud.Width = 152;
            // 
            // DateVid
            // 
            this.DateVid.Text = "Дата выдачи";
            this.DateVid.Width = 107;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(1331, 430);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(196, 48);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(1129, 430);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(196, 48);
            this.buttonDel.TabIndex = 26;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(927, 430);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(196, 48);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(725, 430);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(196, 48);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelOborud
            // 
            this.labelOborud.AutoSize = true;
            this.labelOborud.Location = new System.Drawing.Point(16, 169);
            this.labelOborud.Name = "labelOborud";
            this.labelOborud.Size = new System.Drawing.Size(105, 19);
            this.labelOborud.TabIndex = 28;
            this.labelOborud.Text = "Оборудование";
            // 
            // comboBoxOborud
            // 
            this.comboBoxOborud.FormattingEnabled = true;
            this.comboBoxOborud.Location = new System.Drawing.Point(16, 191);
            this.comboBoxOborud.Name = "comboBoxOborud";
            this.comboBoxOborud.Size = new System.Drawing.Size(214, 27);
            this.comboBoxOborud.TabIndex = 29;
            // 
            // IdOb
            // 
            this.IdOb.Text = "Id оборудования";
            this.IdOb.Width = 124;
            // 
            // NameObor
            // 
            this.NameObor.Text = "Наименование оборудования";
            this.NameObor.Width = 212;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kvantorium_Project.Properties.Resources.rmc_mainbanner_kvantorium_1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormGetOborud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1539, 490);
            this.Controls.Add(this.comboBoxOborud);
            this.Controls.Add(this.labelOborud);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewGet);
            this.Controls.Add(this.textBoxDateVid);
            this.Controls.Add(this.textBoxPriceOborud);
            this.Controls.Add(this.comboBoxSotr);
            this.Controls.Add(this.comboBoxPostav);
            this.Controls.Add(this.labelDateVid);
            this.Controls.Add(this.labelPriceOborud);
            this.Controls.Add(this.labelSotr);
            this.Controls.Add(this.labelPostav);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGetOborud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGetOborud";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostav;
        private System.Windows.Forms.Label labelSotr;
        private System.Windows.Forms.Label labelPriceOborud;
        private System.Windows.Forms.Label labelDateVid;
        private System.Windows.Forms.ComboBox comboBoxPostav;
        private System.Windows.Forms.ComboBox comboBoxSotr;
        private System.Windows.Forms.TextBox textBoxPriceOborud;
        private System.Windows.Forms.TextBox textBoxDateVid;
        private System.Windows.Forms.ListView listViewGet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader IdPost;
        private System.Windows.Forms.ColumnHeader NamepPost;
        private System.Windows.Forms.ColumnHeader IdSotr;
        private System.Windows.Forms.ColumnHeader NamepSotr;
        private System.Windows.Forms.ColumnHeader PriceOborud;
        private System.Windows.Forms.ColumnHeader DateVid;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader IdOb;
        private System.Windows.Forms.ColumnHeader NameObor;
        private System.Windows.Forms.Label labelOborud;
        private System.Windows.Forms.ComboBox comboBoxOborud;
    }
}