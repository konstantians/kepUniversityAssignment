using System;
using System.Drawing;
using System.Windows.Forms;

namespace KEPAssignment.SubForms
{
    public partial class CitizenFilterMenu : Form
    {
        public CitizenFilterMenu()
        {
            InitializeComponent();
        }

        private void searchByAFMButton_Click(object sender, EventArgs e)
        {
            StaticData.SearchByAFMFilter = searchByAFMTextBox.Texts;
            StaticData.FilterAdded = true;
        }

        private void searchByAMKAButton_Click(object sender, EventArgs e)
        {
            StaticData.SearchByAMKAFilter = searchByAMKATextBox.Texts;
            StaticData.FilterAdded = true;
        }

        private void searchByFullNameButton_Click(object sender, EventArgs e)
        {
            StaticData.SearchByFullNameFilter = searchByFullNameTextBox.Texts;
            StaticData.FilterAdded = true;
        }

        private void searchByAddressButton_Click(object sender, EventArgs e)
        {
            StaticData.SearchByAddressFilter = searchByAddressTextBox.Texts;
            StaticData.FilterAdded = true;
        }

        private void searchByEmailButton_Click(object sender, EventArgs e)
        {
            StaticData.SearchByEmailFilter = searchByEmailTextBox.Texts;
            StaticData.FilterAdded = true;
        }

        private void searchByPhoneNumberButton_Click(object sender, EventArgs e)
        {
            StaticData.SearchByPhoneNumberFilter = searchByPhoneNumberTextBox.Texts;
            StaticData.FilterAdded = true;
        }

        private void searchByAFMTextBox_Enter(object sender, EventArgs e)
        {
            searchByAFMTextBox.BorderColor = Color.Black;
        }

        private void searchByAFMTextBox_Leave(object sender, EventArgs e)
        {
            searchByAFMTextBox.BorderColor = Color.RoyalBlue;
        }

        private void searchByAMKATextBox_Enter(object sender, EventArgs e)
        {
            searchByAMKATextBox.BorderColor = Color.Black;
        }

        private void searchByAMKATextBox_Leave(object sender, EventArgs e)
        {
            searchByAMKATextBox.BorderColor = Color.RoyalBlue;
        }

        private void searchByFullNameTextBox_Enter(object sender, EventArgs e)
        {
            searchByFullNameTextBox.BorderColor = Color.Black;
        }

        private void searchByFullNameTextBox_Leave(object sender, EventArgs e)
        {
            searchByFullNameTextBox.BorderColor = Color.RoyalBlue;
        }

        private void searchByAddressTextBox_Enter(object sender, EventArgs e)
        {
            searchByAddressTextBox.BorderColor = Color.Black;
        }

        private void searchByAddressTextBox_Leave(object sender, EventArgs e)
        {
            searchByAddressTextBox.BorderColor = Color.RoyalBlue;
        }

        private void searchByEmailTextBox_Enter(object sender, EventArgs e)
        {
            searchByEmailTextBox.BorderColor = Color.Black;
        }

        private void searchByEmailTextBox_Leave(object sender, EventArgs e)
        {
            searchByEmailTextBox.BorderColor = Color.RoyalBlue;
        }

        private void searchByPhoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            searchByPhoneNumberTextBox.BorderColor = Color.Black;
        }

        private void searchByPhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            searchByPhoneNumberTextBox.BorderColor = Color.RoyalBlue;
        }
    }
}
