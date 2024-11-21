using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSistem
{
    internal class DtBase_Conexion
    {
        public string con = ConfigurationManager.ConnectionStrings["RestaurantSistem.Properties.Settings.sis_connect"].ConnectionString;
    }
}
