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

        public void buscar(String palabra) {

            ArrayList paginas = getPaginas();
            Pagina pagina;
            Tema tema;
            Post post;
            Propuesta propuesta;

            for (int i = 0; i < paginas.Count; i++)
            {
                pagina = (Pagina)paginas[i];
                tema = pagina.getTema();
                for (int i = 0; i < length; i++)
                {
                    
                }
            }



        }

        public void mostrarPagina() { }

        public void agregarPagina() { }

        public void eliminarPagina() { }

    }
}
