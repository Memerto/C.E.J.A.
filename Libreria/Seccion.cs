using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    [Serializable]
    public class Seccion
    {
        private int _id;
        private String _nombre;
        private ArrayList _tags; //Contiene Tags : String
        private ArrayList _temas;  //Contiene Temas
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacione;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setNombre(String nombre) { _nombre = nombre; }
        public void setTags(ArrayList tags) { _tags = tags; }
        public void setTemas(ArrayList temas) { _temas = temas; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacione = fechaModificacion; }
        public int getID() { return _id; }
        public String getNombre() { return _nombre; }
        public ArrayList getTags() { return _tags; }
        public ArrayList getTemas() { return _temas; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacione; }

        #endregion

        public Boolean agregarTema(Tema tema) {

            ArrayList temas = getTemas();
            if (tema == null || tema.getID() == 0)
            {
                throw new ArgumentNullException("Seccion (Agregar Tema) - ID invalida.");
            }
            else
            {
                Tema temaComparar;
                for (int i = 0; i < temas.Count; i++)
                {
                    temaComparar = (Tema)temas[i];
                    if (temaComparar.Equals(tema))
                    {
                        throw new ArgumentException("Seccion (Agregar Tema) - El tema ya se encuentra en esta seccion.");
                    }
                }
                    temas.Add(tema);
                    setTemas(temas);
                    setFechaModificacion(DateTime.Now);
                    return true;
            }
        }

        public Boolean eliminarTema(Tema tema) {

            ArrayList temas = getTemas();
            if (tema == null || tema.getID() == 0)
            {
                throw new ArgumentNullException("Seccion (Agregar Tema) - ID invalida.");
            }
            else
            {
                if (temas.Contains(tema))
                {
                    temas.Add(tema);
                    setTemas(temas);
                    setFechaModificacion(DateTime.Now);
                    return true;
                }
                else
                {
                    throw new ArgumentException("Seccion (Agregar Tema) - El tema ya se encuentra en esta seccion.");
                }
            }
        
        }

        public Boolean agregarTag(String tag)
        {
            ArrayList repo = getTags();
            if (tag == null || tag == "")
            {
                throw new ArgumentNullException("Seccion (Agregar Tag) - Tag invalido.");
            }
            else
            {
                String tagComparar;
                for (int i = 0; i < repo.Count; i++)
                {
                    tagComparar = (String)repo[i];
                    if (tagComparar.Equals(tag))
                    {
                        throw new ArgumentException("Seccion (Agregar Tag) - Ya se encuentra ese tag.");
                    }
                }
                repo.Add(tag);
                setTags(repo);
                setFechaModificacion(DateTime.Now);
                return true;
            }
        }

        public Boolean eliminarTag(String tag) {

            if (tag == null || tag == "")
            {
                throw new ArgumentNullException("Seccion (Eliminar Tag) - Tag invalido.");
            }
            else
            {
                ArrayList repo;
                String tagComparar;
                repo = getTags();
                for (int i = 0; i < repo.Count; i++)
                {
                    tagComparar = (String)repo[i];
                    if (tagComparar.Equals(tag))
                    {
                        repo.Add(tag);
                        setTags(repo);
                        setFechaModificacion(DateTime.Now);
                        return true;
                    }
                }
                throw new ArgumentException("Seccion (Eliminar Tag) - Esa propuesta ya se encuentra en el Tema.");
            }
        }
        
        public void listarTemas() { }

    }
}
