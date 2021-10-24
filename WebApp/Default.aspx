<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>
<%@ Register TagPrefix="uc" TagName="Country" Src="~/Controls/CountryControl.ascx" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12">
            <uc:Country ID="CountrySelection" runat="server" />
        </div>
        <div class="col-md-12">
            <h2>Hello Harshal!</h2>
            <p>How are you doing today...</p>
              <p><asp:Button ID="btn" runat="server" Text="Do PostBack" OnClick="btn_Click" /></p>
        </div>
    </div>

</asp:Content>
