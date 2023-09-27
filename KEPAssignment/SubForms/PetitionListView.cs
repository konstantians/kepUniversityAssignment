using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KEPAssignment.SubForms
{
    public partial class PetitionListView : Form
    {
        public Petition[] Petitions;
        public Panel[] HidePanels = new Panel[7];
        public Label[] IdLabels = new Label[7];
        public Label[] TypeLabels = new Label[7];
        public Label[] DateLabels = new Label[7];
        public Label[] StatusLabels = new Label[7];
        public PetitionListView()
        {
            InitializeComponent();
            IdLabels[0] = idLabel1; IdLabels[1] = idLabel2;
            IdLabels[2] = idLabel3; IdLabels[3] = idLabel4;
            IdLabels[4] = idLabel5; IdLabels[5] = idLabel6;
            IdLabels[6] = idLabel7; 
            TypeLabels[0] = typeLabel1; TypeLabels[1] = typeLabel2;
            TypeLabels[2] = typeLabel3; TypeLabels[3] = typeLabel4;
            TypeLabels[4] = typeLabel5; TypeLabels[5] = typeLabel6;
            TypeLabels[6] = typeLabel7;
            DateLabels[0] = dateLabel1; DateLabels[1] = dateLabel2;
            DateLabels[2] = dateLabel3; DateLabels[3] = dateLabel4;
            DateLabels[4] = dateLabel5; DateLabels[5] = dateLabel6;
            DateLabels[6] = dateLabel7; 
            StatusLabels[0] = statusLabel1; StatusLabels[1] = statusLabel2;
            StatusLabels[2] = statusLabel3; StatusLabels[3] = statusLabel4;
            StatusLabels[4] = statusLabel5; StatusLabels[5] = statusLabel6;
            StatusLabels[5] = statusLabel7;
            HidePanels[0] = hideOnePanel; HidePanels[1] = hideTwoPanel;
            HidePanels[2] = hideThreePanel; HidePanels[3] = hideFourPanel;
            HidePanels[4] = hideFivePanel; HidePanels[5] = hideSixPanel;
            HidePanels[6] = hideSevenPanel;
            loadAllPetitionsApplyingNeccessaryFilters(0);
        }

        public void loadAllPetitionsApplyingNeccessaryFilters(int startingPoint)
        {
            Petitions = DataAccessOperations.GetPetitions().ToArray();

            List<Petition> filteredPetitions = new List<Petition>();

            DateTime filterDateTime = DateTime.Now;
            if (StaticData.PetitionDateFilter != "")
            {
                string[] filterDateTimeParts = StaticData.PetitionDateFilter.Split(',');
                filterDateTime = new DateTime(Int32.Parse(filterDateTimeParts[2]),
                    Int32.Parse(filterDateTimeParts[1]), Int32.Parse(filterDateTimeParts[0]));
            }

            foreach (Petition petition in Petitions)
            {

                string[] petitionDateTimeParts = petition.PetitionDate.Split(',');
                DateTime petitionDateTime = new DateTime(Int32.Parse(petitionDateTimeParts[2]),
                    Int32.Parse(petitionDateTimeParts[1]), Int32.Parse(petitionDateTimeParts[0]));


                if ((petition.PetitionStatus == StaticData.PetitionStatusFilter || StaticData.PetitionStatusFilter == "")
                    && (petition.PetitionType == StaticData.PetitionTypeFilter || StaticData.PetitionTypeFilter == "")
                    && (petition.PetitionId.ToString().Contains(StaticData.SearchByIdFilter) || StaticData.SearchByIdFilter == "")
                    && (petition.PetitionAlias.ToString().Contains(StaticData.SearchByAliasFilter) || StaticData.SearchByAliasFilter == "")
                    && (StaticData.PetitionDateFilter == "" || filterDateTime <= petitionDateTime))
                {
                    filteredPetitions.Add(petition);
                }
            }

            Petition[] filteredPetitionsArray = filteredPetitions.ToArray();

            int endingPoint;
            if (startingPoint + 7 <= filteredPetitionsArray.Length)
            {
                endingPoint = startingPoint + 7;
            }
            else
            {
                endingPoint = filteredPetitionsArray.Length;
            }

            int count = 0;
            for (int i = startingPoint; i < endingPoint; i++)
            {
                IdLabels[i % 7].Text = $"{filteredPetitionsArray[i].PetitionId}";
                TypeLabels[i % 7].Text = $"{filteredPetitionsArray[i].PetitionType}";
                string[] dateParts = filteredPetitionsArray[i].PetitionDate.Split(',');
                DateLabels[i % 7].Text = $"{dateParts[0]}/{dateParts[1]}/{dateParts[2]}";
                StatusLabels[i % 7].Text = $"{filteredPetitionsArray[i].PetitionStatus}";
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                HidePanels[i].Show();
            }

            if (count != 7)
            {
                for (int i = count; i < 7; i++)
                {
                    HidePanels[i].Hide();
                }
            }

        }

        private void listButton1_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(0);
        }

        private void listButton2_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(7);
        }

        private void listButton3_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(14);
        }

        private void listButton4_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(21);
        }

        private void listButton5_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(28);
        }

        private void listButton6_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(35);
        }

        private void listButton7_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(42);
        }

        private void listButton8_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(49);
        }

        private void detailsButton1_Enter(object sender, EventArgs e)
        {
            detailsButton1.BackColor = Color.White;
            detailsButton1.TextColor = Color.Black;
            detailsButton1.BorderColor = Color.Black;
        }

        private void detailsButton1_Leave(object sender, EventArgs e)
        {
            detailsButton1.BackColor = Color.Black;
            detailsButton1.TextColor = Color.White;
            detailsButton1.BorderColor = Color.White;
        }

        private void detailsButton1_MouseEnter(object sender, EventArgs e)
        {
            detailsButton1.BackColor = Color.White;
            detailsButton1.TextColor = Color.Black;
            detailsButton1.BorderColor = Color.Black;
        }

        private void detailsButton1_MouseLeave(object sender, EventArgs e)
        {
            detailsButton1.BackColor = Color.Black;
            detailsButton1.TextColor = Color.White;
            detailsButton1.BorderColor = Color.White;
        }

        private void detailsButton2_Enter(object sender, EventArgs e)
        {
            detailsButton2.BackColor = Color.White;
            detailsButton2.TextColor = Color.Black;
            detailsButton2.BorderColor = Color.Black;
        }

        private void detailsButton2_Leave(object sender, EventArgs e)
        {
            detailsButton2.BackColor = Color.Black;
            detailsButton2.TextColor = Color.White;
            detailsButton2.BorderColor = Color.White;
        }

        private void detailsButton2_MouseEnter(object sender, EventArgs e)
        {
            detailsButton2.BackColor = Color.White;
            detailsButton2.TextColor = Color.Black;
            detailsButton2.BorderColor = Color.Black;
        }

        private void detailsButton2_MouseLeave(object sender, EventArgs e)
        {
            detailsButton2.BackColor = Color.Black;
            detailsButton2.TextColor = Color.White;
            detailsButton2.BorderColor = Color.White;
        }

        private void detailsButton3_Enter(object sender, EventArgs e)
        {
            detailsButton3.BackColor = Color.White;
            detailsButton3.TextColor = Color.Black;
            detailsButton3.BorderColor = Color.Black;
        }

        private void detailsButton3_Leave(object sender, EventArgs e)
        {
            detailsButton3.BackColor = Color.Black;
            detailsButton3.TextColor = Color.White;
            detailsButton3.BorderColor = Color.White;
        }

        private void detailsButton3_MouseEnter(object sender, EventArgs e)
        {
            detailsButton3.BackColor = Color.White;
            detailsButton3.TextColor = Color.Black;
            detailsButton3.BorderColor = Color.Black;
        }

        private void detailsButton3_MouseLeave(object sender, EventArgs e)
        {
            detailsButton3.BackColor = Color.Black;
            detailsButton3.TextColor = Color.White;
            detailsButton3.BorderColor = Color.White;
        }

        private void detailsButton4_Enter(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.White;
            detailsButton4.TextColor = Color.Black;
            detailsButton4.BorderColor = Color.Black;
        }

        private void detailsButton4_Leave(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.Black;
            detailsButton4.TextColor = Color.White;
            detailsButton4.BorderColor = Color.White;
        }

        private void detailsButton4_MouseEnter(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.White;
            detailsButton4.TextColor = Color.Black;
            detailsButton4.BorderColor = Color.Black;
        }

        private void detailsButton4_MouseLeave(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.Black;
            detailsButton4.TextColor = Color.White;
            detailsButton4.BorderColor = Color.White;
        }

        private void detailsButton5_Enter(object sender, EventArgs e)
        {
            detailsButton5.BackColor = Color.White;
            detailsButton5.TextColor = Color.Black;
            detailsButton5.BorderColor = Color.Black;
        }

        private void detailsButton5_Leave(object sender, EventArgs e)
        {
            detailsButton5.BackColor = Color.Black;
            detailsButton5.TextColor = Color.White;
            detailsButton5.BorderColor = Color.White;
        }

        private void detailsButton5_MouseEnter(object sender, EventArgs e)
        {
            detailsButton5.BackColor = Color.White;
            detailsButton5.TextColor = Color.Black;
            detailsButton5.BorderColor = Color.Black;
        }

        private void detailsButton5_MouseLeave(object sender, EventArgs e)
        {
            detailsButton5.BackColor = Color.Black;
            detailsButton5.TextColor = Color.White;
            detailsButton5.BorderColor = Color.White;
        }

        private void detailsButton6_Enter(object sender, EventArgs e)
        {
            detailsButton6.BackColor = Color.White;
            detailsButton6.TextColor = Color.Black;
            detailsButton6.BorderColor = Color.Black;
        }

        private void detailsButton6_Leave(object sender, EventArgs e)
        {
            detailsButton6.BackColor = Color.Black;
            detailsButton6.TextColor = Color.White;
            detailsButton6.BorderColor = Color.White;
        }

        private void detailsButton6_MouseEnter(object sender, EventArgs e)
        {
            detailsButton6.BackColor = Color.White;
            detailsButton6.TextColor = Color.Black;
            detailsButton6.BorderColor = Color.Black;
        }

        private void detailsButton6_MouseLeave(object sender, EventArgs e)
        {
            detailsButton6.BackColor = Color.Black;
            detailsButton6.TextColor = Color.White;
            detailsButton6.BorderColor = Color.White;
        }

        private void detailsButton7_Enter(object sender, EventArgs e)
        {
            detailsButton7.BackColor = Color.White;
            detailsButton7.TextColor = Color.Black;
            detailsButton7.BorderColor = Color.Black;
        }

        private void detailsButton7_Leave(object sender, EventArgs e)
        {
            detailsButton7.BackColor = Color.Black;
            detailsButton7.TextColor = Color.White;
            detailsButton7.BorderColor = Color.White;
        }

        private void detailsButton7_MouseEnter(object sender, EventArgs e)
        {
            detailsButton7.BackColor = Color.White;
            detailsButton7.TextColor = Color.Black;
            detailsButton7.BorderColor = Color.Black;
        }

        private void detailsButton7_MouseLeave(object sender, EventArgs e)
        {
            detailsButton7.BackColor = Color.Black;
            detailsButton7.TextColor = Color.White;
            detailsButton7.BorderColor = Color.White;
        }

        private void detailsButton1_Click(object sender, EventArgs e)
        {
            setupDetails(idLabel1.Text);
        }

        private void detailsButton2_Click(object sender, EventArgs e)
        {
            setupDetails(idLabel2.Text);
        }

        private void detailsButton3_Click(object sender, EventArgs e)
        {
            setupDetails(idLabel3.Text);
        }

        private void detailsButton4_Click(object sender, EventArgs e)
        {
            setupDetails(idLabel4.Text);
        }

        private void detailsButton5_Click(object sender, EventArgs e)
        {
            setupDetails(idLabel5.Text);
        }

        private void detailsButton6_Click(object sender, EventArgs e)
        {
            setupDetails(idLabel6.Text);
        }

        private void detailsButton7_Click(object sender, EventArgs e)
        {
            setupDetails(idLabel7.Text);
        }

        private void setupDetails(string petitionId)
        {
            StaticData.OpenPetitionDetailsForm = true;
            StaticData.PetitionIdValue = int.Parse(petitionId);
        }
    }
}
