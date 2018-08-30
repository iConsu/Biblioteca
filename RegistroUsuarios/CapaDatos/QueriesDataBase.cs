﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class QueriesDataBase
    {
        private ConnectionDB conexDB = new ConnectionDB();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da;
        private DataTable table;

        /// <summary>
        /// Method for mass queries to the database
        /// </summary>
        /// <param name="StoredProcedure">string Name of the stored procedure</param>
        /// <param name="ValuesForms">List<object> List of values by the user already validated</param>
        /// <param name="Params">List<sttring> Nombres de las variables en el procedimiento almacenado</param>
        /// <returns></returns>
        public DataTable Procedimiento(string StoredProcedure, List<object> ValuesForms, List<string> Params)
        {
            try
            {
                cmd = new SqlCommand(StoredProcedure) { CommandType = CommandType.StoredProcedure };
                for (int i = 0; i < ValuesForms.Count; i++)
                    cmd.Parameters.AddWithValue(Params[i], ValuesForms[i]);
                cmd.Connection = conexDB.OpenConnection();
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                cmd.Parameters.Clear();
                cmd.Connection = conexDB.CloseConnection();
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.ToString()); }
            finally { cmd.Connection = conexDB.CloseConnection(); }
            return table;
        }

        public void Procedimiento(string nc, byte service)
        {
            try
            {
                cmd = new SqlCommand("NewMove") { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@nc", nc);
                cmd.Parameters.AddWithValue("@servicio", service);
                cmd.Connection = conexDB.OpenConnection();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.ToString()); }
            finally { cmd.Connection = conexDB.CloseConnection(); }
        }
    }
}