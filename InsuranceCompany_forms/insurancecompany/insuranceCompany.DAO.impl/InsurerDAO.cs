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

                cmd.CommandText = "INSERT INTO `insurance_company`.`insurance_case`(`payment_procent`,`insurance_case_name`) VALUES (?paymentProcent, ?insuranceCaseName);";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("paymentProcent", insuranceCase.getpaymentProcent());
                cmd.Parameters.AddWithValue("insuranceCaseName", insuranceCase.getInsuranceCaseName());
               int queryResult = cmd.ExecuteNonQuery();
                if (queryResult != -1) {
                    result = false;
                }
            }
            catch(MySqlException ex) {
                Debug.WriteLine(ex.Message);
            }
        
        return result;
        }
        public List<InsuranceCase> getAllInsuranceCases() {
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

                cmd.CommandText = "SELECT `insurance_case`.`insurance_case_name`, `insurance_case`.`payment_procent` FROM `insurance_company`.`insurance_case`; ";
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InsuranceCase insuranceCase = new InsuranceCase();
                        insuranceCase.setInsuranceCaseName(reader.GetString(0));
                        insuranceCase.setpaymentProcent(reader.GetDecimal(1));
                        caseList.Add(insuranceCase);
                        
                    }
                    reader.NextResult();
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return caseList;
        }
    }
  }
         

    

