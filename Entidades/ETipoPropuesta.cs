using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ETipoPropuesta
    {
        private int _id;
        private String _tipo;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setTipo(String tipo) { _tipo = tipo; }
        public int getID() { return _id; }
        public String getTipo() { return _tipo; }

        #endregion
    }
}
