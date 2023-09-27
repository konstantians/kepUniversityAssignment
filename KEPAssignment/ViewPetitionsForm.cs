using KEPAssignment.SubForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class ViewPetitionsForm : Form
    {
        PetitionCardView petitionCardView = new PetitionCardView();
        PetitionListView petitionListView = new PetitionListView(); 
        Form currentForm = new Form();
        public ViewPetitionsForm()
        {
            InitializeComponent();
            petitionCardView.loadAllPetitionsApplyingNeccessaryFilters(0);
            currentForm = petitionCardView;
            currentForm.TopLevel = false;
            petitionsViewPanel.Controls.Add(currentForm);
            currentForm.Show();
            petitionStatusComboBox.SelectedIndex = 0;
            petitionTypeComboBox.SelectedIndex = 0;
            petitionStartingDateDatePicker.CustomFormat = "MMMM-dd-yyyy";
            petitionStartingDateDatePicker.Format = DateTimePickerFormat.Custom;
        }

        private void viewOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!viewOptionCheckBox.Checked)
            {
                viewOptionLabel.Text = "Card View";
                petitionsViewPanel.Controls.Remove(currentForm);
                petitionCardView.loadAllPetitionsApplyingNeccessaryFilters(0);
                currentForm = petitionCardView;
            }
            else
            {
                viewOptionLabel.Text = " List View";
                petitionsViewPanel.Controls.Remove(currentForm);
                petitionListView.loadAllPetitionsApplyingNeccessaryFilters(0);
                currentForm = petitionListView;
            }
            currentForm.TopLevel = false;
            petitionsViewPanel.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void searchOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!searchOptionCheckBox.Checked)
            {
                searchByIdOrAliasLabel.Text = "Search By ID";
                searchByIdOrAliasTextBox.Texts = "";
                StaticData.SearchByIdFilter = "";
                StaticData.SearchByAliasFilter = "";
            }
            else
            {
                searchByIdOrAliasLabel.Text = "Search By Alias";
                searchByIdOrAliasTextBox.Texts = "";
                StaticData.SearchByIdFilter = "";
                StaticData.SearchByAliasFilter = "";
            }

        }

        private void applyFiltersButton_Click(object sender, EventArgs e)
        {
            if(applyFiltersButton.Text == "Apply Filters")
            {
                applyFiltersButton.Text = "Clear Filters";
                StaticData.PetitionTypeFilter = petitionTypeComboBox.Texts;
                StaticData.PetitionStatusFilter = petitionStatusComboBox.Texts;
                StaticData.PetitionDateFilter = $"{petitionStartingDateDatePicker.Value.Day}," +
                    $"{petitionStartingDateDatePicker.Value.Month},{petitionStartingDateDatePicker.Value.Year}";

                if (typeof(PetitionCardView) == currentForm.GetType())
                {
                    petitionsViewPanel.Controls.Remove(currentForm);
                    petitionCardView.loadAllPetitionsApplyingNeccessaryFilters(0);
                    currentForm = petitionCardView;
                    currentForm.TopLevel = false;
                    petitionsViewPanel.Controls.Add(currentForm);
                    currentForm.Show();
                }
                else
                {
                    petitionsViewPanel.Controls.Remove(currentForm);
                    petitionListView.loadAllPetitionsApplyingNeccessaryFilters(0);
                    currentForm = petitionListView;
                    currentForm.TopLevel = false;
                    petitionsViewPanel.Controls.Add(currentForm);
                    currentForm.Show();
                }
                petitionTypeComboBox.Enabled = false;
                petitionStartingDateDatePicker.Enabled = false;
                petitionStartingDateDatePicker.SkinColor = SystemColors.Control;
                petitionStartingDateDatePicker.TextColor = SystemColors.ControlDark;
                petitionStatusComboBox.Enabled = false;
            }
            else
            {
                StaticData.PetitionTypeFilter = "";
                StaticData.PetitionDateFilter = "";
                StaticData.PetitionStatusFilter = "";
                if (typeof(PetitionCardView) == currentForm.GetType())
                {
                    petitionsViewPanel.Controls.Remove(currentForm);
                    petitionCardView.loadAllPetitionsApplyingNeccessaryFilters(0);
                    currentForm = petitionCardView;
                    currentForm.TopLevel = false;
                    petitionsViewPanel.Controls.Add(currentForm);
                    currentForm.Show();
                }
                else
                {
                    petitionsViewPanel.Controls.Remove(currentForm);
                    petitionListView.loadAllPetitionsApplyingNeccessaryFilters(0);
                    currentForm = petitionListView;
                    currentForm.TopLevel = false;
                    petitionsViewPanel.Controls.Add(currentForm);
                    currentForm.Show();
                }
                applyFiltersButton.Text = "Apply Filters";

                petitionTypeComboBox.Enabled = true;
                petitionStartingDateDatePicker.Enabled = true;
                petitionStartingDateDatePicker.SkinColor = Color.White;
                petitionStartingDateDatePicker.TextColor = Color.Black;
                petitionStatusComboBox.Enabled = true;
            }
        }

        private void searchByIdOrAliasButton_Click(object sender, EventArgs e)
        {
            if(searchByIdOrAliasLabel.Text == "Search By ID")
            {
                StaticData.SearchByIdFilter = searchByIdOrAliasTextBox.Texts;
            }
            else
            {
                StaticData.SearchByAliasFilter = searchByIdOrAliasTextBox.Texts;
            }

            petitionsViewPanel.Controls.Remove(currentForm);
            if (typeof(PetitionCardView) == currentForm.GetType())
            {   
                petitionCardView.loadAllPetitionsApplyingNeccessaryFilters(0);
                currentForm = petitionCardView;
            }
            else
            {
                petitionListView.loadAllPetitionsApplyingNeccessaryFilters(0);
                currentForm = petitionListView;
            }
            currentForm.TopLevel = false;
            petitionsViewPanel.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void applyFiltersButton_MouseEnter(object sender, EventArgs e)
        {
            applyFiltersButton.BackColor = Color.Black;
            applyFiltersButton.TextColor = Color.RoyalBlue;
            applyFiltersButton.BorderColor = Color.RoyalBlue;
        }

        private void applyFiltersButton_MouseLeave(object sender, EventArgs e)
        {
            applyFiltersButton.BackColor = Color.RoyalBlue;
            applyFiltersButton.TextColor = Color.Black;
            applyFiltersButton.BorderColor = Color.Black;
        }

        private void applyFiltersButton_Enter(object sender, EventArgs e)
        {
            applyFiltersButton.BackColor = Color.Black;
            applyFiltersButton.TextColor = Color.RoyalBlue;
            applyFiltersButton.BorderColor = Color.RoyalBlue;
        }

        private void applyFiltersButton_Leave(object sender, EventArgs e)
        {
            applyFiltersButton.BackColor = Color.RoyalBlue;
            applyFiltersButton.TextColor = Color.Black;
            applyFiltersButton.BorderColor = Color.Black;
        }

        private void searchByIdOrAliasTextBox_Enter(object sender, EventArgs e)
        {
            searchByIdOrAliasTextBox.BorderColor = Color.Black;
        }

        private void searchByIdOrAliasTextBox_Leave(object sender, EventArgs e)
        {
            searchByIdOrAliasTextBox.BorderColor = Color.RoyalBlue;
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
        }

        private void petitionStartingDateDatePicker_Enter(object sender, EventArgs e)
        {
            petitionStartingDateDatePicker.BorderColor = Color.Black;
        }

        private void petitionStartingDateDatePicker_Leave(object sender, EventArgs e)
        {
            petitionStartingDateDatePicker.BorderColor = Color.RoyalBlue;
        }

        private void petitionStatusComboBox_Enter(object sender, EventArgs e)
        {
            petitionStatusComboBox.BorderColor = Color.Black;
            petitionStatusComboBox.IconColor = Color.Black;
        }

        private void petitionStatusComboBox_Leave(object sender, EventArgs e)
        {
            petitionStatusComboBox.BorderColor = Color.RoyalBlue;
            petitionStatusComboBox.IconColor = Color.RoyalBlue;
        }
    }
}
