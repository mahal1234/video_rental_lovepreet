namespace video_rental_lovepreet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblRental = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtVideoCost = new System.Windows.Forms.TextBox();
            this.txtVideoRatting = new System.Windows.Forms.TextBox();
            this.txtVideoYear = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerMObile = new System.Windows.Forms.TextBox();
            this.txtVideoTitle = new System.Windows.Forms.TextBox();
            this.TxtRentId = new System.Windows.Forms.TextBox();
            this.txtVideoGenre = new System.Windows.Forms.TextBox();
            this.txtVideoPlot = new System.Windows.Forms.TextBox();
            this.txtVideoCopies = new System.Windows.Forms.TextBox();
            this.TxtCustomerId = new System.Windows.Forms.TextBox();
            this.TxtVideoId = new System.Windows.Forms.TextBox();
            this.dtpBooking = new System.Windows.Forms.DateTimePicker();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCustomerSAve = new System.Windows.Forms.Button();
            this.btnRentalBooking = new System.Windows.Forms.Button();
            this.btnVideoSAve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostCustomer = new System.Windows.Forms.Button();
            this.btnMostMovie = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDElete = new System.Windows.Forms.Button();
            this.btnVideoUpdate = new System.Windows.Forms.Button();
            this.btnVideoDelete = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRentalReturn = new System.Windows.Forms.Button();
            this.btnRentalDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(23, 171);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(344, 36);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Enter Customer Details";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental.Location = new System.Drawing.Point(789, 171);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(190, 32);
            this.lblRental.TabIndex = 1;
            this.lblRental.Text = "Rental Details";
            this.lblRental.Click += new System.EventHandler(this.lblRental_Click);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(413, 171);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(289, 36);
            this.lblVideo.TabIndex = 2;
            this.lblVideo.Text = "Enter Video Details";
            this.lblVideo.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(182, 252);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(140, 31);
            this.txtCustomerName.TabIndex = 3;
            // 
            // txtVideoCost
            // 
            this.txtVideoCost.Enabled = false;
            this.txtVideoCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoCost.Location = new System.Drawing.Point(562, 376);
            this.txtVideoCost.Name = "txtVideoCost";
            this.txtVideoCost.Size = new System.Drawing.Size(140, 31);
            this.txtVideoCost.TabIndex = 4;
            // 
            // txtVideoRatting
            // 
            this.txtVideoRatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoRatting.Location = new System.Drawing.Point(562, 282);
            this.txtVideoRatting.Name = "txtVideoRatting";
            this.txtVideoRatting.Size = new System.Drawing.Size(140, 31);
            this.txtVideoRatting.TabIndex = 5;
            // 
            // txtVideoYear
            // 
            this.txtVideoYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoYear.Location = new System.Drawing.Point(562, 334);
            this.txtVideoYear.Name = "txtVideoYear";
            this.txtVideoYear.Size = new System.Drawing.Size(140, 31);
            this.txtVideoYear.TabIndex = 6;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(182, 376);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(140, 31);
            this.txtCustomerAddress.TabIndex = 7;
            // 
            // txtCustomerMObile
            // 
            this.txtCustomerMObile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerMObile.Location = new System.Drawing.Point(182, 313);
            this.txtCustomerMObile.Name = "txtCustomerMObile";
            this.txtCustomerMObile.Size = new System.Drawing.Size(140, 31);
            this.txtCustomerMObile.TabIndex = 8;
            // 
            // txtVideoTitle
            // 
            this.txtVideoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoTitle.Location = new System.Drawing.Point(562, 225);
            this.txtVideoTitle.Name = "txtVideoTitle";
            this.txtVideoTitle.Size = new System.Drawing.Size(140, 31);
            this.txtVideoTitle.TabIndex = 9;
            // 
            // TxtRentId
            // 
            this.TxtRentId.Enabled = false;
            this.TxtRentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRentId.Location = new System.Drawing.Point(888, 225);
            this.TxtRentId.Name = "TxtRentId";
            this.TxtRentId.Size = new System.Drawing.Size(140, 31);
            this.TxtRentId.TabIndex = 10;
            // 
            // txtVideoGenre
            // 
            this.txtVideoGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoGenre.Location = new System.Drawing.Point(562, 497);
            this.txtVideoGenre.Name = "txtVideoGenre";
            this.txtVideoGenre.Size = new System.Drawing.Size(140, 31);
            this.txtVideoGenre.TabIndex = 11;
            // 
            // txtVideoPlot
            // 
            this.txtVideoPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoPlot.Location = new System.Drawing.Point(562, 460);
            this.txtVideoPlot.Name = "txtVideoPlot";
            this.txtVideoPlot.Size = new System.Drawing.Size(140, 31);
            this.txtVideoPlot.TabIndex = 12;
            // 
            // txtVideoCopies
            // 
            this.txtVideoCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoCopies.Location = new System.Drawing.Point(562, 423);
            this.txtVideoCopies.Name = "txtVideoCopies";
            this.txtVideoCopies.Size = new System.Drawing.Size(140, 31);
            this.txtVideoCopies.TabIndex = 13;
            // 
            // TxtCustomerId
            // 
            this.TxtCustomerId.Enabled = false;
            this.TxtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerId.Location = new System.Drawing.Point(888, 283);
            this.TxtCustomerId.Name = "TxtCustomerId";
            this.TxtCustomerId.Size = new System.Drawing.Size(140, 31);
            this.TxtCustomerId.TabIndex = 14;
            // 
            // TxtVideoId
            // 
            this.TxtVideoId.Enabled = false;
            this.TxtVideoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVideoId.Location = new System.Drawing.Point(888, 334);
            this.TxtVideoId.Name = "TxtVideoId";
            this.TxtVideoId.Size = new System.Drawing.Size(140, 31);
            this.TxtVideoId.TabIndex = 15;
            // 
            // dtpBooking
            // 
            this.dtpBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBooking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBooking.Location = new System.Drawing.Point(888, 382);
            this.dtpBooking.Name = "dtpBooking";
            this.dtpBooking.Size = new System.Drawing.Size(140, 26);
            this.dtpBooking.TabIndex = 16;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(888, 423);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(140, 26);
            this.dtpReturn.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mobile No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Copies";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(389, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Plot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Genre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(389, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ratting";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(389, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Year";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(389, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Title";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(721, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(721, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 21);
            this.label15.TabIndex = 29;
            this.label15.Text = "Customer ID";
            // 
            // btnCustomerSAve
            // 
            this.btnCustomerSAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSAve.Location = new System.Drawing.Point(12, 410);
            this.btnCustomerSAve.Name = "btnCustomerSAve";
            this.btnCustomerSAve.Size = new System.Drawing.Size(80, 33);
            this.btnCustomerSAve.TabIndex = 30;
            this.btnCustomerSAve.Text = "Save Data";
            this.btnCustomerSAve.UseVisualStyleBackColor = true;
            this.btnCustomerSAve.Click += new System.EventHandler(this.btnCustomerSAve_Click);
            // 
            // btnRentalBooking
            // 
            this.btnRentalBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalBooking.Location = new System.Drawing.Point(725, 460);
            this.btnRentalBooking.Name = "btnRentalBooking";
            this.btnRentalBooking.Size = new System.Drawing.Size(81, 31);
            this.btnRentalBooking.TabIndex = 31;
            this.btnRentalBooking.Text = "Book";
            this.btnRentalBooking.UseVisualStyleBackColor = true;
            this.btnRentalBooking.Click += new System.EventHandler(this.btnRentalBooking_Click);
            // 
            // btnVideoSAve
            // 
            this.btnVideoSAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoSAve.Location = new System.Drawing.Point(354, 534);
            this.btnVideoSAve.Name = "btnVideoSAve";
            this.btnVideoSAve.Size = new System.Drawing.Size(74, 36);
            this.btnVideoSAve.TabIndex = 32;
            this.btnVideoSAve.Text = "Save Data";
            this.btnVideoSAve.UseVisualStyleBackColor = true;
            this.btnVideoSAve.Click += new System.EventHandler(this.btnVideoSAve_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 150);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnMostCustomer
            // 
            this.btnMostCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostCustomer.Location = new System.Drawing.Point(31, 534);
            this.btnMostCustomer.Name = "btnMostCustomer";
            this.btnMostCustomer.Size = new System.Drawing.Size(291, 45);
            this.btnMostCustomer.TabIndex = 34;
            this.btnMostCustomer.Text = "Good customer";
            this.btnMostCustomer.UseVisualStyleBackColor = true;
            this.btnMostCustomer.Click += new System.EventHandler(this.btnMostCustomer_Click);
            // 
            // btnMostMovie
            // 
            this.btnMostMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostMovie.Location = new System.Drawing.Point(29, 483);
            this.btnMostMovie.Name = "btnMostMovie";
            this.btnMostMovie.Size = new System.Drawing.Size(293, 45);
            this.btnMostMovie.TabIndex = 35;
            this.btnMostMovie.Text = "Most Popular Movie";
            this.btnMostMovie.UseVisualStyleBackColor = true;
            this.btnMostMovie.Click += new System.EventHandler(this.btnMostMovie_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerUpdate.Location = new System.Drawing.Point(115, 413);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(102, 33);
            this.btnCustomerUpdate.TabIndex = 36;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDElete
            // 
            this.btnCustomerDElete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDElete.Location = new System.Drawing.Point(223, 411);
            this.btnCustomerDElete.Name = "btnCustomerDElete";
            this.btnCustomerDElete.Size = new System.Drawing.Size(99, 33);
            this.btnCustomerDElete.TabIndex = 37;
            this.btnCustomerDElete.Text = "Delete";
            this.btnCustomerDElete.UseVisualStyleBackColor = true;
            this.btnCustomerDElete.Click += new System.EventHandler(this.btnCustomerDElete_Click);
            // 
            // btnVideoUpdate
            // 
            this.btnVideoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoUpdate.Location = new System.Drawing.Point(462, 534);
            this.btnVideoUpdate.Name = "btnVideoUpdate";
            this.btnVideoUpdate.Size = new System.Drawing.Size(95, 36);
            this.btnVideoUpdate.TabIndex = 38;
            this.btnVideoUpdate.Text = "Update";
            this.btnVideoUpdate.UseVisualStyleBackColor = true;
            this.btnVideoUpdate.Click += new System.EventHandler(this.btnVideoUpdate_Click);
            // 
            // btnVideoDelete
            // 
            this.btnVideoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoDelete.Location = new System.Drawing.Point(607, 534);
            this.btnVideoDelete.Name = "btnVideoDelete";
            this.btnVideoDelete.Size = new System.Drawing.Size(95, 36);
            this.btnVideoDelete.TabIndex = 39;
            this.btnVideoDelete.Text = "Delete";
            this.btnVideoDelete.UseVisualStyleBackColor = true;
            this.btnVideoDelete.Click += new System.EventHandler(this.btnVideoDelete_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(721, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 21);
            this.label16.TabIndex = 40;
            this.label16.Text = "Video ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(721, 387);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 21);
            this.label17.TabIndex = 41;
            this.label17.Text = "Booking Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(721, 426);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 21);
            this.label18.TabIndex = 42;
            this.label18.Text = "Return Date";
            // 
            // btnRentalReturn
            // 
            this.btnRentalReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalReturn.Location = new System.Drawing.Point(816, 460);
            this.btnRentalReturn.Name = "btnRentalReturn";
            this.btnRentalReturn.Size = new System.Drawing.Size(92, 31);
            this.btnRentalReturn.TabIndex = 43;
            this.btnRentalReturn.Text = "Return";
            this.btnRentalReturn.UseVisualStyleBackColor = true;
            this.btnRentalReturn.Click += new System.EventHandler(this.btnRentalReturn_Click);
            // 
            // btnRentalDelete
            // 
            this.btnRentalDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalDelete.Location = new System.Drawing.Point(914, 460);
            this.btnRentalDelete.Name = "btnRentalDelete";
            this.btnRentalDelete.Size = new System.Drawing.Size(96, 31);
            this.btnRentalDelete.TabIndex = 44;
            this.btnRentalDelete.Text = "Delete";
            this.btnRentalDelete.UseVisualStyleBackColor = true;
            this.btnRentalDelete.Click += new System.EventHandler(this.btnRentalDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 582);
            this.Controls.Add(this.btnRentalDelete);
            this.Controls.Add(this.btnRentalReturn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnVideoDelete);
            this.Controls.Add(this.btnVideoUpdate);
            this.Controls.Add(this.btnCustomerDElete);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnMostMovie);
            this.Controls.Add(this.btnMostCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVideoSAve);
            this.Controls.Add(this.btnRentalBooking);
            this.Controls.Add(this.btnCustomerSAve);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.dtpBooking);
            this.Controls.Add(this.TxtVideoId);
            this.Controls.Add(this.TxtCustomerId);
            this.Controls.Add(this.txtVideoCopies);
            this.Controls.Add(this.txtVideoPlot);
            this.Controls.Add(this.txtVideoGenre);
            this.Controls.Add(this.TxtRentId);
            this.Controls.Add(this.txtVideoTitle);
            this.Controls.Add(this.txtCustomerMObile);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtVideoYear);
            this.Controls.Add(this.txtVideoRatting);
            this.Controls.Add(this.txtVideoCost);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.lblRental);
            this.Controls.Add(this.lblCustomer);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtVideoCost;
        private System.Windows.Forms.TextBox txtVideoRatting;
        private System.Windows.Forms.TextBox txtVideoYear;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerMObile;
        private System.Windows.Forms.TextBox txtVideoTitle;
        private System.Windows.Forms.TextBox TxtRentId;
        private System.Windows.Forms.TextBox txtVideoGenre;
        private System.Windows.Forms.TextBox txtVideoPlot;
        private System.Windows.Forms.TextBox txtVideoCopies;
        private System.Windows.Forms.TextBox TxtCustomerId;
        private System.Windows.Forms.TextBox TxtVideoId;
        private System.Windows.Forms.DateTimePicker dtpBooking;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCustomerSAve;
        private System.Windows.Forms.Button btnRentalBooking;
        private System.Windows.Forms.Button btnVideoSAve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostCustomer;
        private System.Windows.Forms.Button btnMostMovie;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDElete;
        private System.Windows.Forms.Button btnVideoUpdate;
        private System.Windows.Forms.Button btnVideoDelete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRentalReturn;
        private System.Windows.Forms.Button btnRentalDelete;
    }
}

