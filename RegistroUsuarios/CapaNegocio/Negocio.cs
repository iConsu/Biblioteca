﻿using CapaDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class Negocio
    {
        #region Instancias

        private QueriesDataBase ObjData = new QueriesDataBase();

        #endregion Instancias

        private DataTable data;
        private List<object> Valor = new List<object>();

        public Negocio() { }

        /// <summary>
        /// Inicio de sesión para la aplicación
        /// </summary>
        /// <param name="nc">string Número de control del usuario</param>
        /// <param name="password">string Contraseña del usuario</param>
        /// <returns></returns>
        public DataTable Sesion(string nc, string password)
        {
            Valor.Clear();
            Valor.Add(nc); Valor.Add(password);
            data = ObjData.Procedimiento("LogSession", Valor);
            return data;
        }

        /// <summary>
        /// Método para registrar un nuevo movimiento en la base de datos
        /// </summary>
        /// <param name="nc">string Número de control</param>
        /// <param name="servicio">byte Clave del servicio que se va a utilizar</param>
        public void Registry(string nc, byte servicie)
        {
            ObjData.Procedimiento(nc, servicie);
        }

        /// <summary>
        /// Método que registra la entrada de un administrador en el sistema
        /// </summary>
        /// <param name="nc">string Número de control</param>
        /// <param name="sistema">string Sistema al que se esta accediendo</param>
        /// <param name="accion">string Acción que se esta realizando</param>
        public void Bitacora(string nc, string sistema, string accion)
        {
            Valor.Clear();
            Valor.Add(nc); Valor.Add(sistema); Valor.Add(accion);
            ObjData.Procedimiento("Bitacora", Valor);
        }

        /// <summary>
        /// Método que consulta sí existe un usuario en la base de datos
        /// </summary>
        /// <param name="nc">string Número de control</param>
        /// <returns></returns>
        public DataTable ExistUsuario(string nc)
        {
            Valor.Clear();
            Valor.Add(nc);
            data = ObjData.Procedimiento("ExistUser", Valor);
            return data;
        }
    }
}
