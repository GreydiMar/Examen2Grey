using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen2Grey.Models
{
    public class Pagos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(70)]
        public string Descripcion { get; set; }

        public double Monto { get; set; }

        public DateTime Fecha { get; set; }

        public byte[] Foto { get; set; }
    }
}
