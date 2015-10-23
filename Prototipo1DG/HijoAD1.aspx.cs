using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Libreria;

namespace Prototipo1DG
{
    public partial class HijoAD1 : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CrearCuenta_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    Usuario nuevo = new Usuario("0000", false, true, contraseña.Text, apodo.Text, correoLogin.Text);
                }
                catch (Exception err)
                {
                   
                }
               
            }


        }


    }
}