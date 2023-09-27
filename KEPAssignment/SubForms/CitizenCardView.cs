using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KEPAssignment.SubForms
{
    public partial class CitizenCardView : Form
    {
        public Citizen[] Citizens;
        public Panel[] Panels = new Panel[6];
        public Label[] AFMLabels = new Label[6];
        public Label[] NameLabels = new Label[6];
        public Label[] AddressLabels = new Label[6];
        public Label[] EmailLabels = new Label[6];
        public Label[] PhoneNumberLabels = new Label[6];
        public CitizenCardView()
        {
            InitializeComponent();
            AFMLabels[0] = afmLabel1; AFMLabels[1] = afmLabel2;
            AFMLabels[2] = afmLabel3; AFMLabels[3] = afmLabel4;
            AFMLabels[4] = afmLabel5; AFMLabels[5] = afmLabel6;
            NameLabels[0] = nameLabel1; NameLabels[1] = nameLabel2;
            NameLabels[2] = nameLabel3; NameLabels[3] = nameLabel4;
            NameLabels[4] = nameLabel5; NameLabels[5] = nameLabel6;
            AddressLabels[0] = addressLabel1; AddressLabels[1] = addressLabel2;
            AddressLabels[2] = addressLabel3; AddressLabels[3] = addressLabel4;
            AddressLabels[4] = addressLabel5; AddressLabels[5] = addressLabel6;
            EmailLabels[0] = emailLabel1; EmailLabels[1] = emailLabel2;
            EmailLabels[2] = emailLabel3; EmailLabels[3] = emailLabel4;
            EmailLabels[4] = emailLabel5; EmailLabels[5] = emailLabel6;
            PhoneNumberLabels[0] = phoneNumberLabel1; PhoneNumberLabels[1] = phoneNumberLabel2;
            PhoneNumberLabels[2] = phoneNumberLabel3; PhoneNumberLabels[3] = phoneNumberLabel4;
            PhoneNumberLabels[4] = phoneNumberLabel5; PhoneNumberLabels[5] = phoneNumberLabel6;
            Panels[0] = panel1; Panels[1] = panel2;
            Panels[2] = panel3; Panels[3] = panel4;
            Panels[4] = panel5; Panels[5] = panel6;
            loadAllPetitionsApplyingNeccessaryFilters(0);
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
            if (startingPoint + 6 <= filteredCitizensArray.Length)
            {
                endingPoint = startingPoint + 6;
            }
            else
            {
                endingPoint = filteredCitizensArray.Length;
            }

            int count = 0;
            for (int i = startingPoint; i < endingPoint; i++)
            {
                AFMLabels[i % 6].Text = $"AFM : {filteredCitizensArray[i].AFM}";
                NameLabels[i % 6].Text = $"Name : {filteredCitizensArray[i].FullName}";
                AddressLabels[i % 6].Text = $"Address : {filteredCitizensArray[i].Address}";
                EmailLabels[i % 6].Text = $"Email : {filteredCitizensArray[i].Email}";
                PhoneNumberLabels[i % 6].Text = $"PhoneNumber : {filteredCitizensArray[i].PhoneNumber}";
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                Panels[i].Show();
            }

            if (count != 6)
            {
                for (int i = count; i < 6; i++)
                {
                    Panels[i].Hide();
                }
            }

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

        private void setupDetails(string afmLabelText)
        {
            string afm = afmLabelText.Split(':')[1].Trim();
            StaticData.OpenCitizenDetailsForm = true;
            StaticData.CitizenDetailsFormAfmValue = afm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(12);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(18);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(24);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(30);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(36);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(42);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(48);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(54);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(60);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            loadAllPetitionsApplyingNeccessaryFilters(66);
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

        private void detailsButton5_Enter(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.White;
            detailsButton4.TextColor = Color.Black;
            detailsButton4.BorderColor = Color.Black;
        }

        private void detailsButton5_Leave(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.Black;
            detailsButton4.TextColor = Color.White;
            detailsButton4.BorderColor = Color.White;
        }

        private void detailsButton5_MouseEnter(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.White;
            detailsButton4.TextColor = Color.Black;
            detailsButton4.BorderColor = Color.Black;
        }

        private void detailsButton5_MouseLeave(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.Black;
            detailsButton4.TextColor = Color.White;
            detailsButton4.BorderColor = Color.White;
        }

        private void detailsButton6_Enter(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.White;
            detailsButton4.TextColor = Color.Black;
            detailsButton4.BorderColor = Color.Black;
        }

        private void detailsButton6_Leave(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.Black;
            detailsButton4.TextColor = Color.White;
            detailsButton4.BorderColor = Color.White;
        }

        private void detailsButton6_MouseEnter(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.White;
            detailsButton4.TextColor = Color.Black;
            detailsButton4.BorderColor = Color.Black;
        }

        private void detailsButton6_MouseLeave(object sender, EventArgs e)
        {
            detailsButton4.BackColor = Color.Black;
            detailsButton4.TextColor = Color.White;
            detailsButton4.BorderColor = Color.White;
        }
    }
}
