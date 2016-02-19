using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrimeForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Crime_Click(object sender, EventArgs e)
    {
        CrimeRef.ServiceClient cr= new CrimeRef.ServiceClient();
        crLabel.Text = cr.GetRobberyData(txt_Long.Text, txt_Lat.Text);
        rpLabel.Text = cr.GetRapeData(txt_Long.Text, txt_Lat.Text);
        bglLabel.Text = cr.GetBurgData(txt_Long.Text, txt_Lat.Text);
        ltLabel.Text = cr.GetLTData(txt_Long.Text, txt_Lat.Text);
    }
}