<%@ Page Title="" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<fieldset  style=" width:594px; position:static;   text-align:center; top: 156px; left: 203px; border-color:White; border-style:groove; height: 449px; margin-left: 111px;">
     <legend style="font-family:Times New Roman;   color:Blue; font-size:medium; text-align: center;"> USER REGISTRATION FORM
     </legend>
<table style="width: 98%; height: 379px; background-color :Aqua">
        
        <tr>
            <td style="width: 2%">
                <span style="color: #0000FF"></td>
            <td style="font-size: large; width: 19%">
                </span><span style="font-family: 'Comic Sans MS'"><span style="color: #0000FF"></td>
            <td style="width: 50%">
                </span></td>
            <td style="width: 2%">
                </span></td>
        </tr>
        <tr>
            <td style="height: 19px; width: 2%">
                <span style="color: #0000FF"></td>
            <td style="font-size: medium; font-family: 'Comic Sans MS'; width: 19%; color: #000000; height: 19px;">
                <i>Full Name:</i></span></td>
            <td style="height: 19px; width: 50%">
                <asp:TextBox ID="TextBox1" runat="server" style="font-family: 'Comic Sans MS'" Width ="150px" Height ="27"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Required Username"></asp:RequiredFieldValidator>
            </td>
            <td style="font-family: 'Comic Sans MS'; color: #0000FF; height: 19px; width: 2%;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 2%">
                <span style="color: #0000FF"></td>
            <td style="font-size: medium; font-family: 'Comic Sans MS'; width: 19%; color: #000000;">
                <i>Address:</i></span></td>
            <td style="width: 50%">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" 
                    style="font-family: 'Comic Sans MS'; color: #000000"  Width ="150px" Height ="27"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="Required Address"></asp:RequiredFieldValidator>
            </td>
            <td style="font-family: 'Comic Sans MS'; color: #0000FF; width: 2%;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 2%">
                <span style="color: #0000FF"></td>
            <td style="font-size: medium; font-family: 'Comic Sans MS'; width: 19%; color: #000000;">
                <i>Gender:</i></td>
            <td style="width: 50%" class="style1">
                <span><span style="color: #000000">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="a" 
                     />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="a" />
                </span>
            </td>
            <td style="width: 2%">
                </span></td>
        </tr>
        <tr>
            <td style="height: 26px; width: 2%;">
            </td>
            <td style="font-size: medium; font-family: 'Comic Sans MS'; width: 19%; height: 26px; color: #000000;">
                <i>Email:</i></td>
            <td style="height: 26px; width: 50%;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" style="font-family: 'Comic Sans MS'"  Width ="150px" Height ="27"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="Plz Insert Correct Email " 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td style="height: 26px; width: 2%;">
            </td>
        </tr>
        <tr>
            <td style="width: 2%">
                <span style="color: #0000FF"></td>
            <td style="font-size: medium; font-family: 'Comic Sans MS'; width: 19%; color: #000000;">
                <i>Contact No:</i></span></td>
            <td style="width: 50%">
                <asp:TextBox ID="TextBox4" runat="server" style="font-family: 'Comic Sans MS'"  Width ="150px" Height ="27"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox4" ErrorMessage="Requierd Contact"></asp:RequiredFieldValidator>
            </td>
            <td style="font-family: 'Comic Sans MS'; color: #0000FF; width: 2%;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 2%">
                <span style="color: #0000FF"></td>
            <td style="font-size: medium; font-family: 'Comic Sans MS'; width: 19%; color: #000000;">
                <i>User Name:</i></span></td>
            <td style="width: 50%">
                <asp:TextBox ID="TextBox5" runat="server" style="font-family: 'Comic Sans MS'"  Width ="150px" Height ="27"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="TextBox5" ErrorMessage="Required Username"></asp:RequiredFieldValidator>
            </td>
            <td style="font-family: 'Comic Sans MS'; color: #0000FF; width: 2%;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 2%">
                <span style="color: #0000FF"></td>
            <td style="font-size: medium; font-family: 'Comic Sans MS'; width: 19%; color: #000000;">
                <i>Password:</i></span></td>
            <td style="width: 50%">
                <asp:TextBox ID="TextBox6" runat="server" style="font-family: 'Comic Sans MS'" 
                    TextMode="Password"  Width ="150px" Height ="27"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="TextBox6" ErrorMessage="Required Password"></asp:RequiredFieldValidator>
            </td>
            <td style="font-family: 'Comic Sans MS'; color: #0000FF; width: 2%;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 34px; width: 2%;">
                <span style="color: #0000FF"></td>
            <td style="width: 19%; color: #000000; height: 34px;">
                <span style="font-family: 'Comic Sans MS'">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></span><span style="font-family: 'Comic Sans MS'; color: #000000">&nbsp;</span></td>
            <td style="height: 34px; width: 50%;">
               
                <asp:Button 
                    ID="Button1" runat="server" Text="Register" 
                    style="font-family: 'Comic Sans MS'"  
                    Height="30px" onclick="Button1_Click" Font-Italic="True" 
                    Font-Names="Comic Sans MS" Font-Size="Medium"  />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" 
                    style="font-family: 'Comic Sans MS'" Height="30px" Font-Italic="True" 
                    Font-Names="Comic Sans MS" Font-Size="Medium" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ="~/Login.aspx" 
                    Font-Italic="True" Font-Names="Comic Sans MS" Font-Size="Medium" >Go To Login</asp:HyperLink>

            </td>
            <td style="font-family: 'Comic Sans MS'; color: #0000FF; height: 34px; width: 2%;">
                </td>
        </tr>
        <tr>
        <td></td>
        <td></td>
        </tr>
    </table>
</asp:Content>

