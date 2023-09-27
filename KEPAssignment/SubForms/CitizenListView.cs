using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KEPAssignment.SubForms
{
    public partial class CitizenListView : Form
    {
        public Citizen[] Citizens;
        public Panel[] Panels = new Panel[7];
        public Label[] AFMLabels = new Label[7];
        public Label[] AMKALabels = new Label[7];
        public Label[] NameLabels = new Label[7];
        public Label[] EmailLabels = new Label[7];
        public CitizenListView()
        {
            InitializeComponent();
            AFMLabels[0] = afmLabel1; AFMLabels[1] = afmLabel2;
            AFMLabels[2] = afmLabel3; AFMLabels[3] = afmLabel4;
            AFMLabels[4] = afmLabel5; AFMLabels[5] = afmLabel6; AFMLabels[6] = afmLabel7;
            AMKALabels[0] = amkaLabel1; AMKALabels[1] = amkaLabel2;
            AMKALabels[2] = amkaLabel3; AMKALabels[3] = amkaLabel4;
            AMKALabels[4] = amkaLabel5; AMKALabels[5] = amkaLabel6; AMKALabels[6] = amkaLabel7;
            NameLabels[0] = fullNameLabel1; NameLabels[1] = fullNameLabel2;
            NameLabels[2] = fullNameLabel3; NameLabels[3] = fullNameLabel4;
            NameLabels[4] = fullNameLabel5; NameLabels[5] = fullNameLabel6; NameLabels[6] = fullNameLabel7;
            EmailLabels[0] = emailLabel1; EmailLabels[1] = emailLabel2;
            EmailLabels[2] = emailLabel3; EmailLabels[3] = emailLabel4;
            EmailLabels[4] = emailLabel5; EmailLabels[5] = emailLabel6; EmailLabels[6] = emailLabel7;
            Panels[0] = hideOnePanel; Panels[1] = hideTwoPanel;
            Panels[2] = hideThreePanel; Panels[3] = hideFourPanel;
            Panels[4] = hideFivePanel; Panels[5] = hideSixPanel;
            Panels[6] = hideSevenPanel;
        }

        public void loadAllPetitionsApplyingNeccessaryFilters(int startingPoint)
        {
            Citizens = DataAccessOperations.GetCitizens().ToArray();

            List<Citizen> filteredCitizens = new List<Citizen>();

            foreach (Citizen citizen in Citizens)
            {

                if ((citizen.AFM.Contains(StaticData.SearchByAFMFilter) || StaticData.SearchByAFMFilter == "")
                    && (citizen.AMKA.Contains(StaticData.SearchByAMKAFilter) || StaticData.SearchByAMKAFilter == "")
                    && (citizen.FullName.Contains(StaticData.SearchByFullNameFilter) || StaticData.SearchByFullNameFilter == "")
                    && (citizen.Address.Contains(StaticData.SearchByAddressFilter) || StaticData.SearchByAddressFilter == "")
                    && (citizen.Email.Contains(StaticData.SearchByEmailFilter) || StaticData.SearchByEmailFilter == "")
                    && (citizen.PhoneNumber.Contains(StaticData.SearchByPhoneNumberFilter) || StaticData.SearchByPhoneNumberFilter == "")
                    )
                {
                    filteredCitizens.Add(citizen);
                }
            }

            Citizen[] filteredCitizensArray = filteredCitizens.ToArray();

            int endingPoint;
            if (startingPoint + 7 <= filteredCitizensArray.Length)
            {
                endingPoint = startingPoint + 7;
            }
            else
            {
                endingPoint = filteredCitizensArray.Length;
            }

            int count = 0;
            for (int i = startingPoint; i < endingPoint; i++)
            {
                AFMLabels[i % 7].Text = filteredCitizensArray[i].AFM;
                AMKALabels[i % 7].Text = filteredCitizensArray[i].AMKA;
                NameLabels[i % 7].Text = filteredCitizensArray[i].FullName;
                EmailLabels[i % 7].Text = filteredCitizensArray[i].Email;
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                Panels[i].Show();
            }

            if (count != 7)
            {
                for (int i = count; i < 7; i++)
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
            loadAllPetitionsApplyingNeccessaryFilters(7);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(14);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(21);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(28);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(35);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(42);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(49);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(56);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(63);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(70);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(77);
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
            setupDetails(afmLabel1.Text);
        }

        private void detailsButton2_Click(object sender, EventArgs e)
        {
            setupDetails(afmLabel2.Text);
        }

        private void detailsButton3_Click(object sender, EventArgs e)
        {
            setupDetails(afmLabel3.Text);
        }

        private void detailsButton4_Click(object sender, EventArgs e)
        {
            setupDetails(afmLabel4.Text);
        }

        private void detailsButton5_Click(object sender, EventArgs e)
        {
            setupDetails(afmLabel5.Text);
        }

        private void detailsButton6_Click(object sender, EventArgs e)
        {
            setupDetails(afmLabel6.Text);
        }

        private void detailsButton7_Click(object sender, EventArgs e)
        {
            setupDetails(afmLabel7.Text);
        }

        private void setupDetails(string afmLabelText)
        {
            StaticData.OpenCitizenDetailsForm = true;
            StaticData.CitizenDetailsFormAfmValue = afmLabelText;
        }
    }
}
