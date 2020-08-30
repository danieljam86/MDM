using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MDM
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void ChangePassword1_ChangedPassword(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("mdmadm.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o Login');", true);
            }
            else if (nome.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o nome');", true);
            }
            else if (senha.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar a senha');", true);
            }
            else if (ddlPerfil.Text == "Selecione")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar perfil');", true);
            }
            else
            {
                SqlConnection cn = new SqlConnection(
                    @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                SqlCommand cm = new SqlCommand(
                    "INSERT INTO usuarios(login_, nome, senha, perfil)" +
                    "VALUES (@login, @nome, @senha, @perfil)", cn
                    );
                try
                {
                    cm.Parameters.AddWithValue("@login", login.Text);
                    cm.Parameters.AddWithValue("@nome", nome.Text);
                    cm.Parameters.AddWithValue("@senha", senha.Text);
                    cm.Parameters.AddWithValue("@perfil", ddlPerfil.Text);
                    cn.Open();
                    cm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Erro no Cadastro')</script>");
                    // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Erro no Cadastro');", true);
                    throw;
                }
                finally
                {
                    Response.Write("<script>alert('Cadastrado com sucesso')</script>");
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Cadastrado com sucesso');", true);
                    atualizaGrid();
                    cn.Close();

                }

            }
        }
        protected void atualizaGrid()
        {
            SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
            SqlCommand cm = new SqlCommand(" select *from usuarios", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.HasRows == true)
            {
                GridView1.DataBind();
            }
            cn.Close();

        }
    }
}