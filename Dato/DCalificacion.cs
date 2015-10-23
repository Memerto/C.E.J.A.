using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Reflection;

namespace Dato
{
    public class DCalificacion:Conexion
    {

        public List<ECalificacion> getCalificaciones()
        {
            //La función obtiene una conexión mediante la clase Conexion y con dicho objeto se creará el objeto command (OracleCommand).
            
            //Conexion objConexion = new Conexion();
            using (OracleConnection cn = getConexion())
            {
                cn.Open();

                //La clase OracleCommand permite ejecutar código SQL & PLSQL directamente desde la aplicación como stored procedures. 
                //Para esta acción se define que ejecutaremos un stored procedure e indicamos el procedimiento almacenado a ejecutar. 

                OracleCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "spu_listarCalificaciones";

                //Debido a que el stored procedure recibe un parámetro de salida creamos un objeto de tipo OracleParameter 
                //y lo definimos que será de salida y de tipo RefCursor.

                OracleParameter part1 = new OracleParameter();
                part1.OracleDbType = OracleDbType.RefCursor;
                part1.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(part1);

                //El método executeNonQuery ejecuta el stored procedure y éste nos devolverá 
                //el cursor ya abierto el cual tiene identificado el conjunto de filas a recuperar.

                cmd.ExecuteNonQuery();
                OracleRefCursor cursor = (OracleRefCursor)part1.Value;

                //Se crea el objeto DataReader mediante el valor obtenido por el cursor (OracleParameter) para recorrer
                //la información y cargarla a nuestro arreglo.
                //Existe un bug con el atributo RowSize del objeto Command ya que devuelve siempre el valor de 0.
                //Para evitar el bug y conseguir el tamaño en bytes de una fila se ha implementado las siguientes líneas de código.

                OracleDataReader dr = cursor.GetDataReader();
                FieldInfo fi = dr.GetType().GetField("m_rowSize", BindingFlags.Instance | BindingFlags.NonPublic);
                int rowsize = Convert.ToInt32(fi.GetValue(dr));

                /*Un fetch es un conjunto de filas que recoge la capa de aplicación de la base de datos mientras recorre un cursor.
                Por default este valor es 64 KB, es decir en bloques de 64 KB se va obteniendo todas las filas de un cursor.
            
                En muchas situaciones es recomendable aumentar el tamaño en ventaja de recoger la información más rápido siendo más eficientes.
                Esto se realiza con la siguiente línea de código: 
            
                dr.FetchSize = cmd.RowSize * 100; 

                En este caso esperamos recibir la información en bloques de 100 filas, por lo cual si una tabla tiene 1000 filas
                se harán 10 viajes de la capa de base de datos a la capa cliente para obtener la información completa de la tabla. 

                */

                dr.FetchSize = rowsize * 100;
                List<ECalificacion> listarCalificaciones = new List<ECalificacion>();
                while (dr.Read())
                {
                    ECalificacion objCalificacion = new ECalificacion();
                    objCalificacion.setID(Convert.ToInt32(dr["id"]));
                    objCalificacion.setAprueba(Convert.ToBoolean(dr["aprobacion"]));
                    objCalificacion.setComentario(dr["comentarios"].ToString());
                    objCalificacion.setFechaCreacion(Convert.ToDateTime(dr["fecha_creacion"]));
                    listarCalificaciones.Add(objCalificacion);

                }
                //cn.Close();
                //part1.Dispose();
                //cmd.Dispose();
                //cn.Dispose();
                //objConexion = null;
                return listarCalificaciones;

                /*Nota 1: En caso siempre una consulta retorne una sola fila con un solo campo es recomendable usar el método
                 * ExecuteScalar del objeto OracleCommand, ya que está diseñado a este tipo de escenario entregando mejor performance.

                  Nota 2: La forma de trabajar con los datos fueron de manera conectada en la función getCalificaciones.
                 * La manera desconectada se recomienda cuando queramos crear reportes que realizan operaciones de join entre
                 * múltiples tablas, donde la información se almacenará en objetos DataSet.
             
                */  
            }
            
            
        }

        public void insertar(ECalificacion calificacion) {
        
            /*Se ha diseñado este procedimiento para que ejecute la operación insert desde la capa de aplicación
             * y no mediante un stored procedure. El objetivo es demostrar como ejecutar sentencias desde la capa de aplicación,
             * más no sería lo más óptimo.
             */

            string SQL = "INSERT INTO CALIFICACION(ID,APROBACION,COMENTARIO,FECHACREACION) VALUES (:PID,:PAPROBACION,:PCOMENTARIO,:FECHACREACION)";
            Conexion objConexion = new Conexion();
            OracleConnection cn = objConexion.getConexion();
            cn.Open();

            OracleCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = SQL;
            cmd.Parameters.Add("PID", OracleDbType.Int32).Value = calificacion.getID();
            cmd.Parameters.Add("PAPROBACION", OracleDbType.Byte).Value = calificacion.getAprueba();
            cmd.Parameters.Add("PCOMENTARIO", OracleDbType.Varchar2).Value = calificacion.getComentario();
            cmd.Parameters.Add("FECHACREACION", OracleDbType.Date).Value = calificacion.getFechaCreacion();

            cmd.ExecuteNonQuery();

            cn.Close();
            cmd.Dispose();
            cn.Dispose();
            objConexion = null;

            /*Nota: Es recomendable que la sentencia SQL utilice parámetros para que diferentes valores que adopten los
             * parámetros, Oracle Database no cree un plan de ejecución por cada uno de ellos, haciendo que nuestra memoria
             * del Shared Pool de la base de datos sea ineficiente. Usando parámetros evitamos hard parsing en la base de datos.
            
             * Si deseamos evitar soft parsing, debemos mantener cursores en cache en la capa de aplicación evitando 
             * repetido procesamiento de metadata. Para realizar esta labor debemos habilitar el cache de sentencias 
             * en la cadena de conexión.
        
             * En nuestro ejemplo deberíamos agregar la cláusula "Statement Cache Size" a la cadena de conexión como
             * se adjunta en el siguiente ejemplo:

                Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=142.68.1.20)(PORT=1521)))
                (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));
                User Id=FRICCIO;Password=oracle;Enlist=false;Pooling=true; Statement Cache Size=50;
                El valor por default es 10.
             */ 
        }

        public void eliminar(ECalificacion calificacion) {
        
            /*EJEMPLO:
             * Este procedimiento se ejecuta el stored procedure spu_eliminarProducto el cual se detalla a continuación:

                create or replace procedure spu_eliminarCalificacion (pid number)
                is
                begin
                delete 
                from producto
                where id=pid;
                end;
                /

            Podemos observar que la confirmación de la transacción no se ha especificado en el código del Stored Procedure
             * porque como buena práctica dicha confirmación debe venir de la capa de aplicación.
             * Por default la conexión establece la propiedad autocommit; es decir terminado una ejecución de una operación DML
             * automáticamente se confirma.

            Nota: Una buena práctica es que la confirmación de la operación DML sea declarativo y
             * no esté configurado en autocommit.

            En el ejemplo de eliminar un producto se confirma la transacción mediante la propiedad autocommit.
             */
            Conexion objConexion = new Conexion();
            OracleConnection cn = objConexion.getConexion();
            cn.Open();

            OracleCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spu_eliminarCalificacion";
            cmd.Parameters.Add("PID", OracleDbType.Int32).Value = calificacion.getID();

            cmd.ExecuteNonQuery();

            cn.Close();
            cmd.Dispose();
            cn.Dispose();
            objConexion = null;


        
        }

        public void modificar(ECalificacion calificacion) {

            /*NOTA
             * Este procedimiento se ejecuta el stored procedure spu_eliminarProducto el cual se detalla a continuación:

            create or replace procedure spu_modificarCalificacion (pid number, paprobacion byte, pcomentario varchar, pfechacreacion date)
            is
            begin
            update producto
            set descripcion=pdescripcion, pu=ppu, registrado=pregistrado
            where id=pid;
            end;
            /
             * En esta ocasión la confirmación de la operación UPDATE no se ejecutará con la propiedad autocommit que es lo más recomendable.
            */

            Conexion objConexion = new Conexion();
            OracleConnection cn = objConexion.getConexion();
            cn.Open();

            OracleCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spu_modificarCalificacion";
            cmd.Parameters.Add("PID", OracleDbType.Int32).Value = calificacion.getID();
            cmd.Parameters.Add("PAPROBACION", OracleDbType.Byte).Value = calificacion.getAprueba();
            cmd.Parameters.Add("PCOMENTARIO", OracleDbType.Varchar2).Value = calificacion.getComentario();
            cmd.Parameters.Add("FECHACREACION", OracleDbType.Date).Value = calificacion.getFechaCreacion();

            OracleTransaction tx = cn.BeginTransaction();
            cmd.ExecuteNonQuery();
            tx.Commit();

            /*Para lograr con el objetivo de no utilizar la propiedad autocommit debemos crear un objeto de la clase
             * OracleTransaction y puntualmente debemos ejecutar el procedimiento commit si deseamos confirmar la transacción
             * de un conjunto de operaciones DML que pudiera ejecutar el OracleCommand o el procedimiento rollback si deseamos
             * cancelar.
            */

            cn.Close();
            cmd.Dispose();
            cn.Dispose();
            objConexion = null;

            /*Nota: ODP.NET nos permite configurar algunos aspectos de globalización de las conexiones que apertura la aplicación
             * hacia la base de datos. Esto lo realizamos a través de la clase OracleGlobalization. En el ejemplo se modifica el 
             * formato de fecha y el calendario para las conexiones de base de datos que ha realizado la aplicación.

                OracleGlobalization objGlobal = OracleGlobalization.GetClientInfo();
                objGlobal.DateFormat="DD/MON/YYYY";
                objGlobal.Calendar="Persian";
                OracleGlobalization.SetThreadInfo(objGlobal);
             */
            
        }

    }
}
