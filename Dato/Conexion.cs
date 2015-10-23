using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace Dato
{
    public class Conexion
    {

        private OracleConnection cn { get; set; }

        public OracleConnection getConexion()
        {
            if (cn == null)
            {
                //string conexion = System.Configuration.ConfigurationSettings.AppSettings["CONEXION"].ToString();
               //string conexion2 = System.Configuration.SettingAttribute.GetCustomAttributes(["cadena"].ToString();
                String conexion3="Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP) (HOST=142.68.1.20)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id=FRICCIO;Password=oracle;Enlist=false;Pooling=true";
                cn = new OracleConnection(conexion3);
            }
            return cn;
        }
    }
}
