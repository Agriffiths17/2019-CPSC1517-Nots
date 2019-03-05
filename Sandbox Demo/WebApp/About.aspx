<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information. Enter Your name and click the button</p>

<%--    Tips:
    -[ctrl] + [k], [ctrl] + [c] will comment out your selected text
    -[ctrl] + [k], [ctrl] + [u] will un-comment out your selected text    
    -[ctrl] + [k], [ctrl] + [d] will format the code in your current file--%>

    <asp:Label ID="MessageLabel" runat="server" />

<%--    The ID attribute will generate a field name in the code-behind class that allows me to programmatically interact with the 
    asp.net server control.--%>
    <asp:TextBox ID="FullName" runat="server" />

<%--    A LinkButton will "look like" a link (render as an <a></a>), but "work like" a button--%>
    <asp:LinkButton ID="GetInitials" runat="server" CssClass="btn btn-primary" Text="Get Your Initials" OnClick="GetInitials_Click"/>
<%--    The OnClick that i specift here associates the click event of the button with a
    method handler in the code-behind of the page--%>
    <asp:Label ID="Initials" runat="server" />
    <asp:LinkButton ID="ReverseName" runat="server" CssClass="btn btn-default" Text="Spell it backwards"
        Visible="false" OnClick="ReverseName_Click" />
</asp:Content>
