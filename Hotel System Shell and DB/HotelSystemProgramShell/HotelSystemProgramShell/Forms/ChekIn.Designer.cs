namespace HotelSystemProgramShell
{
    partial class ChekInForm
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
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label customerSurnameLabel;
            System.Windows.Forms.Label customerMiddleNameLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label vIPLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label customerIDTypeLabel;
            System.Windows.Forms.Label customerIDNoLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label preferedLangLabel;
            System.Windows.Forms.Label roomPriceLabel;
            System.Windows.Forms.Label roomNoLabel;
            System.Windows.Forms.Label discountCashLabel;
            System.Windows.Forms.Label discountPercensLabel;
            System.Windows.Forms.Label paidLabel;
            System.Windows.Forms.Label checkInDateTimeLabel;
            System.Windows.Forms.Label checkOutDateTimeLabel;
            System.Windows.Forms.Label travelAgencyLabel;
            System.Windows.Forms.Label specialRequirementsLabel;
            this.hotelDBDataSet = new HotelSystemProgramShell.HotelDBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new HotelSystemProgramShell.HotelDBDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new HotelSystemProgramShell.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.customerMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vIPCheckBox = new System.Windows.Forms.CheckBox();
            this.genderCheckBox = new System.Windows.Forms.CheckBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.customerIDNoTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.preferedLangTextBox = new System.Windows.Forms.TextBox();
            this.guestCardTableAdapter = new HotelSystemProgramShell.HotelDBDataSetTableAdapters.GuestCardTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.guestCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseKeepingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseKeepingTableAdapter = new HotelSystemProgramShell.HotelDBDataSetTableAdapters.HouseKeepingTableAdapter();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new HotelSystemProgramShell.HotelDBDataSetTableAdapters.PaymentsTableAdapter();
            this.roomPriceTextBox = new System.Windows.Forms.TextBox();
            this.roomNoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.discountCashTextBox = new System.Windows.Forms.TextBox();
            this.discountPercensTextBox = new System.Windows.Forms.TextBox();
            this.paidTextBox = new System.Windows.Forms.TextBox();
            this.checkInDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkOutDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.travelAgencyTextBox = new System.Windows.Forms.TextBox();
            this.specialRequirementsTextBox = new System.Windows.Forms.TextBox();
            customerNameLabel = new System.Windows.Forms.Label();
            customerSurnameLabel = new System.Windows.Forms.Label();
            customerMiddleNameLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            vIPLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            customerIDTypeLabel = new System.Windows.Forms.Label();
            customerIDNoLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            preferedLangLabel = new System.Windows.Forms.Label();
            roomPriceLabel = new System.Windows.Forms.Label();
            roomNoLabel = new System.Windows.Forms.Label();
            discountCashLabel = new System.Windows.Forms.Label();
            discountPercensLabel = new System.Windows.Forms.Label();
            paidLabel = new System.Windows.Forms.Label();
            checkInDateTimeLabel = new System.Windows.Forms.Label();
            checkOutDateTimeLabel = new System.Windows.Forms.Label();
            travelAgencyLabel = new System.Windows.Forms.Label();
            specialRequirementsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.GuestCardTableAdapter = this.guestCardTableAdapter;
            this.tableAdapterManager.HouseKeepingTableAdapter = this.houseKeepingTableAdapter;
            this.tableAdapterManager.PaymentsTableAdapter = this.paymentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = HotelSystemProgramShell.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(40, 9);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(85, 13);
            customerNameLabel.TabIndex = 4;
            customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(131, 6);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerNameTextBox.TabIndex = 5;
            // 
            // customerSurnameLabel
            // 
            customerSurnameLabel.AutoSize = true;
            customerSurnameLabel.Location = new System.Drawing.Point(26, 32);
            customerSurnameLabel.Name = "customerSurnameLabel";
            customerSurnameLabel.Size = new System.Drawing.Size(99, 13);
            customerSurnameLabel.TabIndex = 6;
            customerSurnameLabel.Text = "Customer Surname:";
            // 
            // customerSurnameTextBox
            // 
            this.customerSurnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerSurname", true));
            this.customerSurnameTextBox.Location = new System.Drawing.Point(131, 29);
            this.customerSurnameTextBox.Name = "customerSurnameTextBox";
            this.customerSurnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerSurnameTextBox.TabIndex = 7;
            // 
            // customerMiddleNameLabel
            // 
            customerMiddleNameLabel.AutoSize = true;
            customerMiddleNameLabel.Location = new System.Drawing.Point(6, 54);
            customerMiddleNameLabel.Name = "customerMiddleNameLabel";
            customerMiddleNameLabel.Size = new System.Drawing.Size(119, 13);
            customerMiddleNameLabel.TabIndex = 8;
            customerMiddleNameLabel.Text = "Customer Middle Name:";
            // 
            // customerMiddleNameTextBox
            // 
            this.customerMiddleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerMiddleName", true));
            this.customerMiddleNameTextBox.Location = new System.Drawing.Point(131, 51);
            this.customerMiddleNameTextBox.Name = "customerMiddleNameTextBox";
            this.customerMiddleNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerMiddleNameTextBox.TabIndex = 9;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(54, 348);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(71, 13);
            dateOfBirthLabel.TabIndex = 10;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customersBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(131, 344);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 11;
            // 
            // vIPLabel
            // 
            vIPLabel.AutoSize = true;
            vIPLabel.Location = new System.Drawing.Point(151, 78);
            vIPLabel.Name = "vIPLabel";
            vIPLabel.Size = new System.Drawing.Size(27, 13);
            vIPLabel.TabIndex = 12;
            vIPLabel.Text = "VIP:";
            // 
            // vIPCheckBox
            // 
            this.vIPCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customersBindingSource, "VIP", true));
            this.vIPCheckBox.Location = new System.Drawing.Point(184, 73);
            this.vIPCheckBox.Name = "vIPCheckBox";
            this.vIPCheckBox.Size = new System.Drawing.Size(14, 24);
            this.vIPCheckBox.TabIndex = 13;
            this.vIPCheckBox.Text = "checkBox1";
            this.vIPCheckBox.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(80, 78);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 14;
            genderLabel.Text = "Gender:";
            // 
            // genderCheckBox
            // 
            this.genderCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customersBindingSource, "Gender", true));
            this.genderCheckBox.Location = new System.Drawing.Point(131, 73);
            this.genderCheckBox.Name = "genderCheckBox";
            this.genderCheckBox.Size = new System.Drawing.Size(14, 24);
            this.genderCheckBox.TabIndex = 15;
            this.genderCheckBox.Text = "checkBox1";
            this.genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(71, 100);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(54, 13);
            address1Label.TabIndex = 16;
            address1Label.Text = "Address1:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(131, 97);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(200, 20);
            this.address1TextBox.TabIndex = 17;
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(71, 122);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(54, 13);
            address2Label.TabIndex = 18;
            address2Label.Text = "Address2:";
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(131, 119);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(200, 20);
            this.address2TextBox.TabIndex = 19;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(98, 144);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 20;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(131, 141);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 21;
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(81, 167);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(44, 13);
            regionLabel.TabIndex = 22;
            regionLabel.Text = "Region:";
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(131, 164);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(200, 20);
            this.regionTextBox.TabIndex = 23;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(79, 190);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 24;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(131, 187);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryTextBox.TabIndex = 25;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(58, 213);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 26;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(131, 210);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 27;
            // 
            // customerIDTypeLabel
            // 
            customerIDTypeLabel.AutoSize = true;
            customerIDTypeLabel.Location = new System.Drawing.Point(33, 239);
            customerIDTypeLabel.Name = "customerIDTypeLabel";
            customerIDTypeLabel.Size = new System.Drawing.Size(92, 13);
            customerIDTypeLabel.TabIndex = 28;
            customerIDTypeLabel.Text = "Customer IDType:";
            // 
            // customerIDTypeCheckBox
            // 
            this.customerIDTypeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customersBindingSource, "CustomerIDType", true));
            this.customerIDTypeCheckBox.Location = new System.Drawing.Point(131, 234);
            this.customerIDTypeCheckBox.Name = "customerIDTypeCheckBox";
            this.customerIDTypeCheckBox.Size = new System.Drawing.Size(14, 24);
            this.customerIDTypeCheckBox.TabIndex = 29;
            this.customerIDTypeCheckBox.Text = "checkBox1";
            this.customerIDTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerIDNoLabel
            // 
            customerIDNoLabel.AutoSize = true;
            customerIDNoLabel.Location = new System.Drawing.Point(43, 259);
            customerIDNoLabel.Name = "customerIDNoLabel";
            customerIDNoLabel.Size = new System.Drawing.Size(82, 13);
            customerIDNoLabel.TabIndex = 30;
            customerIDNoLabel.Text = "Customer IDNo:";
            // 
            // customerIDNoTextBox
            // 
            this.customerIDNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerIDNo", true));
            this.customerIDNoTextBox.Location = new System.Drawing.Point(131, 256);
            this.customerIDNoTextBox.Name = "customerIDNoTextBox";
            this.customerIDNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerIDNoTextBox.TabIndex = 31;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(84, 281);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 32;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(131, 278);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 33;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(90, 303);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 34;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(131, 300);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 35;
            // 
            // preferedLangLabel
            // 
            preferedLangLabel.AutoSize = true;
            preferedLangLabel.Location = new System.Drawing.Point(48, 325);
            preferedLangLabel.Name = "preferedLangLabel";
            preferedLangLabel.Size = new System.Drawing.Size(77, 13);
            preferedLangLabel.TabIndex = 36;
            preferedLangLabel.Text = "Prefered Lang:";
            // 
            // preferedLangTextBox
            // 
            this.preferedLangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PreferedLang", true));
            this.preferedLangTextBox.Location = new System.Drawing.Point(131, 322);
            this.preferedLangTextBox.Name = "preferedLangTextBox";
            this.preferedLangTextBox.Size = new System.Drawing.Size(100, 20);
            this.preferedLangTextBox.TabIndex = 37;
            // 
            // guestCardTableAdapter
            // 
            this.guestCardTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Save and Chek In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(464, 294);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 21);
            this.cancelButton.TabIndex = 41;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // guestCardBindingSource
            // 
            this.guestCardBindingSource.DataMember = "FK__GuestCard__Guest__182C9B23";
            this.guestCardBindingSource.DataSource = this.customersBindingSource;
            // 
            // houseKeepingBindingSource
            // 
            this.houseKeepingBindingSource.DataMember = "HouseKeeping";
            this.houseKeepingBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // houseKeepingTableAdapter
            // 
            this.houseKeepingTableAdapter.ClearBeforeFill = true;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // roomPriceLabel
            // 
            roomPriceLabel.AutoSize = true;
            roomPriceLabel.Location = new System.Drawing.Point(392, 122);
            roomPriceLabel.Name = "roomPriceLabel";
            roomPriceLabel.Size = new System.Drawing.Size(65, 13);
            roomPriceLabel.TabIndex = 42;
            roomPriceLabel.Text = "Room Price:";
            // 
            // roomPriceTextBox
            // 
            this.roomPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "RoomPrice", true));
            this.roomPriceTextBox.Location = new System.Drawing.Point(463, 119);
            this.roomPriceTextBox.Name = "roomPriceTextBox";
            this.roomPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomPriceTextBox.TabIndex = 43;
            // 
            // roomNoLabel
            // 
            roomNoLabel.AutoSize = true;
            roomNoLabel.Location = new System.Drawing.Point(402, 6);
            roomNoLabel.Name = "roomNoLabel";
            roomNoLabel.Size = new System.Drawing.Size(55, 13);
            roomNoLabel.TabIndex = 43;
            roomNoLabel.Text = "Room No:";
            // 
            // roomNoNumericUpDown
            // 
            this.roomNoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.houseKeepingBindingSource, "RoomNo", true));
            this.roomNoNumericUpDown.Location = new System.Drawing.Point(463, 6);
            this.roomNoNumericUpDown.Name = "roomNoNumericUpDown";
            this.roomNoNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.roomNoNumericUpDown.TabIndex = 44;
            // 
            // discountCashLabel
            // 
            discountCashLabel.AutoSize = true;
            discountCashLabel.Location = new System.Drawing.Point(378, 144);
            discountCashLabel.Name = "discountCashLabel";
            discountCashLabel.Size = new System.Drawing.Size(79, 13);
            discountCashLabel.TabIndex = 44;
            discountCashLabel.Text = "Discount Cash:";
            // 
            // discountCashTextBox
            // 
            this.discountCashTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "DiscountCash", true));
            this.discountCashTextBox.Location = new System.Drawing.Point(463, 141);
            this.discountCashTextBox.Name = "discountCashTextBox";
            this.discountCashTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountCashTextBox.TabIndex = 45;
            // 
            // discountPercensLabel
            // 
            discountPercensLabel.AutoSize = true;
            discountPercensLabel.Location = new System.Drawing.Point(363, 168);
            discountPercensLabel.Name = "discountPercensLabel";
            discountPercensLabel.Size = new System.Drawing.Size(94, 13);
            discountPercensLabel.TabIndex = 45;
            discountPercensLabel.Text = "Discount Percens:";
            // 
            // discountPercensTextBox
            // 
            this.discountPercensTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "DiscountPercens", true));
            this.discountPercensTextBox.Location = new System.Drawing.Point(463, 165);
            this.discountPercensTextBox.Name = "discountPercensTextBox";
            this.discountPercensTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountPercensTextBox.TabIndex = 46;
            // 
            // paidLabel
            // 
            paidLabel.AutoSize = true;
            paidLabel.Location = new System.Drawing.Point(426, 190);
            paidLabel.Name = "paidLabel";
            paidLabel.Size = new System.Drawing.Size(31, 13);
            paidLabel.TabIndex = 46;
            paidLabel.Text = "Paid:";
            // 
            // paidTextBox
            // 
            this.paidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "Paid", true));
            this.paidTextBox.Location = new System.Drawing.Point(463, 187);
            this.paidTextBox.Name = "paidTextBox";
            this.paidTextBox.Size = new System.Drawing.Size(100, 20);
            this.paidTextBox.TabIndex = 47;
            // 
            // checkInDateTimeLabel
            // 
            checkInDateTimeLabel.AutoSize = true;
            checkInDateTimeLabel.Location = new System.Drawing.Point(352, 32);
            checkInDateTimeLabel.Name = "checkInDateTimeLabel";
            checkInDateTimeLabel.Size = new System.Drawing.Size(105, 13);
            checkInDateTimeLabel.TabIndex = 47;
            checkInDateTimeLabel.Text = "Check In Date Time:";
            // 
            // checkInDateTimeDateTimePicker
            // 
            this.checkInDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.guestCardBindingSource, "CheckInDateTime", true));
            this.checkInDateTimeDateTimePicker.Location = new System.Drawing.Point(463, 28);
            this.checkInDateTimeDateTimePicker.Name = "checkInDateTimeDateTimePicker";
            this.checkInDateTimeDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.checkInDateTimeDateTimePicker.TabIndex = 48;
            // 
            // checkOutDateTimeLabel
            // 
            checkOutDateTimeLabel.AutoSize = true;
            checkOutDateTimeLabel.Location = new System.Drawing.Point(344, 54);
            checkOutDateTimeLabel.Name = "checkOutDateTimeLabel";
            checkOutDateTimeLabel.Size = new System.Drawing.Size(113, 13);
            checkOutDateTimeLabel.TabIndex = 48;
            checkOutDateTimeLabel.Text = "Check Out Date Time:";
            // 
            // checkOutDateTimeDateTimePicker
            // 
            this.checkOutDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.guestCardBindingSource, "CheckOutDateTime", true));
            this.checkOutDateTimeDateTimePicker.Location = new System.Drawing.Point(463, 50);
            this.checkOutDateTimeDateTimePicker.Name = "checkOutDateTimeDateTimePicker";
            this.checkOutDateTimeDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.checkOutDateTimeDateTimePicker.TabIndex = 49;
            // 
            // travelAgencyLabel
            // 
            travelAgencyLabel.AutoSize = true;
            travelAgencyLabel.Location = new System.Drawing.Point(378, 78);
            travelAgencyLabel.Name = "travelAgencyLabel";
            travelAgencyLabel.Size = new System.Drawing.Size(79, 13);
            travelAgencyLabel.TabIndex = 50;
            travelAgencyLabel.Text = "Travel Agency:";
            // 
            // travelAgencyTextBox
            // 
            this.travelAgencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestCardBindingSource, "TravelAgency", true));
            this.travelAgencyTextBox.Location = new System.Drawing.Point(463, 75);
            this.travelAgencyTextBox.Name = "travelAgencyTextBox";
            this.travelAgencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.travelAgencyTextBox.TabIndex = 51;
            // 
            // specialRequirementsLabel
            // 
            specialRequirementsLabel.AutoSize = true;
            specialRequirementsLabel.Location = new System.Drawing.Point(344, 100);
            specialRequirementsLabel.Name = "specialRequirementsLabel";
            specialRequirementsLabel.Size = new System.Drawing.Size(113, 13);
            specialRequirementsLabel.TabIndex = 52;
            specialRequirementsLabel.Text = "Special Requirements:";
            // 
            // specialRequirementsTextBox
            // 
            this.specialRequirementsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestCardBindingSource, "SpecialRequirements", true));
            this.specialRequirementsTextBox.Location = new System.Drawing.Point(463, 97);
            this.specialRequirementsTextBox.Name = "specialRequirementsTextBox";
            this.specialRequirementsTextBox.Size = new System.Drawing.Size(139, 20);
            this.specialRequirementsTextBox.TabIndex = 53;
            // 
            // ChekInForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 372);
            this.ControlBox = false;
            this.Controls.Add(specialRequirementsLabel);
            this.Controls.Add(this.specialRequirementsTextBox);
            this.Controls.Add(travelAgencyLabel);
            this.Controls.Add(this.travelAgencyTextBox);
            this.Controls.Add(checkOutDateTimeLabel);
            this.Controls.Add(this.checkOutDateTimeDateTimePicker);
            this.Controls.Add(checkInDateTimeLabel);
            this.Controls.Add(this.checkInDateTimeDateTimePicker);
            this.Controls.Add(paidLabel);
            this.Controls.Add(this.paidTextBox);
            this.Controls.Add(discountPercensLabel);
            this.Controls.Add(this.discountPercensTextBox);
            this.Controls.Add(discountCashLabel);
            this.Controls.Add(this.discountCashTextBox);
            this.Controls.Add(roomNoLabel);
            this.Controls.Add(this.roomNoNumericUpDown);
            this.Controls.Add(roomPriceLabel);
            this.Controls.Add(this.roomPriceTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(preferedLangLabel);
            this.Controls.Add(this.preferedLangTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(customerIDNoLabel);
            this.Controls.Add(this.customerIDNoTextBox);
            this.Controls.Add(customerIDTypeLabel);
            this.Controls.Add(this.customerIDTypeCheckBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderCheckBox);
            this.Controls.Add(vIPLabel);
            this.Controls.Add(this.vIPCheckBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(customerMiddleNameLabel);
            this.Controls.Add(this.customerMiddleNameTextBox);
            this.Controls.Add(customerSurnameLabel);
            this.Controls.Add(this.customerSurnameTextBox);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Name = "ChekInForm";
            this.Text = "Chek In";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private HotelDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HotelDBDataSetTableAdapters.GuestCardTableAdapter guestCardTableAdapter;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerSurnameTextBox;
        private System.Windows.Forms.TextBox customerMiddleNameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.CheckBox vIPCheckBox;
        private System.Windows.Forms.CheckBox genderCheckBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.CheckBox customerIDTypeCheckBox;
        private System.Windows.Forms.TextBox customerIDNoTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox preferedLangTextBox;
        private System.Windows.Forms.BindingSource guestCardBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelButton;
        private HotelDBDataSetTableAdapters.HouseKeepingTableAdapter houseKeepingTableAdapter;
        private System.Windows.Forms.BindingSource houseKeepingBindingSource;
        private HotelDBDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private System.Windows.Forms.TextBox roomPriceTextBox;
        private System.Windows.Forms.NumericUpDown roomNoNumericUpDown;
        private System.Windows.Forms.TextBox discountCashTextBox;
        private System.Windows.Forms.TextBox discountPercensTextBox;
        private System.Windows.Forms.TextBox paidTextBox;
        private System.Windows.Forms.DateTimePicker checkInDateTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker checkOutDateTimeDateTimePicker;
        private System.Windows.Forms.TextBox travelAgencyTextBox;
        private System.Windows.Forms.TextBox specialRequirementsTextBox;
    }
}