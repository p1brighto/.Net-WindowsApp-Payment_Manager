namespace Assignment4_Beanstream
{
    partial class PaymentManager
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsDataSet = new Assignment4_Beanstream.PaymentsDataSet();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new Assignment4_Beanstream.PaymentsDataSetTableAdapters.PaymentsTableAdapter();
            this.tableAdapterManager = new Assignment4_Beanstream.PaymentsDataSetTableAdapters.TableAdapterManager();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.cvvTextBox = new System.Windows.Forms.TextBox();
            this.clearfieldsButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.cvvLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.processPaymentGroupBox = new System.Windows.Forms.GroupBox();
            this.submitPaymentButton = new System.Windows.Forms.Button();
            this.paymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.processPaymentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(462, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Backup";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // paymentsDataSet
            // 
            this.paymentsDataSet.DataSetName = "PaymentsDataSet";
            this.paymentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.paymentsDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PaymentsTableAdapter = this.paymentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Assignment4_Beanstream.PaymentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.yearComboBox.Location = new System.Drawing.Point(247, 114);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(36, 21);
            this.yearComboBox.TabIndex = 4;
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.monthComboBox.Location = new System.Drawing.Point(156, 114);
            this.monthComboBox.MaxDropDownItems = 12;
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(36, 21);
            this.monthComboBox.TabIndex = 3;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(113, 19);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(177, 20);
            this.amountTextBox.TabIndex = 0;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(113, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(177, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(113, 79);
            this.cardNumberTextBox.MaxLength = 16;
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(177, 20);
            this.cardNumberTextBox.TabIndex = 2;
            this.cardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardNumberTextBox_KeyPress);
            // 
            // cvvTextBox
            // 
            this.cvvTextBox.Location = new System.Drawing.Point(113, 144);
            this.cvvTextBox.MaxLength = 4;
            this.cvvTextBox.Name = "cvvTextBox";
            this.cvvTextBox.Size = new System.Drawing.Size(37, 20);
            this.cvvTextBox.TabIndex = 5;
            this.cvvTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cvvTextBox_KeyPress);
            // 
            // clearfieldsButton
            // 
            this.clearfieldsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearfieldsButton.Location = new System.Drawing.Point(324, 51);
            this.clearfieldsButton.Name = "clearfieldsButton";
            this.clearfieldsButton.Size = new System.Drawing.Size(98, 23);
            this.clearfieldsButton.TabIndex = 7;
            this.clearfieldsButton.Text = " C&lear Fields";
            this.clearfieldsButton.UseVisualStyleBackColor = true;
            this.clearfieldsButton.Click += new System.EventHandler(this.clearfieldsButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(18, 26);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Amount:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(18, 86);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(72, 13);
            this.cardNumberLabel.TabIndex = 3;
            this.cardNumberLabel.Text = "Card Number:";
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Location = new System.Drawing.Point(18, 117);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(64, 13);
            this.expiryDateLabel.TabIndex = 3;
            this.expiryDateLabel.Text = "Expiry Date:";
            // 
            // cvvLabel
            // 
            this.cvvLabel.AutoSize = true;
            this.cvvLabel.Location = new System.Drawing.Point(18, 151);
            this.cvvLabel.Name = "cvvLabel";
            this.cvvLabel.Size = new System.Drawing.Size(57, 13);
            this.cvvLabel.TabIndex = 3;
            this.cvvLabel.Text = "CSV/CVV:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(110, 117);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 4;
            this.monthLabel.Text = "Month:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(209, 117);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // processPaymentGroupBox
            // 
            this.processPaymentGroupBox.Controls.Add(this.submitPaymentButton);
            this.processPaymentGroupBox.Controls.Add(this.yearLabel);
            this.processPaymentGroupBox.Controls.Add(this.monthLabel);
            this.processPaymentGroupBox.Controls.Add(this.cvvLabel);
            this.processPaymentGroupBox.Controls.Add(this.expiryDateLabel);
            this.processPaymentGroupBox.Controls.Add(this.cardNumberLabel);
            this.processPaymentGroupBox.Controls.Add(this.nameLabel);
            this.processPaymentGroupBox.Controls.Add(this.amountLabel);
            this.processPaymentGroupBox.Controls.Add(this.clearfieldsButton);
            this.processPaymentGroupBox.Controls.Add(this.cvvTextBox);
            this.processPaymentGroupBox.Controls.Add(this.cardNumberTextBox);
            this.processPaymentGroupBox.Controls.Add(this.nameTextBox);
            this.processPaymentGroupBox.Controls.Add(this.amountTextBox);
            this.processPaymentGroupBox.Controls.Add(this.monthComboBox);
            this.processPaymentGroupBox.Controls.Add(this.yearComboBox);
            this.processPaymentGroupBox.Location = new System.Drawing.Point(12, 27);
            this.processPaymentGroupBox.Name = "processPaymentGroupBox";
            this.processPaymentGroupBox.Size = new System.Drawing.Size(442, 184);
            this.processPaymentGroupBox.TabIndex = 1;
            this.processPaymentGroupBox.TabStop = false;
            this.processPaymentGroupBox.Text = "Process Payment";
            // 
            // submitPaymentButton
            // 
            this.submitPaymentButton.AccessibleName = "";
            this.submitPaymentButton.Location = new System.Drawing.Point(324, 19);
            this.submitPaymentButton.Name = "submitPaymentButton";
            this.submitPaymentButton.Size = new System.Drawing.Size(98, 23);
            this.submitPaymentButton.TabIndex = 6;
            this.submitPaymentButton.Text = "Submit Payment";
            this.submitPaymentButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.submitPaymentButton.UseVisualStyleBackColor = true;
            this.submitPaymentButton.Click += new System.EventHandler(this.submitPaymentButton_Click);
            // 
            // paymentsDataGridView
            // 
            this.paymentsDataGridView.AutoGenerateColumns = false;
            this.paymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.paymentsDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.paymentsDataGridView.DataSource = this.paymentsBindingSource;
            this.paymentsDataGridView.Location = new System.Drawing.Point(12, 217);
            this.paymentsDataGridView.Name = "paymentsDataGridView";
            this.paymentsDataGridView.Size = new System.Drawing.Size(438, 204);
            this.paymentsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaymentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PaymentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PaymentDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "PaymentDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 135;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PaymentStatus";
            this.dataGridViewTextBoxColumn3.HeaderText = "PaymentStatus";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CardType";
            this.dataGridViewTextBoxColumn4.HeaderText = "CardType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NameOnCard";
            this.dataGridViewTextBoxColumn5.HeaderText = "NameOnCard";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LastFourDigits";
            this.dataGridViewTextBoxColumn6.HeaderText = "LastFourDigits";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PaymentAmount";
            this.dataGridViewTextBoxColumn7.HeaderText = "PaymentAmount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "OrderNumber";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TransactionID";
            this.dataGridViewTextBoxColumn9.HeaderText = "TransactionID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // PaymentManager
            // 
            this.AcceptButton = this.submitPaymentButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearfieldsButton;
            this.ClientSize = new System.Drawing.Size(462, 430);
            this.Controls.Add(this.paymentsDataGridView);
            this.Controls.Add(this.processPaymentGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PaymentManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Manager";
            this.Load += new System.EventHandler(this.PaymentManager_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.processPaymentGroupBox.ResumeLayout(false);
            this.processPaymentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private PaymentsDataSet paymentsDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private PaymentsDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private PaymentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox yearComboBox;
        public System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox cvvTextBox;
        private System.Windows.Forms.Button clearfieldsButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.Label cvvLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.GroupBox processPaymentGroupBox;
        private System.Windows.Forms.DataGridView paymentsDataGridView;
        private System.Windows.Forms.Button submitPaymentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

