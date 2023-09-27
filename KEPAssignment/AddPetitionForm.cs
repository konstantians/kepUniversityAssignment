using DataAccess;
using DataAccess.Models;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class AddPetitionForm : Form
    {
        public AddPetitionForm()
        {
            InitializeComponent();
            petitionTypeComboBox.SelectedIndex = 0;
        }

        private void createPetitionButton_Click(object sender, EventArgs e)
        {
            StringBuilder emptyFields = new StringBuilder();
            emptyFields.Append("All fields must be filled. Please fill");

            if (citizenAFMTextBox.Texts == "")
            {
                MessageBox.Show("All fields must be filled. Please fill the citizen's AFM field and try again.", "Empty Fields",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(petitionAliasTextBox.Texts.Length > 20)
            {
                MessageBox.Show("The petition alias must be less or equal to 20 characters long",
                    "Invalid Petition Alias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = petitionTypeComboBox;
                petitionTypeComboBox.Focus();
                return;
            }

            if (petitionTypeComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please pick one of the available petition types and try again",
                    "Invalid ComboBox Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = petitionTypeComboBox;
                petitionTypeComboBox.Focus();
                return;
            }

            long x;
            if (!Int64.TryParse(citizenAFMTextBox.Texts, out x))
            {
                MessageBox.Show("The citizen's AFM must contain only digits.",
                    "Invalid AFM Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                citizenAFMTextBox.Texts = "";
                this.ActiveControl = citizenAFMTextBox;
                citizenAFMTextBox.Focus();
                return;
            }

            if (citizenAFMTextBox.Texts.Length != 9)
            {
                MessageBox.Show("The citizen's AFM must be 9 digits long.",
                    "Invalid AFM Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                citizenAFMTextBox.Texts = "";
                this.ActiveControl = citizenAFMTextBox;
                citizenAFMTextBox.Focus();
                return;
            }

            if(petitionDescriptionTextBox.Texts.Length > 250)
            {

                MessageBox.Show("The description length must not exceed the 250 characters limit.",
                    "Invalid Description Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = petitionDescriptionTextBox;
                petitionDescriptionTextBox.Focus();
                return;
            }

            if (DataAccessOperations.GetCitizen(citizenAFMTextBox.Texts).AFM == null)
            {
                MessageBox.Show("There is no registered user with the given afm",
                    "Invalid AFM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                citizenAFMTextBox.Texts = "";
                this.ActiveControl = citizenAFMTextBox;
                citizenAFMTextBox.Focus();
                return;
            }

            Petition petition = new Petition();

            petition.PetitionAlias = petitionAliasTextBox.Texts;
            petition.CitizenAfmOfPetition = citizenAFMTextBox.Texts;
            petition.PetitionType = petitionTypeComboBox.Texts;
            petition.PetitionDescription = petitionDescriptionTextBox.Texts;
            petition.PetitionDate = $"{DateTime.Now.Day},{DateTime.Now.Month},{DateTime.Now.Year}";
            petition.PetitionStatus = "Pending";

            DataAccessOperations.CreatePetition(petition);

            MessageBox.Show("The petition was successfully created and is currently pending examination.",
                    "Petition Sucessfully Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshAddPetitionForm();
            StaticData.UnsavedChanges = false;

            //go back to the home form
            StaticData.OpenHomeForm = true;
        }

        public void RefreshAddPetitionForm()
        {
            petitionAliasTextBox.Texts = "";
            citizenAFMTextBox.Texts = "";
            petitionTypeComboBox.SelectedIndex = 0;
            petitionDescriptionTextBox.Texts = "";
        }

        private void checkForChanges()
        {
            if (petitionAliasTextBox.Texts != "" || citizenAFMTextBox.Texts != "" 
                || petitionDescriptionTextBox.Texts != "")
                StaticData.UnsavedChanges = true;
        }

        private void petitionAliasTextBox_Enter(object sender, EventArgs e)
        {
            petitionAliasTextBox.BorderColor = Color.Black;
        }

        private void petitionAliasTextBox_Leave(object sender, EventArgs e)
        {
            petitionAliasTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void citizenAFMTextBox_Enter(object sender, EventArgs e)
        {
            citizenAFMTextBox.BorderColor = Color.Black;
        }

        private void citizenAFMTextBox_Leave(object sender, EventArgs e)
        {
            citizenAFMTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void petitionTypeComboBox_Enter(object sender, EventArgs e)
        {
            petitionTypeComboBox.BorderColor = Color.Black;
            petitionTypeComboBox.IconColor = Color.Black;
        }

        private void petitionTypeComboBox_Leave(object sender, EventArgs e)
        {
            petitionTypeComboBox.BorderColor = Color.RoyalBlue;
            petitionTypeComboBox.IconColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void petitionDescriptionTextBox_Enter(object sender, EventArgs e)
        {
            petitionDescriptionTextBox.BorderColor = Color.Black;
        }

        private void petitionDescriptionTextBox_Leave(object sender, EventArgs e)
        {
            petitionDescriptionTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void createPetitionButton_MouseEnter(object sender, EventArgs e)
        {
            createPetitionButton.BackColor = Color.Black;
            createPetitionButton.TextColor = Color.RoyalBlue;
            createPetitionButton.BorderColor = Color.RoyalBlue;
        }

        private void createPetitionButton_MouseLeave(object sender, EventArgs e)
        {
            createPetitionButton.BackColor = Color.RoyalBlue;
            createPetitionButton.TextColor = Color.Black;
            createPetitionButton.BorderColor = Color.Black;
        }

        private void createPetitionButton_Enter(object sender, EventArgs e)
        {
            createPetitionButton.BackColor = Color.Black;
            createPetitionButton.TextColor = Color.RoyalBlue;
            createPetitionButton.BorderColor = Color.RoyalBlue;
        }

        private void createPetitionButton_Leave(object sender, EventArgs e)
        {
            createPetitionButton.BackColor = Color.RoyalBlue;
            createPetitionButton.TextColor = Color.Black;
            createPetitionButton.BorderColor = Color.Black;
        }
    }
}
