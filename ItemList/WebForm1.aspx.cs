﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ItemList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DropDownList1.SelectedIndex = "1";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue=="-1")
            {
                Response.Write("please select a continent");
            }

            else
            {
                Response.Write(DropDownList1.SelectedItem.Text + "<br/>");
                Response.Write(DropDownList1.SelectedItem.Value + "<br/>");
                Response.Write(DropDownList1.SelectedIndex + "<br/>");
            }
        }
    }
}