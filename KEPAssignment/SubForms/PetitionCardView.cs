using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KEPAssignment.SubForms
{
    public partial class PetitionCardView : Form
    {
        public Petition[] Petitions;
        public Panel[] Panels = new Panel[4];
        public Label[] IdLabels = new Label[4];
        public Label[] AliasLabels = new Label[4];
        public Label[] TypeLabels = new Label[4];
        public Label[] DateLabels = new Label[4];
        public Label[] StatusLabels = new Label[4];
        public PetitionCardView()
        {
            InitializeComponent();
            IdLabels[0] = idLabel1; IdLabels[1] = idLabel2;
            IdLabels[2] = idLabel3; IdLabels[3] = idLabel4;
            AliasLabels[0] = aliasLabel1; AliasLabels[1] = aliasLabel2;
            AliasLabels[2] = aliasLabel3; AliasLabels[3] = aliasLabel4;
            TypeLabels[0] = typeLabel1; TypeLabels[1] = typeLabel2;
            TypeLabels[2] = typeLabel3; TypeLabels[3] = typeLabel4;
            DateLabels[0] = dateLabel1; DateLabels[1] = dateLabel2;
            DateLabels[2] = dateLabel3; DateLabels[3] = dateLabel4;
            StatusLabels[0] = statusLabel1; StatusLabels[1] = statusLabel2;
            StatusLabels[2] = statusLabel3; StatusLabels[3] = statusLabel4;
            Panels[0] = panel1; Panels[1] = panel2;
            Panels[2] = panel3; Panels[3] = panel4;
            loadAllPetitionsApplyingNeccessaryFilters(0);
        }

        public void loadAllPetitionsApplyingNeccessaryFilters(int startingPoint)
        {
            Petitions = DataAccessOperations.GetPetitions().ToArray();

            List<Petition> filteredPetitions = new List<Petition>();

            DateTime filterDateTime = DateTime.Now;
            if (StaticData.PetitionDateFilter != "") {
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
                    && (petition.PetitionAlias.ToString().ToLower().Contains(StaticData.SearchByAliasFilter.ToLower()) || StaticData.SearchByAliasFilter == "")
                    && (StaticData.PetitionDateFilter == "" || filterDateTime <= petitionDateTime))
                {
                    filteredPetitions.Add(petition);
                }
            }



            Petition[] filteredPetitionsArray = filteredPetitions.ToArray();

            int endingPoint;
            if(startingPoint + 4 <= filteredPetitionsArray.Length)
            {
                endingPoint = startingPoint + 4;
            }
            else
            {
                endingPoint = filteredPetitionsArray.Length;
            }

            int count = 0;
            for(int i = startingPoint; i < endingPoint; i++)
            {
                IdLabels[i % 4].Text = $"ID : {filteredPetitionsArray[i].PetitionId}";
                AliasLabels[i % 4].Text = $"Alias : {filteredPetitionsArray[i].PetitionAlias}";
                TypeLabels[i % 4].Text = $"Type : {filteredPetitionsArray[i].PetitionType}";
                string[] dateParts = filteredPetitionsArray[i].PetitionDate.Split(',');
                DateLabels[i % 4].Text = $"Date : {dateParts[0]}/{dateParts[1]}/{dateParts[2]}";
                StatusLabels[i % 4].Text = $"Status : {filteredPetitionsArray[i].PetitionStatus}";
                count++;
            }

            for(int i = 0; i < count; i++)
            {
                Panels[i].Show();
            }

            if(count != 4)
            {
                for(int i = count; i < 4; i++)
                {
                    Panels[i].Hide();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(8);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(12);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(16);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(20);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(24);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(28);
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

        private void setupDetails(string petitionIdLabelText)
        {
            int petitionId = Int32.Parse(petitionIdLabelText.Split(':')[1].Trim());
            StaticData.PetitionIdValue = petitionId;
            StaticData.OpenPetitionDetailsForm = true;
        }
    }
}
