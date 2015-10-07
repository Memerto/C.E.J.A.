using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    class TipoReporte
    {
        private int _id;
        private String _tipo;

        public void setID(int id) { _id = id; }
        public void setTipo(String tipo) { _tipo = tipo; }
        public int getID() { return _id; }
        public String getTipo() { return _tipo; }

        public TipoReporte() {

            setID(0);
            setTipo("");
        }

        public TipoReporte(int id, String tipo) {

            if (id == 0)
            {
                throw new ArgumentNullException("ID del reporte no valida (0 o null)");
            }
            else
            {
                if (tipo == null || tipo == "")
                {
                    throw new ArgumentNullException("Texto del reporte invalido (\"\" o null)");
                }
                else
                {
                    setID(id);
                    setTipo(tipo);
                }
            }         
        }

        public void agregarTipo(String tipo) {

            if (tipo != null || tipo != "")
            {
                setTipo(tipo);
            }
            else
            {
                throw new ArgumentNullException("Texto invalido. No se agregó el tipo nuevo.");
            }
        }
    }
}
