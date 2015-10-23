using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class Libro
    {
        private ArrayList _paginas;
        private String _nombre;

        #region Getters y Setters

        public void setPaginas(ArrayList paginas) { _paginas = paginas; }
        public void setNombre(String nombre) { _nombre = nombre; }
        public ArrayList getPaginas() { return _paginas; }
        public String getNombre() { return _nombre; }

        #endregion

        public Tema buscar(String palabra) {
     
            ArrayList paginas = getPaginas();
            ArrayList tags;
            Pagina pagina;
            Tema tema;

            for (int i = 0; i < paginas.Count; i++)
            {
                pagina = (Pagina)paginas[i];
                tema = pagina.getTema();
                tags = tema.getTags();
                if (compararPalabras(palabra,tema.getTitulo()))
	            {
		                //Encontro la palabra
                    return tema;
	            }
                else
	            {
                    for (int n = 0; n < tags.Count; n++)
                    {
                        if (compararPalabras(palabra,tags[n].ToString()))
                        {
                            //Encontro la palabra
                            return tema;
                        }
                    }
	            } 
            }

            return new Tema();
        }

        public Boolean compararPalabras(String palabraPorBuscada, String palabraAComparar) {

            String buscada,comparar;

            comparar = palabraAComparar.Trim().ToUpper();
            buscada = palabraPorBuscada.Trim().ToUpper();

            if (comparar == buscada)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void mostrarPagina() { }

        public void agregarPagina(Pagina pagina) {

            if (pagina.Equals(null) || pagina.getID().Equals(0))
            {
                throw new ArgumentNullException("Libro (Agregar Pagina) - La pagina no es valida.");
            }
            else
            {
                ArrayList paginas = getPaginas();
                Pagina pag;
                for (int i = 0; i < paginas.Count; i++)
                {
                    pag = (Pagina)paginas[i];
                    if (pag.getID().Equals(pagina.getID()))
                    {
                        throw new ArgumentException("Libro (Agregar Pagina) - La pagina ya se encuentra agregada.");
                    }
                }

                paginas.Add(pagina);
                setPaginas(paginas);
            }
        }

        public void eliminarPagina(int id) {
        
            if (id.Equals(null) || id.Equals(0))
            {
                throw new ArgumentNullException("Libro (Eliminar Pagina) - ID invalido.");
            }
            else
            {
                ArrayList paginas = getPaginas();
                Pagina pag;
                for (int i = 0; i < paginas.Count; i++)
                {
                    pag = (Pagina)paginas[i];
                    if (id.Equals(pag.getID()))
                    {
                        paginas.RemoveAt(i);
                        setPaginas(paginas);
                    }
                }

                throw new ArgumentException("Libro (Agregar Pagina) - No se encontró la pagina.");
            }
        }

    }
}
