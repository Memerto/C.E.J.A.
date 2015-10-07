using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    [Serializable]
    class Tema
    {
        private int _id;
        private ArrayList _posts; //Contiene Posts.
        private ArrayList _propuestas; //Contiene Propuestas
        private ArrayList _tags; //Contiene Tags.
        private String _titulo;
        private Categoria _categoria;
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacion;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setPosts(ArrayList posts) { _posts = posts; }
        public void setPropuestas(ArrayList propuestas) { _propuestas = propuestas; }
        public void setTags(ArrayList tags) { _tags = tags; }
        public void setTitulo(String titulo) { _titulo = titulo; }
        public void setCategoria(Categoria categoria) { _categoria = categoria; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacion = fechaModificacion; }

        public int getID() { return _id; }
        public ArrayList getPosts() { return _posts; }
        public ArrayList getPropuestas() { return _propuestas; }
        public ArrayList getTags() { return _tags; }
        public String getTitulo() { return _titulo; }
        public Categoria getCategoria() { return _categoria; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacion; }

        #endregion

        public Tema() {

            setID(0);
            setPosts(new ArrayList());
            setPropuestas(new ArrayList());
            setTags(new ArrayList());
            setTitulo("");
            setCategoria(new Categoria());
            setFechaCreacion(DateTime.Now);
            setFechaModificacion(DateTime.Now);
        }

        public Tema(int id,String titulo,Categoria categoria) {

            if (id == 0)
            {
                throw new ArgumentNullException("Constructor Tema - ID invalida.");
            }
            else
            {
                if (titulo == null || titulo == "")
                {
                    throw new ArgumentNullException("Constructor Tema - Titulo invalido.");
                }
                else
                {
                    if (categoria == null || categoria.getID() == 0)
                    {
                        throw new ArgumentNullException("Constructor Tema - Categoria invalida.");
                    }
                    else
                    {
                        setID(id);
                        setPosts(new ArrayList());
                        setPropuestas(new ArrayList());
                        setTags(new ArrayList());
                        setTitulo(titulo);
                        setCategoria(categoria);
                        setFechaCreacion(DateTime.Now);
                        setFechaModificacion(DateTime.Now);
                    }
                }
            }
        }

        public Tema(int id,ArrayList tags,String titulo,Categoria categoria){
        
            if (id == 0)
	        {
		        throw new ArgumentNullException("Constructor Tema - ID invalida.");
	        }
            else
            {
                if (tags.Count == 0 || tags == null)
                {
                    throw new ArgumentNullException("Constructor Tema - Array de tags invalido.");
                }
                else
                {
                    if (titulo == null || titulo == "")
                    {
                        throw new ArgumentNullException("Constructor Tema - Titulo invalido.");
                    }
                    else
                    {
                        if (categoria == null || categoria.getID() == 0)
                        {
                            throw new ArgumentNullException("Constructor Tema - Categoria invalida.");
                        }
                        else
                        {
                            setID(id);
                            setPosts(new ArrayList());
                            setPropuestas(new ArrayList());
                            setTags(tags);
                            setTitulo(titulo);
                            setCategoria(categoria);
                            setFechaCreacion(DateTime.Now);
                            setFechaModificacion(DateTime.Now);
                        }
                    }
                }
            }
        }
        
        public void listarPosts() { }

        public Boolean agregarTag(String tag)
        {

            if (tag == null || tag == "")
            {
                throw new ArgumentNullException("Seccion (Agregar Tag) - Tag invalido.");
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
                        throw new ArgumentException("Tema (Agregar Tag) - Ya se encuentra ese tag.");
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
                throw new ArgumentNullException("Tema (Eliminar Tag) - Ingrese un tag valido para eliminar.");
            }
            else
            {
                ArrayList repo;
                repo = getTags();
                if (repo.Contains(tag))
                {
                    repo.Remove(tag);
                    setTags(repo);
                    setFechaModificacion(DateTime.Now);
                    return true;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Tema (Eliminar Tag) - No se encontró el tag que desea eliminar.");
                }
            }
        }

        public Boolean agregarPost(Post post) {

            if (post.getID().Equals(0) || post == null)
            {
                throw new ArgumentNullException("Tema (Agregar Post) - Post invalido.");
            }
            else
            {
                Post po;
                ArrayList posts = getPosts();
                for (int i = 0; i < posts.Count; i++)
                {
                    po = (Post)posts[i];
                    if (po.getID().Equals(post.getID()) || po.Equals(post))
                    {
                        throw new ArgumentNullException("Tema (Agregar Post) - Post Duplicado.");
                    }
                }
                posts.Add(post);
                setPosts(posts);
                setFechaModificacion(DateTime.Now);
                return true;
            }
        }

        public Boolean elminiarPost(int id)
        {
            if (id == 0)
            {
                throw new Exception("Tema (Eliminar Post) - ID valida");
            }
            else
            {
                for (int i = 0; i < getPosts().Count; i++)
                {
                    ArrayList repo = getPosts();
                    Post post = (Post)getPosts()[i];
                    if (post.getID() == id)
                    {
                        repo.RemoveAt(i);
                        setPosts(repo);
                        setFechaModificacion(DateTime.Now);
                        return true;
                    }
                }
                throw new ArgumentException("Tema (Eliminar Post) - No se encontro el post a eliminar");
            }
            
        }

        public Boolean agregarPropuesta(Propuesta propuesta) {

            if (propuesta == null || propuesta.getID().Equals(0))
            {
                throw new ArgumentNullException("Tema (Agregar Propuesta) - Propuesta valida.");
            }
            else
            {
                ArrayList propuestas = getPropuestas();
                Propuesta prop;
                for (int i = 0; i < propuestas.Count; i++)
                {
                    prop = (Propuesta)propuestas[i];
                    if (prop.getID().Equals(propuesta.getID()) || prop.Equals(propuesta))
                    {
                        throw new ArgumentException("Tema (Agregar Propuesta) - Esa propuesta ya se encuentra en el Tema.");
                    }
                }
                propuestas.Add(propuesta);
                setPropuestas(propuestas);
                setFechaModificacion(DateTime.Now);
                return true;
            }
        }

        public Boolean eliminarPropuesta(Propuesta propuesta) {

            if (propuesta != null || propuesta.getID() != "0000")
            {
                ArrayList repo;
                Propuesta prop;
                repo = getPropuestas();
                for (int i = 0; i < repo.Count; i++)
                {
                    prop = (Propuesta)repo[i];
                    if (repo.Equals(propuesta) && prop.getID() == propuesta.getID())
                    {
                        repo.RemoveAt(i);
                        setPropuestas(repo);
                        setFechaModificacion(DateTime.Now);
                        return true;
                    }
                }

                throw new ArgumentException("Tema (Eliminar Propuesta) - La propuesta no se encuentra en el Tema.");
            }
            else
            {
                throw new ArgumentNullException("Tema (Eliminar Propuesta) - Propuesta invalida.");
            }
            }

        public Propuesta obtenerMejorPropuesta(TipoPropuesta tipo)
        {
            int contador, mejor = 0, ubic = 0;
            Propuesta prop;
            Calificacion cali;
            for (int i = 0; i < getPropuestas().Count; i++)
            {
                prop = (Propuesta)getPropuestas()[i];
                if (tipo.Equals(prop.getTipoPropuesta()))
                {
                    contador = 0;
                    for (int n = 0; n < prop.getCalificaciones().Count; n++)
                    {
                        cali = (Calificacion)prop.getCalificaciones()[n];
                        if (cali.getAprueba().Equals(true))
                        {
                            contador++;
                        }
                    }
                    if (mejor < contador)
                    {
                        mejor = contador;
                        ubic = Int32.Parse(prop.getID());
                    }
                }
            }
            prop = (Propuesta)getPropuestas()[ubic];

            return prop;
        }

        public int obtenerCantidadAprobacion(Propuesta propuesta) {

            Calificacion cali;
            int contador = 0;
            for (int n = 0; n < propuesta.getCalificaciones().Count; n++)
            {
                cali = (Calificacion)propuesta.getCalificaciones()[n];
                if (cali.getAprueba().Equals(true))
                {
                    contador++;
                }
            }
            
            return contador;
        }

        public int obtenerCantidadDesaprobacion(Propuesta propuesta)
        {
            Calificacion cali;
            int contador = 0;
            for (int n = 0; n < propuesta.getCalificaciones().Count; n++)
            {
                cali = (Calificacion)propuesta.getCalificaciones()[n];
                if (cali.getAprueba().Equals(false))
                {
                    contador++;
                }
            }
            return contador;
        }

        public String generarIDPropuestaPosicion() {

            StringBuilder sb = new StringBuilder();

            if (getPropuestas().Count < 10)
            {
                sb.Append("000" + (getPropuestas().Count - 1).ToString());
            }
            else
            {
                if (getPropuestas().Count < 100)
                {
                    sb.Append("00" + (getPropuestas().Count - 1).ToString());
                }
                else
                {
                    if (getPropuestas().Count < 1000)
                    {
                        sb.Append("0" + (getPropuestas().Count - 1).ToString());
                    }
                    else
                    {
                        sb.Append((getPropuestas().Count - 1).ToString());
                    }
                }
            }

            return sb.ToString();

        }   //Genera un String con la posicion en el ArrayList
    }
}
