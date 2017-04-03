﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiAgenda.Models
{
    public class Contactos
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime Cumpleaños { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
    }
}