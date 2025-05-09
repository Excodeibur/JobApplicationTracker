using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace JobTrackerWebForms
{
    public partial class JobAppsWebForm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=JobApplicationTracker;integrated security=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            //string connString = ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString;
 
            SqlCommand cmd = new SqlCommand("insert into JobApplications values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
            cmd.ExecuteNonQuery();
            Label1.Text = "Record submitted successfully";

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

            con.Close();
        }
    }
}

/*<connectionStrings>
	  <add name="defaultConn"
           connectionString ="Data Source=localhost\\SQLEXPRESS; Initial Catalog=JobApplicationTracker;integrated security=true"
           providerName="System.Data.SqlClient"/>
  </connectionStrings>*/