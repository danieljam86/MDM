using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace MDM
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            atualizaGrid();
        }


        protected void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txbcod.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o código');", true);
            }
            else if (txbcond.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o nome do Condomínio');", true);
            }
            else if (txbgerente.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o gerente');", true);
            }
            else if (txPrioridade.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar a prioridade do condomínio');", true);
            }
            else if (txmes.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o mês da pasta');", true);
            }
            else if (txano.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o ano da pasta');", true);
            }
            else
            {
                SqlConnection cn = new SqlConnection(
                    @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                SqlCommand cm = new SqlCommand(
                    "INSERT INTO BaseLiberacao(cod, cond, carteira, prioridade, mes, ano)" +
                    "VALUES (@cod, @cond, @carteira, @prioridade, @mes, @ano)", cn
                    );
                try
                {
                    cm.Parameters.AddWithValue("@cod", txbcod.Text);
                    cm.Parameters.AddWithValue("@cond", txbcond.Text);
                    cm.Parameters.AddWithValue("@carteira", txbgerente.Text);
                    cm.Parameters.AddWithValue("@prioridade", txPrioridade.Text);
                    cm.Parameters.AddWithValue("@mes", txmes.Text);
                    cm.Parameters.AddWithValue("@ano", txano.Text);
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

        protected void gvCadCond_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("mdmadm.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastrocond.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("LiberacaoConciliacao.aspx");
        }

        protected void VerificaDuplicidade()
        {

            SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
            SqlCommand cm = new SqlCommand("SELECT COUNT(0) FROM BaseLiberacao WHERE mes = @mes", cn
                );
            try
            {
                cm.Parameters.AddWithValue("@mes", txpmes.Text);
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Erro no Cadastro');", true);
                Response.Write(ex.Message);

            }
            finally
            {
                //Response.Write("<script>alert('Cadastrado com sucesso')</script>");
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Cadastrado com sucesso');", true);
                atualizaGrid();
                cn.Close();

            }

        }

        protected void UpdateTabela()
        {

            SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
            SqlCommand cm = new SqlCommand("UPDATE BaseLiberacao SET mes = @mes, ano = @ano", cn
                );
            try
            {
                var rd = Guid.NewGuid();
                cm.Parameters.AddWithValue("@mes", txpmes.Text);
                cm.Parameters.AddWithValue("@ano", txpano.Text);
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Erro no Cadastro');", true);
                Response.Write(ex.Message);

            }
            finally
            {
                //Response.Write("<script>alert('Cadastrado com sucesso')</script>");
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Cadastrado com sucesso');", true);
                atualizaGrid();
                cn.Close();

            }
        }

            protected void atualizaGrid()
        {
            SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
            SqlCommand cm = new SqlCommand(" select *from BaseLiberacao ORDER BY cod", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.HasRows == true)
            {
                gvCadCond.DataSource = dr;
                gvCadCond.DataBind();
                cn.Close();

            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("LiberacaoGerente.aspx");
        }

        protected void gvCadCond_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvCadCond.DataKeys[e.RowIndex].Value.ToString());
            SqlConnection cn = new SqlConnection(
                 @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
            SqlCommand cm = new SqlCommand("delete from Liberacao where id= @id", cn);
            cn.Open();
            cm.Parameters.AddWithValue("@id ", id);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        protected void gvCadCond_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate) | e.Row.RowState == DataControlRowState.Edit)
            //{
            //    return;
            //}

            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
            //    //Referencia ao linkbutton delete
            //    ImageButton deleteButton = (ImageButton)e.Row.Cells[6].Controls[0];
            //    deleteButton.OnClientClick = "if (!window.confirm('Confirma a exclusão deste registro ?')) return false;";
            //}
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (txpmes.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o mês da pasta');", true);
            }
            else if (txpano.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o ano da pasta');", true);
            }
            else
            {
                UpdateTabela();
                SqlConnection cn = new SqlConnection(
                        @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                SqlCommand cm = new SqlCommand(
                    "INSERT INTO Liberacao(cod, cond, carteira, prioridade, mes, ano)" +
                    "SELECT cod, cond, carteira, prioridade, mes, ano FROM BaseLiberacao", cn
                    );
                try
                {
                    //cm.Parameters.AddWithValue("@mes", txpmes.Text);
                    //cm.Parameters.AddWithValue("@ano", txpano.Text);
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

        protected void Button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
    
