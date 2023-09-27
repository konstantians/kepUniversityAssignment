using DataAccess;
using DataAccess.Models;
using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class AddCitizenForm : Form
    {
        public AddCitizenForm()
        {
            InitializeComponent();
        }

        private void registerCitizenButton_Click(object sender, EventArgs e)
        {

            StringBuilder emptyFields = new StringBuilder();
            emptyFields.Append("All fields must be filled. Please fill");

            int count = 0;
            if (AFMTextBox.Texts == "")
            {
                emptyFields.Append(" the AFM field");
                count++;
            }
            if (fullNameTextBox.Texts == "")
            {
                if (count == 0)
                {
                    emptyFields.Append(" the full name field");
                }
                else
                {
                    emptyFields.Append(", the full name field");
                }
                count++;
            }
            if (addressTextBox.Texts == "")
            {
                if (count == 0)
                {
                    emptyFields.Append(" the address field");
                }
                else
                {
                    emptyFields.Append(", the address field");
                }
                count++;
            }
            if (emailTextBox.Texts == "")
            {
                if (count == 0)
                {
                    emptyFields.Append(" the email field");

                }
                else
                {
                    emptyFields.Append(", the email field");
                }
                count++;
            }
            if (phoneNumberTextBox.Texts == "")
            {
                if (count == 0)
                {
                    emptyFields.Append(" the phone number field");

                }
                else
                {
                    emptyFields.Append(" and the phone number field");
                }
                count++;
            }
            emptyFields.Append(" and try again.");

            if (count > 0)
            {
                MessageBox.Show(emptyFields.ToString(), "Empty Fields",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long x;
            if(!Int64.TryParse(AFMTextBox.Texts,out x))
            {
                MessageBox.Show("The AFM must contain only digits.",
                    "Invalid AFM Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AFMTextBox.Texts = "";
                this.ActiveControl = AFMTextBox;
                AFMTextBox.Focus();
                return;
            }


            if(AFMTextBox.Texts.Length != 9)
            {
                MessageBox.Show("The AFM must be 9 digits long.",
                    "Invalid AFM Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AFMTextBox.Texts = "";
                this.ActiveControl = AFMTextBox;
                AFMTextBox.Focus();
                return;
            }

            if (dateOfBirthCalendar.Value.Year < 1920 || dateOfBirthCalendar.Value.Year > 2023)
            {
                MessageBox.Show("The date of birth must be between the year 1920 and the year 2023.",
                    "Invalid Date Of Birth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AFMTextBox.Texts = "";
                this.ActiveControl = AFMTextBox;
                AFMTextBox.Focus();
                return;
            }

            Regex emailRegex = new Regex(@"^([0-9a-zA-Z]([-\.\'\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z\.])+[.a-zA-Z]{2,9})$");
            if (!emailRegex.IsMatch(emailTextBox.Texts))
            {
                MessageBox.Show("The email you have given is not of a valid format.",
                    "Invalid Email Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Texts = "";
                this.ActiveControl = emailTextBox;
                emailTextBox.Focus();
                return;
            }

            if (!Int64.TryParse(phoneNumberTextBox.Texts, out x))
            {
                MessageBox.Show("The phone number must contain only digits.",
                    "Invalid Phone Number Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneNumberTextBox.Texts = "";
                this.ActiveControl = phoneNumberTextBox;
                phoneNumberTextBox.Focus();
                return;
            }

            if (phoneNumberTextBox.Texts.Length != 10)
            {
                MessageBox.Show("The phone number must be 10 digits long.",
                    "Invalid Phone Number Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneNumberTextBox.Texts = "";
                this.ActiveControl = phoneNumberTextBox;
                phoneNumberTextBox.Focus();
                return;
            }

            //check if there is another citizen already registered
            Citizen citizen = DataAccessOperations.GetCitizen(AFMTextBox.Texts);

            if (citizen.AFM != null)
            {
                MessageBox.Show("There is already a registration with the given AFM.",
                    "Citizen Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AFMTextBox.Texts = "";
                this.ActiveControl = AFMTextBox;
                AFMTextBox.Focus();
                return;
            }

            citizen.AFM = AFMTextBox.Texts;
            citizen.AMKA = AMKATextBox.Texts;
            citizen.FullName = fullNameTextBox.Texts;
            citizen.DateOfBirth = $"{dateOfBirthCalendar.Value.Day},{dateOfBirthCalendar.Value.Month},{dateOfBirthCalendar.Value.Year}";
            citizen.Address = addressTextBox.Texts;
            citizen.Email = emailTextBox.Texts;
            citizen.PhoneNumber = phoneNumberTextBox.Texts;

            DataAccessOperations.CreateCitizen(citizen, ActiveUser.KepEmployee.Username);
            ActiveUser.KepEmployee.RegisteredCitizens.Add(citizen);

            MessageBox.Show("The citizen was successfully registered into the system.",
                    "Citizen Sucessfully Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshAddCitizenForm();
            StaticData.UnsavedChanges = false;


            //go back to the home form
            StaticData.OpenHomeForm = true;
        }

        public void RefreshAddCitizenForm()
        {
            AFMTextBox.Texts = "";
            AMKATextBox.Texts = "";
            fullNameTextBox.Texts = "";
            dateOfBirthCalendar.ResetText();
            addressTextBox.Texts = "";
            emailTextBox.Texts = "";
            phoneNumberTextBox.Texts = "";
        }

        private void checkForChanges()
        {
            if (AFMTextBox.Texts != "" || AMKATextBox.Texts != "" || fullNameTextBox.Texts != ""
                || addressTextBox.Texts != "" || emailTextBox.Texts != "" || phoneNumberTextBox.Texts != "")
                StaticData.UnsavedChanges = true;
        }

        private void AFMTextBox_Enter(object sender, EventArgs e)
        {
            AFMTextBox.BorderColor = Color.Black;
        }

        private void AFMTextBox_Leave(object sender, EventArgs e)
        {
            AFMTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            addressTextBox.BorderColor = Color.Black;
        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            addressTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void AMKATextBox_Enter(object sender, EventArgs e)
        {
            AMKATextBox.BorderColor = Color.Black;
        }

        private void AMKATextBox_Leave(object sender, EventArgs e)
        {
            AMKATextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            emailTextBox.BorderColor = Color.Black;
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            emailTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void fullNameTextBox_Enter(object sender, EventArgs e)
        {
            fullNameTextBox.BorderColor = Color.Black;
        }

        private void fullNameTextBox_Leave(object sender, EventArgs e)
        {
            fullNameTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void phoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            phoneNumberTextBox.BorderColor = Color.Black;
        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            phoneNumberTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void registerCitizenButton_MouseEnter(object sender, EventArgs e)
        {
            registerCitizenButton.BackColor = Color.Black;
            registerCitizenButton.TextColor = Color.RoyalBlue;
            registerCitizenButton.BorderColor = Color.RoyalBlue;
        }

        private void registerCitizenButton_MouseLeave(object sender, EventArgs e)
        {
            registerCitizenButton.BackColor = Color.RoyalBlue;
            registerCitizenButton.TextColor = Color.Black;
            registerCitizenButton.BorderColor = Color.Black;
        }

        private void registerCitizenButton_Enter(object sender, EventArgs e)
        {
            registerCitizenButton.BackColor = Color.Black;
            registerCitizenButton.TextColor = Color.RoyalBlue;
            registerCitizenButton.BorderColor = Color.RoyalBlue;
        }

        private void registerCitizenButton_Leave(object sender, EventArgs e)
        {
            registerCitizenButton.BackColor = Color.RoyalBlue;
            registerCitizenButton.TextColor = Color.Black;
            registerCitizenButton.BorderColor = Color.Black;
        }
    }
}
