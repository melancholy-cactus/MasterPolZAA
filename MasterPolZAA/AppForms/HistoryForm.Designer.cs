namespace MasterPolZAA.AppForms
{
    partial class HistoryForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.titleLabelAttentionFont = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.master_pol_zaaDataSet = new MasterPolZAA.master_pol_zaaDataSet();
            this.partnerProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerProductTableAdapter = new MasterPolZAA.master_pol_zaaDataSetTableAdapters.PartnerProductTableAdapter();
            this.partnerProductDataGridView = new System.Windows.Forms.DataGridView();
            this.tableAdapterManager1 = new MasterPolZAA.master_pol_zaaDataSetTableAdapters.TableAdapterManager();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new MasterPolZAA.master_pol_zaaDataSetTableAdapters.ProductTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_pol_zaaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.titleLabelAttentionFont);
            this.splitContainer.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.partnerProductDataGridView);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 90;
            this.splitContainer.TabIndex = 1;
            // 
            // titleLabelAttentionFont
            // 
            this.titleLabelAttentionFont.AutoSize = true;
            this.titleLabelAttentionFont.Location = new System.Drawing.Point(85, 20);
            this.titleLabelAttentionFont.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabelAttentionFont.Name = "titleLabelAttentionFont";
            this.titleLabelAttentionFont.Size = new System.Drawing.Size(113, 13);
            this.titleLabelAttentionFont.TabIndex = 1;
            this.titleLabelAttentionFont.Text = "ИСТОРИЯ ПРОДАЖ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MasterPolZAA.Properties.Resources.Мастер_пол;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // master_pol_zaaDataSet
            // 
            this.master_pol_zaaDataSet.DataSetName = "master_pol_zaaDataSet";
            this.master_pol_zaaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnerProductBindingSource
            // 
            this.partnerProductBindingSource.DataMember = "PartnerProduct";
            this.partnerProductBindingSource.DataSource = this.master_pol_zaaDataSet;
            // 
            // partnerProductTableAdapter
            // 
            this.partnerProductTableAdapter.ClearBeforeFill = true;
            // 
            // partnerProductDataGridView
            // 
            this.partnerProductDataGridView.AllowUserToAddRows = false;
            this.partnerProductDataGridView.AllowUserToDeleteRows = false;
            this.partnerProductDataGridView.AutoGenerateColumns = false;
            this.partnerProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partnerProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partnerProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.partnerProductDataGridView.DataSource = this.partnerProductBindingSource;
            this.partnerProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partnerProductDataGridView.Location = new System.Drawing.Point(20, 0);
            this.partnerProductDataGridView.Name = "partnerProductDataGridView";
            this.partnerProductDataGridView.ReadOnly = true;
            this.partnerProductDataGridView.Size = new System.Drawing.Size(760, 336);
            this.partnerProductDataGridView.TabIndex = 0;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PartnerProductTableAdapter = this.partnerProductTableAdapter;
            this.tableAdapterManager1.PartnerTableAdapter = null;
            this.tableAdapterManager1.PartnerTypeTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager1.ProductTypeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MasterPolZAA.master_pol_zaaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.master_pol_zaaDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn
            // 
            this.dataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.dataGridViewTextBoxColumn.DisplayMember = "ProductName";
            this.dataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn.HeaderText = "Продукция";
            this.dataGridViewTextBoxColumn.Name = "dataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn.ReadOnly = true;
            this.dataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn.ValueMember = "IdProduct";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_pol_zaaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label titleLabelAttentionFont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private master_pol_zaaDataSet master_pol_zaaDataSet;
        private System.Windows.Forms.BindingSource partnerProductBindingSource;
        private master_pol_zaaDataSetTableAdapters.PartnerProductTableAdapter partnerProductTableAdapter;
        private System.Windows.Forms.DataGridView partnerProductDataGridView;
        private master_pol_zaaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private master_pol_zaaDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}