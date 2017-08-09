<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-family: "Times New Roman", Times, serif;
            font-style: italic;
            font-weight: bold;
            font-size: large;
        }
        .style2
        {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <fieldset  style=" width:570px; position:static;   text-align:center; top: 156px; left: 203px; border-color:White; border-style:groove; height: 369px; margin-left: 111px;">
     <legend style="font-family:Times New Roman;   color:Blue; font-size:medium; text-align: center;"> Welcome 
     </legend>
<table style="width: 536px; height: 291px; background-color :Aqua">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bold; color: #0000FF; font-style: italic">
            <i><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </b></i></td>
        <td class="style1">
            <span class="style2">&nbsp;</span><span style="font-style: normal" 
                class="style2"><em>Welcome</em></span><span class="style2">:&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="style2"></asp:Label>
        </td>
        <td>
            <i>
            <span class="style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                style="font-weight: bold; font-family: 'Times New Roman', Times, serif;" 
                CssClass="style2">Logout</asp:LinkButton>
            <br class="style2" />
            </i>
        </td>
    </tr>
    <tr>
        <td colspan="10" style="background-image: url('images/1.jpg'); height: 299px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;</td>
    </tr>
    
</table>
</fieldset>
</asp:Content>

