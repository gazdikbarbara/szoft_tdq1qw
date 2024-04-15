namespace EuropeanCountries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            populationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaInSquareKmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataBindingSource = new BindingSource(components);
            MegnyitásButton = new Button();
            SzerkesztésButton = new Button();
            TörlésButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, populationDataGridViewTextBoxColumn, areaInSquareKmDataGridViewTextBoxColumn });
            dataGridView1.DataSource = countryDataBindingSource;
            dataGridView1.Location = new Point(14, 80);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(887, 452);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn.HeaderText = "Population";
            populationDataGridViewTextBoxColumn.MinimumWidth = 6;
            populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            populationDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.MinimumWidth = 6;
            areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            areaInSquareKmDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // MegnyitásButton
            // 
            MegnyitásButton.Location = new Point(781, 16);
            MegnyitásButton.Margin = new Padding(3, 4, 3, 4);
            MegnyitásButton.Name = "MegnyitásButton";
            MegnyitásButton.Size = new Size(120, 51);
            MegnyitásButton.TabIndex = 1;
            MegnyitásButton.Text = "Megnyitás";
            MegnyitásButton.UseVisualStyleBackColor = true;
            MegnyitásButton.Click += MegnyitásButton_Click;
            // 
            // SzerkesztésButton
            // 
            SzerkesztésButton.Location = new Point(789, 548);
            SzerkesztésButton.Margin = new Padding(3, 4, 3, 4);
            SzerkesztésButton.Name = "SzerkesztésButton";
            SzerkesztésButton.Size = new Size(112, 31);
            SzerkesztésButton.TabIndex = 2;
            SzerkesztésButton.Text = "Szerkesztés";
            SzerkesztésButton.UseVisualStyleBackColor = true;
            SzerkesztésButton.Click += SzerkesztésButton_Click;
            // 
            // TörlésButton
            // 
            TörlésButton.Location = new Point(670, 548);
            TörlésButton.Margin = new Padding(3, 4, 3, 4);
            TörlésButton.Name = "TörlésButton";
            TörlésButton.Size = new Size(113, 31);
            TörlésButton.TabIndex = 3;
            TörlésButton.Text = "Törlés";
            TörlésButton.UseVisualStyleBackColor = true;
            TörlésButton.Click += TörlésButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 553);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "Mentés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(TörlésButton);
            Controls.Add(SzerkesztésButton);
            Controls.Add(MegnyitásButton);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button MegnyitásButton;
        private Button SzerkesztésButton;
        private Button TörlésButton;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private BindingSource countryDataBindingSource;
        private Button button1;
    }
}