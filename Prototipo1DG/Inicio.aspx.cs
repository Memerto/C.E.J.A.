using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Libreria;

namespace Prototipo1DG
{
    public partial class Inicio : System.Web.UI.Page
    {

        public Foro foro = new Foro();
        


        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                
            }

            

        }


    }
}