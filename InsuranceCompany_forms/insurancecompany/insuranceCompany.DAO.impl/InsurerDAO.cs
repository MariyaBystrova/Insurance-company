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
                cmd.Parameters.AddWithValue("paymentProcent", insuranceCase.getPaymentProcent());
                cmd.Parameters.AddWithValue("caseName", insuranceCase.getInsuranceCaseName());
                cmd.Parameters.AddWithValue("insCategoryId", 1);
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

                cmd.CommandText = "SELECT 	icase.ins_case_id, icase.payment_procent, icase.case_name, icategory.ins_category_name FROM insurance_case as icase JOIN insurance_category as icategory ON icase.ins_category_id = icategory.ins_category_id; ";
                reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InsuranceCase insuranceCase = new InsuranceCase();
                        insuranceCase.setInsuranceCaseId(reader.GetInt32(0));
                        insuranceCase.setPaymentProcent(reader.GetDecimal(1));
                        insuranceCase.setInsuranceCaseName(reader.GetString(2));
                        insuranceCase.setInsuranceCategoryName(reader.GetString(3));
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
         

    

