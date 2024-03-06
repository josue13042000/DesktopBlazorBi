using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoDesk.Modelos
{
    public class ModeloUsuarios
    {
        public decimal Id { get; set; }
        public string Userkey { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Ap_paterno { get; set; } = string.Empty;
        public string Ap_materno { get; set; } = string.Empty;
        public string Seccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string Distrito { get; set; } = string.Empty;
        public bool Activo { get; set; }
        public bool Calculadora { get; set; }
        public bool Escaneo { get; set; }
        public bool Apollos { get; set; }
        public bool R1 { get; set; }
        public bool R2 { get; set; }
        public bool R3 { get; set; }
        public bool R4 { get; set; }
        public string PAutobus { get; set; } = string.Empty;
        public string PTaxi { get; set; } = string.Empty;
        public string TipoUsuario { get; set; } = string.Empty;
        public string data1 { get; set; } = string.Empty;
        public string data2 { get; set; } = string.Empty;
        public string data3 { get; set; } = string.Empty;
        public string data4 { get; set; } = string.Empty;
        public string data5 { get; set; } = string.Empty;
    }
}
