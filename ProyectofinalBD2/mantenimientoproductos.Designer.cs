namespace ProyectofinalBD2
{
    partial class mantenimientoproductos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proyectofinalDataSet = new ProyectofinalBD2.ProyectofinalDataSet();
            this.proyectofinalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new ProyectofinalBD2.ProyectofinalDataSetTableAdapters.productosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectofinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectofinalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.capacidadDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.dimensionesDataGridViewTextBoxColumn,
            this.tapaDataGridViewTextBoxColumn,
            this.fabricacionDataGridViewTextBoxColumn,
            this.loteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1052, 652);
            this.dataGridView1.TabIndex = 0;
            // 
            // proyectofinalDataSet
            // 
            this.proyectofinalDataSet.DataSetName = "ProyectofinalDataSet";
            this.proyectofinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectofinalDataSetBindingSource
            // 
            this.proyectofinalDataSetBindingSource.DataSource = this.proyectofinalDataSet;
            this.proyectofinalDataSetBindingSource.Position = 0;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.proyectofinalDataSetBindingSource;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            this.capacidadDataGridViewTextBoxColumn.DataPropertyName = "capacidad";
            this.capacidadDataGridViewTextBoxColumn.HeaderText = "capacidad";
            this.capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // dimensionesDataGridViewTextBoxColumn
            // 
            this.dimensionesDataGridViewTextBoxColumn.DataPropertyName = "dimensiones";
            this.dimensionesDataGridViewTextBoxColumn.HeaderText = "dimensiones";
            this.dimensionesDataGridViewTextBoxColumn.Name = "dimensionesDataGridViewTextBoxColumn";
            // 
            // tapaDataGridViewTextBoxColumn
            // 
            this.tapaDataGridViewTextBoxColumn.DataPropertyName = "tapa";
            this.tapaDataGridViewTextBoxColumn.HeaderText = "tapa";
            this.tapaDataGridViewTextBoxColumn.Name = "tapaDataGridViewTextBoxColumn";
            // 
            // fabricacionDataGridViewTextBoxColumn
            // 
            this.fabricacionDataGridViewTextBoxColumn.DataPropertyName = "fabricacion";
            this.fabricacionDataGridViewTextBoxColumn.HeaderText = "fabricacion";
            this.fabricacionDataGridViewTextBoxColumn.Name = "fabricacionDataGridViewTextBoxColumn";
            // 
            // loteDataGridViewTextBoxColumn
            // 
            this.loteDataGridViewTextBoxColumn.DataPropertyName = "lote";
            this.loteDataGridViewTextBoxColumn.HeaderText = "lote";
            this.loteDataGridViewTextBoxColumn.Name = "loteDataGridViewTextBoxColumn";
            // 
            // mantenimientoproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 676);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mantenimientoproductos";
            this.Text = "mantenimientoproductos";
            this.Load += new System.EventHandler(this.mantenimientoproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectofinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectofinalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource proyectofinalDataSetBindingSource;
        private ProyectofinalDataSet proyectofinalDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private ProyectofinalDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tapaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteDataGridViewTextBoxColumn;
    }
}