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
    public partial class exam : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = dtu; User ID = sa; Password=***********");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_ADD_TO_exam_Click(object sender, EventArgs e)
        {
            SqlCommand sp_exam_schedule = new SqlCommand("sp_exam_schedule", con);
            sp_exam_schedule.CommandType = CommandType.StoredProcedure;
            int Group_id = int.Parse(DropDownList_Group_Name1.SelectedValue);

            int module_id = int.Parse(DropDownList_Module2.SelectedValue);
            DateTime 
           
            //System.Globalization.DateTimeFormatInfo dateInfo = new System.Globalization.DateTimeFormatInfo();
           // dateInfo.ShortDatePattern = "yyyy-MM-dd";
            DateTime exam_first_Date = Convert.ToDateTime(ce_exam_first);
           
            //System.Globalization.DateTimeFormatInfo dateInfo = new System.Globalization.DateTimeFormatInfo();
            //dateInfo.ShortDatePattern = "yyyy-MM-dd";
            //DateTime exam_secondday = DateTime.ParseExact(TextBox_exam_secondday, "yyyy-MM-dd", null);
            //string exam_secondday = TextBox_exam_secondday.Text;

            sp_exam_schedule.Parameters.AddWithValue("@Group_id", Group_id);
            
             sp_exam_schedule.Parameters.AddWithValue("@Schedule_Ex_date", exam_first_Date);
            
             sp_exam_schedule.Parameters.AddWithValue("@Schedule_Ex_time", )
     
            sp_exam_schedule.Parameters.AddWithValue("@module_id", module_id);


            try
            {
                con.Open();
                sp_exam_schedule.ExecuteNonQuery();
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
                TextBox_exam_first_Date.Text = "";
                TextBox_exam_first_Time.Text = "";
            }

        }

   



protected void button_save_exam_Click(object sender, EventArgs e)
        {

        }


        protected void button_delete_exam_Click(object sender, EventArgs e)
        {

        }

        protected void Button_insert_day_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
 
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




*/
