
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit"  TagPrefix="ajaxtoolkit" %>

<!DOCTYPE html>

<%@ Page language="C#"  serv CodeFile="~/exam_schedule.aspx.cs" Inherits="exam_schedule.exam_schedule" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_ADD_TO_exam_Click(object sender, EventArgs e)
    {
      
    }

    protected void CheckAll_Click(object sender, EventArgs e)
    {

    }

    protected void UncheckAll_Click(object sender, EventArgs e)
    {

    }

    protected void gridService_Training_Schedule_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 78px;
        }
    </style>
  </head>
    <body>

    <form id="form1" runat="server" dir="rtl">
        <div>
            <table id="content2" dir="rtl">
                <tr>
                    <td colspan="3">
                        <asp:Label ID="Label1" runat="server" Text="شاشة الامتحانات" Font-Bold="true" Font-Size="X-Large" ForeColor="black" style="text-align: center"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="مجموعة"></asp:Label>
                    </td>
                     

                 <td class="auto-style19" colspan="4">
                                <asp:DropDownList ID="DropDownList_Group_Name1"  runat="server"  AppendDataBoundItems="true" DataSourceID="SqlDataSource_Groups" listitem DataTextField="Group_name" DataValueField="Group_id" OnSelectedIndexChanged="DropDownList_Group_Name1_SelectedIndexChanged">
                                  <asp:ListItem Selected="True" Text="--اختر--" Value="0"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource_Groups" runat="server" ConnectionString="<%$ ConnectionStrings:dtuConnectionString %>" SelectCommand="SELECT [Group_id], [Group_name] FROM [Groups]">
                                <SelectParameters>
                                <asp:Parameter DefaultValue="true" Name="G_Is_open" Type="Boolean" />
                                <asp:Parameter DefaultValue="false" Name="G_Is_Close" Type="Boolean" />
                            </SelectParameters>
                                    </asp:SqlDataSource>
                            </td>

                    
               
                <br />
            </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="اليوم الاول"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;
                        <asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>  
                       <asp:TextBox ID="TextBox_exam_first" runat="server"> </asp:TextBox>
                        <ajaxtoolkit:CalendarExtender   ID="ce_exam_first"   runat="server"  Enabled="True"  TargetControlID="TextBox_exam_first" Format="dd-MM-yyyy">    
                </ajaxtoolkit:CalendarExtender>
                        <ajaxtoolkit:FilteredTextBoxExtender  ID="exam_first"  runat="server" TargetControlID="TextBox_exam_first"  FilterMode="ValidChars"    ValidChars="0123456789-/:">    
</ajaxtoolkit:FilteredTextBoxExtender>


                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="اليوم الثانى"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        
                       <asp:TextBox ID="TextBox_exam_secondday" runat="server"> </asp:TextBox>
                        <ajaxtoolkit:CalendarExtender   ID="CalendarExtender1"   runat="server"  Enabled="True"  TargetControlID="TextBox_exam_secondday" Format="dd-MM-yyyy">    
                </ajaxtoolkit:CalendarExtender>
                        <ajaxtoolkit:FilteredTextBoxExtender  ID="FilteredTextBoxExtender1"  runat="server" TargetControlID="TextBox_exam_secondday"  FilterMode="ValidChars"    ValidChars="0123456789-/:">    
</ajaxtoolkit:FilteredTextBoxExtender>

                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="المادة"></asp:Label>
                    </td>
                   
                     <td class="auto-style23" colspan="4">
                                <asp:DropDownList ID="DropDownList_Module2" runat="server" AppendDataBoundItems="true" DataSourceID="SqlDataSource_Module" DataTextField="module_name_ar" DataValueField="module_id">
                                <asp:ListItem Selected="True" Text="--اختر--" Value="0"></asp:ListItem>
                              
                                </asp:DropDownList>
                          
                                <asp:SqlDataSource ID="SqlDataSource_Module" runat="server" ConnectionString="<%$ ConnectionStrings:dtuConnectionString %>" SelectCommand="SELECT [module_id], [module_name_ar] FROM [Module]">
                                </asp:SqlDataSource>
                            </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="بداية الامتحان"></asp:Label>
                    </td>
                    <td> 
                       
                      
                       
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                       
                      
                       
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                     <td colspan="2">
                                <asp:Button ID="Button_ADD_TO_exam" runat="server" Text="اضافة" Height="35px" Width="128px" OnClick="Button_ADD_TO_exam_Click" />
                            </td>
                    <td>&nbsp;</td>

                </tr>
                 <tr>
                           
                      <td dir="rtl" class="auto-style42" colspan="9">
                           <asp:Button ID="CheckAll" runat="server" Text="اختيار الكل" />
 
                        <asp:Button ID="UncheckAll" runat="server" Text="Uncheck All" />
                                <asp:GridView ID="gridService_exam_Schedule" align runat="server" Width="740px" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource_Schedule_Exam" ForeColor="#333333" GridLines="None" DataKeyNames="Schedule_Ex_id">
                                    <AlternatingRowStyle BackColor="White" />

                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="CheckBox_schedule" runat="server" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Schedule_Ex_id" HeaderText="Schedule_Ex_id" SortExpression="Schedule_Ex_id" ReadOnly="True" />
                                        <asp:BoundField DataField="Exam_id" HeaderText="Exam_id" SortExpression="Exam_id" />
                                        <asp:BoundField DataField="module_id" HeaderText="module_id" SortExpression="module_id" />
                                        <asp:BoundField DataField="Schedule_Ex_date" HeaderText="Schedule_Ex_date" SortExpression="Schedule_Ex_date" />
                                        <asp:BoundField DataField="Schedule_Ex_time" HeaderText="Schedule_Ex_time" SortExpression="Schedule_Ex_time" />
                                        <asp:BoundField DataField="Schedule_Ex_duration" HeaderText="Schedule_Ex_duration" SortExpression="Schedule_Ex_duration" />
                                    </Columns>
                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                </asp:GridView>

                                <asp:SqlDataSource ID="SqlDataSource_Schedule_Exam" runat="server" ConnectionString="<%$ ConnectionStrings:dtuConnectionString %>" SelectCommand="SELECT [Schedule_Ex_id], [Exam_id], [module_id], [Schedule_Ex_date], [Schedule_Ex_time], [Schedule_Ex_duration] FROM [Schedule_Exam]">
                                </asp:SqlDataSource>

                            </td>
 </td>

 </tr>
                
                           
               
             </table>

                </div>
        
        </form>


    </body>
</html>
 