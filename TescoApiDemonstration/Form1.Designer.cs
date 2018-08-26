namespace TescoApiDemonstration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numLimit = new System.Windows.Forms.NumericUpDown();
            this.numOffset = new System.Windows.Forms.NumericUpDown();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSuperDepartment = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentsMeasureTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPNBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageSellingUnitWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentsQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsItems = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numLimit);
            this.panel1.Controls.Add(this.numOffset);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 58);
            this.panel1.TabIndex = 1;
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(632, 24);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ReadOnly = true;
            this.txtQuery.Size = new System.Drawing.Size(631, 20);
            this.txtQuery.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Items Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Offset";
            // 
            // numLimit
            // 
            this.numLimit.Location = new System.Drawing.Point(340, 23);
            this.numLimit.Name = "numLimit";
            this.numLimit.Size = new System.Drawing.Size(65, 20);
            this.numLimit.TabIndex = 4;
            this.numLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numOffset
            // 
            this.numOffset.Location = new System.Drawing.Point(259, 23);
            this.numOffset.Name = "numOffset";
            this.numOffset.Size = new System.Drawing.Size(75, 20);
            this.numOffset.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(411, 21);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(110, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Term";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSuperDepartment);
            this.panel2.Controls.Add(this.lblDepartment);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1275, 166);
            this.panel2.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescription.Location = new System.Drawing.Point(615, 31);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(660, 135);
            this.txtDescription.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(209, 43);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 25);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "0,00";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(203, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(155, 31);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Item Name";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(203, 166);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.superDepartmentDataGridViewTextBoxColumn,
            this.contentsMeasureTypeDataGridViewTextBoxColumn,
            this.unitQuantityDataGridViewTextBoxColumn,
            this.tPNBDataGridViewTextBoxColumn,
            this.unitOfSaleDataGridViewTextBoxColumn,
            this.averageSellingUnitWeightDataGridViewTextBoxColumn,
            this.contentsQuantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.imageURLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdsItems;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1275, 365);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDepartment.Location = new System.Drawing.Point(210, 124);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(104, 20);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "Department";
            // 
            // lblSuperDepartment
            // 
            this.lblSuperDepartment.AutoSize = true;
            this.lblSuperDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperDepartment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSuperDepartment.Location = new System.Drawing.Point(210, 93);
            this.lblSuperDepartment.Name = "lblSuperDepartment";
            this.lblSuperDepartment.Size = new System.Drawing.Size(157, 20);
            this.lblSuperDepartment.TabIndex = 7;
            this.lblSuperDepartment.Text = "Super Department";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // superDepartmentDataGridViewTextBoxColumn
            // 
            this.superDepartmentDataGridViewTextBoxColumn.DataPropertyName = "SuperDepartment";
            this.superDepartmentDataGridViewTextBoxColumn.HeaderText = "SuperDepartment";
            this.superDepartmentDataGridViewTextBoxColumn.Name = "superDepartmentDataGridViewTextBoxColumn";
            this.superDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contentsMeasureTypeDataGridViewTextBoxColumn
            // 
            this.contentsMeasureTypeDataGridViewTextBoxColumn.DataPropertyName = "ContentsMeasureType";
            this.contentsMeasureTypeDataGridViewTextBoxColumn.HeaderText = "ContentsMeasureType";
            this.contentsMeasureTypeDataGridViewTextBoxColumn.Name = "contentsMeasureTypeDataGridViewTextBoxColumn";
            this.contentsMeasureTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitQuantityDataGridViewTextBoxColumn
            // 
            this.unitQuantityDataGridViewTextBoxColumn.DataPropertyName = "UnitQuantity";
            this.unitQuantityDataGridViewTextBoxColumn.HeaderText = "UnitQuantity";
            this.unitQuantityDataGridViewTextBoxColumn.Name = "unitQuantityDataGridViewTextBoxColumn";
            this.unitQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tPNBDataGridViewTextBoxColumn
            // 
            this.tPNBDataGridViewTextBoxColumn.DataPropertyName = "TPNB";
            this.tPNBDataGridViewTextBoxColumn.HeaderText = "TPNB";
            this.tPNBDataGridViewTextBoxColumn.Name = "tPNBDataGridViewTextBoxColumn";
            this.tPNBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitOfSaleDataGridViewTextBoxColumn
            // 
            this.unitOfSaleDataGridViewTextBoxColumn.DataPropertyName = "UnitOfSale";
            this.unitOfSaleDataGridViewTextBoxColumn.HeaderText = "UnitOfSale";
            this.unitOfSaleDataGridViewTextBoxColumn.Name = "unitOfSaleDataGridViewTextBoxColumn";
            this.unitOfSaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averageSellingUnitWeightDataGridViewTextBoxColumn
            // 
            this.averageSellingUnitWeightDataGridViewTextBoxColumn.DataPropertyName = "AverageSellingUnitWeight";
            this.averageSellingUnitWeightDataGridViewTextBoxColumn.HeaderText = "AverageSellingUnitWeight";
            this.averageSellingUnitWeightDataGridViewTextBoxColumn.Name = "averageSellingUnitWeightDataGridViewTextBoxColumn";
            this.averageSellingUnitWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contentsQuantityDataGridViewTextBoxColumn
            // 
            this.contentsQuantityDataGridViewTextBoxColumn.DataPropertyName = "ContentsQuantity";
            this.contentsQuantityDataGridViewTextBoxColumn.HeaderText = "ContentsQuantity";
            this.contentsQuantityDataGridViewTextBoxColumn.Name = "contentsQuantityDataGridViewTextBoxColumn";
            this.contentsQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageURLDataGridViewTextBoxColumn
            // 
            this.imageURLDataGridViewTextBoxColumn.DataPropertyName = "ImageURL";
            this.imageURLDataGridViewTextBoxColumn.HeaderText = "ImageURL";
            this.imageURLDataGridViewTextBoxColumn.Name = "imageURLDataGridViewTextBoxColumn";
            this.imageURLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsItems
            // 
            this.bdsItems.DataSource = typeof(TescoApiDemonstration.Product);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tesco API Demonstration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLimit;
        private System.Windows.Forms.NumericUpDown numOffset;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn superDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentsMeasureTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPNBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageSellingUnitWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentsQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSuperDepartment;
        private System.Windows.Forms.Label lblDepartment;
    }
}

