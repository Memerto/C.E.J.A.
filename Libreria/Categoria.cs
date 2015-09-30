using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Categoria
    {
        private int _id;
        private String _tipo;

        public void setID(int id) { _id = id; }
        public void setTipo(String tipo) { _tipo = tipo; }
        public int getID() { return _id; }
        public String getTipo() { return _tipo; }

        public void agregarCategoria() { }

        public void eliminarCategoria() { }
    }
}
