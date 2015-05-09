namespace WindowsFormsApplication1
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddToExcel = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namesDataSet = new WindowsFormsApplication1.NamesDataSet();
            this.tblNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNamesTableAdapter = new WindowsFormsApplication1.NamesDataSetTableAdapters.tblNamesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(45, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(45, 115);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // btnAddToExcel
            // 
            this.btnAddToExcel.Location = new System.Drawing.Point(55, 194);
            this.btnAddToExcel.Name = "btnAddToExcel";
            this.btnAddToExcel.Size = new System.Drawing.Size(75, 23);
            this.btnAddToExcel.TabIndex = 2;
            this.btnAddToExcel.Text = "Add to DB";
            this.btnAddToExcel.UseVisualStyleBackColor = true;
            this.btnAddToExcel.Click += new System.EventHandler(this.btnAddToExcel_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(52, 39);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(52, 99);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.field1DataGridViewTextBoxColumn,
            this.field2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(151, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 233);
            this.dataGridView1.TabIndex = 5;
            // 
            // namesDataSet
            // 
            this.namesDataSet.DataSetName = "NamesDataSet";
            this.namesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNamesBindingSource
            // 
            this.tblNamesBindingSource.DataMember = "tblNames";
            this.tblNamesBindingSource.DataSource = this.namesDataSet;
            // 
            // tblNamesTableAdapter
            // 
            this.tblNamesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // field1DataGridViewTextBoxColumn
            // 
            this.field1DataGridViewTextBoxColumn.DataPropertyName = "Field1";
            this.field1DataGridViewTextBoxColumn.HeaderText = "Field1";
            this.field1DataGridViewTextBoxColumn.Name = "field1DataGridViewTextBoxColumn";
            // 
            // field2DataGridViewTextBoxColumn
            // 
            this.field2DataGridViewTextBoxColumn.DataPropertyName = "Field2";
            this.field2DataGridViewTextBoxColumn.HeaderText = "Field2";
            this.field2DataGridViewTextBoxColumn.Name = "field2DataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnAddToExcel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNamesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAddToExcel;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NamesDataSet namesDataSet;
        private System.Windows.Forms.BindingSource tblNamesBindingSource;
        private NamesDataSetTableAdapters.tblNamesTableAdapter tblNamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn field1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn field2DataGridViewTextBoxColumn;
    }
}

