﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAnKLKK__Windows_Forms_App_.DAO
{
    public class AcountDAO
    {
        private static AcountDAO instance;

        public static AcountDAO Instance 
        {
            get { if (instance == null) instance = new AcountDAO(); return instance; }
            private set { instance = value; }
        }

        private AcountDAO() { }

        public bool Login(string userName, string password)
        {
            string query = "USP_Login @userName , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, password });
            return result.Rows.Count > 0;
        }
    }
}
