﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Datos
    {
        private SqlConnection conex; private SqlCommand cmd; private SqlDataAdapter da; private DataTable dt;

        public Datos()
        {
            try { conex = new SqlConnection(ConfigurationManager.ConnectionStrings["biblioteca"].ConnectionString); } catch (Exception e) { Console.WriteLine("Error de conexión a base de datos: " + e.Message); }
        }

        public DataTable Procedimiento(string NameProcedure, List<object> ValorTexto, List<string> NombreParametro)
        {
            try
            {
                cmd = new SqlCommand(NameProcedure, conex) { CommandType = CommandType.StoredProcedure };
                for(int i = 0; i < ValorTexto.Count; i++)
                    cmd.Parameters.AddWithValue(NombreParametro[i], ValorTexto[i]);
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                Console.WriteLine("Compilación: \"P01\" realizada con éxito.");
            }
            catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            finally { conex.Close(); }
            return dt;
        }

        public void Insersion(string NameProcedure, List<object> ValorTexto, List<string> NombreParametro)
        {
            try
            {
                cmd = new SqlCommand(NameProcedure, conex) { CommandType = CommandType.StoredProcedure };
                for (int i = 0; i < ValorTexto.Count; i++)
                    cmd.Parameters.AddWithValue(NombreParametro[i], ValorTexto[i]);
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
                Console.WriteLine("Compilación: \"P01\" realizada con éxito.");
            }catch (Exception e) { Console.WriteLine("Error: " + e.Message); } finally { conex.Close(); }
        }
    }
}
