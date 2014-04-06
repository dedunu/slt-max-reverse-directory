using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data.Common ;
using System.Data;

namespace SLTMAX
{
    class DB
    {
        public static string[] getDetail(string code, string telno)
        {
            string[] s = new string [3];
            
            OleDbDataAdapter dbda = new OleDbDataAdapter("SELECT * FROM " + code + " WHERE T='" + code + "2" + telno + "'", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SLTMAX.mdb");
            DataTable dt = new DataTable ();
            dbda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                s[0] = "Not Found";
                s[1] = "Not Found";
                s[2] = code + "2" + telno;
            }
            else
            {
                string sname;
                sname = dt.Rows[0]["Title"] + " " + dt.Rows[0]["OtherName"] + " " + dt.Rows[0]["LastName"];
                s[0] = sname;
                s[1] = dt.Rows[0]["Address"].ToString();
                s[2] = dt.Rows[0]["T"].ToString();
            }
            return s;
        }
    }
}
