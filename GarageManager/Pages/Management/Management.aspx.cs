using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Managerment_Management : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void grdProducts_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Get seleted row
        GridViewRow row = grdProducts.Rows[e.NewEditIndex];
        //Get Id of selected product
        int rowId = Convert.ToInt32(row.Cells[1].Text);
        //Redirect user to ManagerProducts along with the selected rowId
        Response.Redirect("~/Pages/Management/ManageProducts.aspx?id="+rowId);

    }
}