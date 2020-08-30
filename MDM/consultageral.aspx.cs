using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace MDM
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    atualizaGrid();
            //}
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            Response.Redirect("cadastrocond.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("consultageral.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastrocond.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("LiberacaoConciliacao.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("LiberacaoGerente.aspx");
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroUsuario.aspx");
        }

        protected void VerificaVaziodataLib()
        {
            if (carteira.Text != "TODOS")
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE carteira = @gerente AND mes = @mes AND ano = @ano AND dataLib is null  ", cn);
                cm.Parameters.AddWithValue("@gerente", carteira.Text);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                    lblc1.Text = dr[0] + "\n";
                cn.Close();

            }
            else
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE mes = @mes AND ano = @ano AND dataLib is null  ", cn);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                lblc1.Text = dr[0] + "\n";
                cn.Close();

            }
        }

        protected void VerificaVaziodataLibG1()
        {
            if (carteira.Text != "TODOS")
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE carteira = @gerente AND mes = @mes AND ano = @ano AND dataLibG1 is null  ", cn);
                cm.Parameters.AddWithValue("@gerente", carteira.Text);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                    lblg1.Text = dr[0] + "\n";
                cn.Close();

            }
            else
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE mes = @mes AND ano = @ano AND dataLibG1 is null  ", cn);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                    lblg1.Text = dr[0] + "\n";
                cn.Close();

            }
        }

        protected void VerificaVaziodataLibP()
        {
            if (carteira.Text != "TODOS")
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE carteira = @gerente AND mes = @mes AND ano = @ano AND dataLibP is null  ", cn);
                cm.Parameters.AddWithValue("@gerente", carteira.Text);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                    lblp.Text = dr[0] + "\n";
                cn.Close();

            }
            else
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE mes = @mes AND ano = @ano AND dataLibP is null  ", cn);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                    lblp.Text = dr[0] + "\n";
                cn.Close();

            }
        }

        protected void VerificaVaziodataLibC2()
        {
            if (carteira.Text != "TODOS")
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE carteira = @gerente AND mes = @mes AND ano = @ano AND dataLibC2 is null  ", cn);
                cm.Parameters.AddWithValue("@gerente", carteira.Text);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                    lblc2.Text = dr[0] + "\n";
            }
            else
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE mes = @mes AND ano = @ano AND dataLibC2 is null  ", cn);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                    lblc2.Text = dr[0] + "\n";
                cn.Close();

            }
        }

        protected void VerificaVaziodataLibG2()
        {
            if (carteira.Text != "TODOS")
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE carteira = @gerente AND mes = @mes AND ano = @ano AND dataLibG2 is null  ", cn);
                cm.Parameters.AddWithValue("@gerente", carteira.Text);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                    lblg2.Text = dr[0] + "\n";
                cn.Close();

            }
            else
            {
                SqlConnection cn = new SqlConnection(
                @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                //SqlCommand cm = new SqlCommand(" select count(*) AS dataLib from Liberacao WHERE mes = @mes, ano = @ano, dataLib is null  ", cn);
                SqlCommand cm = new SqlCommand(" select count(*) from Liberacao WHERE mes = @mes AND ano = @ano AND dataLibG2 is null  ", cn);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                    lblg2.Text = dr[0] + "\n";
                cn.Close();

            }
        }

        protected void atualizaGrid()
        {
            if (carteira.Text != "TODOS")
            {
                SqlConnection cn = new SqlConnection(
                    @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                SqlCommand cm = new SqlCommand(" select * from Liberacao WHERE carteira = @gerente AND mes = @mes AND ano = @ano ORDER BY carteira ", cn);
                cm.Parameters.AddWithValue("@gerente", carteira.Text);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                    cn.Close();

                }
            }
            else
            {
                SqlConnection cn = new SqlConnection(
                    @"Data Source=DESKTOP-HICL4N5;Initial Catalog=mdmadm;Integrated Security=True;Connect Timeout=30");
                SqlCommand cm = new SqlCommand(" select * from Liberacao WHERE mes = @mes AND ano = @ano ORDER BY carteira ", cn);
                cm.Parameters.AddWithValue("@mes", txmes.Text);
                cm.Parameters.AddWithValue("@ano", txano.Text);
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
            {
            //SqlConnection cn = new SqlConnection(
            //    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danie\OneDrive\Documentos\dados_mdm.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlCommand cm = new SqlCommand(" select * from Liberacao", cn);
            //cn.Open();
            //SqlDataReader dr = cm.ExecuteReader();

            //if (dr.HasRows == true)
            //{

            //    GridView1.DataBind();
             }

        protected void Button6_Click(object sender, EventArgs e)
        {
            VerificaVaziodataLib();
            VerificaVaziodataLibG1();
            VerificaVaziodataLibP();
            VerificaVaziodataLibC2();
            VerificaVaziodataLibG2();

            if (txmes.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o mês da consulta');", true);
            }
            else if (txano.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "mensagem-1", "alert('Favor informar o ano da consulta');", true);
            }
            else
            {
                atualizaGrid();
            }

        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            //decimal Total = 0;
            //foreach (GridViewRow row in GridView1.Rows)
            //{
            //    // converte o preco e a qtde para multiplicar e somar no total
            //    decimal preco = decimal.Parse(row.Cells[2].Text);
            //    int qtde = Int32.Parse(row.Cells[3].Text);
            //    Total += preco * qtde;
            //}
            //GridViewRow footer = GridView1.FooterRow;
            //footer.Cells[0].ColumnSpan = 3;
            //footer.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            //footer.Cells.RemoveAt(2);
            //footer.Cells.RemoveAt(1);
            //footer.Cells[0].Text = string.Format("Stock value: {0:n2}", myStock);
        }

        // Class-scope, running total variables...
        decimal _dataLib = 0m;
        int _dataLibG1 = 0;
        int _dataLibP = 0;
        int _dataLibC2 = 0;
        int _dataLibG2 = 0;
        private int valorTotal = 0;


        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                CalculaTotal(e.Row.Cells[1].Text);
                //e.Row.Cells[1].Text = string.Format("{0:c}", Convert.ToInt32(e.Row.Cells[1].Text));
                e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Right;
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[0].Text = "Total Pastas";
                e.Row.Cells[1].Text = GridView1.Rows.Count.ToString();
                e.Row.Cells[2].Text = GridView1.Rows.Count.ToString();
                e.Row.Cells[3].Text = GridView1.Rows.Count.ToString();
                e.Row.Cells[4].Text = GridView1.Rows.Count.ToString();
                e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Right;
            }
            
        }
        private void CalculaTotal(string _preco)
        {
            try
            {
                valorTotal += Int32.Parse(_preco);
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.ToString());
            }
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            
            if (e.Row.RowType == DataControlRowType.Header)
            {
                GridView grvObjeto = (GridView)sender;
                GridViewRow gvrObjetoLinha = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell tclCelula = new TableCell();
                tclCelula = new TableCell();
                tclCelula.Text = "Depto";
                tclCelula.ColumnSpan = 3;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "Conciliação";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "Gerente";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "Prévia";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "Conciliação";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "Gerente";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
            }
            if (e.Row.RowType == DataControlRowType.Header)
            {
                GridView grvObjeto = (GridView)sender;
                GridViewRow gvrObjetoLinha = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell tclCelula = new TableCell();
                tclCelula = new TableCell();
                tclCelula.Text = "Prazo";
                tclCelula.ColumnSpan = 3;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "02/09/2020";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "04/09/2020";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "16/09/2020";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "17/09/2020";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula = new TableCell();
                tclCelula.Text = "";
                tclCelula.ColumnSpan = 1;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
            }
            if (e.Row.RowType == DataControlRowType.Header)
            {
                GridView grvObjeto = (GridView)sender;
                GridViewRow gvrObjetoLinha = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell tclCelula = new TableCell();
                tclCelula = new TableCell();
                tclCelula.Text = "ACOMPANHAMENTO DE LIBERAÇÃO FECHAMENTOS " + txmes.Text + "/" + txano.Text;
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
                tclCelula.ColumnSpan = 9;
                gvrObjetoLinha.Cells.Add(tclCelula);
                grvObjeto.Controls[0].Controls.AddAt(0, gvrObjetoLinha);
                tclCelula.HorizontalAlign = HorizontalAlign.Center;
            }
        }

    }
}