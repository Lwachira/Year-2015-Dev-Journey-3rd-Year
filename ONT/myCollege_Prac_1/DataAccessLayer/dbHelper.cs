using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class dbHelper
    {
        const string dbConnection = @"Data Source=localhost;Database =TinyCollege;Integrated Security=True";


        internal static DataTable ExecuteSelectCommand(string commandName,CommandType cmdType)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(dbConnection))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = commandName;


                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();


                        }


                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }
                    }
                    catch (Exception )
                    {

                        
                        throw;
                    }
                }
            }
            return table;
        }


        internal static DataTable ExecuteParamerizedSelectCommand(string commandName, CommandType cmdType,SqlParameter[] param)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(dbConnection))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = commandName;
                    cmd.Parameters.AddRange(param);

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();

                        }


                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            return table;
        }

        internal static bool ExecuteNonQuery(string commandName,CommandType cmdType, SqlParameter[] param)
        {
            int result = 0;

            using (SqlConnection con = new SqlConnection(dbConnection))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = commandName;
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(param);

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        result = cmd.ExecuteNonQuery();
                    }
                    catch 
                    {

                        throw;
                    }
                }
            }
            return (result > 0);
        }

    }

}
