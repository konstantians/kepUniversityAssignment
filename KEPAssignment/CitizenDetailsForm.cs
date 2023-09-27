using DataAccess;
using DataAccess.Models;
using KEPAssignment.Properties;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class CitizenDetailsForm : Form
    {
        public Citizen CurrentCitizen { get; set; }
        public CitizenDetailsForm(string afm)
        {
            InitializeComponent();
            CurrentCitizen = DataAccessOperations.GetCitizen(afm);
            AFMTextBox.Texts = CurrentCitizen.AFM;
            AMKATextBox.Texts = CurrentCitizen.AMKA;
            fullNameTextBox.Texts = CurrentCitizen.FullName;
            dateOfBirthCalendar.Text = CurrentCitizen.DateOfBirth;
            addressTextBox.Texts = CurrentCitizen.Address;
            emailTextBox.Texts = CurrentCitizen.Email;
            phoneNumberTextBox.Texts = CurrentCitizen.PhoneNumber;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
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
            if (!Int64.TryParse(AFMTextBox.Texts, out x))
            {
                MessageBox.Show("The AFM must contain only digits.",
                    "Invalid AFM Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AFMTextBox.Texts = "";
                this.ActiveControl = AFMTextBox;
                AFMTextBox.Focus();
                return;
            }


            if (AFMTextBox.Texts.Length != 9)
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

            if (citizen.AFM != CurrentCitizen.AFM && citizen.AFM != null)
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

            DataAccessOperations.UpdateCitizen(citizen, CurrentCitizen.AFM);
            ActiveUser.KepEmployee.RegisteredCitizens.RemoveAll(tempCitizen => tempCitizen.AFM == CurrentCitizen.AFM);
            ActiveUser.KepEmployee.RegisteredCitizens.Add(citizen);

            MessageBox.Show("The citizen was successfully updated!",
                    "Citizen Sucessfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StaticData.UnsavedChanges = false;

            //go back to the view citizens form
            StaticData.OpenViewCitizenForm = true;
        }

        private void deleteCitizenButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this citizen?", "Citizen Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataAccessOperations.DeleteCitizen(CurrentCitizen.AFM);
                MessageBox.Show("Citizen deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StaticData.UnsavedChanges = false;

                //go back to the view citizens form
                StaticData.OpenViewCitizenForm = true;
            }
        }

        private void checkForChanges()
        {
            if (CurrentCitizen.AFM != AFMTextBox.Texts || CurrentCitizen.AMKA != AMKATextBox.Texts ||
                CurrentCitizen.FullName != fullNameTextBox.Texts || dateOfBirthCalendar.Text != CurrentCitizen.DateOfBirth ||
                CurrentCitizen.Address != addressTextBox.Texts || CurrentCitizen.Email != emailTextBox.Texts ||
                CurrentCitizen.PhoneNumber != phoneNumberTextBox.Texts)
            {
                StaticData.UnsavedChanges = true;
            }
            else
            {
                StaticData.UnsavedChanges = false;
            }
        }

        //////////////////////////////////////// Styling ////////////////////////////////////////

        private void AFMEditButton_Click(object sender, EventArgs e)
        {
            if (!AFMTextBox.Enabled)
            {
                AFMTextBox.Enabled = true;
                AFMTextBox.BackColor = Color.White;
                AFMEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            AFMTextBox.Enabled = false;
            AFMTextBox.BackColor = SystemColors.Control;
            AFMEditButton.BackgroundImage = Resources.editIcon;
        }

        private void AMKAEditButton_Click(object sender, EventArgs e)
        {
            if (!AMKATextBox.Enabled)
            {
                AMKATextBox.Enabled = true;
                AMKATextBox.BackColor = Color.White;
                AMKAEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            AMKATextBox.Enabled = false;
            AMKATextBox.BackColor = SystemColors.Control;
            AMKAEditButton.BackgroundImage = Resources.editIcon;
        }

        private void fullNameEditButton_Click(object sender, EventArgs e)
        {
            if (!fullNameTextBox.Enabled)
            {
                fullNameTextBox.Enabled = true;
                fullNameTextBox.BackColor = Color.White;
                fullNameEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            fullNameTextBox.Enabled = false;
            fullNameTextBox.BackColor = SystemColors.Control;
            fullNameEditButton.BackgroundImage = Resources.editIcon;
        }

        private void dateOfBirthButton_Click(object sender, EventArgs e)
        {
            if (!dateOfBirthCalendar.Enabled)
            {
                dateOfBirthCalendar.Enabled = true;
                dateOfBirthCalendar.BackColor = Color.White;
                dateOfBirthButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            dateOfBirthCalendar.Enabled = false;
            dateOfBirthCalendar.BackColor = SystemColors.Control;
            dateOfBirthButton.BackgroundImage = Resources.editIcon;
        }

        private void addressEditButton_Click(object sender, EventArgs e)
        {
            if (!addressTextBox.Enabled)
            {
                addressTextBox.Enabled = true;
                addressTextBox.BackColor = Color.White;
                addressEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            addressTextBox.Enabled = false;
            addressTextBox.BackColor = SystemColors.Control;
            addressEditButton.BackgroundImage = Resources.editIcon;
        }

        private void emailEditButton_Click(object sender, EventArgs e)
        {
            if (!emailTextBox.Enabled)
            {
                emailTextBox.Enabled = true;
                emailTextBox.BackColor = Color.White;
                emailEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            emailTextBox.Enabled = false;
            emailTextBox.BackColor = SystemColors.Control;
            emailEditButton.BackgroundImage = Resources.editIcon;
        }

        private void phoneNumberEditButton_Click(object sender, EventArgs e)
        {
            if (!phoneNumberTextBox.Enabled)
            {
                phoneNumberTextBox.Enabled = true;
                phoneNumberTextBox.BackColor = Color.White;
                phoneNumberEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            phoneNumberTextBox.Enabled = false;
            phoneNumberTextBox.BackColor = SystemColors.Control;
            phoneNumberEditButton.BackgroundImage = Resources.editIcon;
        }

        private void textBoxFocusEnter(object sender, EventArgs e)
        {
            CustomTextBox customTextBox = (CustomTextBox)sender;
            customTextBox.BorderColor = Color.Black;
        }

        private void textBoxFocusLeave(object sender, EventArgs e)
        {
            CustomTextBox customTextBox = (CustomTextBox)sender;
            customTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void dateOfBirthCalendar_Enter(object sender, EventArgs e)
        {
            checkForChanges();
        }

        private void editButtonMouseEnter(object sender, EventArgs e)
        {
            CustomButton customButton = (CustomButton)sender;
            customButton.BackColor = Color.White;
        }

        private void editButtonMouseLeave(object sender, EventArgs e)
        {
            CustomButton customButton = (CustomButton)sender;
            customButton.BackColor = Color.RoyalBlue;
        }

        private void saveChangesButton_MouseEnter(object sender, EventArgs e)
        {
            saveChangesButton.BackColor = Color.Black;
            saveChangesButton.TextColor = Color.RoyalBlue;
            saveChangesButton.BorderColor = Color.RoyalBlue;
        }

        private void saveChangesButton_MouseLeave(object sender, EventArgs e)
        {
            saveChangesButton.BackColor = Color.RoyalBlue;
            saveChangesButton.TextColor = Color.Black;
            saveChangesButton.BorderColor = Color.Black;
        }

        private void deleteCitizenButton_MouseEnter(object sender, EventArgs e)
        {
            deleteCitizenButton.BackColor = Color.RoyalBlue;
            deleteCitizenButton.TextColor = Color.Black;
            deleteCitizenButton.BorderColor = Color.Black;
        }

        private void deleteCitizenButton_MouseLeave(object sender, EventArgs e)
        {
            deleteCitizenButton.BackColor = Color.Black;
            deleteCitizenButton.TextColor = Color.RoyalBlue;
            deleteCitizenButton.BorderColor = Color.RoyalBlue;
        }
    }
}
