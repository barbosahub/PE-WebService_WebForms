<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WFCorreios._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <br /><br />
        <label>Preencha os campos abaixo </label>    
    </div>
    <div class="row"> 
            <div class="col-sm-2">
            <label>Cep:</label>
            <asp:TextBox ID="txtCep" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="btnConsultaCep" ></asp:TextBox>
           <%--     --%>
                <div class="text-danger"><asp:Literal ID="ltlCompanyCep" runat="server"  /></div>
        </div>
            <div class="col-sm-5">
            <label>Endereço:</label>
            <asp:TextBox ID="txtStreet" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
            <div class="col-sm-5">
            <label>Cidade:</label>
            <asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>
        </div>            
    </div>    

                                                                                              
    <div class="row text-right">
        <div class="col-lg-12">
            <asp:Button runat="server" ID="btnConfirm" Text="CONFIRMAR" CssClass="btn btn-primary" OnClick="btnConsultaCep" />
        </div>                                     
    </div>


</asp:Content>
