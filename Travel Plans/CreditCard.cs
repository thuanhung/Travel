using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Plans
{
    public partial class CreditCard : Form
    {
        private string firstName = "";          //initialyzing the value to send back to the form1
        private string lastName = "";
        private string address1 = "";
        private string address2 = "";
        private string cardType = "";
        private string cardNum = "";
        private string csc = "";
        private string date = "";
        private string email = "";

        public string FirstName { get { return firstName; } set { firstName = value; } }//creating getter and setter
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Address1 { get { return address1; } set { address1 = value; } }
        public string Address2 { get { return address2; } set { address2 = value; } }
        public string CardType { get { return cardType; } set { cardType = value; } }
        public string CardNum { get { return cardNum; } set { cardNum = value; } }
        public string CSC { get { return csc; } set { csc = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string Email { get { return email; } set { email = value; } }

        public CreditCard()
        {
            InitializeComponent();
        }
        private void Customer_Info_Load(object sender, EventArgs e)
        {
            //Creating array for card type 
            string[] cardType = { "Card Type", "Visa", "Discover", "Master Card" };
            foreach (string Card in cardType)
            {
                cboCardType.Items.Add(Card);
                
            }
            cboCardType.SelectedIndex = 0;

            string[] Month = { "Month", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" }; //creating array for Month 
            foreach(string month in Month)
            {
                cboMonth.Items.Add(month);
            }
            cboMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;         // getting the actual year
            int endYear = year + 10;                //Adding some more year to it
            cboYear.Items.Add("Year");              //Adding year to comboBox as index 0
            while (year < endYear)                  //Adding years to the comboBox
            {
                cboYear.Items.Add(year);
                year++;
            }
            cboYear.SelectedIndex = 0;              //Setting year as index 0        
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try       //Doing this we catch all the exceptions that will occur
            {
                if (IsValid()) //Doing validation on every single entry
                {
                    Form1 f1 = new Form1();
                    FirstName = txtFirst.Text;      //setting up values from CreditCard input
                    LastName = txtLast.Text;   
                    Address1 = txtAdd1.Text;      
                    Address2 = txtAdd2.Text;       
                    CardType = cboCardType.Text;    
                    CardNum = txtCardNum.Text;      
                    CSC = txtCSC.Text;             
                    Date = cboMonth.Text + "/" + cboYear.Text;//setting up value to be gotten in the form1
                    Email = txtEmail.Text;

                    this.Hide();
                }
            }

            catch (FormatException) //Handling format exceptions
            {
                MessageBox.Show(" Formating exception occurs, Please check your entries");
            }
            catch (OverflowException) //Handling overflow exceptions
            {
                MessageBox.Show(" OverFlow exception occurs, Please enter small value");
            }
            catch (Exception ex) //Handling any other exceptions that have not be created yet
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        //Method to check if there is an entry
        public bool IsPresent(TextBox text, string name)
        {
            if (text.Text == "")
            {
                MessageBox.Show(name + " Is a required field. Enter a data", "Entry Error");
                text.Focus();
                return false;
            }
            return true;
        }

        //Method to check if the entry is an integer
        public bool IsInt(TextBox text, string name)
        {
            long num = 0;
            if (Int64.TryParse(text.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " has to be an int, Please enter an integer ", "Entry error");
                text.Focus();
                return false;
            }
        }

        //Method to check if the entry is in the range set up
        public bool IsInRange(TextBox text, string name, int Required)
        {
            string contening = Convert.ToString(text.Text);
            if (contening.Count() != Required)
            {
                MessageBox.Show(name + " digit has to be equal to " + Required + ".");
                txtFirst.Focus();
                return false;
            }
            return true;
        }

        //Method to check if the combo box has the correct selection
        public bool IsSelected(ComboBox text, string name)
        {
            if (text.SelectedIndex == -1 || text.SelectedIndex == 0)
            {
                MessageBox.Show(name + " Is a required field. Please select a " + name, "Entry Error");
                text.Focus();
                return false;
            }
            return true;
        }
        public bool IsValid()
        {
            return
                IsPresent(txtFirst, "First Name") &&    //Validation on first name
                IsPresent(txtLast, "Last Name") &&      //Validation on last name
                IsPresent(txtAdd1, "Address") &&        //Validation on address 1

                IsSelected(cboCardType, "Card type") &&  //Validation on card type
                //Validation on Card Number
                IsPresent(txtCardNum, "Card Number") &&
                IsInt(txtCardNum, "Card Number") &&
                IsInRange(txtCardNum, "Card Number", 16) &&     
                //Validation on CSC number
                IsPresent(txtCSC, "CSC Number") &&
                IsInt(txtCSC, "CSC Number") &&
                IsInRange(txtCSC, "CSC Number", 3) &&
                //Validation on Month
                IsSelected(cboMonth, "Month") &&
                IsSelected(cboYear, "Year") &&
                IsPresent(txtEmail, "Email");           //Validation on Email
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
