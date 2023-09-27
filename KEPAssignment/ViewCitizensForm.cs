using KEPAssignment.SubForms;
using System;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class ViewCitizensForm : Form
    {
        CitizenCardView citizenCardView = new CitizenCardView();
        CitizenListView citizenListView = new CitizenListView();
        CitizenFilterMenu citizenFilterMenu = new CitizenFilterMenu();
        Form currentForm = new Form();
        public ViewCitizensForm()
        {
            InitializeComponent();
            currentForm = citizenCardView;
            currentForm.TopLevel = false;
            citizensViewPanel.Controls.Add(currentForm);
            currentForm.Show();

            citizenFilterMenu.TopLevel = false;
            extendedFilterMenu.Controls.Add(citizenFilterMenu);
            extendedFilterMenu.Visible = false;
            citizenFilterMenu.Show();
        }

        private void filterMenuButton_Click(object sender, EventArgs e)
        {
            if(extendedFilterMenu.Height > 454)
            {
                extendedFilterMenu.Visible = false;
                extendedFilterMenu.Height -= 454;
            }
            else
            {
                extendedFilterMenu.Visible = true;
                extendedFilterMenu.Height += 454;
            }
        }

        private void filterCheckTimer_Tick(object sender, EventArgs e)
        {
            if (!StaticData.FilterAdded)
                return;

            //change it back to no changes
            StaticData.FilterAdded = false;

            if (typeof(CitizenCardView) == currentForm.GetType())
            {
                citizensViewPanel.Controls.Remove(currentForm);
                citizenCardView.loadAllPetitionsApplyingNeccessaryFilters(0);
                currentForm = citizenCardView;
                currentForm.TopLevel = false;
                citizensViewPanel.Controls.Add(currentForm);
                currentForm.Show();
            }
            else
            {
                citizensViewPanel.Controls.Remove(currentForm);
                citizenListView.loadAllPetitionsApplyingNeccessaryFilters(0);
                currentForm = citizenListView;
                currentForm.TopLevel = false;
                citizensViewPanel.Controls.Add(currentForm);
                currentForm.Show();
            }
        }

        private void viewOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!viewOptionCheckBox.Checked)
            {
                viewOptionLabel.Text = "Card View";
                citizensViewPanel.Controls.Remove(currentForm);
                citizenCardView.loadAllPetitionsApplyingNeccessaryFilters(0);
                currentForm = citizenCardView;
                currentForm.TopLevel = false;
                citizensViewPanel.Controls.Add(currentForm);
                currentForm.Show();
            }
            else
            {
                viewOptionLabel.Text = " List View";
                citizensViewPanel.Controls.Remove(currentForm);
                citizenListView.loadAllPetitionsApplyingNeccessaryFilters(0);
                currentForm = citizenListView;
                currentForm.TopLevel = false;
                citizensViewPanel.Controls.Add(currentForm);
                currentForm.Show();
            }
        }
    }
}
