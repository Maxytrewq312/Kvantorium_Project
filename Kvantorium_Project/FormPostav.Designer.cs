﻿namespace Kvantorium_Project
{
    partial class FormPostav
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelTimeWork = new System.Windows.Forms.Label();
            this.labelMediumPrice = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxTimeWork = new System.Windows.Forms.TextBox();
            this.textBoxMediumPrice = new System.Windows.Forms.TextBox();
            this.listViewPostavshiki = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MediumPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(19, 17);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(38, 19);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(19, 93);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(70, 19);
            this.labelMiddleName.TabIndex = 1;
            this.labelMiddleName.Text = "Фамилия";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(19, 173);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(81, 19);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Отчество";
            // 
            // labelTimeWork
            // 
            this.labelTimeWork.AutoSize = true;
            this.labelTimeWork.Location = new System.Drawing.Point(19, 259);
            this.labelTimeWork.Name = "labelTimeWork";
            this.labelTimeWork.Size = new System.Drawing.Size(179, 19);
            this.labelTimeWork.TabIndex = 3;
            this.labelTimeWork.Text = "Срок работы с команией";
            // 
            // labelMediumPrice
            // 
            this.labelMediumPrice.AutoSize = true;
            this.labelMediumPrice.Location = new System.Drawing.Point(19, 343);
            this.labelMediumPrice.Name = "labelMediumPrice";
            this.labelMediumPrice.Size = new System.Drawing.Size(186, 19);
            this.labelMediumPrice.TabIndex = 4;
            this.labelMediumPrice.Text = "Средняя стоимость услуг";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(23, 40);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(215, 26);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMiddleName.Location = new System.Drawing.Point(23, 115);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(215, 26);
            this.textBoxMiddleName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(23, 195);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(215, 26);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxTimeWork
            // 
            this.textBoxTimeWork.Location = new System.Drawing.Point(23, 281);
            this.textBoxTimeWork.Name = "textBoxTimeWork";
            this.textBoxTimeWork.Size = new System.Drawing.Size(215, 26);
            this.textBoxTimeWork.TabIndex = 8;
            // 
            // textBoxMediumPrice
            // 
            this.textBoxMediumPrice.Location = new System.Drawing.Point(23, 365);
            this.textBoxMediumPrice.Name = "textBoxMediumPrice";
            this.textBoxMediumPrice.Size = new System.Drawing.Size(215, 26);
            this.textBoxMediumPrice.TabIndex = 9;
            // 
            // listViewPostavshiki
            // 
            this.listViewPostavshiki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.TimeWork,
            this.MediumPrice});
            this.listViewPostavshiki.FullRowSelect = true;
            this.listViewPostavshiki.GridLines = true;
            this.listViewPostavshiki.HideSelection = false;
            this.listViewPostavshiki.Location = new System.Drawing.Point(275, 17);
            this.listViewPostavshiki.MultiSelect = false;
            this.listViewPostavshiki.Name = "listViewPostavshiki";
            this.listViewPostavshiki.Size = new System.Drawing.Size(782, 374);
            this.listViewPostavshiki.TabIndex = 19;
            this.listViewPostavshiki.UseCompatibleStateImageBehavior = false;
            this.listViewPostavshiki.View = System.Windows.Forms.View.Details;
            this.listViewPostavshiki.SelectedIndexChanged += new System.EventHandler(this.listViewPostavshiki_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            this.FirstName.Width = 88;
            // 
            // MiddleName
            // 
            this.MiddleName.Text = "Фамилия";
            this.MiddleName.Width = 93;
            // 
            // LastName
            // 
            this.LastName.Text = "Отчество";
            this.LastName.Width = 97;
            // 
            // TimeWork
            // 
            this.TimeWork.Text = "Время работы с компанией";
            this.TimeWork.Width = 218;
            // 
            // MediumPrice
            // 
            this.MediumPrice.Text = "Средняя стоимость услуг";
            this.MediumPrice.Width = 223;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(861, 467);
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
            this.buttonDel.Location = new System.Drawing.Point(659, 467);
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
            this.buttonEdit.Location = new System.Drawing.Point(457, 467);
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
            this.buttonAdd.Location = new System.Drawing.Point(255, 467);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(196, 48);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kvantorium_Project.Properties.Resources.rmc_mainbanner_kvantorium_1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormPostav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 527);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewPostavshiki);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMediumPrice);
            this.Controls.Add(this.textBoxTimeWork);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelMediumPrice);
            this.Controls.Add(this.labelTimeWork);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPostav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPostav";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelTimeWork;
        private System.Windows.Forms.Label labelMediumPrice;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxTimeWork;
        private System.Windows.Forms.TextBox textBoxMediumPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewPostavshiki;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader TimeWork;
        private System.Windows.Forms.ColumnHeader MediumPrice;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}