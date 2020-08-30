using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MDM
{



    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Salvar()
        {
            try
            {
                if (txtUsuario.Text != string.Empty)
                Session["Salvar"] = this.txtUsuario.Text;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string usuarioConectado;

        public bool VerificaLogin()
        {

            bool result = false;
            SqlConnection cn = new SqlConnection(
                    @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
            try
            {
                SqlCommand cm = new SqlCommand("select * from usuarios where login_ = @usuario AND senha = @senha;", cn);
                cm.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cm.Parameters.AddWithValue("@senha", txtSenha.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                result = dr.HasRows;
                
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('Erro no acesso')</script>");
                // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Erro no Cadastro');", true);
                throw;
            }
            finally
            {
                cn.Close();
            }
            return result;
        }

    protected void Button1_Click(object sender, EventArgs e)
        {

            Variaveis.Login = txtUsuario.Text;
            //Perfil();
            Salvar();
            bool result = VerificaLogin();
            Logado = result;
            if (result)
            {
                usuarioConectado = txtUsuario.Text;
                Response.Redirect("mdmadm.aspx");
            }
            else
            {
                lblmens.Text = "Usuário / Senha inválido";
            }

            

        }
        //private void Perfil()
        //{
        //    SqlConnection cn = new SqlConnection(
        //            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danie\OneDrive\Documentos\dados_mdm.mdf;Integrated Security=True;Connect Timeout=30");
        //    {
        //        SqlCommand cm = new SqlCommand(" select * from usuarios WHERE perfil = @perfil ", cn);
        //        cm.Parameters.AddWithValue("@perfil", txtUsuario.Text);
        //        cn.Open();
        //        SqlDataReader dr = cm.ExecuteReader();
        //        lblPerfil.Text = dr[]
        //        cn.Close();
        //    }
        //}

        

        private bool Logado = false;

    }
}