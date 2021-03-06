﻿namespace Kvantorium_Project
{
    partial class FormUchetPostav
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
            this.labelDatePostav = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelOborud = new System.Windows.Forms.Label();
            this.comboBoxPostav = new System.Windows.Forms.ComboBox();
            this.textBoxDatePostav = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxOborud = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewUchet = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Oborud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatePostav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPostav
            // 
            this.labelPostav.AutoSize = true;
            this.labelPostav.Location = new System.Drawing.Point(19, 21);
            this.labelPostav.Name = "labelPostav";
            this.labelPostav.Size = new System.Drawing.Size(90, 19);
            this.labelPostav.TabIndex = 0;
            this.labelPostav.Text = "Поставщик";
            // 
            // labelDatePostav
            // 
            this.labelDatePostav.AutoSize = true;
            this.labelDatePostav.Location = new System.Drawing.Point(19, 208);
            this.labelDatePostav.Name = "labelDatePostav";
            this.labelDatePostav.Size = new System.Drawing.Size(116, 19);
            this.labelDatePostav.TabIndex = 1;
            this.labelDatePostav.Text = "Дата поставки";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(19, 301);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(130, 19);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Стоимость услуг";
            // 
            // labelOborud
            // 
            this.labelOborud.AutoSize = true;
            this.labelOborud.Location = new System.Drawing.Point(19, 116);
            this.labelOborud.Name = "labelOborud";
            this.labelOborud.Size = new System.Drawing.Size(105, 19);
            this.labelOborud.TabIndex = 3;
            this.labelOborud.Text = "Оборудование";
            // 
            // comboBoxPostav
            // 
            this.comboBoxPostav.FormattingEnabled = true;
            this.comboBoxPostav.Location = new System.Drawing.Point(23, 44);
            this.comboBoxPostav.Name = "comboBoxPostav";
            this.comboBoxPostav.Size = new System.Drawing.Size(214, 27);
            this.comboBoxPostav.TabIndex = 4;
            // 
            // textBoxDatePostav
            // 
            this.textBoxDatePostav.Location = new System.Drawing.Point(23, 231);
            this.textBoxDatePostav.Name = "textBoxDatePostav";
            this.textBoxDatePostav.Size = new System.Drawing.Size(214, 26);
            this.textBoxDatePostav.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(23, 323);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(214, 26);
            this.textBoxPrice.TabIndex = 6;
            // 
            // textBoxOborud
            // 
            this.textBoxOborud.Location = new System.Drawing.Point(23, 138);
            this.textBoxOborud.Name = "textBoxOborud";
            this.textBoxOborud.Size = new System.Drawing.Size(214, 26);
            this.textBoxOborud.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kvantorium_Project.Properties.Resources.rmc_mainbanner_kvantorium_1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // listViewUchet
            // 
            this.listViewUchet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Postav,
            this.Oborud,
            this.DatePostav,
            this.Price});
            this.listViewUchet.FullRowSelect = true;
            this.listViewUchet.GridLines = true;
            this.listViewUchet.HideSelection = false;
            this.listViewUchet.Location = new System.Drawing.Point(256, 21);
            this.listViewUchet.MultiSelect = false;
            this.listViewUchet.Name = "listViewUchet";
            this.listViewUchet.Size = new System.Drawing.Size(918, 398);
            this.listViewUchet.TabIndex = 19;
            this.listViewUchet.UseCompatibleStateImageBehavior = false;
            this.listViewUchet.View = System.Windows.Forms.View.Details;
            this.listViewUchet.SelectedIndexChanged += new System.EventHandler(this.listViewUchet_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id поставщика";
            this.Id.Width = 123;
            // 
            // Postav
            // 
            this.Postav.Text = "Имя и отчество поставщика";
            this.Postav.Width = 224;
            // 
            // Oborud
            // 
            this.Oborud.Text = "Оборудование";
            this.Oborud.Width = 152;
            // 
            // DatePostav
            // 
            this.DatePostav.Text = "Дата поставки";
            this.DatePostav.Width = 130;
            // 
            // Price
            // 
            this.Price.Text = "Стоимость услуг";
            this.Price.Width = 152;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(981, 477);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(196, 48);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(779, 477);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(196, 48);
            this.buttonDel.TabIndex = 22;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(577, 477);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(196, 48);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(375, 477);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(196, 48);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormUchetPostav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 537);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewUchet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxOborud);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDatePostav);
            this.Controls.Add(this.comboBoxPostav);
            this.Controls.Add(this.labelOborud);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDatePostav);
            this.Controls.Add(this.labelPostav);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUchetPostav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUchetPostav";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostav;
        private System.Windows.Forms.Label labelDatePostav;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelOborud;
        private System.Windows.Forms.ComboBox comboBoxPostav;
        private System.Windows.Forms.TextBox textBoxDatePostav;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxOborud;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewUchet;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Postav;
        private System.Windows.Forms.ColumnHeader DatePostav;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Oborud;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}