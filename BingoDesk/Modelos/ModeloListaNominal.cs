using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoDesk.Modelos
{
    public class ModeloListaNominal
    {


        public decimal Id { get; set; }
        public string APaterno { get; set; } = string.Empty;
        public string AMaterno { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public int NumeroNominal { get; set; }
        public string Seccion { get; set; } = string.Empty;
        public string Casilla { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public bool Confirmado { get; set; }
        public string Partido { get; set; } = string.Empty;
        public DateTime FH_Confirmacion { get; set; }
        public string data1 { get; set; } = string.Empty;
        public string data2 { get; set; } = string.Empty;
        public string data3 { get; set; } = string.Empty;
        public string data4 { get; set; } = string.Empty;
        public string data5 { get; set; } = string.Empty;
        public string Credenciales { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string BingoUsuario { get; set; } = string.Empty;
        public string latitud { get; set; } = string.Empty;
        public string longitud { get; set; } = string.Empty;




    }
}
