﻿using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Code.SP_Code
{
    public class SP_GeneralTransaction
    {
        private CloudErpV1Entities db = new CloudErpV1Entities();
        public List<AllAccountModel> GetAllAccounts(int CompanyID, int BranchID)
        {
            var accountslist = new List<AllAccountModel>();
            SqlCommand command = new SqlCommand("GetAllAccounts", DatabaseQuery.ConnOpen());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@CompanyID", CompanyID);
            var dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                var account = new AllAccountModel();
                account.AccountHeadID = Convert.ToInt32(row[0].ToString());
                account.AccountHeadName = Convert.ToString(row[1]); 
                account.AccountControlID = Convert.ToInt32(row[2].ToString()); ;
                account.AccountControlName = Convert.ToString(row[3]);
                account.BranchID = Convert.ToInt32(row[4].ToString()); ;
                account.CompanyID = Convert.ToInt32(row[5].ToString()); ;
                account.AccountSubControlID = Convert.ToInt32(row[6].ToString()); ;
                account.AccountSubControl = Convert.ToString(row[7]);
                accountslist.Add(account);
            }
            return accountslist;
        }

        public List<JournalModel> GetJournal(int CompanyID, int BranchID, DateTime FromDate, DateTime ToDate)
        {
            var jounalentries = new List<JournalModel>();
            SqlCommand command = new SqlCommand("GetJournal", DatabaseQuery.ConnOpen());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@CompanyID", CompanyID);
            command.Parameters.AddWithValue("@FromDate", FromDate);
            command.Parameters.AddWithValue("@ToDate", ToDate);
            var dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);
            int no = 1;
            foreach (DataRow row in dt.Rows)
            {

                var entry = new JournalModel();
                entry.TransectionDate = Convert.ToDateTime(row[0].ToString());
                entry.AccountSubControl = Convert.ToString(row[1]);
                entry.TransectionTitle = Convert.ToString(row[2].ToString()); 
                entry.AccountSubControlID = Convert.ToInt32(row[3]);
                entry.InvoiceNo = Convert.ToString(row[4].ToString()); 
                entry.Debit = Convert.ToDouble(row[5].ToString()); 
                entry.Credit = Convert.ToDouble(row[6].ToString());
                entry.SNO = no;
                jounalentries.Add(entry);
                no = no + 1;
            }
            return jounalentries;
        }
    }
}
