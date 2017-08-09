<%@ Page Title="" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 85px;
            height: 22px;
        }
        .style10
        {
            width: 85px;
            height: 65px;
        }
        .style13
        {
            height: 50px;
        }
        .style14
        {
            width: 85px;
            height: 50px;
        }
        .style15
        {
            width: 40px;
            height: 65px;
        }
        .style18
        {
            height: 50px;
            width: 40px;
        }
        .style19
        {
            height: 80px;
            width: 40px;
        }
        .style20
        {
            width: 85px;
            height: 80px;
            color: #000000;
        }
        .style22
        {
            height: 22px;
            width: 40px;
        }
        .style23
        {
            height: 22px;
        }
        .style24
        {
            height: 65px;
        }
        .style27
        {
            font-family: "Times New Roman", Times, serif;
            font-size: large;
        }
        .style28
        {
            height: 80px;
        }
        .style29
        {
            width: 85px;
            height: 50px;
            color: #000000;
            font-style: italic;
        }
        .style30
        {
            color: #000000;
        }
        .style31
        {
            color: #000000;
            font-style: italic;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<fieldset  style=" width:570px; position:static;   text-align:center; top: 156px; left: 203px; border-color:White; border-style:groove; height: 317px; margin-left: 111px;">
     <legend style="font-family:Times New Roman;   color:Blue; font-size:medium; text-align: center;">USER LOGIN FORM
     </legend>
<table style="width: 100%; background-color :Aqua; height: 287px;">
            <tr>
                <td class="style22">
                    </td>
                <td colspan="2" class="style23">
                    &nbsp; <span style="font-size: x-large; font-family: 'Comic Sans MS'; color: #0000FF">
                    <em><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <%--<br />USER LOGIN FORM<br />--%>
                    </strong></em></span></td>
                <td class="style23">
                    </td>
            </tr>
            <tr>
                <td class="style22">
                    </td>
                <td style="font-size: large; " class="style4">
                    </td>
                <td class="style23">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;</td>
                <td class="style23">
                    </td>
            </tr>
           
            <tr>
                <td class="style19" >
                    </td>
                <td style="font-size: medium; font-family: 'Comic Sans MS';" class="style20"  >
                    User Name:</td>
                <td class="style28">
&nbsp;
                    <br />
&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server" Height="27px" Width="150px"></asp:TextBox>
                    <br />
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox5" ErrorMessage="Required Usernamer"></asp:RequiredFieldValidator>
                </td>
                <td class="style28" >
                    </td>
            </tr>
            <tr>
                <td class="style18" >
                    </td>
                <td style="font-size: medium; font-family: 'Comic Sans MS';" class="style29" >
                    Password:</td>
                <td class="style13" >
&nbsp;
                    
                    <br />
                    
                    &nbsp;
                    
                    <asp:TextBox ID="TextBox6" runat="server" TextMode="Password" Width ="150px" Height ="27px"></asp:TextBox>
                &nbsp;<br />
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox6" ErrorMessage="Required Password"></asp:RequiredFieldValidator>
&nbsp;
                </td>
                <td class="style13">
                    </td>
            </tr>
            <tr>
                <td class="style18" >
                    </td>
                <td style="font-size: medium; font-family: 'Comic Sans MS';" class="style14" >
                    <span class="style30">Login
                    Key</span><span class="style31">:</span></td>
                <td class="style13" >
&nbsp;
                    
                    <br />
                    
                    &nbsp;
                    
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" Width ="150px" Height ="27px"></asp:TextBox>
                &nbsp;<br />
&nbsp;&nbsp;
                    &nbsp;
                </td>
                <td class="style13">
                    </td>
            </tr>
             <tr>
                <td class="style18" >
                    </td>
                <td style="font-size: medium; font-family: 'Comic Sans MS';" class="style14" >
                    <span class="style30">Account
                    Key</span><span class="style31">:</span></td>
                <td class="style13" >
&nbsp;
                    
                    <br />
                    
                    &nbsp;
                    
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width ="150px" Height ="27px"></asp:TextBox>
                &nbsp;<br />
&nbsp;&nbsp;
                    &nbsp;
                </td>
                <td class="style13">
                    </td>
            </tr>
            <tr>
                <td class="style15">
                    </td>
                <td class="style10">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;</td>
                <td class="style24">
                    <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" 
                        Font-Italic="True" Font-Names="Comic Sans MS" Font-Size="Medium"  
                        Height ="30px" Width="69px"
                         />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" CssClass="style27" Text="Cancel" />
&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx" 
                        Font-Italic="True" Font-Names="Comic Sans MS" CssClass="style27">Sign Up </asp:HyperLink>
                &nbsp;&nbsp;&nbsp;
                    </td>
                <td class="style24">
                    </td>
            </tr>
        </table>
</asp:Content>

