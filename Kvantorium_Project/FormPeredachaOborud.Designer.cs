﻿namespace Kvantorium_Project
{
    partial class FormPeredachaOborud
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
            this.labelFirstSotr = new System.Windows.Forms.Label();
            this.labelSecondSotr = new System.Windows.Forms.Label();
            this.labelOborud = new System.Windows.Forms.Label();
            this.labelPurposePeredacha = new System.Windows.Forms.Label();
            this.comboBoxFirstSotr = new System.Windows.Forms.ComboBox();
            this.textBoxPurposePeredacha = new System.Windows.Forms.TextBox();
            this.comboBoxSecondSotr = new System.Windows.Forms.ComboBox();
            this.comboBoxOborud = new System.Windows.Forms.ComboBox();
            this.listViewPeredacha = new System.Windows.Forms.ListView();
            this.IdFSotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamePFS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdSSotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamePSS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdObor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameObor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PurposePeredacha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstSotr
            // 
            this.labelFirstSotr.AutoSize = true;
            this.labelFirstSotr.Location = new System.Drawing.Point(12, 9);
            this.labelFirstSotr.Name = "labelFirstSotr";
            this.labelFirstSotr.Size = new System.Drawing.Size(94, 19);
            this.labelFirstSotr.TabIndex = 0;
            this.labelFirstSotr.Text = "1 сотрудник";
            // 
            // labelSecondSotr
            // 
            this.labelSecondSotr.AutoSize = true;
            this.labelSecondSotr.Location = new System.Drawing.Point(12, 88);
            this.labelSecondSotr.Name = "labelSecondSotr";
            this.labelSecondSotr.Size = new System.Drawing.Size(94, 19);
            this.labelSecondSotr.TabIndex = 1;
            this.labelSecondSotr.Text = "2 сотрудник";
            // 
            // labelOborud
            // 
            this.labelOborud.AutoSize = true;
            this.labelOborud.Location = new System.Drawing.Point(12, 171);
            this.labelOborud.Name = "labelOborud";
            this.labelOborud.Size = new System.Drawing.Size(105, 19);
            this.labelOborud.TabIndex = 2;
            this.labelOborud.Text = "Оборудование";
            // 
            // labelPurposePeredacha
            // 
            this.labelPurposePeredacha.AutoSize = true;
            this.labelPurposePeredacha.Location = new System.Drawing.Point(12, 257);
            this.labelPurposePeredacha.Name = "labelPurposePeredacha";
            this.labelPurposePeredacha.Size = new System.Drawing.Size(205, 19);
            this.labelPurposePeredacha.TabIndex = 3;
            this.labelPurposePeredacha.Text = "Цель передачи оборудования";
            // 
            // comboBoxFirstSotr
            // 
            this.comboBoxFirstSotr.FormattingEnabled = true;
            this.comboBoxFirstSotr.Location = new System.Drawing.Point(12, 31);
            this.comboBoxFirstSotr.Name = "comboBoxFirstSotr";
            this.comboBoxFirstSotr.Size = new System.Drawing.Size(215, 27);
            this.comboBoxFirstSotr.TabIndex = 4;
            // 
            // textBoxPurposePeredacha
            // 
            this.textBoxPurposePeredacha.Location = new System.Drawing.Point(12, 279);
            this.textBoxPurposePeredacha.Name = "textBoxPurposePeredacha";
            this.textBoxPurposePeredacha.Size = new System.Drawing.Size(215, 26);
            this.textBoxPurposePeredacha.TabIndex = 5;
            // 
            // comboBoxSecondSotr
            // 
            this.comboBoxSecondSotr.FormattingEnabled = true;
            this.comboBoxSecondSotr.Location = new System.Drawing.Point(12, 110);
            this.comboBoxSecondSotr.Name = "comboBoxSecondSotr";
            this.comboBoxSecondSotr.Size = new System.Drawing.Size(215, 27);
            this.comboBoxSecondSotr.TabIndex = 6;
            // 
            // comboBoxOborud
            // 
            this.comboBoxOborud.FormattingEnabled = true;
            this.comboBoxOborud.Location = new System.Drawing.Point(12, 193);
            this.comboBoxOborud.Name = "comboBoxOborud";
            this.comboBoxOborud.Size = new System.Drawing.Size(215, 27);
            this.comboBoxOborud.TabIndex = 7;
            // 
            // listViewPeredacha
            // 
            this.listViewPeredacha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdFSotr,
            this.NamePFS,
            this.IdSSotr,
            this.NamePSS,
            this.IdObor,
            this.NameObor,
            this.PurposePeredacha});
            this.listViewPeredacha.FullRowSelect = true;
            this.listViewPeredacha.GridLines = true;
            this.listViewPeredacha.HideSelection = false;
            this.listViewPeredacha.Location = new System.Drawing.Point(256, 9);
            this.listViewPeredacha.MultiSelect = false;
            this.listViewPeredacha.Name = "listViewPeredacha";
            this.listViewPeredacha.Size = new System.Drawing.Size(1236, 319);
            this.listViewPeredacha.TabIndex = 34;
            this.listViewPeredacha.UseCompatibleStateImageBehavior = false;
            this.listViewPeredacha.View = System.Windows.Forms.View.Details;
            this.listViewPeredacha.SelectedIndexChanged += new System.EventHandler(this.listViewPeredacha_SelectedIndexChanged);
            // 
            // IdFSotr
            // 
            this.IdFSotr.Text = "Id 1 сотрудника";
            this.IdFSotr.Width = 124;
            // 
            // NamePFS
            // 
            this.NamePFS.Text = "Имя и отчество 1 сотрудника";
            this.NamePFS.Width = 223;
            // 
            // IdSSotr
            // 
            this.IdSSotr.Text = "Id 2 сотрудника";
            this.IdSSotr.Width = 122;
            // 
            // NamePSS
            // 
            this.NamePSS.Text = "Имя и отчество 2 сотрудника";
            this.NamePSS.Width = 223;
            // 
            // IdObor
            // 
            this.IdObor.Text = "Id оборудования";
            this.IdObor.Width = 122;
            // 
            // NameObor
            // 
            this.NameObor.Text = "Наименование оборудования";
            this.NameObor.Width = 208;
            // 
            // PurposePeredacha
            // 
            this.PurposePeredacha.Text = "Цель передачи оборудования";
            this.PurposePeredacha.Width = 211;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(1295, 367);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(196, 48);
            this.buttonUpdate.TabIndex = 38;
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
            this.buttonDel.Location = new System.Drawing.Point(1093, 367);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(196, 48);
            this.buttonDel.TabIndex = 37;
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
            this.buttonEdit.Location = new System.Drawing.Point(891, 367);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(196, 48);
            this.buttonEdit.TabIndex = 36;
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
            this.buttonAdd.Location = new System.Drawing.Point(689, 367);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(196, 48);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Добавить ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kvantorium_Project.Properties.Resources.rmc_mainbanner_kvantorium_1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FormPeredachaOborud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1503, 427);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewPeredacha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxOborud);
            this.Controls.Add(this.comboBoxSecondSotr);
            this.Controls.Add(this.textBoxPurposePeredacha);
            this.Controls.Add(this.comboBoxFirstSotr);
            this.Controls.Add(this.labelPurposePeredacha);
            this.Controls.Add(this.labelOborud);
            this.Controls.Add(this.labelSecondSotr);
            this.Controls.Add(this.labelFirstSotr);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPeredachaOborud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPeredachaOborud";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstSotr;
        private System.Windows.Forms.Label labelSecondSotr;
        private System.Windows.Forms.Label labelOborud;
        private System.Windows.Forms.Label labelPurposePeredacha;
        private System.Windows.Forms.ComboBox comboBoxFirstSotr;
        private System.Windows.Forms.TextBox textBoxPurposePeredacha;
        private System.Windows.Forms.ComboBox comboBoxSecondSotr;
        private System.Windows.Forms.ComboBox comboBoxOborud;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewPeredacha;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader IdFSotr;
        private System.Windows.Forms.ColumnHeader NamePFS;
        private System.Windows.Forms.ColumnHeader IdSSotr;
        private System.Windows.Forms.ColumnHeader NamePSS;
        private System.Windows.Forms.ColumnHeader IdObor;
        private System.Windows.Forms.ColumnHeader NameObor;
        private System.Windows.Forms.ColumnHeader PurposePeredacha;
    }
}