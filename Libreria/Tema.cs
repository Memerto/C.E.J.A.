using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Tema
    {
        private int id;
        private Post[] posts;
        private Propuesta[] propuesta;
        private String[] tags;
        private String titulo;
        private Categoria categoria;
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;

        public void listarPosts() { }

        public void agregarTag() { }

        public void eliminarTag() { }

        public void agregarPropuesta() { }

        public void eliminarPropuesta() { }
    }
}
