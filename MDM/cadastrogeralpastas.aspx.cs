using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MDM
{
    public partial class cadastrogeralpastas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
                    @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
            SqlCommand cm = new SqlCommand(
                "INSERT INTO Liberacao(cod, cond, carteira, prioridade, mes, ano)" + 
                    "SELECT (cod, cond, carteira, prioridade, mes, ano FROM Liberacao)" +
                    "WHERE mes = @mes AND ano = @ano"
                    , cn
                    );
            try
            {
                cm.Parameters.AddWithValue("@mes", txbMes.Text);
                cm.Parameters.AddWithValue("@ano", txbAno.Text);
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
        protected void atualizaGrid()
        {
            SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
            SqlCommand cm = new SqlCommand(" select *from Liberacao", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.HasRows == true)
            {
                GridView1.DataSource = dr;
                GridView1.DataBind();
                cn.Close();

            }
        }
    }
}