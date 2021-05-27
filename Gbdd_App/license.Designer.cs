namespace Gbdd_App
{
    partial class license
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
            System.Windows.Forms.Label gUIDLabel;
            System.Windows.Forms.Label licenceDateLabel;
            System.Windows.Forms.Label expireDateLabel;
            System.Windows.Forms.Label categoriesLabel;
            System.Windows.Forms.Label licenceSeriesLabel;
            System.Windows.Forms.Label licenceNumberLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label vINLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label engineTypeLabel;
            System.Windows.Forms.Label typeOfDriveLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(license));
            this.databaseDriverDataSet = new Gbdd_App.DatabaseDriverDataSet();
            this.licensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licensesTableAdapter = new Gbdd_App.DatabaseDriverDataSetTableAdapters.licensesTableAdapter();
            this.tableAdapterManager = new Gbdd_App.DatabaseDriverDataSetTableAdapters.TableAdapterManager();
            this.licensesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.licensesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gUIDTextBox = new System.Windows.Forms.TextBox();
            this.licenceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriesTextBox = new System.Windows.Forms.TextBox();
            this.licenceSeriesTextBox = new System.Windows.Forms.TextBox();
            this.licenceNumberTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.vINTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.engineTypeTextBox = new System.Windows.Forms.TextBox();
            this.typeOfDriveTextBox = new System.Windows.Forms.TextBox();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new Gbdd_App.DatabaseDriverDataSetTableAdapters.DriverTableAdapter();
            this.Driverbtn = new System.Windows.Forms.Button();
            gUIDLabel = new System.Windows.Forms.Label();
            licenceDateLabel = new System.Windows.Forms.Label();
            expireDateLabel = new System.Windows.Forms.Label();
            categoriesLabel = new System.Windows.Forms.Label();
            licenceSeriesLabel = new System.Windows.Forms.Label();
            licenceNumberLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            vINLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            engineTypeLabel = new System.Windows.Forms.Label();
            typeOfDriveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDriverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensesBindingNavigator)).BeginInit();
            this.licensesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gUIDLabel
            // 
            gUIDLabel.AutoSize = true;
            gUIDLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            gUIDLabel.Location = new System.Drawing.Point(22, 42);
            gUIDLabel.Name = "gUIDLabel";
            gUIDLabel.Size = new System.Drawing.Size(34, 14);
            gUIDLabel.TabIndex = 1;
            gUIDLabel.Text = "GUID:";
            // 
            // licenceDateLabel
            // 
            licenceDateLabel.AutoSize = true;
            licenceDateLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            licenceDateLabel.Location = new System.Drawing.Point(22, 69);
            licenceDateLabel.Name = "licenceDateLabel";
            licenceDateLabel.Size = new System.Drawing.Size(73, 14);
            licenceDateLabel.TabIndex = 3;
            licenceDateLabel.Text = "Licence Date:";
            // 
            // expireDateLabel
            // 
            expireDateLabel.AutoSize = true;
            expireDateLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            expireDateLabel.Location = new System.Drawing.Point(22, 95);
            expireDateLabel.Name = "expireDateLabel";
            expireDateLabel.Size = new System.Drawing.Size(65, 14);
            expireDateLabel.TabIndex = 5;
            expireDateLabel.Text = "Expire Date:";
            // 
            // categoriesLabel
            // 
            categoriesLabel.AutoSize = true;
            categoriesLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            categoriesLabel.Location = new System.Drawing.Point(22, 120);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new System.Drawing.Size(62, 14);
            categoriesLabel.TabIndex = 7;
            categoriesLabel.Text = "Categories:";
            // 
            // licenceSeriesLabel
            // 
            licenceSeriesLabel.AutoSize = true;
            licenceSeriesLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            licenceSeriesLabel.Location = new System.Drawing.Point(22, 146);
            licenceSeriesLabel.Name = "licenceSeriesLabel";
            licenceSeriesLabel.Size = new System.Drawing.Size(82, 14);
            licenceSeriesLabel.TabIndex = 9;
            licenceSeriesLabel.Text = "Licence Series:";
            // 
            // licenceNumberLabel
            // 
            licenceNumberLabel.AutoSize = true;
            licenceNumberLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            licenceNumberLabel.Location = new System.Drawing.Point(22, 172);
            licenceNumberLabel.Name = "licenceNumberLabel";
            licenceNumberLabel.Size = new System.Drawing.Size(88, 14);
            licenceNumberLabel.TabIndex = 11;
            licenceNumberLabel.Text = "Licence Number:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            statusLabel.Location = new System.Drawing.Point(22, 198);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(41, 14);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "Status:";
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            vINLabel.Location = new System.Drawing.Point(22, 224);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(27, 14);
            vINLabel.TabIndex = 15;
            vINLabel.Text = "VIN:";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            manufacturerLabel.Location = new System.Drawing.Point(22, 250);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(75, 14);
            manufacturerLabel.TabIndex = 17;
            manufacturerLabel.Text = "Manufacturer:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            modelLabel.Location = new System.Drawing.Point(22, 276);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(38, 14);
            modelLabel.TabIndex = 19;
            modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            yearLabel.Location = new System.Drawing.Point(22, 303);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(33, 14);
            yearLabel.TabIndex = 21;
            yearLabel.Text = "Year:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            weightLabel.Location = new System.Drawing.Point(22, 328);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(43, 14);
            weightLabel.TabIndex = 23;
            weightLabel.Text = "Weight:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            colorLabel.Location = new System.Drawing.Point(22, 354);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(35, 14);
            colorLabel.TabIndex = 25;
            colorLabel.Text = "Color:";
            // 
            // engineTypeLabel
            // 
            engineTypeLabel.AutoSize = true;
            engineTypeLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            engineTypeLabel.Location = new System.Drawing.Point(22, 380);
            engineTypeLabel.Name = "engineTypeLabel";
            engineTypeLabel.Size = new System.Drawing.Size(68, 14);
            engineTypeLabel.TabIndex = 27;
            engineTypeLabel.Text = "Engine Type:";
            // 
            // typeOfDriveLabel
            // 
            typeOfDriveLabel.AutoSize = true;
            typeOfDriveLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            typeOfDriveLabel.Location = new System.Drawing.Point(22, 406);
            typeOfDriveLabel.Name = "typeOfDriveLabel";
            typeOfDriveLabel.Size = new System.Drawing.Size(76, 14);
            typeOfDriveLabel.TabIndex = 29;
            typeOfDriveLabel.Text = "Type Of Drive:";
            // 
            // databaseDriverDataSet
            // 
            this.databaseDriverDataSet.DataSetName = "DatabaseDriverDataSet";
            this.databaseDriverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // licensesBindingSource
            // 
            this.licensesBindingSource.DataMember = "licenses";
            this.licensesBindingSource.DataSource = this.databaseDriverDataSet;
            // 
            // licensesTableAdapter
            // 
            this.licensesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.licensesTableAdapter = this.licensesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gbdd_App.DatabaseDriverDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // licensesBindingNavigator
            // 
            this.licensesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.licensesBindingNavigator.BindingSource = this.licensesBindingSource;
            this.licensesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.licensesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.licensesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.licensesBindingNavigatorSaveItem});
            this.licensesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.licensesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.licensesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.licensesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.licensesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.licensesBindingNavigator.Name = "licensesBindingNavigator";
            this.licensesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.licensesBindingNavigator.Size = new System.Drawing.Size(502, 25);
            this.licensesBindingNavigator.TabIndex = 0;
            this.licensesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // licensesBindingNavigatorSaveItem
            // 
            this.licensesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.licensesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("licensesBindingNavigatorSaveItem.Image")));
            this.licensesBindingNavigatorSaveItem.Name = "licensesBindingNavigatorSaveItem";
            this.licensesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.licensesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.licensesBindingNavigatorSaveItem.Click += new System.EventHandler(this.licensesBindingNavigatorSaveItem_Click);
            // 
            // gUIDTextBox
            // 
            this.gUIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "GUID", true));
            this.gUIDTextBox.Location = new System.Drawing.Point(116, 39);
            this.gUIDTextBox.Name = "gUIDTextBox";
            this.gUIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.gUIDTextBox.TabIndex = 2;
            // 
            // licenceDateDateTimePicker
            // 
            this.licenceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.licensesBindingSource, "LicenceDate", true));
            this.licenceDateDateTimePicker.Location = new System.Drawing.Point(116, 65);
            this.licenceDateDateTimePicker.Name = "licenceDateDateTimePicker";
            this.licenceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.licenceDateDateTimePicker.TabIndex = 4;
            // 
            // expireDateDateTimePicker
            // 
            this.expireDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.licensesBindingSource, "ExpireDate", true));
            this.expireDateDateTimePicker.Location = new System.Drawing.Point(116, 91);
            this.expireDateDateTimePicker.Name = "expireDateDateTimePicker";
            this.expireDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expireDateDateTimePicker.TabIndex = 6;
            // 
            // categoriesTextBox
            // 
            this.categoriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "Categories", true));
            this.categoriesTextBox.Location = new System.Drawing.Point(116, 117);
            this.categoriesTextBox.Name = "categoriesTextBox";
            this.categoriesTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoriesTextBox.TabIndex = 8;
            // 
            // licenceSeriesTextBox
            // 
            this.licenceSeriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "LicenceSeries", true));
            this.licenceSeriesTextBox.Location = new System.Drawing.Point(116, 143);
            this.licenceSeriesTextBox.Name = "licenceSeriesTextBox";
            this.licenceSeriesTextBox.Size = new System.Drawing.Size(200, 20);
            this.licenceSeriesTextBox.TabIndex = 10;
            // 
            // licenceNumberTextBox
            // 
            this.licenceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "LicenceNumber", true));
            this.licenceNumberTextBox.Location = new System.Drawing.Point(116, 169);
            this.licenceNumberTextBox.Name = "licenceNumberTextBox";
            this.licenceNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.licenceNumberTextBox.TabIndex = 12;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(116, 195);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 14;
            // 
            // vINTextBox
            // 
            this.vINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "VIN", true));
            this.vINTextBox.Location = new System.Drawing.Point(116, 221);
            this.vINTextBox.Name = "vINTextBox";
            this.vINTextBox.Size = new System.Drawing.Size(200, 20);
            this.vINTextBox.TabIndex = 16;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "Manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(116, 247);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(200, 20);
            this.manufacturerTextBox.TabIndex = 18;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(116, 273);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 20);
            this.modelTextBox.TabIndex = 20;
            // 
            // yearDateTimePicker
            // 
            this.yearDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.licensesBindingSource, "Year", true));
            this.yearDateTimePicker.Location = new System.Drawing.Point(116, 299);
            this.yearDateTimePicker.Name = "yearDateTimePicker";
            this.yearDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.yearDateTimePicker.TabIndex = 22;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(116, 325);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(200, 20);
            this.weightTextBox.TabIndex = 24;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(116, 351);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(200, 20);
            this.colorTextBox.TabIndex = 26;
            // 
            // engineTypeTextBox
            // 
            this.engineTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "EngineType", true));
            this.engineTypeTextBox.Location = new System.Drawing.Point(116, 377);
            this.engineTypeTextBox.Name = "engineTypeTextBox";
            this.engineTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.engineTypeTextBox.TabIndex = 28;
            // 
            // typeOfDriveTextBox
            // 
            this.typeOfDriveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licensesBindingSource, "TypeOfDrive", true));
            this.typeOfDriveTextBox.Location = new System.Drawing.Point(116, 403);
            this.typeOfDriveTextBox.Name = "typeOfDriveTextBox";
            this.typeOfDriveTextBox.Size = new System.Drawing.Size(200, 20);
            this.typeOfDriveTextBox.TabIndex = 30;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.databaseDriverDataSet;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // Driverbtn
            // 
            this.Driverbtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Driverbtn.Location = new System.Drawing.Point(358, 390);
            this.Driverbtn.Name = "Driverbtn";
            this.Driverbtn.Size = new System.Drawing.Size(112, 26);
            this.Driverbtn.TabIndex = 31;
            this.Driverbtn.Text = "BackToDriver";
            this.Driverbtn.UseVisualStyleBackColor = true;
            this.Driverbtn.Click += new System.EventHandler(this.Driverbtn_Click);
            // 
            // license
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 428);
            this.Controls.Add(this.Driverbtn);
            this.Controls.Add(gUIDLabel);
            this.Controls.Add(this.gUIDTextBox);
            this.Controls.Add(licenceDateLabel);
            this.Controls.Add(this.licenceDateDateTimePicker);
            this.Controls.Add(expireDateLabel);
            this.Controls.Add(this.expireDateDateTimePicker);
            this.Controls.Add(categoriesLabel);
            this.Controls.Add(this.categoriesTextBox);
            this.Controls.Add(licenceSeriesLabel);
            this.Controls.Add(this.licenceSeriesTextBox);
            this.Controls.Add(licenceNumberLabel);
            this.Controls.Add(this.licenceNumberTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(vINLabel);
            this.Controls.Add(this.vINTextBox);
            this.Controls.Add(manufacturerLabel);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearDateTimePicker);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(engineTypeLabel);
            this.Controls.Add(this.engineTypeTextBox);
            this.Controls.Add(typeOfDriveLabel);
            this.Controls.Add(this.typeOfDriveTextBox);
            this.Controls.Add(this.licensesBindingNavigator);
            this.Name = "license";
            this.Text = "License";
            this.Load += new System.EventHandler(this.j_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDriverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensesBindingNavigator)).EndInit();
            this.licensesBindingNavigator.ResumeLayout(false);
            this.licensesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDriverDataSet databaseDriverDataSet;
        private System.Windows.Forms.BindingSource licensesBindingSource;
        private DatabaseDriverDataSetTableAdapters.licensesTableAdapter licensesTableAdapter;
        private DatabaseDriverDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator licensesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton licensesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gUIDTextBox;
        private System.Windows.Forms.DateTimePicker licenceDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker expireDateDateTimePicker;
        private System.Windows.Forms.TextBox categoriesTextBox;
        private System.Windows.Forms.TextBox licenceSeriesTextBox;
        private System.Windows.Forms.TextBox licenceNumberTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox vINTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.DateTimePicker yearDateTimePicker;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox engineTypeTextBox;
        private System.Windows.Forms.TextBox typeOfDriveTextBox;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private DatabaseDriverDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.Button Driverbtn;
    }
}