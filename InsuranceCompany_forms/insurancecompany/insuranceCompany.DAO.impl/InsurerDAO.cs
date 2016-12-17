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
        private readonly static String conString = "server=localhost;database=insurance_company;uid=root;pwd=marusya;";

        public bool registerNewInsuranceCase(InsuranceCase insuranceCase)
        {
            bool result = false;
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
                    result = true;
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
            bool result = false;
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
                    result = true;
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
            bool result = false;
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
                    result = true;
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
            bool result = false;
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
                    result = true;
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
                        legalPerson.Id = reader.GetInt32(0);
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


        public List<Individual> getAllIndividualInfo()
        {
            List<Individual> individualList = new List<Individual>();
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

                cmd.CommandText = "select `ind_client_id`, `first_name`, `second_name`, `surname`, `birth_date`, `sex`, `driving_experience`, `address`, `phone_number`, `photo_link` from individual_clients;";
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Individual ind = new Individual();
                        ind.Id = reader.GetInt32(0);
                        ind.Name = reader.GetString(1);
                        ind.SecondName = reader.GetString(2);
                        ind.Surname = reader.GetString(3);
                        ind.BirthDate = reader.GetDateTime(4);
                        ind.Sex = reader.GetString(5);
                        ind.DrivingExperience = reader.GetDecimal(6);
                        ind.Address = reader.GetString(7);
                        ind.PhoneNumber = reader.GetString(8);
                        ind.Photo = reader.GetString(9);
                      
                        individualList.Add(ind);
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
            return individualList;
        }


        public List<Insurer> getAllInsurersInfo()
        {
            List<Insurer> insurerList = new List<Insurer>();
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

                cmd.CommandText = "select insurer_id, first_name, second_name, surname, ssn, phone_number, address from insurers;";
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Insurer insurer = new Insurer();
                        insurer.Id = reader.GetInt32(0);
                        insurer.Name = reader.GetString(1);
                        insurer.SecondName = reader.GetString(2);
                        insurer.Surname = reader.GetString(3);
                        insurer.Ssn = reader.GetString(4);
                        insurer.PhoneNumber = reader.GetString(5);
                        insurer.Address = reader.GetString(6);

                        insurerList.Add(insurer);
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
            return insurerList;
        }

        public bool registerPolicyForLegalPerson(InsurancePolicy policy)
        {
            bool result = false;
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "insert into insurance_police (ins_category_id, ind_client_id, police_cost, police_money_amount, police_sign_date, police_expiration_date, insurer_id, legal_client_id) values (?categoryId, NULL, ?policyCost, ?policyAmount, ?policySignDate, ?policyExpirationDate, ?insurerId, ?legalClientId);";
                cmd.Prepare();
                
                cmd.Parameters.AddWithValue("categoryId", policy.Category.Id);
                cmd.Parameters.AddWithValue("policyCost", policy.Cost);
                cmd.Parameters.AddWithValue("policyAmount", policy.Amount);
                cmd.Parameters.AddWithValue("policySignDate", policy.SignDate);
                cmd.Parameters.AddWithValue("policyExpirationDate", policy.ExpirationDate);
                cmd.Parameters.AddWithValue("insurerId", policy.Insurer.Id);
                cmd.Parameters.AddWithValue("legalClientId", ((LegalPerson)policy.Client).Id);

                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult != -1)
                {
                    result = true;
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


        public bool registerPolicyForIndividual(InsurancePolicy policy)
        {
            bool result = false;
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "insert into insurance_police (ins_category_id, ind_client_id, police_cost, police_money_amount, police_sign_date, police_expiration_date, insurer_id, legal_client_id) values (?categoryId, ?individualClientId, ?policyCost, ?policyAmount, ?policySignDate, ?policyExpirationDate, ?insurerId, NULL);";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("categoryId", policy.Category.Id);
                cmd.Parameters.AddWithValue("individualClientId", ((Individual)policy.Client).Id);
                cmd.Parameters.AddWithValue("policyCost", policy.Cost);
                cmd.Parameters.AddWithValue("policyAmount", policy.Amount);
                cmd.Parameters.AddWithValue("policySignDate", policy.SignDate);
                cmd.Parameters.AddWithValue("policyExpirationDate", policy.ExpirationDate);
                cmd.Parameters.AddWithValue("insurerId", policy.Insurer.Id);
                

                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult != -1)
                {
                    result = true;
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


        public List<InsurancePolicy> getAllLegalPersonPolicies(LegalPerson legalPerson)
        {
            List<InsurancePolicy> legalPolicyList = new List<InsurancePolicy>();
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

                cmd.CommandText = "SELECT police.ins_police_id, police.ins_category_id, police.police_cost, police.police_money_amount, police.police_sign_date, police.police_expiration_date, police.insurer_id, ins.first_name, ins.second_name, ins.surname, ins.SSN, ins.address, ins.phone_number, category.ins_category_name, category.max_police_cost FROM `insurance_company`.`insurance_police` as police JOIN insurers as ins  ON police.insurer_id = ins.insurer_id JOIN insurance_category as category  ON police.ins_category_id = category.ins_category_id WHERE police.legal_client_id = ?legalClientId;";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("legalClientId", legalPerson.Id);
                reader = cmd.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InsurancePolicy policy = new InsurancePolicy();
                        policy.Client = legalPerson;
                        policy.PolicyId = reader.GetInt32(0);
                        policy.Cost = reader.GetInt32(2);
                        policy.Amount = reader.GetInt32(3);
                        policy.SignDate = reader.GetDateTime(4);
                        policy.ExpirationDate = reader.GetDateTime(5);

                        Insurer insurer = new Insurer();
                        insurer.Id = reader.GetInt32(6);
                        insurer.Name = reader.GetString(7);
                        insurer.SecondName = reader.GetString(8);
                        insurer.Surname = reader.GetString(9);
                        insurer.Ssn = reader.GetString(10);
                        insurer.Address = reader.GetString(11);
                        insurer.PhoneNumber = reader.GetString(12);
                        policy.Insurer = insurer;

                        InsuranceCategory category = new InsuranceCategory();
                        category.Id = reader.GetInt32(1);
                        category.Name = reader.GetString(13);
                        category.MaxPoliceCost = reader.GetInt32(14);
                        policy.Category = category;

                        legalPolicyList.Add(policy);
                    }
                    reader.NextResult();
                }


                cmd.CommandText = "SELECT `insurance_case`.`ins_case_id`,  `insurance_case`.`payment_procent`, `insurance_case`.`case_name` FROM `insurance_company`.`insurance_case` WHERE insurance_case.ins_category_id = ?categoryId;";
                cmd.Prepare();

                for (int i = 0; i < legalPolicyList.Count; i++)
                {
                    cmd.Parameters.Clear();
                    reader.Close();
                    cmd.Parameters.AddWithValue("categoryId", legalPolicyList[i].Category.Id);
                    reader = cmd.ExecuteReader();
                    List<InsuranceCase> caseList = new List<InsuranceCase>();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            InsuranceCase insuranceCase = new InsuranceCase();
                            insuranceCase.InsuranceCaseId = reader.GetInt32(0);
                            insuranceCase.PaymentProcent = reader.GetDecimal(1);
                            insuranceCase.InsuranceCaseName = reader.GetString(2);
                            caseList.Add(insuranceCase);
                        }
                        reader.NextResult();
                    }
                    legalPolicyList[i].InsuranceCaseList = caseList;
                }

                cmd.CommandText = "select ins_police_id,  SUM(payment_amount) from payments where payment_status=1 and ins_police_id=?policyId group by ins_police_id;";
                cmd.Prepare();

                for (int i = 0; i < legalPolicyList.Count; i++)
                {
                    cmd.Parameters.Clear();
                    reader.Close();
                    cmd.Parameters.AddWithValue("policyId", legalPolicyList[i].PolicyId);
                    reader = cmd.ExecuteReader();

                    decimal sum = 0;
                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sum = reader.GetDecimal(1);
                        }
                        reader.NextResult();
                    }
                    legalPolicyList[i].FullPayments = sum;
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

            return legalPolicyList;

        }


        public List<InsurancePolicy> getAllIndividulPolicies(Individual individualPerson)
        {
            List<InsurancePolicy> individualPolicyList = new List<InsurancePolicy>();
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

                cmd.CommandText = "SELECT police.ins_police_id, police.ins_category_id, police.police_cost, police.police_money_amount, police.police_sign_date, police.police_expiration_date, police.insurer_id, ins.first_name, ins.second_name, ins.surname, ins.SSN, ins.address, ins.phone_number, category.ins_category_name, category.max_police_cost FROM `insurance_company`.`insurance_police` as police JOIN insurers as ins  ON police.insurer_id = ins.insurer_id JOIN insurance_category as category  ON police.ins_category_id = category.ins_category_id WHERE police.ind_client_id = ?individualClientId;";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("individualClientId", individualPerson.Id);
                reader = cmd.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InsurancePolicy policy = new InsurancePolicy();
                        policy.Client = individualPerson;
                        policy.PolicyId = reader.GetInt32(0);
                        policy.Cost = reader.GetInt32(2);
                        policy.Amount = reader.GetInt32(3);
                        policy.SignDate = reader.GetDateTime(4);
                        policy.ExpirationDate = reader.GetDateTime(5);

                        Insurer insurer = new Insurer();
                        insurer.Id = reader.GetInt32(6);
                        insurer.Name = reader.GetString(7);
                        insurer.SecondName = reader.GetString(8);
                        insurer.Surname = reader.GetString(9);
                        insurer.Ssn = reader.GetString(10);
                        insurer.Address = reader.GetString(11);
                        insurer.PhoneNumber = reader.GetString(12);
                        policy.Insurer = insurer;

                        InsuranceCategory category = new InsuranceCategory();
                        category.Id = reader.GetInt32(1);
                        category.Name = reader.GetString(13);
                        category.MaxPoliceCost = reader.GetInt32(14);
                        policy.Category = category;

                        individualPolicyList.Add(policy);
                    }
                    reader.NextResult();
                }


                cmd.CommandText = "SELECT `insurance_case`.`ins_case_id`,  `insurance_case`.`payment_procent`, `insurance_case`.`case_name` FROM `insurance_company`.`insurance_case` WHERE insurance_case.ins_category_id = ?categoryId;";
                cmd.Prepare();

                for (int i = 0; i < individualPolicyList.Count; i++)
                {
                    cmd.Parameters.Clear();
                    reader.Close();
                    cmd.Parameters.AddWithValue("categoryId", individualPolicyList[i].Category.Id);
                    reader = cmd.ExecuteReader();
                    List<InsuranceCase> caseList = new List<InsuranceCase>();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            InsuranceCase insuranceCase = new InsuranceCase();
                            insuranceCase.InsuranceCaseId = reader.GetInt32(0);
                            insuranceCase.PaymentProcent = reader.GetDecimal(1);
                            insuranceCase.InsuranceCaseName = reader.GetString(2);
                            caseList.Add(insuranceCase);
                        }
                        reader.NextResult();
                    }
                    individualPolicyList[i].InsuranceCaseList = caseList;
                }

                cmd.CommandText = "select ins_police_id, SUM(payment_amount) from payments where payment_status=1 and ins_police_id=?policyId group by ins_police_id;";
                cmd.Prepare();

                for (int i = 0; i < individualPolicyList.Count; i++)
                {
                    cmd.Parameters.Clear();
                    reader.Close();
                    cmd.Parameters.AddWithValue("policyId", individualPolicyList[i].PolicyId);
                    reader = cmd.ExecuteReader();

                    decimal sum = 0;
                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sum = reader.GetDecimal(1);
                        }
                        reader.NextResult();
                    }
                    individualPolicyList[i].FullPayments = sum;
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
            return individualPolicyList;

        }

        public bool registerNewLegalPaymentRequest(InsuranceCase insuranceCase, int legalClientId)
        {
            bool result = true;
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            List<InsurancePolicy> legalPolicyList = new List<InsurancePolicy>();
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;
                LegalPerson legalPerson = new LegalPerson();
                InsurancePolicy currentPolicy = null;
                legalPerson.Id = legalClientId;
                legalPolicyList = getAllLegalPersonPolicies(legalPerson);

                bool permissionFlag = false;

                foreach (InsurancePolicy policy in legalPolicyList)
                {
                    foreach (InsuranceCase cs in policy.InsuranceCaseList)
                    {
                        if (cs.InsuranceCaseName.Equals(insuranceCase.InsuranceCaseName))
                        {
                            permissionFlag = true;
                            currentPolicy = policy;
                            break;
                        }
                    }

                    if (permissionFlag)
                    {
                        break;
                    }
                }

                if (!permissionFlag)
                {
                    result = false;
                    return result;
                }

                cmd.CommandText = "INSERT INTO `insurance_company`.`payments` (`ins_police_id`, `payment_request_date`, `ins_case_id`) VALUES (?policeId, ?paymentRequestDate, ?insCaseId);";
                cmd.Prepare();
                DateTime requestDate = DateTime.Now;
                cmd.Parameters.AddWithValue("policeId", currentPolicy.PolicyId);
                cmd.Parameters.AddWithValue("paymentRequestDate", requestDate);
                cmd.Parameters.AddWithValue("insCaseId", insuranceCase.InsuranceCaseId);
                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult == -1)
                {
                    result = false;
                    return result;
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

        public bool registerNewIndividualPaymentRequest(InsuranceCase insuranceCase, int individualClientId)
        {

            bool result = true;
            MySqlConnection conn = null; ;
            MySqlCommand cmd = null;
            List<InsurancePolicy> individualPolicyList = new List<InsurancePolicy>();
            try
            {
                conn = new MySqlConnection();
                cmd = new MySqlCommand();
                conn.ConnectionString = conString;
                conn.Open();
                cmd.Connection = conn;
                Individual individualPerson = new Individual();
                InsurancePolicy currentPolicy = null;
                individualPerson.Id = individualClientId;
                individualPolicyList = getAllIndividulPolicies(individualPerson);

                bool permissionFlag = false;

                foreach (InsurancePolicy policy in individualPolicyList)
                {
                    foreach (InsuranceCase cs in policy.InsuranceCaseList)
                    {
                        if (cs.InsuranceCaseName.Equals(insuranceCase.InsuranceCaseName))
                        {
                            permissionFlag = true;
                            currentPolicy = policy;
                            break;
                        }
                    }

                    if (permissionFlag)
                    {
                        break;
                    }
                }

                if (!permissionFlag)
                {
                    result = false;
                    return result;
                }

                cmd.CommandText = "INSERT INTO `insurance_company`.`payments` (`ins_police_id`, `payment_request_date`, `ins_case_id`) VALUES (?policeId, ?paymentRequestDate, ?insCaseId);";
                cmd.Prepare();
                DateTime requestDate = DateTime.Now;
                cmd.Parameters.AddWithValue("policeId", currentPolicy.PolicyId);
                cmd.Parameters.AddWithValue("paymentRequestDate", requestDate);
                cmd.Parameters.AddWithValue("insCaseId", insuranceCase.InsuranceCaseId);
                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult == -1)
                {
                    result = false;
                    return result;
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




        public List<PolicyPayment> getAllLegalPersonPolicyPayments(LegalPerson legalPerson)
        {
            List<PolicyPayment> list = new List<PolicyPayment>();

            

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

                cmd.CommandText = "select pay.payment_id, pay.ins_police_id, pay.payment_request_date, pay.payment_date, pay.payment_amount, c.ins_category_name, cas.case_name from payments as pay join insurance_police as p on p.ins_police_id=pay.ins_police_id join insurance_category as c on c.ins_category_id = p.ins_category_id join insurance_case as cas on cas.ins_case_id=pay.ins_case_id where pay.payment_status=1 and p.legal_client_id=?clientId;";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("clientId", legalPerson.Id);
                reader = cmd.ExecuteReader();


                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PolicyPayment payment = new PolicyPayment();
                        payment.Id = reader.GetInt32(0);
                        InsurancePolicy policy = new InsurancePolicy();
                        policy.PolicyId = reader.GetInt32(1);
                        payment.Policy = policy;
                        payment.PaymentApplicationDate = reader.GetDateTime(2);
                        payment.PaymentDate = reader.GetDateTime(3);
                        payment.PaymentAmount = reader.GetDecimal(4);
                        InsuranceCase cas = new InsuranceCase();
                        cas.InsuranceCaseName = reader.GetString(5);
                        payment.InsuranceCase = cas;
                        InsuranceCategory category = new InsuranceCategory();
                        category.Name = reader.GetString(6);
                        payment.Policy.Category = category;

                        list.Add(payment);
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
            }

                return list;
            
        }

        public List<PolicyPayment> getAllIndividualPolicyPayments(Individual individualClient)
        {
            List<PolicyPayment> list = new List<PolicyPayment>();



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

                cmd.CommandText = "select pay.payment_id, pay.ins_police_id, pay.payment_request_date, pay.payment_date, pay.payment_amount, c.ins_category_name, cas.case_name from payments as pay join insurance_police as p on p.ins_police_id=pay.ins_police_id join insurance_category as c on c.ins_category_id = p.ins_category_id join insurance_case as cas on cas.ins_case_id=pay.ins_case_id where pay.payment_status=1 and p.ind_client_id=?clientId;";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("clientId", individualClient.Id);
                reader = cmd.ExecuteReader();


                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PolicyPayment payment = new PolicyPayment();
                        payment.Id = reader.GetInt32(0);
                        InsurancePolicy policy = new InsurancePolicy();
                        policy.PolicyId = reader.GetInt32(1);
                        payment.Policy = policy;
                        payment.PaymentApplicationDate = reader.GetDateTime(2);
                        payment.PaymentDate = reader.GetDateTime(3);
                        payment.PaymentAmount = reader.GetDecimal(4);
                        InsuranceCase cas = new InsuranceCase();
                        cas.InsuranceCaseName = reader.GetString(5);
                        payment.InsuranceCase = cas;
                        InsuranceCategory category = new InsuranceCategory();
                        category.Name = reader.GetString(6);
                        payment.Policy.Category = category;

                        list.Add(payment);
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
            }

            return list;

        }


        public List<PolicyPayment> getAllIndividualPaymentRequests(Individual individualPerson)
        {
            List<PolicyPayment> paymentsList = new List<PolicyPayment>();
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
                cmd.CommandText = "SELECT pa.payment_id,  pa.ins_police_id,  pa.payment_request_date, pa.ins_case_id, cs.case_name, cs.payment_procent FROM payments  as pa JOIN insurance_police as pol  ON pa.ins_police_id = pol.ins_police_id  JOIN insurance_case as cs ON pa.ins_case_id = cs.ins_case_id WHERE pa.payment_status IS NULL AND pol.legal_client_id IS NULL AND pol.police_expiration_date > now();";
                cmd.Prepare();
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PolicyPayment paymentRequest = new PolicyPayment();
                        InsurancePolicy policy = new InsurancePolicy();
                        InsuranceCase insuranceCase = new InsuranceCase();

                        paymentRequest.Id = reader.GetInt32(0);
                        policy.PolicyId = reader.GetInt32(1);
                        paymentRequest.PaymentApplicationDate = reader.GetDateTime(2);
                        insuranceCase.InsuranceCaseId = reader.GetInt32(3);
                        insuranceCase.InsuranceCaseName = reader.GetString(4);
                        insuranceCase.PaymentProcent = reader.GetDecimal(5);
                        paymentRequest.InsuranceCase = insuranceCase;
                        paymentRequest.Policy = policy;

                        paymentsList.Add(paymentRequest);
                    }
                    reader.NextResult();
                }

                foreach (PolicyPayment payment in paymentsList)
                {
                    cmd.CommandText = "SELECT police.ins_police_id, police.ins_category_id, police.police_cost, police.police_money_amount, police.police_sign_date, police.police_expiration_date, police.insurer_id, ins.first_name, ins.second_name, ins.surname, ins.SSN, ins.address, ins.phone_number, category.ins_category_name, category.max_police_cost FROM `insurance_company`.`insurance_police` as police JOIN insurers as ins  ON police.insurer_id = ins.insurer_id JOIN insurance_category as category  ON police.ins_category_id = category.ins_category_id WHERE police.ins_police_id = ?policeId;";
                    cmd.Parameters.Clear();
                    reader.Close();
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("policeId", payment.Policy.PolicyId);
                    reader = cmd.ExecuteReader();
                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            InsurancePolicy policy = payment.Policy;
                            policy.Client = individualPerson;
                            policy.PolicyId = reader.GetInt32(0);
                            policy.Cost = reader.GetInt32(2);
                            policy.Amount = reader.GetInt32(3);
                            policy.SignDate = reader.GetDateTime(4);
                            policy.ExpirationDate = reader.GetDateTime(5);

                            Insurer insurer = new Insurer();
                            insurer.Id = reader.GetInt32(6);
                            insurer.Name = reader.GetString(7);
                            insurer.SecondName = reader.GetString(8);
                            insurer.Surname = reader.GetString(9);
                            insurer.Ssn = reader.GetString(10);
                            insurer.Address = reader.GetString(11);
                            insurer.PhoneNumber = reader.GetString(12);
                            policy.Insurer = insurer;

                            InsuranceCategory category = new InsuranceCategory();
                            category.Id = reader.GetInt32(1);
                            category.Name = reader.GetString(13);
                            category.MaxPoliceCost = reader.GetInt32(14);
                            policy.Category = category;
                            payment.InsuranceCase.InsuranceCategory = category;
                        }
                        reader.NextResult();
                    }
                    cmd.CommandText = "SELECT `insurance_case`.`ins_case_id`,  `insurance_case`.`payment_procent`, `insurance_case`.`case_name` FROM `insurance_company`.`insurance_case` WHERE insurance_case.ins_category_id = ?categoryId;";
                    cmd.Prepare();
                    cmd.Parameters.Clear();
                    reader.Close();
                    cmd.Parameters.AddWithValue("categoryId", payment.Policy.Category.Id);
                    reader = cmd.ExecuteReader();
                    List<InsuranceCase> caseList = new List<InsuranceCase>();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            InsuranceCase insuranceCase = new InsuranceCase();
                            insuranceCase.InsuranceCaseId = reader.GetInt32(0);
                            insuranceCase.PaymentProcent = reader.GetDecimal(1);
                            insuranceCase.InsuranceCaseName = reader.GetString(2);
                            caseList.Add(insuranceCase);
                        }
                        reader.NextResult();
                    }
                    payment.Policy.InsuranceCaseList = caseList;
                    payment.PaymentAmount = payment.Policy.Amount * payment.InsuranceCase.PaymentProcent / 100;

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
            return paymentsList;
        }

        public List<PolicyPayment> getAllLegalPaymentRequests(LegalPerson legalPerson)
        {
            List<PolicyPayment> paymentsList = new List<PolicyPayment>();
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
                cmd.CommandText = "SELECT pa.payment_id,  pa.ins_police_id,  pa.payment_request_date, pa.ins_case_id, cs.case_name, cs.payment_procent FROM payments  as pa JOIN insurance_police as pol  ON pa.ins_police_id = pol.ins_police_id  JOIN insurance_case as cs ON pa.ins_case_id = cs.ins_case_id WHERE pa.payment_status IS NULL AND pol.ind_client_id IS NULL AND pol.police_expiration_date > now();";
                cmd.Prepare();
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PolicyPayment paymentRequest = new PolicyPayment();
                        InsurancePolicy policy = new InsurancePolicy();
                        InsuranceCase insuranceCase = new InsuranceCase();

                        paymentRequest.Id = reader.GetInt32(0);
                        policy.PolicyId = reader.GetInt32(1);
                        paymentRequest.PaymentApplicationDate = reader.GetDateTime(2);
                        insuranceCase.InsuranceCaseId = reader.GetInt32(3);
                        insuranceCase.InsuranceCaseName = reader.GetString(4);
                        insuranceCase.PaymentProcent = reader.GetDecimal(5);
                        paymentRequest.InsuranceCase = insuranceCase;
                        paymentRequest.Policy = policy;

                        paymentsList.Add(paymentRequest);
                    }
                    reader.NextResult();
                }

                foreach (PolicyPayment payment in paymentsList)
                {
                    cmd.CommandText = "SELECT police.ins_police_id, police.ins_category_id, police.police_cost, police.police_money_amount, police.police_sign_date, police.police_expiration_date, police.insurer_id, ins.first_name, ins.second_name, ins.surname, ins.SSN, ins.address, ins.phone_number, category.ins_category_name, category.max_police_cost FROM `insurance_company`.`insurance_police` as police JOIN insurers as ins  ON police.insurer_id = ins.insurer_id JOIN insurance_category as category  ON police.ins_category_id = category.ins_category_id WHERE police.ins_police_id = ?policeId;";
                    cmd.Parameters.Clear();
                    reader.Close();
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("policeId", payment.Policy.PolicyId);
                    reader = cmd.ExecuteReader();
                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            InsurancePolicy policy = payment.Policy;
                            policy.Client = legalPerson;
                            policy.PolicyId = reader.GetInt32(0);
                            policy.Cost = reader.GetInt32(2);
                            policy.Amount = reader.GetInt32(3);
                            policy.SignDate = reader.GetDateTime(4);
                            policy.ExpirationDate = reader.GetDateTime(5);

                            Insurer insurer = new Insurer();
                            insurer.Id = reader.GetInt32(6);
                            insurer.Name = reader.GetString(7);
                            insurer.SecondName = reader.GetString(8);
                            insurer.Surname = reader.GetString(9);
                            insurer.Ssn = reader.GetString(10);
                            insurer.Address = reader.GetString(11);
                            insurer.PhoneNumber = reader.GetString(12);
                            policy.Insurer = insurer;

                            InsuranceCategory category = new InsuranceCategory();
                            category.Id = reader.GetInt32(1);
                            category.Name = reader.GetString(13);
                            category.MaxPoliceCost = reader.GetInt32(14);
                            policy.Category = category;
                            payment.InsuranceCase.InsuranceCategory = category;
                        }
                        reader.NextResult();
                    }
                    cmd.CommandText = "SELECT `insurance_case`.`ins_case_id`,  `insurance_case`.`payment_procent`, `insurance_case`.`case_name` FROM `insurance_company`.`insurance_case` WHERE insurance_case.ins_category_id = ?categoryId;";
                    cmd.Prepare();
                    cmd.Parameters.Clear();
                    reader.Close();
                    cmd.Parameters.AddWithValue("categoryId", payment.Policy.Category.Id);
                    reader = cmd.ExecuteReader();
                    List<InsuranceCase> caseList = new List<InsuranceCase>();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            InsuranceCase insuranceCase = new InsuranceCase();
                            insuranceCase.InsuranceCaseId = reader.GetInt32(0);
                            insuranceCase.PaymentProcent = reader.GetDecimal(1);
                            insuranceCase.InsuranceCaseName = reader.GetString(2);
                            caseList.Add(insuranceCase);
                        }
                        reader.NextResult();
                    }
                    payment.Policy.InsuranceCaseList = caseList;
                    payment.PaymentAmount = payment.Policy.Amount * payment.InsuranceCase.PaymentProcent / 100;

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
            return paymentsList;
        }

        public bool submitPaymentRequest(PolicyPayment payment)
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

                cmd.CommandText = "UPDATE `insurance_company`.`payments` SET `payment_date` = ?paymentDate, `payment_status` = 1, `payment_amount` = ?paymentAmount WHERE `payment_id` = ?paymentId;";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("paymentDate", DateTime.Now);
                cmd.Parameters.AddWithValue("paymentAmount", payment.PaymentAmount);
                cmd.Parameters.AddWithValue("paymentId", payment.Id);

                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult == -1)
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

        public bool rejectPaymentRequest(PolicyPayment payment)
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

                cmd.CommandText = "UPDATE `insurance_company`.`payments` SET  `payment_status` = 0 WHERE `payment_id` = ?paymentId;";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("paymentId", payment.Id);

                int queryResult = cmd.ExecuteNonQuery();
                if (queryResult == -1)
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


        public List<Individual> getAllIndividualWithPaymentRequests()
        {
            List<Individual> list = new List<Individual>();


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

                cmd.CommandText = "select distinct pay.payment_id, c.ind_client_id, c.first_name, c.second_name, c.surname, c.birth_date, c.sex, c.driving_experience, c.address, c.phone_number, c.photo_link from payments as pay join insurance_police as p on p.ins_police_id=pay.ins_police_id join individual_clients as c on c.ind_client_id=p.ind_client_id where pay.payment_status is null;";
                cmd.Prepare();
                reader = cmd.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Individual client = new Individual();
                        client.Id = reader.GetInt32(1);
                        client.Name = reader.GetString(2);
                        client.SecondName = reader.GetString(3);
                        client.Surname = reader.GetString(4);
                        client.BirthDate = reader.GetDateTime(5);
                        client.Sex = reader.GetString(6);
                        client.DrivingExperience = reader.GetDecimal(7);
                        client.Address = reader.GetString(8);
                        client.PhoneNumber = reader.GetString(9);
                        client.Photo = reader.GetString(10);

                        list.Add(client);
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
            }
            return list;
        }

       // getAllLegalPersonsWithPaymentRequests()
        public List<LegalPerson> getAllLegalPersonsWithPaymentRequests()
        {
            List<LegalPerson> list = new List<LegalPerson>();


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

                cmd.CommandText = "select distinct c.legal_client_id, c.company_name, c.taxpayer_number, c.dir_first_name, c.dir_second_name, c.dir_surname, c. acc_first_name, c.acc_second_name, c.acc_surname, c.address from payments as pay join insurance_police as p on p.ins_police_id=pay.ins_police_id join legal_clients as c on c.legal_client_id=p.legal_client_id where pay.payment_status is null;";
                cmd.Prepare();
                reader = cmd.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        LegalPerson client = new LegalPerson();
                        client.Id = reader.GetInt32(0);
                        client.CompanyName = reader.GetString(1);
                        client.UniqueNumber = reader.GetString(2);
                        client.DirectorName = reader.GetString(3);
                        client.DirectorSecondName = reader.GetString(4);
                        client.DirectorSurname = reader.GetString(5);
                        client.AccountantName = reader.GetString(6);
                        client.AccountantSecondName = reader.GetString(7);
                        client.AccountantSurname = reader.GetString(8);
                        client.CompanyAddress = reader.GetString(9);

                        list.Add(client);
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
            }
            return list;
        }

    }
}




