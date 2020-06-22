namespace Kvantorium_Project
{
    partial class FormOborud
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelColOb = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxColOb = new System.Windows.Forms.TextBox();
            this.listViewOborud = new System.Windows.Forms.ListView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColOb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(204, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Наименование оборудования";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(8, 108);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(141, 19);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Цена оборудования";
            // 
            // labelColOb
            // 
            this.labelColOb.AutoSize = true;
            this.labelColOb.Location = new System.Drawing.Point(8, 191);
            this.labelColOb.Name = "labelColOb";
            this.labelColOb.Size = new System.Drawing.Size(188, 19);
            this.labelColOb.TabIndex = 2;
            this.labelColOb.Text = "Количество оборудования";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(215, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 130);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(215, 26);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxColOb
            // 
            this.textBoxColOb.Location = new System.Drawing.Point(12, 213);
            this.textBoxColOb.Name = "textBoxColOb";
            this.textBoxColOb.Size = new System.Drawing.Size(215, 26);
            this.textBoxColOb.TabIndex = 5;
            // 
            // listViewOborud
            // 
            this.listViewOborud.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name1,
            this.Price,
            this.ColOb});
            this.listViewOborud.FullRowSelect = true;
            this.listViewOborud.GridLines = true;
            this.listViewOborud.HideSelection = false;
            this.listViewOborud.Location = new System.Drawing.Point(263, 28);
            this.listViewOborud.MultiSelect = false;
            this.listViewOborud.Name = "listViewOborud";
            this.listViewOborud.Size = new System.Drawing.Size(544, 320);
            this.listViewOborud.TabIndex = 6;
            this.listViewOborud.UseCompatibleStateImageBehavior = false;
            this.listViewOborud.View = System.Windows.Forms.View.Details;
            this.listViewOborud.SelectedIndexChanged += new System.EventHandler(this.listViewOborud_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(677, 392);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(132, 48);
            this.buttonUpdate.TabIndex = 31;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(539, 392);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(132, 48);
            this.buttonDel.TabIndex = 30;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(401, 392);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(132, 48);
            this.buttonEdit.TabIndex = 29;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(263, 392);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 48);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Добавить ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 38;
            // 
            // Name1
            // 
            this.Name1.Text = "Наименование оборудования";
            this.Name1.Width = 271;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 130;
            // 
            // ColOb
            // 
            this.ColOb.Text = "Количество";
            this.ColOb.Width = 101;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kvantorium_Project.Properties.Resources.rmc_mainbanner_kvantorium_1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FormOborud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewOborud);
            this.Controls.Add(this.textBoxColOb);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelColOb);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOborud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOborud";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelColOb;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxColOb;
        private System.Windows.Forms.ListView listViewOborud;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Name1;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader ColOb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}