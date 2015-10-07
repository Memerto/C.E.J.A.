using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Libro
    {
        private ArrayList _paginas;
        private String _nombre;

        #region Getters y Setters

        public void setPaginas(ArrayList paginas) { _paginas = paginas; }
        public void setNombre(String nombre) { _nombre = nombre; }
        public ArrayList getPaginas() { return _paginas; }
        public String getNombre() { return _nombre; }

        #endregion

        public void buscar() { }

        public void mostrarPagina() { }

        public void agregarPagina() { }

        public void eliminarPagina() { }

    }
}
