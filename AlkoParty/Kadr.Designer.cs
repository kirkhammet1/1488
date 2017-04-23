namespace AlkoParty
{
    partial class Kadr
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDOtdKafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSotrudnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otdelKadrovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPCLUBDataSet = new AlkoParty.COMPCLUBDataSet();
            this.otdel_KadrovTableAdapter = new AlkoParty.COMPCLUBDataSetTableAdapters.Otdel_KadrovTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPCLUBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отдел кадров";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(347, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 66);
            this.button2.TabIndex = 12;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(347, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 66);
            this.button1.TabIndex = 11;
            this.button1.Text = "Провести собеседование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(347, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 66);
            this.button6.TabIndex = 10;
            this.button6.Text = "Обновить Базу";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOtdKafDataGridViewTextBoxColumn,
            this.otchetiDataGridViewTextBoxColumn,
            this.iDSotrudnikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.otdelKadrovBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDOtdKafDataGridViewTextBoxColumn
            // 
            this.iDOtdKafDataGridViewTextBoxColumn.DataPropertyName = "ID_OtdKaf";
            this.iDOtdKafDataGridViewTextBoxColumn.HeaderText = "ID Отдел кадров";
            this.iDOtdKafDataGridViewTextBoxColumn.Name = "iDOtdKafDataGridViewTextBoxColumn";
            this.iDOtdKafDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otchetiDataGridViewTextBoxColumn
            // 
            this.otchetiDataGridViewTextBoxColumn.DataPropertyName = "Otcheti";
            this.otchetiDataGridViewTextBoxColumn.HeaderText = "Отчёт";
            this.otchetiDataGridViewTextBoxColumn.Name = "otchetiDataGridViewTextBoxColumn";
            // 
            // iDSotrudnikDataGridViewTextBoxColumn
            // 
            this.iDSotrudnikDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudnik";
            this.iDSotrudnikDataGridViewTextBoxColumn.HeaderText = "ID Сотрудника";
            this.iDSotrudnikDataGridViewTextBoxColumn.Name = "iDSotrudnikDataGridViewTextBoxColumn";
            // 
            // otdelKadrovBindingSource
            // 
            this.otdelKadrovBindingSource.DataMember = "Otdel_Kadrov";
            this.otdelKadrovBindingSource.DataSource = this.cOMPCLUBDataSet;
            // 
            // cOMPCLUBDataSet
            // 
            this.cOMPCLUBDataSet.DataSetName = "COMPCLUBDataSet";
            this.cOMPCLUBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otdel_KadrovTableAdapter
            // 
            this.otdel_KadrovTableAdapter.ClearBeforeFill = true;
            // 
            // Kadr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(473, 444);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kadr";
            this.Text = "Kadr";
            this.Load += new System.EventHandler(this.Kadr_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPCLUBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private COMPCLUBDataSet cOMPCLUBDataSet;
        private System.Windows.Forms.BindingSource otdelKadrovBindingSource;
        private COMPCLUBDataSetTableAdapters.Otdel_KadrovTableAdapter otdel_KadrovTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOtdKafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
    }
}