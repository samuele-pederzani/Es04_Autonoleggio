using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.Security.Cryptography;
using System.Text;
using ADOSQLServer2017_ns;
using System.Data;
using System.Data.SqlClient;

namespace Es04_Autonoleggio
{
    public class clsDB
    {
        ADOSQLServer2017 ado;
        public clsDB(string nomeDB)
        {
            this.ado = new ADOSQLServer2017(nomeDB);
        }

        public string sha256(string pwd)
        {
            string p = "";
            SHA256 mySHA256 = SHA256.Create();
            //calcolo codice hash 
            byte[] hashValue = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashValue.Length; i++)
            {
                builder.Append(hashValue[i].ToString("x2")); //converto in esadecimale
            }
            p = builder.ToString();
            return p;
        }

        public DataTable cercaUtente(string email, string psw)
        {
            DataTable dt;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT email, idTipo
                            FROM Utenti
                            where email=@email AND psw=@psw";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@psw", psw);
            dt = ado.EseguiQuery(cmd);
            return dt;
        }
    }
}