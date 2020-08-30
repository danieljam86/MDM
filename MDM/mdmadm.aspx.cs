using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MDM
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        //private void Recuperar()
        //{
        //    try
        //    {
        //        usuario.Text = Session["Salvar"].ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            //Recuperar();
            data.Text = DateTime.Now.ToShortDateString();
            Label4.Text = usuario.Text;
            usuario.Text = Variaveis.Login;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LiberacaoGerente.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("consultageral.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastrocond.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroUsuario.aspx");
        }
    }
}