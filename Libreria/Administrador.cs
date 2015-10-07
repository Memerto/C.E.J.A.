using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Administrador : Usuario
    {

        public Administrador(String id, Boolean activo, String contrasena, String apodo, String correo, String ocupacion, ArrayList intereses)
        {
            setID(id);
            setAdmin(true);
            setActivo(true);
            setContrasena(contrasena);
            setApodo(apodo);
            setCorreo(correo);
            setOcupacion(ocupacion);
            setIntereses(intereses);
        }

        public void eliminarPost(int id) { }

        public Tema crearTema(int id,String titulo,Categoria categoria) {

            Tema tema = new Tema(id, titulo, categoria);
            return tema;
        }

        public void editarTema(int idTema) { }

        public Boolean eliminarTema(Seccion seccion, Tema tema) {

            ArrayList temas;
            temas = seccion.getTemas();
            if (tema.getID().Equals(0) || tema.Equals(null))
            {
                throw new ArgumentNullException("Administrador (Elminar Tema) - Tema invalido.");
            }
            else
            {
                if (seccion.getID().Equals(0) || seccion.Equals(null))
                {
                    throw new ArgumentNullException("Administrador (Eliminar Tema) - Seccion invalida.");
                }
                else
                {
                    for (int i = 0; i < temas.Count; i++)
                    {
                        Tema temaComparar = (Tema)temas[i];
                        if (temaComparar.Equals(tema) && temaComparar.getID().Equals(tema.getID()))
                        {
                            temas.RemoveAt(i);
                            setFechaModificacion(DateTime.Now);
                            return true;
                        }
                    }
                    throw new ArgumentOutOfRangeException("Administrador (Eliminar Tema) - No se encuetra el tema a eliminar en la seccion.");
                }
            }
         }

        public void activarUsuario(Usuario usuario) {

            if (usuario.getID().Equals(0) || usuario.Equals(null))
            {
                throw new ArgumentNullException("Administrador (Activar Usuario) - Usuario invalido.");
            }
            else
            {
                usuario.setActivo(true);
            }
        }

        public void desactivarUsuario(Usuario usuario) {

            if (usuario.getID().Equals(0) || usuario.Equals(null))
            {
                throw new ArgumentNullException("Administrador (Activar Usuario) - Usuario invalido.");
            }
            else
            {
                usuario.setActivo(false);
            }
        }

        public void VotarAprobarPropuesta(Propuesta propuesta) {

            if (propuesta.getID().Equals(0) || propuesta.Equals(null))
            {
                throw new ArgumentNullException("Administrador (Votar Aprobar Propuesta) - Propuesta invalida.");
            }
            else
            {
                if (propuesta.getAprobada().Equals(true))
                {
                    throw new ArgumentException("Administrador (Votar Aprobar Propuesta) - La Propuesta ya se encuentra aprobada.");
                }
                else
                {
                    if (propuesta.getPreAprobada().Equals(false))
                    {
                        throw new ArgumentException("Administrador (Votar Aprobar Propuesta) - La Propuesta aun no se a Pre-Aprobado por la comunidad.");
                    }
                    else
                    {
                        int contador = 0;
                        Administrador admin;
                        ArrayList admins = propuesta.getAdminVotaron();
                            for (int i = 0; i < 3; i++)
                            {
                                admin = (Administrador)admins[i];
                                if (admin.getID().Equals(getID()))
                                {
                                    throw new ArgumentException("Administrador (Votar Aprobar Propuesta) - Usted ya voto en esta propuesta.");
                                }
                                if (!admin.getID().Equals(0))
                                {
                                    contador++;
                                }
                            }
                            if (contador < 3 || propuesta.getVotosAprobarAdmin().Equals(3))
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    admin = (Administrador)admins[i];
                                    if (admin.getID().Equals(0))
                                    {
                                        admins.Insert(i,new Administrador(getID(),getActivo(),getContrasena(),getApodo(),getCorreo(),getOcupacion(),getIntereses()));
                                        propuesta.setAdminVotaron(admins);
                                        propuesta.setVotosAprobarAdmin(propuesta.getVotosAprobarAdmin()+1);
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                throw new ArgumentOutOfRangeException("Administrador (Votar Aprobar Propuesta) - Ya han votado 3 Administradorese en esta Propuesta");
                            }
                    }
                }
            }
        }
    }
}
