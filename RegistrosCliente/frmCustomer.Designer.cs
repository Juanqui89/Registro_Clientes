using RegistroCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace RegistroClientes
{
    partial class frmCustomer
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnJSON = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.ckbInactive = new System.Windows.Forms.CheckBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.imagePhoto = new System.Windows.Forms.PictureBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.Notes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbProfession = new System.Windows.Forms.ComboBox();
            this.lblProfession = new System.Windows.Forms.Label();
            this.cmbBusinessType = new System.Windows.Forms.ComboBox();
            this.lblBusinessType = new System.Windows.Forms.Label();
            this.grpMenu.SuspendLayout();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpMenu.Controls.Add(this.btnExit);
            this.grpMenu.Controls.Add(this.btnJSON);
            this.grpMenu.Controls.Add(this.btnFind);
            this.grpMenu.Controls.Add(this.btnNext);
            this.grpMenu.Controls.Add(this.btnPrevious);
            this.grpMenu.Controls.Add(this.btnDelete);
            this.grpMenu.Controls.Add(this.btnSave);
            this.grpMenu.Controls.Add(this.btnCreate);
            this.grpMenu.Controls.Add(this.btnClose);
            this.grpMenu.Controls.Add(this.btnOpen);
            this.grpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpMenu.Location = new System.Drawing.Point(3, 0);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(187, 769);
            this.grpMenu.TabIndex = 36;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Action Menu";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(9, 614);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 47);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnJSON
            // 
            this.btnJSON.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJSON.BackColor = System.Drawing.Color.LightGray;
            this.btnJSON.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnJSON.FlatAppearance.BorderSize = 2;
            this.btnJSON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJSON.Image = ((System.Drawing.Image)(resources.GetObject("btnJSON.Image")));
            this.btnJSON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJSON.Location = new System.Drawing.Point(9, 544);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(132, 47);
            this.btnJSON.TabIndex = 26;
            this.btnJSON.Text = "JSON";
            this.btnJSON.UseVisualStyleBackColor = false;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.LightGray;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFind.FlatAppearance.BorderSize = 2;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(9, 472);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(132, 47);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(9, 403);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 47);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.BorderSize = 2;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(9, 340);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(132, 47);
            this.btnPrevious.TabIndex = 23;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(9, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 47);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(9, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 47);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.BackColor = System.Drawing.Color.LightGray;
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreate.FlatAppearance.BorderSize = 2;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(9, 147);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(132, 47);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(9, 84);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 47);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpen.FlatAppearance.BorderSize = 2;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(9, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(132, 47);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(220, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 13);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "Custumer ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(291, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(88, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Transparent;
            this.txtResult.Location = new System.Drawing.Point(226, 658);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(471, 32);
            this.txtResult.TabIndex = 14;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(220, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(291, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(389, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(291, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(389, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(291, 84);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(389, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(291, 111);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(389, 20);
            this.txtCity.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(220, 61);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(220, 91);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(220, 118);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(220, 147);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State";
            // 
            // comboState
            // 
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(292, 143);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(55, 21);
            this.comboState.TabIndex = 6;
            this.comboState.Text = "PR";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(493, 148);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 10;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(562, 146);
            this.txtZipCode.Mask = "00000-9999";
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtZipCode.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(291, 174);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(220, 181);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone";
            // 
            // ckbInactive
            // 
            this.ckbInactive.AutoSize = true;
            this.ckbInactive.Location = new System.Drawing.Point(496, 177);
            this.ckbInactive.Name = "ckbInactive";
            this.ckbInactive.Size = new System.Drawing.Size(64, 17);
            this.ckbInactive.TabIndex = 9;
            this.ckbInactive.Text = "Inactive";
            this.ckbInactive.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbtFemale);
            this.grpGender.Controls.Add(this.rbtMale);
            this.grpGender.Location = new System.Drawing.Point(238, 210);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(200, 57);
            this.grpGender.TabIndex = 16;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(109, 30);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtFemale.TabIndex = 11;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Checked = true;
            this.rbtMale.Location = new System.Drawing.Point(6, 30);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(48, 17);
            this.rbtMale.TabIndex = 10;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(493, 197);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(35, 13);
            this.lblPhoto.TabIndex = 39;
            this.lblPhoto.Text = "Photo";
            // 
            // imagePhoto
            // 
            this.imagePhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagePhoto.Location = new System.Drawing.Point(496, 213);
            this.imagePhoto.Name = "imagePhoto";
            this.imagePhoto.Size = new System.Drawing.Size(132, 101);
            this.imagePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePhoto.TabIndex = 40;
            this.imagePhoto.TabStop = false;
            this.imagePhoto.Click += new System.EventHandler(this.imagePhoto_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(220, 340);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 24;
            this.lblDOB.Text = "DOB";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MMM-yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(256, 334);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(175, 20);
            this.dtpDOB.TabIndex = 13;
            this.dtpDOB.Value = new System.DateTime(1991, 9, 11, 0, 1, 0, 0);
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(223, 374);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(35, 13);
            this.Notes.TabIndex = 22;
            this.Notes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(291, 371);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(388, 120);
            this.txtNotes.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(223, 519);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(291, 512);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(388, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // cmbProfession
            // 
            this.cmbProfession.FormattingEnabled = true;
            this.cmbProfession.Location = new System.Drawing.Point(291, 558);
            this.cmbProfession.Name = "cmbProfession";
            this.cmbProfession.Size = new System.Drawing.Size(389, 21);
            this.cmbProfession.TabIndex = 16;
            this.cmbProfession.Text = "profession";
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Location = new System.Drawing.Point(220, 566);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(56, 13);
            this.lblProfession.TabIndex = 42;
            this.lblProfession.Text = "Profession";
            // 
            // cmbBusinessType
            // 
            this.cmbBusinessType.FormattingEnabled = true;
            this.cmbBusinessType.Location = new System.Drawing.Point(291, 598);
            this.cmbBusinessType.Name = "cmbBusinessType";
            this.cmbBusinessType.Size = new System.Drawing.Size(389, 21);
            this.cmbBusinessType.TabIndex = 43;
            this.cmbBusinessType.Text = "BusinessType";
            // 
            // lblBusinessType
            // 
            this.lblBusinessType.AutoSize = true;
            this.lblBusinessType.Location = new System.Drawing.Point(203, 606);
            this.lblBusinessType.Name = "lblBusinessType";
            this.lblBusinessType.Size = new System.Drawing.Size(73, 13);
            this.lblBusinessType.TabIndex = 43;
            this.lblBusinessType.Text = "BusinessType";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 745);
            this.Controls.Add(this.lblBusinessType);
            this.Controls.Add(this.cmbBusinessType);
            this.Controls.Add(this.lblProfession);
            this.Controls.Add(this.cmbProfession);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.imagePhoto);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.ckbInactive);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.comboState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.grpMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Record";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.grpMenu.ResumeLayout(false);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.MaskedTextBox txtZipCode;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.CheckBox ckbInactive;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.PictureBox imagePhoto;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbProfession;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.ComboBox cmbBusinessType;
        private System.Windows.Forms.Label lblBusinessType;
    }
}


#endregion