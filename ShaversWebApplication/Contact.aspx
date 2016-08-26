<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ShaversWebApplication.Contact" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %> </h2>
    <h4>Store Contact Details.</h4>
    <br />
    <h3>
        Shavers Kilbarrack
    </h3>
    <address>
        Kilbarrack Shopping Centre, <br />Dublin 05<br />
        Mon, Tue, Wed, 9.00am – 6.00pm | Thurs, Fri 9.30am – 8.00pm
        Sat 8.30am – 5.30pm | Sun 11.am – 5.00pm<br />
        <abbr title="Phone">Ph: </abbr>
        01 8** ****<br />
        <abbr title="Email">E: </abbr><a href="mailto:ShaversKilbarrack@gmail.com">ShaversKilbarrack@gmail.com</a>
    </address>
    <hr />
    <h3>
        Shavers Malahide
    </h3>
    <address>
        Malahide Village, <br />Co. Dublin.<br />
        Mon, Tue, Wed, 9.30am – 6.30pm | Thurs, Fri 9.30am – 7.00pm
        Sat 8.30am – 5.30pm | Sun 11.am – 5.00pm<br />
        <abbr title="Phone">Ph: </abbr>
        01 8** ****<br />
        <abbr title="Email">E: </abbr><a href="mailto:ShaversMalahide@gmail.com">ShaversMalahide@gmail.com</a>
    </address>
    <hr />
    
    <h3>
        Shavers Balbriggan
    </h3>
    <address>
        Balbriggan Main Street, <br />Co. Dublin.<br />
        Mon, Tue, Wed, 9.30am – 6.30pm | Thurs, Fri 9.30am – 7.00pm
        Sat 8.30am – 5.30pm | Sun 11.am – 5.00pm<br />
        <abbr title="Phone">Ph: </abbr>
        01 8** ****<br />
        <abbr title="Email">E: </abbr><a href="mailto:ShaversBalbriggan@gmail.com">ShaversBalbriggan@gmail.com</a>
    </address>
    <hr />
</asp:Content>