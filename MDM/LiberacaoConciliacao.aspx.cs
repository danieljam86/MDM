using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MDM
{


    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                atualizaGrid();
            }
            //dataHoje.Text = DateTime.Now.ToShortDateString();
            dataHoje.Text = "08/08/2020";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("mdmadm.aspx");
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("LiberacaoConciliacao.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }




        private void MarcarTodos(bool checkState)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("ProductSelector");
                if (cb != null)
                    cb.Checked = checkState;
            }
        }



        protected void marcaTodos_Click(object sender, EventArgs e)
        {
            MarcarTodos(true);
        }

        protected void desmarcaTodos_Click(object sender, EventArgs e)
        {
            MarcarTodos(false);
        }

        protected void btnSalver_Click(object sender, EventArgs e)
        {


        }

    

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastrocond.aspx");
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
            }
            cn.Close();


        }
        private void Delete(int cod)
        {

            SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
            SqlCommand cm = new SqlCommand("delete from Liberacao where id='" + cod + "'", cn);
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();       
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("ProductSelector");
                int id = Convert.ToInt32(GridView1.DataKeys[row.DataItemIndex].Value);
                if (cb != null && cb.Checked)
                {
                    SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cm = new SqlCommand("UPDATE Liberacao SET dataLib = @dataLib WHERE id = @id", cn
                        );
                    try
                    {
                        cm.Parameters.AddWithValue("@dataLib", Convert.ToDateTime(dataHoje.Text));
                        cm.Parameters.AddWithValue("@id", Convert.ToInt32(GridView1.DataKeys[row.DataItemIndex].Value.ToString()));
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

            }
        }
        protected void Salvar0_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("ProductSelector2");
                int id = Convert.ToInt32(GridView1.DataKeys[row.DataItemIndex].Value);
                if (cb != null && cb.Checked)
                {
                    SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cm = new SqlCommand("UPDATE Liberacao SET dataLibC2 = @dataLibC2 WHERE id = @id", cn
                        );
                    try
                    {
                        cm.Parameters.AddWithValue("@dataLibC2", Convert.ToDateTime(dataHoje.Text));
                        cm.Parameters.AddWithValue("@id", Convert.ToInt32(GridView1.DataKeys[row.DataItemIndex].Value.ToString()));
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

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("LiberacaoGerente.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}