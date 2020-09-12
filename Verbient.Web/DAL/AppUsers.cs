using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class AppUsers
    {
        public string AppUserName { get; set; }
        public string Companyname { get; set; }
        public int Userid { get; set; }
        public int UpdateUserid(string id = "")
        {
            using (IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                return conn.Query<int>("sp_UpdateUserID", (object)new
                {
                    @id = id
                }, (IDbTransaction)null, true, (int?)null, (CommandType?)CommandType.StoredProcedure).FirstOrDefault();

            }
        }
    }
}
