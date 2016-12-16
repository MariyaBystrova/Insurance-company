using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.command;

namespace InsuranceCompany
{
    public partial class RegisterClient : Form
    {
        public RegisterClient()
        {
            InitializeComponent();
            groupBoxIndividual.Visible = false;
            groupBoxLegal.Visible = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterClient_Load(object sender, EventArgs e)
        {

        }

        private void clientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxIndividual.Visible = false;
            groupBoxLegal.Visible = false;
            if (clientType.SelectedItem.Equals("юр. лицо"))
            {
                groupBoxLegal.Visible = true;
            }
            if (clientType.SelectedItem.Equals("физ. лицо"))
            {
                groupBoxIndividual.Visible = true;
            }
        }

        private void registerClientButton_Click(object sender, EventArgs e)
        {
            RegisterClient cw = new RegisterClient();
            cw.Show();
            this.Close();
        }

        private void RegisterNewInsuranceCase_Click(object sender, EventArgs e)
        {
            FormNewInsuranceCase cw = new FormNewInsuranceCase();
            cw.Show();
            this.Close();
        }

        private void registerNewPoliceCategory_Click(object sender, EventArgs e)
        {
            FormNewPoliceCategory cw = new FormNewPoliceCategory();
            cw.Show();
            this.Close();
        }

        private void InsurerWelcome_Load(object sender, EventArgs e)
        {

        }

        private void showAllClientsInfo_Click(object sender, EventArgs e)
        {
            ShowAllClientInfoAndPolicies cw = new ShowAllClientInfoAndPolicies();
            this.Close();
        }

        private void showAllClientPayments_Click(object sender, EventArgs e)
        {
            ShowAllClientsPayments cw = new ShowAllClientsPayments();
            cw.Show();
            this.Close();
        }

        private void showAllPoliceCategoriesAndCases_Click(object sender, EventArgs e)
        {
            ShowAllPoliceCategories cw = new ShowAllPoliceCategories();
            cw.Show();
            this.Close();
        }

        private void formPayment_Click(object sender, EventArgs e)
        {
            FormPaymentAdmin cw = new FormPaymentAdmin();
            cw.Show();
            this.Close();
        }

        private void getClientInfo_Click(object sender, EventArgs e)
        {
            ShowAllClientInfo cw = new ShowAllClientInfo();
            cw.Show();
            this.Close();
        }

        private void formPolice_Click(object sender, EventArgs e)
        {
            RegisterPolice cw = new RegisterPolice();
            cw.Show();
            this.Close();
        }

        private void registerNewInsuranceCase_Click_1(object sender, EventArgs e)
        {
            FormNewInsuranceCase cw = new FormNewInsuranceCase();
            cw.Show();
            this.Close();
        }


//LegalPersonForm
        private void companyNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void taxUniqueNumberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void directorNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void directorSecondNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void directorSurnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountantNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountantSecondNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountantSurnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyAddressInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyPhoneNumberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitLegalPerson_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(companyNameInput.Text) || String.IsNullOrEmpty(taxUniqueNumberInput.Text) ||
                String.IsNullOrEmpty(directorNameInput.Text) || String.IsNullOrEmpty(directorSecondNameInput.Text) ||
                String.IsNullOrEmpty(directorSurnameInput.Text) || String.IsNullOrEmpty(accountantNameInput.Text) ||
                String.IsNullOrEmpty(accountantSecondNameInput.Text) || String.IsNullOrEmpty(accountantSurnameInput.Text) ||
                String.IsNullOrEmpty(companyAddressInput.Text) || String.IsNullOrEmpty(companyPhoneNumberInput.Text))
            {
                label1.Text = "Проверьте заполнение всех полей.";
            }
            else
            {
                LegalPerson legalPerson = new LegalPerson();
                legalPerson.CompanyName = companyNameInput.Text;
                legalPerson.UniqueNumber = taxUniqueNumberInput.Text;
                legalPerson.DirectorName = directorNameInput.Text;
                legalPerson.DirectorSecondName = directorSecondNameInput.Text;
                legalPerson.DirectorSurname = directorSurnameInput.Text;
                legalPerson.AccountantName = accountantNameInput.Text;
                legalPerson.AccountantSecondName = accountantSecondNameInput.Text;
                legalPerson.AccountantSurname = accountantSurnameInput.Text;
                legalPerson.CompanyAddress = companyAddressInput.Text;
                legalPerson.CompanyPhoneNumber = companyPhoneNumberInput.Text;

                RegisterNewLegalPersonCommand command = new RegisterNewLegalPersonCommand();
                bool result = command.registerNewLegalPerson(legalPerson);
                if (result == true)
                {
                    companyNameInput.Clear();
                    taxUniqueNumberInput.Clear();
                    directorNameInput.Clear();
                    directorSecondNameInput.Clear();
                    directorSurnameInput.Clear();
                    accountantNameInput.Clear();
                    accountantSecondNameInput.Clear();
                    accountantSurnameInput.Clear();
                    companyAddressInput.Clear();
                    companyPhoneNumberInput.Clear();

                    label1.Text = "Юр. клиент успешно зарегистрирован.";
                }
                if (result == false)
                {
                    label1.Text = "Не удалось зарегистрировать юр. клиента.";
                }
            }

        }

//


//Individual

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateOfBirthInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void photoPathInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void findPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            //  string fileText = System.IO.File.ReadAllText(filename);
            photoPathInput.Text = filename;
            //MessageBox.Show("Файл открыт");
        }

        private void drivingExperienceInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addressInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitIndividual_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameInput.Text) || String.IsNullOrEmpty(secondNameInput.Text) ||
               String.IsNullOrEmpty(surnameInput.Text) || String.IsNullOrEmpty(dateOfBirthInput.Text) ||
               String.IsNullOrEmpty(photoPathInput.Text) || String.IsNullOrEmpty(drivingExperienceInput.Text) ||
               String.IsNullOrEmpty(addressInput.Text) || String.IsNullOrEmpty(phoneNumberInput.Text))
            {
                label2.Text = "Проверьте заполнение всех полей.";
            }
            else
            {
                Individual individualPerson = new Individual();
                individualPerson.Name = nameInput.Text;
                individualPerson.SecondName = secondNameInput.Text;
                individualPerson.Surname = surnameInput.Text;
                individualPerson.BirthDate = dateOfBirthInput.Value;

                if (male.Checked)
                {
                    individualPerson.Sex = male.Text;
                }
                else
                {
                    individualPerson.Sex = female.Text;
                }
                individualPerson.Photo = photoPathInput.Text;
                individualPerson.DrivingExperience = (int)drivingExperienceInput.Value;
                individualPerson.Address = addressInput.Text;
                individualPerson.PhoneNumber = phoneNumberInput.Text;

                RegisterNewIndividualPersonCommand command = new RegisterNewIndividualPersonCommand();
                bool result = command.registerIndividualPerson(individualPerson);

                if (result == true)
                {
                    nameInput.Clear();
                    secondNameInput.Clear();
                    surnameInput.Clear();
                    dateOfBirthInput.ResetText();
                    photoPathInput.Clear();
                    drivingExperienceInput.ResetText();
                    addressInput.Clear();
                    phoneNumberInput.Clear();

                    label2.Text = "Физ. клиент успешно зарегистрирован.";
                }
                if (result == false)
                {
                    label2.Text = "Не удалось зарегистрировать физ. клиента.";
                }
            }
        }

        private void groupBoxIndividual_Enter(object sender, EventArgs e)
        {

        }

        //private void findPhotoButton_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void nameInput_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void secondNameInput_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void surnameInput_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void dateOfBirthInput_ValueChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void male_CheckedChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void female_CheckedChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void drivingExperienceInput_ValueChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void photoPathInput_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void addressInput_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void phoneNumberInput_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void submitIndividual_Click_1(object sender, EventArgs e)
        //{

        //}

    }
}
