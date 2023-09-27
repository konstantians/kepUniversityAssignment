using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class HomeForm : Form
    {
        List<Petition> Petitions = new List<Petition>();
        List<Citizen> Citizens = new List<Citizen>();

        public HomeForm()
        {
            InitializeComponent();
            RefreshHomeForm();
        }

        public void RefreshHomeForm()
        {
            Petitions = DataAccessOperations.GetPetitions();
            Citizens = DataAccessOperations.GetCitizens();
            totalPetitionsLabel.Text = Petitions.Count == 1 ? "1 Petition" : $"{Petitions.Count} Total Petitions";
            totalAppliedCitizensLabel.Text = Citizens.Count == 1 ? "1 Applied Citizen" : $"{Citizens.Count} Total Applied Citizens";
            newAppliedCitizensLabel.Text = Citizens.Count == 1 ? "1 New Applied Citizen Today" : $"{Citizens.Count} New Applied Citizens Today";
            newPetitionsTodayLabel.Text = Petitions.Count == 1 ? "1 New Petitions Today" : $"{Petitions.Count} Total Petitions";

            int pendingCount = 0;
            int acceptedCount = 0;
            int rejectedCount = 0;
            foreach(Petition petition in Petitions)
            {
                if(petition.PetitionStatus == "Pending")
                {
                    pendingCount++;
                }
                else if(petition.PetitionStatus == "Accepted")
                {
                    acceptedCount++;
                }
                else
                {
                    rejectedCount++;
                }
            }

            pendingPetitionsLabel.Text = pendingCount == 1 ? "1 Pending Petition" : $"{pendingCount} Pending Petitions";
            acceptedPetitionsLabel.Text = acceptedCount == 1 ? "1 Accepted Petition" : $"{acceptedCount} Accepted Petitions";
            rejectedPetitionsLabel.Text = rejectedCount == 1 ? "1 Rejected Petition" : $"{rejectedCount} Rejected Petitions";

            int underageCount = 0;
            int nativeCount = 0;
            foreach (Citizen citizen in Citizens)
            {
                string x = citizen.DateOfBirth.Split(',').Last();
                if (Int32.Parse(citizen.DateOfBirth.Split(',').Last()) >= 2006)
                {
                    underageCount++;
                }

                if (citizen.AMKA != "" && citizen.AMKA != null)
                {
                    nativeCount++;
                }
            }
            underageCitizensLabel.Text = underageCount == 1 ? "1 Applied Underage Citizen" : $"{underageCount} Applied Underage Citizens";
            nativeCitizensLabel.Text = nativeCount == 1 ? "1 Applied Native Citizen" : $"{nativeCount} Applied Native Citizens";
        }

        private void viewPetitionsButton_Click(object sender, EventArgs e)
        {
            StaticData.OpenViewPetitionForm = true;
        }

        private void viewCitizensButton_Click(object sender, EventArgs e)
        {
            StaticData.OpenViewCitizenForm = true;
        }

        private void addPetitionButton_Click(object sender, EventArgs e)
        {
            StaticData.OpenAddPetitionForm = true;
        }

        private void applyCitizenButton_Click(object sender, EventArgs e)
        {
            StaticData.OpenAddCitizenForm = true;
        }

        private void viewPetitionsButton_MouseEnter(object sender, EventArgs e)
        {
            viewPetitionsButton.BackColor = Color.White;
            viewPetitionsButton.ForeColor = Color.FromArgb(35, 35, 35);
        }

        private void viewPetitionsButton_MouseLeave(object sender, EventArgs e)
        {
            viewPetitionsButton.BackColor = Color.FromArgb(35, 35, 35);
            viewPetitionsButton.ForeColor = Color.White;
        }

        private void viewPetitionsButton_Enter(object sender, EventArgs e)
        {
            viewPetitionsButton.BackColor = Color.White;
            viewPetitionsButton.ForeColor = Color.FromArgb(35, 35, 35);
        }

        private void viewPetitionsButton_Leave(object sender, EventArgs e)
        {
            viewPetitionsButton.BackColor = Color.FromArgb(35, 35, 35);
            viewPetitionsButton.ForeColor = Color.White;
        }

        private void viewCitizensButton_MouseEnter(object sender, EventArgs e)
        {
            viewCitizensButton.BackColor = Color.White;
            viewCitizensButton.ForeColor = Color.FromArgb(35, 35, 35);
        }

        private void viewCitizensButton_MouseLeave(object sender, EventArgs e)
        {
            viewCitizensButton.BackColor = Color.FromArgb(35, 35, 35);
            viewCitizensButton.ForeColor = Color.White;
        }

        private void viewCitizensButton_Enter(object sender, EventArgs e)
        {
            viewCitizensButton.BackColor = Color.White;
            viewCitizensButton.ForeColor = Color.FromArgb(35, 35, 35);
        }

        private void viewCitizensButton_Leave(object sender, EventArgs e)
        {
            viewCitizensButton.BackColor = Color.FromArgb(35, 35, 35);
            viewCitizensButton.ForeColor = Color.White;
        }

        private void addPetitionButton_MouseEnter(object sender, EventArgs e)
        {
            addPetitionButton.BackColor = Color.White;
            addPetitionButton.ForeColor = Color.FromArgb(35, 35, 35);
        }

        private void addPetitionButton_MouseLeave(object sender, EventArgs e)
        {
            addPetitionButton.BackColor = Color.FromArgb(35, 35, 35);
            addPetitionButton.ForeColor = Color.White;
        }

        private void addPetitionButton_Enter(object sender, EventArgs e)
        {
            addPetitionButton.BackColor = Color.White;
            addPetitionButton.ForeColor = Color.FromArgb(35, 35, 35);
        }

        private void addPetitionButton_Leave(object sender, EventArgs e)
        {
            addPetitionButton.BackColor = Color.FromArgb(35, 35, 35);
            addPetitionButton.ForeColor = Color.White;
        }

        private void applyCitizenButton_MouseEnter(object sender, EventArgs e)
        {
            applyCitizenButton.BackColor = Color.White;
            applyCitizenButton.ForeColor = Color.FromArgb(35, 35, 35);
        }

        private void applyCitizenButton_MouseLeave(object sender, EventArgs e)
        {
            applyCitizenButton.BackColor = Color.FromArgb(35, 35, 35);
            applyCitizenButton.ForeColor = Color.White;
        }

        private void applyCitizenButton_Enter(object sender, EventArgs e)
        {
            applyCitizenButton.BackColor = Color.White;
            applyCitizenButton.ForeColor = Color.FromArgb(35, 35, 35);
        }

        private void applyCitizenButton_Leave(object sender, EventArgs e)
        {
            applyCitizenButton.BackColor = Color.FromArgb(35, 35, 35);
            applyCitizenButton.ForeColor = Color.White;
        }
    }
}
