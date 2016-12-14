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
            return caseList;
        }

        public bool registerNewInsuranceCategory(String categoryName) {
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
            return categoryList;

        }
    }
  }
         

    

