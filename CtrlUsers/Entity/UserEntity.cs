﻿using System;

namespace Entity
{
    public class UserEntity
    {
        public string NumControl { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreCompleto { get; set; }
        public char Sexo { get; set; }
        public int Departamento { get; set; }
        public char Status { get; set; }
        public DateTime Hora { get; set; }
        public DateTime Fecha { get; set; }
    }
}
