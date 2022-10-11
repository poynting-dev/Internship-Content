namespace WindowsFormsApp_Test1
{
    partial class employees_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees_list));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.internBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new WindowsFormsApp_Test1.EmployeeDataSet();
            this.internTableAdapter = new WindowsFormsApp_Test1.EmployeeDataSetTableAdapters.internTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searhButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.uidInput = new System.Windows.Forms.TextBox();
            this.practiceInput = new System.Windows.Forms.TextBox();
            this.employeeInput = new System.Windows.Forms.TextBox();
            this.insertDetail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.Label();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.practiceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.internBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(101, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 244);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // internBindingSource
            // 
            this.internBindingSource.DataMember = "intern";
            this.internBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // internTableAdapter
            // 
            this.internTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.searhButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.uidInput);
            this.groupBox1.Controls.Add(this.practiceInput);
            this.groupBox1.Controls.Add(this.employeeInput);
            this.groupBox1.Controls.Add(this.insertDetail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.uid);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(57, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 260);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intern Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searhButton
            // 
            this.searhButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.searhButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searhButton.Location = new System.Drawing.Point(574, 180);
            this.searhButton.Name = "searhButton";
            this.searhButton.Size = new System.Drawing.Size(134, 54);
            this.searhButton.TabIndex = 18;
            this.searhButton.Text = "Search";
            this.searhButton.UseVisualStyleBackColor = false;
            this.searhButton.Click += new System.EventHandler(this.search);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(398, 180);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(134, 54);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.delete);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.updateButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(216, 180);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(134, 54);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.update);
            // 
            // uidInput
            // 
            this.uidInput.Location = new System.Drawing.Point(330, 42);
            this.uidInput.Name = "uidInput";
            this.uidInput.Size = new System.Drawing.Size(149, 34);
            this.uidInput.TabIndex = 15;
            this.uidInput.TextChanged += new System.EventHandler(this.uidInput_TextChanged);
            // 
            // practiceInput
            // 
            this.practiceInput.Location = new System.Drawing.Point(330, 127);
            this.practiceInput.Name = "practiceInput";
            this.practiceInput.Size = new System.Drawing.Size(256, 34);
            this.practiceInput.TabIndex = 14;
            // 
            // employeeInput
            // 
            this.employeeInput.Location = new System.Drawing.Point(330, 82);
            this.employeeInput.Name = "employeeInput";
            this.employeeInput.Size = new System.Drawing.Size(256, 34);
            this.employeeInput.TabIndex = 13;
            // 
            // insertDetail
            // 
            this.insertDetail.BackColor = System.Drawing.Color.DodgerBlue;
            this.insertDetail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDetail.Location = new System.Drawing.Point(31, 180);
            this.insertDetail.Name = "insertDetail";
            this.insertDetail.Size = new System.Drawing.Size(134, 54);
            this.insertDetail.TabIndex = 12;
            this.insertDetail.Text = "Insert";
            this.insertDetail.UseVisualStyleBackColor = false;
            this.insertDetail.Click += new System.EventHandler(this.insert);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(225, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Practice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(151, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Employee Name";
            // 
            // uid
            // 
            this.uid.AutoSize = true;
            this.uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uid.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.uid.Location = new System.Drawing.Point(246, 39);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(45, 25);
            this.uid.TabIndex = 9;
            this.uid.Text = "UID";
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "uid";
            this.uidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            this.uidDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // practiceDataGridViewTextBoxColumn
            // 
            this.practiceDataGridViewTextBoxColumn.DataPropertyName = "practice";
            this.practiceDataGridViewTextBoxColumn.HeaderText = "practice";
            this.practiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.practiceDataGridViewTextBoxColumn.Name = "practiceDataGridViewTextBoxColumn";
            this.practiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // employees_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "employees_list";
            this.Text = "Employees_List";
            this.Load += new System.EventHandler(this.employees_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource internBindingSource;
        private EmployeeDataSetTableAdapters.internTableAdapter internTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox uidInput;
        private System.Windows.Forms.TextBox practiceInput;
        private System.Windows.Forms.TextBox employeeInput;
        private System.Windows.Forms.Button insertDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uid;
        private System.Windows.Forms.Button searhButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn practiceDataGridViewTextBoxColumn;
    }
}

