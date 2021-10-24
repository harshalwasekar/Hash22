<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CountryControl.ascx.cs" Inherits="WebApp.Controls.CountryControl" %>

<div class="container">
    <div class="row">
        <div class="col-md-12">
            <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlCountry" runat="server" Width="600px"></asp:DropDownList>
        </div>
        <div class="col-md-12">
            <asp:Label ID="Label1" runat="server" Text="State"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlState" runat="server" Width="600px"></asp:DropDownList>
        </div>
        <div class="col-md-12">
            <asp:Label ID="Label2" runat="server" Text="City"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlCity" runat="server" Width="600px"></asp:DropDownList>
        </div>
    </div>
</div>
<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {
        

    });
    $(function () {
        $.ajax({
            type: "POST",
            url: "Controls/CountryHandler.aspx/GetCountry",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {
                var ddlCountry = $("[id*=ddlCountry]");
                ddlCountry.empty().append('<option selected="selected" value="0">Please select Country</option>');
                $.each(r.d, function () {
                    ddlCountry.append($("<option></option>").val(this['Value']).html(this['Text']));
                });
            }
        });
        $.ajax({
            type: "POST",
            url: "Controls/CountryHandler.aspx/GetState",
            data: '{ "ID": "0"}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {
                var ddlState = $("[id*=ddlState]");
                ddlState.empty().append('<option selected="selected" value="0">Please select State</option>');
                $.each(r.d, function () {
                    ddlState.append($("<option></option>").val(this['Value']).html(this['Text']));
                });
            }
        });
        var ddlCity = $("[id*=ddlCity]");
        ddlCity.empty().append('<option selected="selected" value="0">Please select City</option>');

    });

    $("[id*=ddlCountry]").on("change", function () { 
        var CountryID = $("[id*=ddlCountry]").val();

        if (CountryID == null)
            CountryID = 0;
        
        $.ajax({
            type: "POST",
            url: "Controls/CountryHandler.aspx/GetState",
            data: '{ "ID": "' + CountryID+'" }',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {
                var ddlState = $("[id*=ddlState]");
                ddlState.empty().append('<option selected="selected" value="0">Please select State</option>');
                $.each(r.d, function () {
                    ddlState.append($("<option></option>").val(this['Value']).html(this['Text']));
                });
            }
        });

    });

    $("[id*=ddlState]").on("change", function () {
        var stateID = $("[id*=ddlState]").val();
  
        if (stateID == null)
            stateID = 0;

        $.ajax({
            type: "POST",
            url: "Controls/CountryHandler.aspx/GetCity",
            data: '{ "ID": "' + stateID + '" }',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {
                var ddlCity = $("[id*=ddlCity]");
                ddlCity.empty().append('<option selected="selected" value="0">Please select City</option>');
                $.each(r.d, function () {
                    ddlCity.append($("<option></option>").val(this['Value']).html(this['Text']));
                });
            }
        });

    });

    $("[id*=ddlCity]").on("change", function () {
        var cityID = $("[id*=ddlCity]").val();

        if (cityID == null)
            cityID = 0;

        $.ajax({
            type: "POST",
            url: "Controls/CountryHandler.aspx/SetCity",
            data: '{ "ID": "' + cityID + '" }',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {}
        });

    });
</script>