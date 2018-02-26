<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Obligatorio.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
    <div class="row">
        <div class="col-md-4"></div>
        
        <div class="col-md-4">
            
            <h3>Login</h3>
            <br />
           
            <div class="form-group">
                <asp:Label runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="txtUsuario" ForeColor="Red" Font-Italic="True" Font-Size="Small"></asp:RequiredFieldValidator>
            </div>


            <div class="form-group">
                <asp:Label runat="server" Text="Contraseña"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="txtPassword" ForeColor="Red" Font-Italic="True" Font-Size="Small"></asp:RequiredFieldValidator>
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Ingresar" CssClass="btn" />
            <br />
            <br />

                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>

            <br />
        
    
        
            </div>
        <div class="col-md-4"></div>
    </div>
    
</asp:Content>
