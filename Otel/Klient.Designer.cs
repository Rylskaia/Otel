namespace Otel
{
    partial class Klient
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klient));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаселенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.завтракDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бронирование_номеровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._907ca_RylskayaDataSet3 = new Otel._907ca_RylskayaDataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new Otel._907ca_RylskayaDataSet3TableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new Otel._907ca_RylskayaDataSet3TableAdapters.TableAdapterManager();
            this.бронирование_номеровTableAdapter = new Otel._907ca_RylskayaDataSet3TableAdapters.Бронирование_номеровTableAdapter();
            this.клиентBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.клиентBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.klientFillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.klientFillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zakazFillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.zakazFillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            фИОLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронирование_номеровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._907ca_RylskayaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingNavigator)).BeginInit();
            this.клиентBindingNavigator.SuspendLayout();
            this.klientFillByToolStrip.SuspendLayout();
            this.zakazFillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.BackColor = System.Drawing.Color.Transparent;
            фИОLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.ForeColor = System.Drawing.Color.White;
            фИОLabel.Location = new System.Drawing.Point(45, 97);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(54, 20);
            фИОLabel.TabIndex = 5;
            фИОLabel.Text = "ФИО:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.BackColor = System.Drawing.Color.Transparent;
            адресLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel.ForeColor = System.Drawing.Color.White;
            адресLabel.Location = new System.Drawing.Point(32, 128);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(67, 20);
            адресLabel.TabIndex = 7;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.BackColor = System.Drawing.Color.Transparent;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.ForeColor = System.Drawing.Color.White;
            телефонLabel.Location = new System.Drawing.Point(9, 156);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(90, 20);
            телефонLabel.TabIndex = 9;
            телефонLabel.Text = "Телефон:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.BackColor = System.Drawing.Color.Transparent;
            логинLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            логинLabel.ForeColor = System.Drawing.Color.White;
            логинLabel.Location = new System.Drawing.Point(35, 184);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(64, 20);
            логинLabel.TabIndex = 11;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.BackColor = System.Drawing.Color.Transparent;
            парольLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            парольLabel.ForeColor = System.Drawing.Color.White;
            парольLabel.Location = new System.Drawing.Point(25, 218);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(77, 20);
            парольLabel.TabIndex = 13;
            парольLabel.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Личный кабинет";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(29, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Просмотр свободных номеров";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.датаЗаселенияDataGridViewTextBoxColumn,
            this.завтракDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.бронирование_номеровBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(265, 256);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(425, 155);
            this.dataGridView2.TabIndex = 3;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            this.номерDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЗаселенияDataGridViewTextBoxColumn
            // 
            this.датаЗаселенияDataGridViewTextBoxColumn.DataPropertyName = "Дата заселения";
            this.датаЗаселенияDataGridViewTextBoxColumn.HeaderText = "Дата заселения";
            this.датаЗаселенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗаселенияDataGridViewTextBoxColumn.Name = "датаЗаселенияDataGridViewTextBoxColumn";
            this.датаЗаселенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // завтракDataGridViewTextBoxColumn
            // 
            this.завтракDataGridViewTextBoxColumn.DataPropertyName = "Завтрак";
            this.завтракDataGridViewTextBoxColumn.HeaderText = "Завтрак";
            this.завтракDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.завтракDataGridViewTextBoxColumn.Name = "завтракDataGridViewTextBoxColumn";
            this.завтракDataGridViewTextBoxColumn.Width = 125;
            // 
            // бронирование_номеровBindingSource
            // 
            this.бронирование_номеровBindingSource.DataMember = "Бронирование номеров";
            this.бронирование_номеровBindingSource.DataSource = this._907ca_RylskayaDataSet3;
            // 
            // _907ca_RylskayaDataSet3
            // 
            this._907ca_RylskayaDataSet3.DataSetName = "_907ca_RylskayaDataSet3";
            this._907ca_RylskayaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Мои бронирования";
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this._907ca_RylskayaDataSet3;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Otel._907ca_RylskayaDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Бронирование_номеровTableAdapter = this.бронирование_номеровTableAdapter;
            this.tableAdapterManager.ИспользованиеTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.НомерTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Тип_номераTableAdapter = null;
            // 
            // бронирование_номеровTableAdapter
            // 
            this.бронирование_номеровTableAdapter.ClearBeforeFill = true;
            // 
            // клиентBindingNavigator
            // 
            this.клиентBindingNavigator.AddNewItem = null;
            this.клиентBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.клиентBindingNavigator.BindingSource = this.клиентBindingSource;
            this.клиентBindingNavigator.CountItem = null;
            this.клиентBindingNavigator.DeleteItem = null;
            this.клиентBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.клиентBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.клиентBindingNavigatorSaveItem});
            this.клиентBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клиентBindingNavigator.MoveFirstItem = null;
            this.клиентBindingNavigator.MoveLastItem = null;
            this.клиентBindingNavigator.MoveNextItem = null;
            this.клиентBindingNavigator.MovePreviousItem = null;
            this.клиентBindingNavigator.Name = "клиентBindingNavigator";
            this.клиентBindingNavigator.PositionItem = null;
            this.клиентBindingNavigator.Size = new System.Drawing.Size(767, 27);
            this.клиентBindingNavigator.TabIndex = 5;
            this.клиентBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 24);
            this.toolStripButton1.Text = "Назад";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // клиентBindingNavigatorSaveItem
            // 
            this.клиентBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиентBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиентBindingNavigatorSaveItem.Image")));
            this.клиентBindingNavigatorSaveItem.Name = "клиентBindingNavigatorSaveItem";
            this.клиентBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.клиентBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клиентBindingNavigatorSaveItem.Click += new System.EventHandler(this.клиентBindingNavigatorSaveItem_Click);
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(105, 97);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(194, 22);
            this.фИОTextBox.TabIndex = 6;
            this.фИОTextBox.TextChanged += new System.EventHandler(this.фИОTextBox_TextChanged);
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(105, 126);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(194, 22);
            this.адресTextBox.TabIndex = 8;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(105, 156);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(194, 22);
            this.телефонTextBox.TabIndex = 10;
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(105, 184);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(130, 22);
            this.логинTextBox.TabIndex = 12;
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(105, 218);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(130, 22);
            this.парольTextBox.TabIndex = 14;
            // 
            // klientFillByToolStrip
            // 
            this.klientFillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.klientFillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klientFillByToolStripButton});
            this.klientFillByToolStrip.Location = new System.Drawing.Point(0, 27);
            this.klientFillByToolStrip.Name = "klientFillByToolStrip";
            this.klientFillByToolStrip.Size = new System.Drawing.Size(842, 27);
            this.klientFillByToolStrip.TabIndex = 15;
            this.klientFillByToolStrip.Text = "klientFillByToolStrip";
            this.klientFillByToolStrip.Visible = false;
            // 
            // klientFillByToolStripButton
            // 
            this.klientFillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.klientFillByToolStripButton.Name = "klientFillByToolStripButton";
            this.klientFillByToolStripButton.Size = new System.Drawing.Size(86, 24);
            this.klientFillByToolStripButton.Text = "KlientFillBy";
            this.klientFillByToolStripButton.Click += new System.EventHandler(this.klientFillByToolStripButton_Click);
            // 
            // zakazFillByToolStrip
            // 
            this.zakazFillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.zakazFillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.zakazFillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakazFillByToolStripButton});
            this.zakazFillByToolStrip.Location = new System.Drawing.Point(0, 27);
            this.zakazFillByToolStrip.Name = "zakazFillByToolStrip";
            this.zakazFillByToolStrip.Size = new System.Drawing.Size(767, 27);
            this.zakazFillByToolStrip.TabIndex = 16;
            this.zakazFillByToolStrip.Text = "zakazFillByToolStrip";
            this.zakazFillByToolStrip.Visible = false;
            // 
            // zakazFillByToolStripButton
            // 
            this.zakazFillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zakazFillByToolStripButton.Name = "zakazFillByToolStripButton";
            this.zakazFillByToolStripButton.Size = new System.Drawing.Size(87, 24);
            this.zakazFillByToolStripButton.Text = "ZakazFillBy";
            this.zakazFillByToolStripButton.Click += new System.EventHandler(this.zakazFillByToolStripButton_Click);
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 431);
            this.Controls.Add(this.zakazFillByToolStrip);
            this.Controls.Add(this.klientFillByToolStrip);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.клиентBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Klient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.Klient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронирование_номеровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._907ca_RylskayaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingNavigator)).EndInit();
            this.клиентBindingNavigator.ResumeLayout(false);
            this.клиентBindingNavigator.PerformLayout();
            this.klientFillByToolStrip.ResumeLayout(false);
            this.klientFillByToolStrip.PerformLayout();
            this.zakazFillByToolStrip.ResumeLayout(false);
            this.zakazFillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private _907ca_RylskayaDataSet3 _907ca_RylskayaDataSet3;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private _907ca_RylskayaDataSet3TableAdapters.КлиентTableAdapter клиентTableAdapter;
        private _907ca_RylskayaDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиентBindingNavigator;
        private System.Windows.Forms.ToolStripButton клиентBindingNavigatorSaveItem;
        private _907ca_RylskayaDataSet3TableAdapters.Бронирование_номеровTableAdapter бронирование_номеровTableAdapter;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.BindingSource бронирование_номеровBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаселенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоДнейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn завтракDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip klientFillByToolStrip;
        private System.Windows.Forms.ToolStripButton klientFillByToolStripButton;
        private System.Windows.Forms.ToolStrip zakazFillByToolStrip;
        private System.Windows.Forms.ToolStripButton zakazFillByToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}