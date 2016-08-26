<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShaversWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="4000" OnTick="Timer1_Tick"></asp:Timer>
                <asp:Image ID="Image1" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <div class="row">
        <p id="mainPageParagraph">
            Shavers are a growing chain of barber shops who started business in 1993 , currently located in Kilbarrack, Balbriggan and Malahide.<br />
            We provide a friendly, yet professional atmosphere towards our customers and their requests. <br />
            We perform male grooming, have sunbeds and sell hair and beauty products, so drop into one of our shops or browse our online products
            that we can deliver or you can buy online.<br />
        </p>
    </div>
</asp:Content>