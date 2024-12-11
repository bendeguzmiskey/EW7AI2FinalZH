namespace FormCseresznye
{
    partial class UserControlLoad
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            pilotaNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            csapatIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szponzorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nemzetisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            versenyBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)versenyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 274);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { pilotaNevDataGridViewTextBoxColumn, csapatIdDataGridViewTextBoxColumn, szponzorDataGridViewTextBoxColumn, nemzetisegDataGridViewTextBoxColumn });
            dataGridView1.DataSource = versenyBindingSource;
            dataGridView1.Location = new Point(129, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(392, 303);
            dataGridView1.TabIndex = 2;
            // 
            // pilotaNevDataGridViewTextBoxColumn
            // 
            pilotaNevDataGridViewTextBoxColumn.DataPropertyName = "PilotaNev";
            pilotaNevDataGridViewTextBoxColumn.HeaderText = "PilotaNev";
            pilotaNevDataGridViewTextBoxColumn.Name = "pilotaNevDataGridViewTextBoxColumn";
            // 
            // csapatIdDataGridViewTextBoxColumn
            // 
            csapatIdDataGridViewTextBoxColumn.DataPropertyName = "CsapatId";
            csapatIdDataGridViewTextBoxColumn.HeaderText = "CsapatId";
            csapatIdDataGridViewTextBoxColumn.Name = "csapatIdDataGridViewTextBoxColumn";
            // 
            // szponzorDataGridViewTextBoxColumn
            // 
            szponzorDataGridViewTextBoxColumn.DataPropertyName = "Szponzor";
            szponzorDataGridViewTextBoxColumn.HeaderText = "Szponzor";
            szponzorDataGridViewTextBoxColumn.Name = "szponzorDataGridViewTextBoxColumn";
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            // 
            // versenyBindingSource
            // 
            versenyBindingSource.DataSource = typeof(Verseny);
            // 
            // UserControlLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "UserControlLoad";
            Size = new Size(592, 329);
            Load += UserControlLoad_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)versenyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn pilotaNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn csapatIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szponzorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private BindingSource versenyBindingSource;
    }
}
