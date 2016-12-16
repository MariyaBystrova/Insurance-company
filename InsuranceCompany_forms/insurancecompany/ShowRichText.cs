using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class ShowRichText : Form
    {
        private LegalPerson client;
        private Individual individual;

        internal Individual Individual
        {
            get { return individual; }
            set { individual = value; fillForIndividual(); }
        }

        internal LegalPerson Client
        {
            get { return client; }
            set { client = value; fillForLegalClient(); }
        }

        public ShowRichText()
        {
            InitializeComponent();
        }

        private void fillForLegalClient()
        {
            richTextBox1.ReadOnly = true;
            //Since too much string appending go for string builder
            StringBuilder tableRtf = new StringBuilder();

            //beginning of rich text format,dont customize this begining line              
            tableRtf.Append(@"{\rtf1\adeflag1025\ansi\ansicpg1251\uc1 ");

            row(tableRtf, "Клиент:", client.CompanyName);
            row(tableRtf, "УНН:", "№ " + client.Id.ToString());
            row(tableRtf, "Адрес:", client.CompanyAddress);
            row(tableRtf, "Телефон:", "тел. " + client.CompanyPhoneNumber);
            row(tableRtf, "Тип:", "юридическое лицо");
            row(tableRtf, "Руководитель:", client.DirectorSurname + " " + client.DirectorName + " " + client.DirectorSecondName);
            row(tableRtf, "Главбух:", client.AccountantSurname + " " + client.AccountantName + " " + client.AccountantSecondName);


            //beginning of rich text format,dont customize this begining line              
            tableRtf.Append(@"{\rtf1\adeflag1025\ansi\ansicpg1251 ");

            tableRtf.Append(@"\trowd");
            //A cell with width 1500.
            tableRtf.Append(@"\cellx1500").AppendLine("Дата полиса");
            tableRtf.Append(@"\intbl \cell");
            //A cell with width 4000.
            tableRtf.Append(@"\cellx3500").AppendLine("Категория полиса");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx5000").AppendLine("Действоует до");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx6500").AppendLine("Сумма полича");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx8500").AppendLine("Стоимость полиса");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx11000").AppendLine("Суммарные выплаты");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\intbl \cell \row");


            GetAllLegalPersonPoliciesCommand command = new GetAllLegalPersonPoliciesCommand();
            List<InsurancePolicy> list = command.getAllLegalPersonPolicies(client);

            decimal sumPolicyAmount = 0;
            decimal sumPoliceCost = 0;
            decimal sumFullPayments = 0;

            foreach (InsurancePolicy l in list)
            {
                tableRtf.Append(@"{\rtf1\adeflag1025\ansi\ansicpg1251 ");

                tableRtf.Append(@"\trowd");
                tableRtf.Append(@"\cellx1500").AppendLine("/" + l.SignDate.Day + "/" + l.SignDate.Month + "/" + l.SignDate.Year);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\cellx3500").AppendLine(l.Category.Name);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\cellx5000").AppendLine("/" + l.ExpirationDate.Day + "/" + l.ExpirationDate.Month + "/" + l.ExpirationDate.Year);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\cellx6500").AppendLine("$" + l.Amount);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\cellx8500").AppendLine("$" + l.Cost);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\cellx11000").AppendLine("$" + l.FullPayments);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\intbl \cell \row");

                sumPoliceCost += l.Cost;
                sumPolicyAmount += l.Amount;
                sumFullPayments += l.FullPayments;

            }

            lastRow(tableRtf, "ИТОГО", "$" + sumPolicyAmount, "$" + sumPoliceCost, "$" + sumFullPayments);

            tableRtf.Append(@"\pard");
            tableRtf.Append(@"}");

            richTextBox1.Rtf = tableRtf.ToString();
            
        }

        private void fillForIndividual()
        {
            richTextBox1.ReadOnly = true;
            //Since too much string appending go for string builder
            StringBuilder tableRtf = new StringBuilder();

            //beginning of rich text format,dont customize this begining line              
            tableRtf.Append(@"{\rtf1\adeflag1025\ansi\ansicpg1251\uc1\adeff31507\deff0\stshfdbch31506\stshfhich31506\stshfbi31507\deflang1049\deflangfe1049\themelang1049\themelangfe0\stshfloch31506 ");

            row(tableRtf, "Клиент:", individual.Surname + " " + individual.Name + " " + individual.SecondName);
            row(tableRtf, "УНН:", "№ " + individual.Id);
            row(tableRtf, "Адрес:", individual.Address);
            row(tableRtf, "Телефон:", "тел. " + individual.PhoneNumber);
            row(tableRtf, "Тип:", "физическое лицо");


            //beginning of rich text format,dont customize this begining line              
            tableRtf.Append(@"{\rtf1\adeflag1025\ansi\ansicpg1251 ");

            tableRtf.Append(@"\trowd");
            tableRtf.Append(@"\cellx1500").AppendLine("Дата полиса");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx3500").AppendLine("Категория полиса");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx5000").AppendLine("Действоует до");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx6500").AppendLine("Сумма полича");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx8500").AppendLine("Стоимость полиса");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx11000").AppendLine("Суммарные выплаты");
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\intbl \cell \row");

            GetAllIndividualPoliciesCommand command = new GetAllIndividualPoliciesCommand();
            List<InsurancePolicy> list = command.getallIndividualPolicies(individual);

            decimal sumPolicyAmount = 0;
            decimal sumPoliceCost = 0;
            decimal sumFullPayments = 0;

            foreach(InsurancePolicy l in list)
            {
                tableRtf.Append(@"{\rtf1\adeflag1025\ansi\ansicpg1251 ");

                tableRtf.Append(@"\trowd");
                //A cell with width 1500.
                tableRtf.Append(@"\cellx1500").AppendLine("/" + l.SignDate.Day + "/" + l.SignDate.Month + "/" + l.SignDate.Year );
                tableRtf.Append(@"\intbl \cell");
                //A cell with width 4000.
                tableRtf.Append(@"\cellx3500").AppendLine(l.Category.Name);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\cellx5000").AppendLine("/" + l.ExpirationDate.Day + "/" + l.ExpirationDate.Month + "/" + l.ExpirationDate.Year);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\cellx6500").AppendLine("$" + l.Amount);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\cellx8500").AppendLine("$" + l.Cost);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\cellx11000").AppendLine("$" + l.FullPayments);
                tableRtf.Append(@"\intbl \cell");
                tableRtf.Append(@"\intbl \cell \row");

                sumPoliceCost += l.Cost;
                sumPolicyAmount += l.Amount;
                sumFullPayments += l.FullPayments;
               
            }


            lastRow(tableRtf, "ИТОГО", "$" + sumPolicyAmount, "$" + sumPoliceCost, "$" + sumFullPayments);

            tableRtf.Append(@"\pard");
            tableRtf.Append(@"}");

            richTextBox1.Rtf = tableRtf.ToString();
            
        }

        private void row(StringBuilder tableRtf, String name, String value)
        {
            //beginning of rich text format,dont customize this begining line              
            tableRtf.Append(@"{\rtf1\adeflag1025\ansi\ansicpg1251 ");

            tableRtf.Append(@"\trowd");
            //A cell with width 1500.
            tableRtf.Append(@"\cellx4000").AppendLine(name);
            tableRtf.Append(@"\intbl \cell");
            //A cell with width 4000.
            tableRtf.Append(@"\cellx11000").AppendLine(value);
            //tableRtf.Append(client.CompanyName);
            tableRtf.Append(@"\intbl \cell");
            //Another cell with width 2000.end point is 3000 (which is 1000+2000).
            tableRtf.Append(@"\intbl \cell \row"); //create row
            tableRtf.Append(@"}");
        }


        private void lastRow(StringBuilder tableRtf, String col1, String col2, String col3, String col4)
        {
            //beginning of rich text format,dont customize this begining line              
            tableRtf.Append(@"{\rtf1\adeflag1025\ansi\ansicpg1251 ");

            tableRtf.Append(@"\trowd");
            tableRtf.Append(@"\cellx5000").AppendLine(col1);
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx6500").AppendLine(col2);
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx8500").AppendLine(col3);
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\cellx11000").AppendLine(col4);
            tableRtf.Append(@"\intbl \cell");
            tableRtf.Append(@"\intbl \cell \row");
            tableRtf.Append(@"}");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Workbook excelappworkbook;
            Microsoft.Office.Interop.Excel.Workbooks excelappworkbooks;
            Microsoft.Office.Interop.Excel.Application excelapp;

            excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 1;
            excelapp.Workbooks.Add(Type.Missing);
            //Запрашивать сохранение
            excelapp.DisplayAlerts = true;
            //Получаем набор ссылок на объекты Workbook (на созданные книги)
            excelappworkbooks = excelapp.Workbooks;
            //Получаем ссылку на книгу 1 - нумерация от 1
            excelappworkbook = excelappworkbooks[1];
            //Ссылку можно получить и так, но тогда надо знать имена книг,
            //причем, после сохранения - знать расширение файла
            //excelappworkbook=excelappworkbooks["Книга 1"];
            //Запроса на сохранение для книги не должно быть
            excelappworkbook.Saved = true;

            Microsoft.Office.Interop.Excel.Sheets excelsheets;
            Microsoft.Office.Interop.Excel.Worksheet excelworksheet;
            Microsoft.Office.Interop.Excel.Range excelcells;
            excelsheets = excelappworkbook.Worksheets;
            //Получаем ссылку на лист 1
            excelworksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelsheets.get_Item(1);

            excelcells = excelworksheet.get_Range("A1", "M33");
            if (client != null)
            {
                int row = excelWriteHeaderLegalPerson(excelcells, excelworksheet);

                GetAllLegalPersonPoliciesCommand command = new GetAllLegalPersonPoliciesCommand();
                List<InsurancePolicy> list = command.getAllLegalPersonPolicies(client);

                excelWriteMain(excelcells, excelworksheet, list, row);
            }
            if (individual != null)
            {
                int row = excelWriteHeaderIndividual(excelcells, excelworksheet);

                GetAllIndividualPoliciesCommand command = new GetAllIndividualPoliciesCommand();
                List<InsurancePolicy> list = command.getallIndividualPolicies(individual);
                excelWriteMain(excelcells, excelworksheet, list, row);
            }
            
        }

        private void excelWriteElement(Microsoft.Office.Interop.Excel.Range excelcells, Microsoft.Office.Interop.Excel.Worksheet excelworksheet, int cellRow, int cellCol, String value)
        {
            excelcells = (Microsoft.Office.Interop.Excel.Range)excelworksheet.Cells[cellRow, cellCol];
            //Выводим координаты ячеек
            excelcells.Value2 = value;
        }

        private void excelMergeCells(Microsoft.Office.Interop.Excel.Range excelcells, Microsoft.Office.Interop.Excel.Worksheet excelworksheet, String cellLeftTop, String cellRightBottom)
        {
            excelcells = excelworksheet.get_Range(cellLeftTop, cellRightBottom);
            //Объединяем ячейки
            excelcells.Merge(Type.Missing);
        }

        private void excelWriteHeaderLineLegalPerson(Microsoft.Office.Interop.Excel.Range excelcells, Microsoft.Office.Interop.Excel.Worksheet excelworksheet, String name, String value, int row)
        {
            excelMergeCells(excelcells, excelworksheet, "A" + row, "D" + row);
            excelWriteElement(excelcells, excelworksheet, row, 1, name);
            excelMergeCells(excelcells, excelworksheet, "E" + row, "M" + row);
            excelWriteElement(excelcells, excelworksheet, row, 5, value);
        }

        private int excelWriteHeaderLegalPerson(Microsoft.Office.Interop.Excel.Range excelcells, Microsoft.Office.Interop.Excel.Worksheet excelworksheet)
        {
            int row = 1;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Клиент:", client.CompanyName, row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "УНН:", "№ " + client.Id.ToString(), row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Адрес:", client.CompanyAddress, row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Телефон:", "тел. "+ client.CompanyPhoneNumber, row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Тип:", "юридическое лицо", row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Руководитель:", client.DirectorSurname + " " + client.DirectorName + " " + client.DirectorSecondName, row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Главбух:", client.AccountantSurname + " " + client.AccountantName + " " + client.AccountantSecondName, row);
            row++;
            return row;
        }

        private int excelWriteHeaderIndividual(Microsoft.Office.Interop.Excel.Range excelcells, Microsoft.Office.Interop.Excel.Worksheet excelworksheet)
        {
            int row = 1;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Клиент:", individual.Surname+" "+ individual.Name+" "+ individual.SecondName, row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "УНН:", "№ " + individual.Id, row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Адрес:", individual.Address, row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Телефон:", "тел. " + individual.PhoneNumber, row);
            row++;
            excelWriteHeaderLineLegalPerson(excelcells, excelworksheet, "Тип:", "физическое лицо", row);
            row++;
            return row;
        }

        private void excelWriteMainLine(Microsoft.Office.Interop.Excel.Range excelcells, Microsoft.Office.Interop.Excel.Worksheet excelworksheet, String col1, String col2, String col3, String col4, String col5, String col6, int row)
        {
            excelMergeCells(excelcells, excelworksheet, "A" + row, "B" + row);
            excelWriteElement(excelcells, excelworksheet, row, 1, col1);
            excelMergeCells(excelcells, excelworksheet, "C" + row, "D" + row);
            excelWriteElement(excelcells, excelworksheet, row, 3, col2);
            excelMergeCells(excelcells, excelworksheet, "E" + row, "F" + row);
            excelWriteElement(excelcells, excelworksheet, row, 5, col3);
            excelMergeCells(excelcells, excelworksheet, "G" + row, "H" + row);
            excelWriteElement(excelcells, excelworksheet, row, 7, col4);
            excelMergeCells(excelcells, excelworksheet, "I" + row, "J" + row);
            excelWriteElement(excelcells, excelworksheet, row, 9, col5);
            excelMergeCells(excelcells, excelworksheet, "K" + row, "M" + row);
            excelWriteElement(excelcells, excelworksheet, row, 11, col6);
        }

        private void excelWriteBottomLine(Microsoft.Office.Interop.Excel.Range excelcells, Microsoft.Office.Interop.Excel.Worksheet excelworksheet, String col1, String col2, String col3, String col4, int row)
        {
            excelMergeCells(excelcells, excelworksheet, "A" + row, "F" + row);
            excelWriteElement(excelcells, excelworksheet, row, 1, col1);
            excelMergeCells(excelcells, excelworksheet, "G" + row, "H" + row);
            excelWriteElement(excelcells, excelworksheet, row, 7, col2);
            excelMergeCells(excelcells, excelworksheet, "I" + row, "J" + row);
            excelWriteElement(excelcells, excelworksheet, row, 9, col3);
            excelMergeCells(excelcells, excelworksheet, "K" + row, "M" + row);
            excelWriteElement(excelcells, excelworksheet, row, 11, col4);
        }

        private void excelWriteMain(Microsoft.Office.Interop.Excel.Range excelcells, Microsoft.Office.Interop.Excel.Worksheet excelworksheet, List<InsurancePolicy> list, int row)
        {
            excelWriteMainLine(excelcells, excelworksheet, "Дата полиса", "Категория полиса", "Действоует до", "Сумма полича, $", "Стоимость полиса, $", "Суммарные выплаты, $", row);
            
            decimal sumPolicyAmount = 0;
            decimal sumPoliceCost = 0;
            decimal sumFullPayments = 0;
            row++;
            foreach (InsurancePolicy l in list)
            {

                excelWriteMainLine(excelcells, excelworksheet, l.SignDate.ToShortDateString(), l.Category.Name, l.ExpirationDate.ToShortDateString(), l.Amount.ToString(), l.Cost.ToString(), l.FullPayments.ToString(), row);
                row++;
                
                sumPoliceCost += l.Cost;
                sumPolicyAmount += l.Amount;
                sumFullPayments += l.FullPayments;

            }

            excelWriteBottomLine(excelcells, excelworksheet, "ИТОГО",  sumPolicyAmount.ToString(),  sumPoliceCost.ToString(), sumFullPayments.ToString(), row);
            
            excelcells = excelworksheet.get_Range("A1", "M" + row);
            excelcells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            excelcells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
        }


        //

    }
    
}
