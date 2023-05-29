using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Gym_Management_System
{
    public class DataAccess
    {

        static string ConnectionString = @"Data Source = DESKTOP - VJTRTHP; Initial Catalog = GMS; Integrated Security = True";

        static SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-VJTRTHP;Initial Catalog=GMS;Integrated Security=True");



        public static DataSet GetDataSet(string Stored_Name, string TableName, params SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(Stored_Name, con);
            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, TableName);

            return ds;
        }


        public static SqlDataReader GetDataReader(string stored_Name, out SqlConnection connectionOut, params SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(stored_Name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }
            con.Open();
            SqlDataReader DReader = cmd.ExecuteReader();

            connectionOut = con;
            return DReader;
        }



        public static int ExecuteNonQuery(string Stored_Name, params SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(Stored_Name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }
            con.Open();
            int Effects = cmd.ExecuteNonQuery();
            con.Close();
            return Effects;
        }



        public static object ExecuteScalar(string Stored_Name, params SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(Stored_Name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }
            con.Open();
            object scaler = cmd.ExecuteScalar();

            con.Close();
            return scaler;
        }



        public static Hashtable ExecuteNonQueryOutPut(string Stored_Name, params SqlParameter[] parameters)
        {

            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            SqlCommand sqlcmd = new SqlCommand(Stored_Name, sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter param in parameters)
            {
                sqlcmd.Parameters.Add(param);
            }
            sqlcon.Open();

            int x = sqlcmd.ExecuteNonQuery();

            Hashtable ht = new Hashtable();
            foreach (SqlParameter param in parameters)
            {
                if (param.Direction == ParameterDirection.Output)
                {
                    ht.Add(param.ParameterName, param.Value);
                }
            }
            sqlcon.Close();

            return ht;
        }



        public static DataTable SelectData(string Stored_Procedure, params SqlParameter[] Param)
        {
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.CommandText = Stored_Procedure;
            SqlCmd.Connection = sqlConnection;
            if (Param != null)
            {
                for (int i = 0; i < Param.Length; i++)
                {

                    SqlCmd.Parameters.Add(Param[i]);
                }

            }

            SqlDataAdapter da = new SqlDataAdapter(SqlCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }




        public static SqlParameter CreateParameters(string Parameters_Name, SqlDbType Parameters_Type, object Parameters_Value)
        {
            SqlParameter sqlParam = new SqlParameter(Parameters_Name, Parameters_Type);
            sqlParam.Value = Parameters_Value;
            return sqlParam;
        }
       





        
      /*  public static SqlParameter CreateParameters(string Parameters_Name, SqlDbType Parameters_Type, ParameterDirection Parameters_Direction)
        {
            SqlParameter sqlParam = new SqlParameter(Parameters_Name, Parameters_Type);
            sqlParam.Direction = Parameters_Direction;
            return sqlParam;
        }
        public void open()
          {
              if (sqlConnection.State != ConnectionState.Open)
              {
                  sqlConnection.Open();
              }

          }
          public void close()
          {
              if (sqlConnection.State != ConnectionState.Closed)
              {
                  sqlConnection.Close();
              }

          }
          public DataTable SelectData(string Stored_procedure, SqlParameter[] sqlParameters)
          {
              SqlCommand sqlCommands = new SqlCommand();

              sqlCommands.CommandType = CommandType.StoredProcedure;
              sqlCommands.CommandText = "Stored_procedure";
              sqlCommands.Connection = sqlConnection;


              if (sqlParameters != null)
              {
                  sqlCommands.Parameters.AddRange(sqlParameters);
              }


              SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommands);
              DataTable dt = new DataTable();
              sqlDataAdapter.Fill(dt);
              return dt;
          }
          public static void ExecuteNonQuery(string Stored_procedure, params SqlParameter[] sqlParameters)
          {
              DataAccess ds = new DataAccess();
              ds.open();

              SqlCommand sqlCommands = new SqlCommand();


              sqlCommands.CommandType = CommandType.StoredProcedure;
              sqlCommands.CommandText = Stored_procedure;

              if (sqlParameters != null)
              {
                  sqlCommands.Parameters.AddRange(sqlParameters);
              }
              sqlCommands.Connection = ds.sqlConnection;
              sqlCommands.ExecuteNonQuery();
              ds.close();

          }
          public static SqlParameter CreateParameters(string Parameters_Name, SqlDbType Parameters_Type, object Parameters_Value)
          {
              SqlParameter sqlParam = new SqlParameter(Parameters_Name, Parameters_Type);
              sqlParam.Value = Parameters_Value;
              return sqlParam;
          }


          public static DataSet GetDataSet(string Stored_Name, string Table_Name, params SqlParameter[] parameters)
          {
              SqlConnection con = new SqlConnection(ConnectionString);
              SqlCommand cmd = new SqlCommand(Stored_Name, con);

              foreach (SqlParameter param in parameters)
              {
                  cmd.Parameters.Add(param);
              }

              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds, Table_Name);

              return ds;
          }*/
    }
}


