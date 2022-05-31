﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TradeCompany
{
    public partial class Showinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_AddOrder(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button2_AddToOrder(object sender, EventArgs e)
        {
            SqlDataSource2.Insert();
            GridView2.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Panel1.Visible = false;
        }

        protected void Button3_CancelOrder(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Panel1.Visible = false;
        }

        protected void Button4_EditOrder(object sender, EventArgs e)
        {
            if(Button4.Text == "Редактировать заказы")
            {
                GridView2.AutoGenerateEditButton = true;
                Button4.Text = "Закончить редактирование";
            }
            else
            {
                GridView2.AutoGenerateEditButton = false;
                Button4.Text = "Редактировать заказы";
            }
            
        }

        protected void Button5_DeleteOrder(object sender, EventArgs e)
        {
            if (Button5.Text == "Удалить заказ")
            {
                GridView2.AutoGenerateDeleteButton = true;
                Button5.Text = "Закончить удаление";
            }
            else
            {
                GridView2.AutoGenerateDeleteButton = false;
                Button5.Text = "Удалить заказы";
            }
        }

        protected void Button6_AddCust(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void Button7_AddToCust(object sender, EventArgs e)
        {
            SqlDataSource1.Insert();
            GridView1.DataBind();
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            Panel2.Visible = false;
        }

        protected void Button8_CancelCust(object sender, EventArgs e)
        {
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            Panel2.Visible = false;
        }

        protected void Button9_EditCust(object sender, EventArgs e)
        {
            if (Button9.Text == "Редактировать заказчика")
            {
                GridView1.AutoGenerateEditButton = true;
                Button9.Text = "Закончить редактирование";
            }
            else
            {
                GridView1.AutoGenerateEditButton = false;
                Button9.Text = "Редактировать заказчика";
            }
        }

        protected void Button10_DeleteCust(object sender, EventArgs e)
        {
            if (Button10.Text == "Удалить заказчика")
            {
                GridView1.AutoGenerateDeleteButton = true;
                Button10.Text = "Закончить удаление";
            }
            else
            {
                GridView1.AutoGenerateDeleteButton = false;
                Button10.Text = "Удалить заказчика";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}