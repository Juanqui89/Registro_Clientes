using RegistroCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Customer = RegistroCliente.Customer;
using System.Data.SQLite;
using System.Diagnostics;
using RegistrosCliente;

namespace RegistroClientes

{
    public partial class frmCustomer : Form
    {
        enum BusinessType
        {
            Private, Goverment, Educational, Health, Scientific, Contractor, Entreprenur, Church, Other
        }

        private int idValue = -1;
        private Char genderValue = 'M';
        private string statusValue = "Active";
        private Boolean statusBoolean = true;
        private String ImagePhotoValue = "";
        private Boolean foundCustomerRecord = false;

        static String fileNameJSON = "C:\\EDP\\ITP-4385\\LabTextFileJSON.json";

        SQLiteConnection databaseConnection =
            new SQLiteConnection("Data Source=C:\\Users\\juanq\\source\\repos\\RegistrosCliente\\RegistrosCliente\\database.sqlite;cache=shared;");

        public string sqlCounterCustomer { get; private set; }

        SQLiteCommand sqlCommand;

        String sqlInsertCustomer;

        String sqlDeleteCustomer;

        String sqlCounterCustumer;
        private string imagePhotoValue;

        private Customer customer;

        public frmCustomer()
        {
            InitializeComponent();
        }




        private void btn_Hide()
        {
            btnClose.Enabled = false;
            btnCreate.Enabled = false;
            btnJSON.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnSave.Enabled = false;
            btnFind.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btn_Show()
        {
            btnClose.Enabled = true;
            btnCreate.Enabled = true;
            btnJSON.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnSave.Enabled = true;
            btnFind.Enabled = true;
            btnDelete.Enabled = true;
        }

        public class Profession
        {
            public string ProfessionName { get; set; }
            public string ProfessionValue { get; set; }
        }

        private void FillComboBoxProfession()
        {
            var dataSource = new List<Profession>();
            {
                new Profession() { ProfessionName = "Programmer", ProfessionValue = "Programmer" };
                new Profession() { ProfessionName = "Engineer", ProfessionValue = "Engineer" };
                new Profession() { ProfessionName = "Accountant", ProfessionValue = "Accountant" };
                new Profession() { ProfessionName = "Lawyer", ProfessionValue = "Lawyer" };
                new Profession() { ProfessionName = "Professor", ProfessionValue = "Professor" };
                new Profession() { ProfessionName = "Doctor", ProfessionValue = "Doctor" };
                new Profession() { ProfessionName = "Other", ProfessionValue = "Other" };
            };


            cmbProfession.DataSource = dataSource;
            cmbProfession.DisplayMember = "ProfessionName";
            cmbProfession.ValueMember = "ProfessionValue";
        }

        private void FillComboBoxBusinessType()
        {
            cmbBusinessType.DataSource = Enum.GetValues(typeof(BusinessType));
        }

        private void FillComboBoxState()
        {
            string[] states = { "PR", "FL", "TX", "CA", "LA", "NY", "NJ", "MA", "OH", "PA", "UT" };

            comboState.Items.Clear();

            for (int i = 0; i < states.Length; i++)
            {
                comboState.Items.Add(states[i]);
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            btn_Hide();
            FillComboBoxBusinessType();
            FillComboBoxProfession();
            FillComboBoxState();

            CreateMenu();
        }

        public void CreateMenu()
        {
            MainMenu mainMenu = new MainMenu();
            this.Menu = mainMenu;

            MenuItem menuItemPrograms = new MenuItem("&Programs");
            MenuItem menuItemForms = new MenuItem("&Forms");
            MenuItem menuItemOthers = new MenuItem("&Others");

            mainMenu.MenuItems.Add(menuItemPrograms);
            mainMenu.MenuItems.Add(menuItemForms);
            mainMenu.MenuItems.Add(menuItemOthers);

            MenuItem menuItemNotepad = new MenuItem("&Notepad");
            MenuItem menuItemFileManager = new MenuItem("File &Manager");
            MenuItem menuItemCalculator = new MenuItem("&Calculator");

            menuItemPrograms.MenuItems.Add(menuItemNotepad);
            menuItemPrograms.MenuItems.Add("-");
            menuItemPrograms.MenuItems.Add(menuItemFileManager);

            menuItemPrograms.MenuItems.Add("-");
            menuItemPrograms.MenuItems.Add(menuItemCalculator);

            MenuItem menuItemProfessions = new MenuItem("&Professions");
            menuItemForms.MenuItems.Add(menuItemProfessions);

            MenuItem menuItemExit = new MenuItem("&Exit");
            menuItemOthers.MenuItems.Add(menuItemExit);

            menuItemNotepad.Click += new System.EventHandler(this.menuItemNotepad_Click);
            menuItemFileManager.Click += new System.EventHandler(this.menuItemFileManager_Click);
            menuItemCalculator.Click += new System.EventHandler(this.menuItemCalculator_Click);
            menuItemProfessions.Click += new System.EventHandler(this.menuItemProfessions_Click); 
            menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
        }

        private void menuItemNotepad_Click(object sender, System.EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void menuItemFileManager_Click(object sender, System.EventArgs e)
        {
            Process.Start(@"c:\");
        }

        private void menuItemCalculator_Click(object sender, System.EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void menuItemProfessions_Click(object sender, System.EventArgs e)
        {
            frmProfession frmProfession = new frmProfession();
            frmProfession.Show();
        }

        private void menuItemExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }


        private void ClearAll()
        {
            txtID.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            comboState.Text = "PR";
            txtZipCode.Clear();
            txtPhone.Clear();
            ckbInactive.Checked = false;
            rbtMale.Checked = true;
            rbtFemale.Checked = false;

            string date = "11/09/1991 12:01 AM";
            DateTime dt = Convert.ToDateTime(date);
            var dtpDOB = dt;

            imagePhoto.Image = null;

            cmbProfession.Text = null;
            cmbBusinessType.Text = null;

            txtEmail.Clear();
            txtNotes.Clear();

            txtResult.Text = null;
            txtResult.Visible = false;

        }

        private void createCustomer()
        {
            customer = new Customer
            {
                ID = int.Parse(this.txtID.Text.ToString()),
                Name = this.txtName.Text.ToString(),
                LastName = this.txtLastName.Text.ToString(),
                Street = this.txtStreet.Text.ToString(),
                City = this.txtCity.Text.ToString(),
                State = this.comboState.Text.ToString(),
                ZipCode = this.txtZipCode.Text.ToString(),
                Phone = this.txtPhone.Text.ToString()
            };

            if (ckbInactive.Checked)
                customer.Inactive = true;
            else
                customer.Inactive = false;

            customer.Gender = this.genderValue;

            customer.DOB = this.dtpDOB.Text;

            customer.Email = this.txtEmail.Text.ToString();

            customer.Profession = this.cmbProfession.Text.ToString();

            customer.BusinessType = this.cmbBusinessType.Text.ToString();

            customer.Photo = this.ImagePhotoValue;

            customer.Notes = this.txtNotes.Text.ToString();
        }

        private Boolean verifyData()
        {

            if (string.IsNullOrWhiteSpace(this.txtID.Text))
            {
                MessageBox.Show("The ID field is empty. Try again.");
                this.txtID.Focus();
                return false;
            }

            if (!Int32.TryParse(this.txtID.Text, out idValue))
            {
                MessageBox.Show("The ID field must be a number. Try again.");
                this.txtID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                MessageBox.Show("The name field is empty. Try again.");
                this.txtName.Focus();
                txtName.ForeColor = Color.White;
                txtName.BackColor = Color.Red;
                return false;
            }
            else
            {
                txtName.ForeColor = Color.Black;
                txtName.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(this.txtLastName.Text))
            {
                MessageBox.Show("The LastName field is empty. Try again.");
                this.txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStreet.Text))
            {
                MessageBox.Show("The Street field is empty. Try again.");
                this.txtStreet.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtCity.Text))
            {
                MessageBox.Show("The City field is empty. Try again.");
                this.txtCity.Focus();
                return false;
            }

            if (!this.txtZipCode.MaskCompleted)  //maskedTextBox1.MaskFull
            {
                MessageBox.Show("The ZipCode field is empty. Try again.");
                this.txtZipCode.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                try
                {
                    var email = txtEmail.Text;
                    var emailAddress = new System.Net.Mail.MailAddress(email);
                    txtEmail.Text = emailAddress.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("The Email field is empty. Try again.");
                    this.txtEmail.Focus();
                    return false;
                }
            }

            createCustomer();
            return true;
        }

        private SQLiteCommand GetSqlCommand()
        {
            return sqlCommand;
        }

        private void InsertUpdateCustomer(SQLiteCommand sqlCommand)
        {
            Boolean isDataOK = verifyData();

            if (isDataOK)
            {
                sqlInsertCustomer = "INSERT OR REPLACE INTO customer VALUES ("
                                    + customer.ID + ", '"
                                    + customer.Name + "', '"
                                    + customer.LastName + "', '"
                                    + customer.Street + "', '"
                                    + customer.City + "', '"
                                    + customer.State + "', '"
                                    + customer.ZipCode + "', '"
                                    + customer.Phone + "', '"
                                    + customer.Inactive + "', '"
                                    + customer.Gender + "', '"
                                    + customer.DOB + "', '"
                                    + customer.Email + "', '"
                                    + customer.Profession + "', '"
                                    + customer.BusinessType + "', '"
                                    + customer.Photo + "', '"
                                    + customer.Notes + "')";
                sqlCommand = new SQLiteCommand(sqlInsertCustomer, databaseConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Customer data record saved seccessfully");
            }

            void DeleteCustomer()
            {
                Boolean DataOK = verifyData();

                if (isDataOK)
                {
                    sqlDeleteCustomer = "DELETE FROM customer WHERE ID = "
                        + Int32.Parse(this.txtID.Text.ToString());

                    sqlCommand = new SQLiteCommand(sqlDeleteCustomer, databaseConnection);

                    sqlCommand.ExecuteNonQuery();

                }
            }

              

            Boolean  FindCustomerID(int customer_id)
            {
                Boolean foundCustomerId = false;

                sqlCounterCustomer = "SELECT * FROM customer where id = " + customer_id;

                sqlCommand = new SQLiteCommand(sqlCounterCustomer, databaseConnection);

                SQLiteDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    txtID.Text = sqlDataReader["id"].ToString();
                    txtName.Text = sqlDataReader["name"].ToString();
                    txtLastName.Text = sqlDataReader["lastname"].ToString();
                    txtStreet.Text = sqlDataReader["street"].ToString();
                    txtCity.Text = sqlDataReader["city"].ToString();
                    comboState.Text = sqlDataReader["state"].ToString();
                    txtZipCode.Text = sqlDataReader["zipcode"].ToString();
                    txtPhone.Text = sqlDataReader["phone"].ToString();

                    statusValue = sqlDataReader["inactive"].ToString();

                    if (statusValue == "1")
                        ckbInactive.Checked = true;
                    else
                        ckbInactive.Checked = false;

                    genderValue = Char.Parse(sqlDataReader["gender"].ToString().Substring(0, 1));

                    if (genderValue == 'M')
                    {
                        rbtMale.Checked = true;
                    }
                    else
                        rbtFemale.Checked = true;

                    string date = sqlDataReader["dob"].ToString();
                    DateTime dt = Convert.ToDateTime(date);
                    dtpDOB.Text = dt.ToString();

                    txtEmail.Text = sqlDataReader[".email"].ToString();
                    cmbProfession.Text = sqlDataReader["profession"].ToString();
                    cmbBusinessType.Text = sqlDataReader["businessType"].ToString();

                    imagePhotoValue = sqlDataReader["photo"].ToString();

                    Image loadedBitmap = Image.FromFile(imagePhotoValue);

                    imagePhoto.Image = loadedBitmap;

                    txtNotes.Text = sqlDataReader["notes"].ToString();

                    foundCustomerId = true;
                }

                return foundCustomerId;
            }
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnection.Open();
                string sqlCreateTable = "CREATE TABLE IF NOT EXISTS customer ( id integer PRIMARY KEY, "
                    + "name varchar(20) NOT NULL, lastname varchar(30) NOT NULL, sreet varchar(40), "
                    + "city varchar(30), state varchar(30), zipCode varchar(10), phone varchar(15), "
                    + "inactive boolean, gender varchar(1), dob varchar(20), email varchar(30), "
                    + "profession varchar(30), businessType varchar(30), photo varchar(30), notes varchar(200))";

                SQLiteCommand commandCreateTable = new SQLiteCommand(sqlCreateTable, databaseConnection);
                commandCreateTable.ExecuteNonQuery();
                foundCustomerRecord = FindCustomerID(1);

                if (!foundCustomerRecord)
                {
                    MessageBox.Show("Customer table is Empty with no Records. Please enter the data record.");
                    btn_Show();
                    btnOpen.Enabled = false;
                    return;
                }
                btn_Show();
                btnOpen.Enabled = false;

            }
            catch (Exception exeption)
            {
                Console.WriteLine("btnOpen_Click() --> The database file could not be read: " + exeption.Message);
                btnOpen.Enabled = false;
                btn_Show();
            }
        }

        private bool FindCustomerID()
        {
            throw new NotImplementedException();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearAll();

            databaseConnection.Close();

            btn_Hide();
            btnOpen.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClearAll();

            int idValueTemp = NextCustomerID();
            txtID.Text = idValueTemp.ToString();
            txtID.Enabled = false;
            txtName.Focus();

        }

        private int NextCustomerID()
        {
            int nextCustomerID = 0;
            int countRecords = 0;

            sqlCounterCustomer = "SELECT MAX(ID) AS counter FROM customer";

            sqlCommand = new SQLiteCommand(sqlCounterCustomer, databaseConnection);
            if (foundCustomerRecord == true)
            {

                SQLiteDataReader sqliteDataReader = sqlCommand.ExecuteReader();
                while (sqliteDataReader.Read())
                {
                    countRecords = Int16.Parse(sqliteDataReader["counter"].ToString());
                }
            }
            nextCustomerID = countRecords + 1;
            return nextCustomerID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertUpdateCustomer(GetSqlCommand());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the customer record ?",
                "Delete Customer", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DeleteCustomer();
                ClearAll();
            }
            else if (dialogResult == DialogResult.No) ;
            //do something else
        }

        private void DeleteCustomer()
        {
            Boolean isDataOk = verifyData();

            if (isDataOk)
            {
                sqlDeleteCustomer = "DELETE FROM customer WHERE ID = "
                    + Int32.Parse(this.txtID.Text.ToString());

                sqlCommand = new SQLiteCommand(sqlDeleteCustomer, databaseConnection);

                sqlCommand.ExecuteNonQuery();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Boolean foundCustomerRecord = false;

            string idValue = (Int16.Parse(txtID.Text) - 1).ToString();

            int numValueID = 0;


            if (Int32.TryParse(idValue, out numValueID))
            {
                foundCustomerRecord = FindCustomerID(numValueID);
            }

            if (foundCustomerRecord == false)
            {
                MessageBox.Show("You reach the top of the Customer file. Please try again. ");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            Boolean foundCustomerRecord = false;

            string idValue = (Int16.Parse(txtID.Text) + 1).ToString();

            int numValueID = 0;

            if (Int32.TryParse(idValue, out numValueID))
            {
                foundCustomerRecord = FindCustomerID(numValueID);
            }

            if (foundCustomerRecord == false)
            {
                MessageBox.Show("You reach the top of the Customer file. Please try again. ");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Boolean foundCustomerRecord = false;

            string message = "Please enter the Customer ID to search:";
            string title = "Customer - Search Dialog";
            string defaultValue = "1";

            string idValue = Microsoft.VisualBasic.Interaction.InputBox
                (message, title, defaultValue, 525, 250);

            int numValueID = 0;

            if (Int32.TryParse(idValue, out numValueID))
            {
                foundCustomerRecord = FindCustomerID(numValueID);

                if (!foundCustomerRecord)
                {
                    MessageBox.Show("Customer ID Not Found. Please try again.");
                    return;

                }

            }
            else
            {
                MessageBox.Show("Customer ID Not Found. Please try again.");
            }
        }

        private bool FindCustomerID(int numValueID)
        {
            throw new NotImplementedException();
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
            txtResult.Visible = false;

            if (ckbInactive.Checked)
            {
                statusValue = "Inactive";
                statusBoolean = true;
            }
            else
            {
                statusValue = "Active";
                statusBoolean = false;
            }

            Int32.TryParse(txtID.Text, out idValue);

            Customer customer = new Customer(idValue, txtName.Text,
                    txtLastName.Text, txtStreet.Text, txtCity.Text,
                    comboState.Text, txtZipCode.Text, txtPhone.Text,
                    statusBoolean, genderValue, dtpDOB.Text,
                    txtEmail.Text, cmbProfession.Text, cmbBusinessType.Text,
                    imagePhotoValue, txtNotes.Text);

            CustomerJSON custumerJSON = new CustomerJSON(
                idValue,
                txtName.Text,
                txtLastName.Text,
                genderValue,
                dtpDOB.Text,
                customer.YearsOld,
                txtStreet.Text,
                txtCity.Text,
                comboState.Text,
                txtZipCode.Text,
                txtPhone.Text,
                statusValue,
                txtEmail.Text,
                cmbProfession.Text,
                cmbBusinessType.Text,
                ImagePhotoValue,
                txtNotes.Text);

            JavaScriptSerializer ser = new
                JavaScriptSerializer();

            string outputJSON = ser.Serialize(custumerJSON);


            custumerJSON = ser.Deserialize<CustomerJSON>(outputJSON);

            MessageBox.Show("The creation of JSON File was completed successfully.");
        }

        


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void ckbInactive_CheckedChanged(object sender, EventArgs e)
        {
            bool check_box = false;

            if (ckbInactive.Checked)
                check_box = true;
            else
                check_box = false;
        }

        private void comboState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProfession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBusinessType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dtbDOB_ValueChanged(object sender, EventArgs e)
        {

        }


       
        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBusinessType_Click(object sender, EventArgs e)
        {

        }

        private void lblProfession_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void imagePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files (*.*) |*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();

            try
            {

                imagePhotoValue = openFileDialog1.FileName.ToString();
                Image loadedBitmap = Image.FromFile(imagePhotoValue);
                imagePhoto.Image = loadedBitmap;

            }

            catch (Exception exception)
            {
                Console.WriteLine("photoImage_Click() ERROR --> " + exception.Message);

                btnOpen.Enabled = false;
                btn_Show();
            }
        }

        private void rbtFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFemale.Checked)
                genderValue = 'F';
            else
                genderValue = 'M';
        }

        private void rbtMale_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtMale.Checked)
                genderValue = 'M';
            else
                genderValue = 'F';
        }

   
    }
}
