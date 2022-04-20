using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ManagementSystem
{
    class CommonClass
    {
        public static string currentUserName = "";
        public static string currentUserEmail = "";
        public static string currentUserId = "";
        public static string currentUserPhone = "";

        public static string strcon = "Data Source=.\\sqlexpress;Initial Catalog=ms;Integrated Security=True";

        public static SqlConnection con = new SqlConnection(strcon);
        public static bool ConnectDB()
        {
            //string connectionString = "";
            

            return true;
        }

        public static bool checkTheDatabase()
        {
            try
            {
                SqlConnection con = new SqlConnection(CommonClass.strcon);
                con.Open();
                return true;
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return false;
            }

        }


    }
}
