using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;



namespace exam_schedule
{
    public partial class exam_schedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button_ADD_TO_exam_Click(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList_Group_Name1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;



namespace traning_schedule
{
    public partial class trainig_schedule : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button_Add_Oriantion_day_Click(object sender, EventArgs e)
        {
            int Group_id = int.Parse(DropDownList_Group_Name.SelectedValue);
            System.Globalization.DateTimeFormatInfo dateInfo = new System.Globalization.DateTimeFormatInfo();
            dateInfo.ShortDatePattern = "yyyy-MM-dd";
            DateTime Orintation_Date = DateTime.ParseExact(TextBox_Oriantion_Date.Text, "yyyy-MM-dd", null);

            string Orintation_Time = TextBox_Oriantion_Time.Text;
            string dtuConnectionString = "Data Source=.;Initial Catalog=dtu;User ID=sa;Password=asd!@#123";
            SqlConnection con = new SqlConnection(dtuConnectionString);
            SqlCommand Insert_Oriantation = new SqlCommand();
            Insert_Oriantation.Connection = con;
            Insert_Oriantation.CommandText = "Insert_Oriantation";

            Insert_Oriantation.CommandType = CommandType.StoredProcedure;
            //SqlParameter[] pram = new SqlParameter[]
            //{
            //   new SqlParameter ("@Group_id", Group_id), 
            //  new SqlParameter ("@Orintation_Date", TextBox_Oriantion_Date.Text),
            //  new SqlParameter ("@Orintation_Time", Orintation_Time)

            //};

            //Insert_Oriantation.Parameters.AddRange(pram);
            Insert_Oriantation.Parameters.AddWithValue("@Group_id", Group_id);
            Insert_Oriantation.Parameters.AddWithValue("@Orintation_Date", Orintation_Date);
            Insert_Oriantation.Parameters.AddWithValue("@Orintation_Time", Orintation_Time);



            try
            {
                con.Open();
                Insert_Oriantation.ExecuteNonQuery();
                Label_Saveoriantation.Text = "تم الحفظ بنجاح";


            }
            catch (Exception)
            {

                // Label_Saveoriantation.Text = "لم يتم الحقظ";
                Exception exc = Server.GetLastError();

            }
            finally
            {
                con.Close();
                TextBox_Oriantion_Date.Text = "";
                TextBox_Oriantion_Time.Text = "";
            }

        }

    }




using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data;


public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Log_Users where UserName =@username and Password=@password", con);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPWD.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Details.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username Or Password')</script>");
            }
        }
    }
*/
