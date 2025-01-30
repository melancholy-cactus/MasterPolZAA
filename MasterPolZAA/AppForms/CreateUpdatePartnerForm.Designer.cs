namespace MasterPolZAA.AppForms
{
    partial class CreateUpdatePartnerForm
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
            System.Windows.Forms.Label partnerTypeIdLabel;
            System.Windows.Forms.Label partnerNameLabel;
            System.Windows.Forms.Label ceoLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.titleLabelAttentionFont = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ratingHintAttentionFont = new System.Windows.Forms.Label();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_pol_zaaDataSet = new MasterPolZAA.master_pol_zaaDataSet();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.saveAttentionBackground = new System.Windows.Forms.Button();
            this.partnerTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.partnerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerNameTextBox = new System.Windows.Forms.TextBox();
            this.ceoTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.partnerTableAdapter = new MasterPolZAA.master_pol_zaaDataSetTableAdapters.PartnerTableAdapter();
            this.tableAdapterManager = new MasterPolZAA.master_pol_zaaDataSetTableAdapters.TableAdapterManager();
            this.partnerTypeTableAdapter = new MasterPolZAA.master_pol_zaaDataSetTableAdapters.PartnerTypeTableAdapter();
            this.partnerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            partnerTypeIdLabel = new System.Windows.Forms.Label();
            partnerNameLabel = new System.Windows.Forms.Label();
            ceoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_pol_zaaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // partnerTypeIdLabel
            // 
            partnerTypeIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            partnerTypeIdLabel.AutoSize = true;
            partnerTypeIdLabel.Location = new System.Drawing.Point(3, 53);
            partnerTypeIdLabel.Name = "partnerTypeIdLabel";
            partnerTypeIdLabel.Size = new System.Drawing.Size(26, 13);
            partnerTypeIdLabel.TabIndex = 0;
            partnerTypeIdLabel.Text = "Тип";
            // 
            // partnerNameLabel
            // 
            partnerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            partnerNameLabel.AutoSize = true;
            partnerNameLabel.Location = new System.Drawing.Point(3, 80);
            partnerNameLabel.Name = "partnerNameLabel";
            partnerNameLabel.Size = new System.Drawing.Size(83, 13);
            partnerNameLabel.TabIndex = 2;
            partnerNameLabel.Text = "Наименование";
            // 
            // ceoLabel
            // 
            ceoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ceoLabel.AutoSize = true;
            ceoLabel.Location = new System.Drawing.Point(3, 106);
            ceoLabel.Name = "ceoLabel";
            ceoLabel.Size = new System.Drawing.Size(57, 13);
            ceoLabel.TabIndex = 4;
            ceoLabel.Text = "Директор";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(3, 184);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(38, 13);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Адрес";
            // 
            // ratingLabel
            // 
            ratingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(3, 210);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(48, 13);
            ratingLabel.TabIndex = 12;
            ratingLabel.Text = "Рейтинг";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(3, 130);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(3, 158);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Телефон";
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
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.ratingHintAttentionFont);
            this.splitContainer.Panel2.Controls.Add(phoneLabel);
            this.splitContainer.Panel2.Controls.Add(this.phoneMaskedTextBox);
            this.splitContainer.Panel2.Controls.Add(emailLabel);
            this.splitContainer.Panel2.Controls.Add(this.emailTextBox);
            this.splitContainer.Panel2.Controls.Add(this.saveAttentionBackground);
            this.splitContainer.Panel2.Controls.Add(partnerTypeIdLabel);
            this.splitContainer.Panel2.Controls.Add(this.partnerTypeIdComboBox);
            this.splitContainer.Panel2.Controls.Add(partnerNameLabel);
            this.splitContainer.Panel2.Controls.Add(this.partnerNameTextBox);
            this.splitContainer.Panel2.Controls.Add(ceoLabel);
            this.splitContainer.Panel2.Controls.Add(this.ceoTextBox);
            this.splitContainer.Panel2.Controls.Add(addressLabel);
            this.splitContainer.Panel2.Controls.Add(this.addressTextBox);
            this.splitContainer.Panel2.Controls.Add(ratingLabel);
            this.splitContainer.Panel2.Controls.Add(this.ratingTextBox);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.splitContainer.Size = new System.Drawing.Size(321, 450);
            this.splitContainer.SplitterDistance = 90;
            this.splitContainer.TabIndex = 2;
            // 
            // titleLabelAttentionFont
            // 
            this.titleLabelAttentionFont.AutoSize = true;
            this.titleLabelAttentionFont.Location = new System.Drawing.Point(85, 20);
            this.titleLabelAttentionFont.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabelAttentionFont.Name = "titleLabelAttentionFont";
            this.titleLabelAttentionFont.Size = new System.Drawing.Size(102, 13);
            this.titleLabelAttentionFont.TabIndex = 1;
            this.titleLabelAttentionFont.Text = "НОВЫЙ ПАРТНЕР";
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
            // ratingHintAttentionFont
            // 
            this.ratingHintAttentionFont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingHintAttentionFont.AutoSize = true;
            this.ratingHintAttentionFont.Location = new System.Drawing.Point(89, 230);
            this.ratingHintAttentionFont.Margin = new System.Windows.Forms.Padding(0);
            this.ratingHintAttentionFont.Name = "ratingHintAttentionFont";
            this.ratingHintAttentionFont.Size = new System.Drawing.Size(162, 13);
            this.ratingHintAttentionFont.TabIndex = 17;
            this.ratingHintAttentionFont.Text = "Целое неотрицательное число";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(92, 155);
            this.phoneMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(217, 20);
            this.phoneMaskedTextBox.TabIndex = 16;
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataMember = "Partner";
            this.partnerBindingSource.DataSource = this.master_pol_zaaDataSet;
            // 
            // master_pol_zaaDataSet
            // 
            this.master_pol_zaaDataSet.DataSetName = "master_pol_zaaDataSet";
            this.master_pol_zaaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(92, 130);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(217, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // saveAttentionBackground
            // 
            this.saveAttentionBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveAttentionBackground.Location = new System.Drawing.Point(6, 259);
            this.saveAttentionBackground.Name = "saveAttentionBackground";
            this.saveAttentionBackground.Size = new System.Drawing.Size(303, 33);
            this.saveAttentionBackground.TabIndex = 14;
            this.saveAttentionBackground.Text = "Сохранить";
            this.saveAttentionBackground.UseVisualStyleBackColor = true;
            this.saveAttentionBackground.Click += new System.EventHandler(this.saveAttentionBackground_Click);
            // 
            // partnerTypeIdComboBox
            // 
            this.partnerTypeIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partnerTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partnerTypeBindingSource, "PartnerTypeName", true));
            this.partnerTypeIdComboBox.DataSource = this.partnerTypeBindingSource;
            this.partnerTypeIdComboBox.DisplayMember = "PartnerTypeName";
            this.partnerTypeIdComboBox.FormattingEnabled = true;
            this.partnerTypeIdComboBox.Location = new System.Drawing.Point(92, 50);
            this.partnerTypeIdComboBox.Name = "partnerTypeIdComboBox";
            this.partnerTypeIdComboBox.Size = new System.Drawing.Size(217, 21);
            this.partnerTypeIdComboBox.TabIndex = 1;
            this.partnerTypeIdComboBox.ValueMember = "IdPartnerType";
            // 
            // partnerTypeBindingSource
            // 
            this.partnerTypeBindingSource.DataMember = "PartnerType";
            this.partnerTypeBindingSource.DataSource = this.master_pol_zaaDataSet;
            // 
            // partnerNameTextBox
            // 
            this.partnerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partnerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "PartnerName", true));
            this.partnerNameTextBox.Location = new System.Drawing.Point(92, 77);
            this.partnerNameTextBox.Name = "partnerNameTextBox";
            this.partnerNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.partnerNameTextBox.TabIndex = 3;
            // 
            // ceoTextBox
            // 
            this.ceoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ceoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Ceo", true));
            this.ceoTextBox.Location = new System.Drawing.Point(92, 103);
            this.ceoTextBox.Name = "ceoTextBox";
            this.ceoTextBox.Size = new System.Drawing.Size(217, 20);
            this.ceoTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(92, 181);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(217, 20);
            this.addressTextBox.TabIndex = 11;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(92, 207);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(217, 20);
            this.ratingTextBox.TabIndex = 13;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PartnerProductTableAdapter = null;
            this.tableAdapterManager.PartnerTableAdapter = this.partnerTableAdapter;
            this.tableAdapterManager.PartnerTypeTableAdapter = this.partnerTypeTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MasterPolZAA.master_pol_zaaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partnerTypeTableAdapter
            // 
            this.partnerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // partnerBindingSource1
            // 
            this.partnerBindingSource1.DataMember = "Partner";
            this.partnerBindingSource1.DataSource = this.master_pol_zaaDataSet;
            // 
            // CreateUpdatePartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "CreateUpdatePartnerForm";
            this.Text = "CreateUpdatePartnerForm";
            this.Load += new System.EventHandler(this.CreateUpdatePartnerForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_pol_zaaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label titleLabelAttentionFont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private master_pol_zaaDataSet master_pol_zaaDataSet;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private master_pol_zaaDataSetTableAdapters.PartnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.Label ratingHintAttentionFont;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button saveAttentionBackground;
        private System.Windows.Forms.ComboBox partnerTypeIdComboBox;
        private System.Windows.Forms.TextBox partnerNameTextBox;
        private System.Windows.Forms.TextBox ceoTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private master_pol_zaaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource partnerBindingSource1;
        private master_pol_zaaDataSetTableAdapters.PartnerTypeTableAdapter partnerTypeTableAdapter;
        private System.Windows.Forms.BindingSource partnerTypeBindingSource;
    }
}