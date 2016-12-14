using System;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using InsuranceCompany.entity;
using System.Collections;
using System.Collections.Generic;

namespace InsuranceCompany.insuranceCompany.DAO.impl
{
    class InsurerDAO
    {
        private readonly static String conString = "server=localhost;database=insurance_company;uid=root;pwd=3946833Andrey;";

        public bool registerNewInsuranceCase(InsuranceCase insuranceCase)
        {
            bool result = true;
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO `insurance_company`.`insurance_case` (`payment_procent`, `case_name`, `ins_category_id`) VALUES (?paymentProcent, ?caseName, ?insCategoryId); ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("paymentProcent", insuranceCase.PaymentProcent);
                cmd.Parameters.AddWithValue("caseName", insuranceCase.InsuranceCaseName);
                cmd.Parameters.AddWithValue("insCategoryId", insuranceCase.InsuranceCategory.Id);
                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult != -1)
                {
                    result = false;
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

            return result;
        }
        public List<InsuranceCase> getAllInsuranceCases()
        {
            List<InsuranceCase> caseList = new List<InsuranceCase>();
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT 	icase.ins_case_id, icase.payment_procent, icase.case_name, icategory.ins_category_name FROM insurance_case as icase JOIN insurance_category as icategory ON icase.ins_category_id = icategory.ins_category_id; ";
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InsuranceCase insuranceCase = new InsuranceCase();
                        insuranceCase.InsuranceCaseId = reader.GetInt32(0);
                        insuranceCase.PaymentProcent = reader.GetDecimal(1);
                        insuranceCase.InsuranceCaseName = reader.GetString(2);
                        InsuranceCategory category = new InsuranceCategory();
                        category.Name = reader.GetString(3);
                        insuranceCase.InsuranceCategory = category;
                        caseList.Add(insuranceCase);

                    }
                    reader.NextResult();
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return caseList;
        }

        public bool registerNewInsuranceCategory(String categoryName)
        {
            bool result = true;
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO `insurance_company`.`insurance_category` (`ins_category_name`, `max_police_cost`) VALUES (?categoryName, '10000'); ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("categoryName", categoryName);
                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult != -1)
                {
                    result = false;
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

            return result;
        }
        public List<InsuranceCategory> getAllPoliceCategories()
        {
            List<InsuranceCategory> categoryList = new List<InsuranceCategory>();
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT `insurance_category`.`ins_category_id`, `insurance_category`.`ins_category_name`, `insurance_category`.`max_police_cost` FROM `insurance_company`.`insurance_category`; ";
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InsuranceCategory insuranceCategory = new InsuranceCategory();
                        insuranceCategory.Id = reader.GetInt32(0);
                        insuranceCategory.Name = reader.GetString(1);
                        insuranceCategory.MaxPoliceCost = reader.GetInt32(2);
                        categoryList.Add(insuranceCategory);
                    }
                    reader.NextResult();
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return categoryList;

        }

        public bool registerLegalPerson(LegalPerson legalPerson)
        {
            bool result = true;
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO `insurance_company`.`legal_clients` (`company_name`, `taxpayer_number`, `dir_first_name`, `dir_second_name`, `dir_surname`, `acc_first_name`, `acc_second_name`, `acc_surname`, `address`, `phone_number`) VALUES (?companyName, ?taxpayerNumber, ?dirFirstName, ?dirSecondName, ?dirSurname, ?accFirstName, ?accSecondName, ?accSurname, ?address, ?phoneNumber);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("companyName", legalPerson.CompanyName);
                cmd.Parameters.AddWithValue("taxpayerNumber", legalPerson.UniqueNumber);
                cmd.Parameters.AddWithValue("dirFirstName", legalPerson.DirectorName);
                cmd.Parameters.AddWithValue("dirSecondName", legalPerson.DirectorSecondName);
                cmd.Parameters.AddWithValue("dirSurname", legalPerson.DirectorSurname);
                cmd.Parameters.AddWithValue("accFirstName", legalPerson.AccountantName);
                cmd.Parameters.AddWithValue("accSecondName", legalPerson.AccountantSecondName);
                cmd.Parameters.AddWithValue("accSurname", legalPerson.AccountantSurname);
                cmd.Parameters.AddWithValue("address", legalPerson.CompanyAddress);
                cmd.Parameters.AddWithValue("phoneNumber", legalPerson.CompanyPhoneNumber);

                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult != -1)
                {
                    result = false;
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            return result;
        }

        public bool registerIndividualPerson(Individual individualPerson) {
            bool result = true;
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO `insurance_company`.`individual_clients` (`first_name`, `second_name`, `surname`, `birth_date`, `sex`, `driving_experience`, `address`, `phone_number`, `photo_link`) VALUES (?firstName, ?secondName, ?surname, ?birthDate, ?sex, ?drivingExp, ?address, ?phoneNumber, ?photoLink);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("firstName", individualPerson.Name);
                cmd.Parameters.AddWithValue("secondName", individualPerson.SecondName);
                cmd.Parameters.AddWithValue("surname", individualPerson.Surname);
                cmd.Parameters.AddWithValue("birthDate", individualPerson.BirthDate);
                cmd.Parameters.AddWithValue("sex", individualPerson.Sex);
                cmd.Parameters.AddWithValue("drivingExp", individualPerson.DrivingExperience);
                cmd.Parameters.AddWithValue("address", individualPerson.Address);
                cmd.Parameters.AddWithValue("phoneNumber", individualPerson.PhoneNumber);
                cmd.Parameters.AddWithValue("photoLink", individualPerson.Photo);

                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult != -1)
                {
                    result = false;
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            return result;
        }

        public List<LegalPerson> getAllLegalPersonInfo()
        {
            List<LegalPerson> legalPersonList = new List<LegalPerson>();
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT `legal_clients`.`legal_client_id`, `legal_clients`.`company_name`, `legal_clients`.`taxpayer_number`, `legal_clients`.`dir_first_name`, `legal_clients`.`dir_second_name`, `legal_clients`.`dir_surname`, `legal_clients`.`acc_first_name`, `legal_clients`.`acc_second_name`, `legal_clients`.`acc_surname`, `legal_clients`.`address`, `legal_clients`.`phone_number` FROM `insurance_company`.`legal_clients`;";
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        LegalPerson legalPerson = new LegalPerson();
                        legalPerson.CompanyName = reader.GetString(1);
                        legalPerson.UniqueNumber = reader.GetString(2);
                        legalPerson.DirectorName = reader.GetString(3);
                        legalPerson.DirectorSecondName = reader.GetString(4);
                        legalPerson.DirectorSurname = reader.GetString(5);
                        legalPerson.AccountantName = reader.GetString(6);
                        legalPerson.AccountantSecondName = reader.GetString(7);
                        legalPerson.AccountantSurname = reader.GetString(8);
                        legalPerson.CompanyAddress = reader.GetString(9);
                        legalPerson.CompanyPhoneNumber = reader.GetString(10);
                        legalPersonList.Add(legalPerson);

                    }
                    reader.NextResult();
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return legalPersonList;
        }
    }
}




