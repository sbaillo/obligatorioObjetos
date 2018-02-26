<%@ Page Title="Alquiler de vehículos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alquiler.aspx.cs" Inherits="Obligatorio.Alquiler" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

   <br />

    <div class="row">
        <div class="col-md-3"></div>
        <div class="col-md-6">

            <h3>Alquiler de vehículos</h3>


             <asp:Label runat="server" Text="Tipo de cliente a ingresar"></asp:Label>

            <div class="form-group">
                <br />
                <asp:DropDownList ID="sTipoCliente" runat="server" Cssclass="form-control" ValidationGroup="cliente">
                    <asp:ListItem Selected="True">Particular</asp:ListItem>
                    <asp:ListItem>Empresa</asp:ListItem>
                </asp:DropDownList>
                                               
            </div>


            <div class="form-group">
                <asp:Label runat="server" Text="ID de Cliente"></asp:Label>
                <asp:TextBox ID="txtID" runat="server" CssClass="form-control col-md-12" ValidationGroup="cliente"></asp:TextBox>
                <asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="El campo no puede estar vacío y debe contener numeros" ClientValidationFunction="validarNumero" ControlToValidate="txtID" ValidateEmptyText="True" Font-Italic="True" Font-Size="Small" ForeColor="Red" ValidationGroup="cliente"></asp:CustomValidator>
            </div>

            <asp:Button ID="btnContinuar" runat="server" Text="Continuar" CssClass="btn" ValidationGroup="cliente" />
                        
            <br />
                       
            <asp:Panel ID="panelAlquiler" runat="server">
            
                <br />

            <asp:Label ID="datosCliente" runat="server" Text=""></asp:Label>
                 <br />

            <div class="form-group col-sm-6">
                <asp:Label runat="server" Text="Fecha Inicio"></asp:Label>
                <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="form-control col-md-12" Placeholder="DD/MM/AAAA"></asp:TextBox>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="El campo no puede estar vacío" ClientValidationFunction="validarVacio" ControlToValidate="txtFechaInicio" ValidateEmptyText="True" Font-Italic="True" Font-Size="Small" ForeColor="Red"></asp:CustomValidator>
            </div>


           <div class="form-group col-sm-6">
                <asp:Label runat="server" Text="Fecha Fin"></asp:Label>
                <asp:TextBox ID="txtFechaFin" runat="server" CssClass="form-control col-md-12" Placeholder="DD/MM/AAAA"></asp:TextBox>
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="El campo no puede estar vacío" ClientValidationFunction="validarVacio" ControlToValidate="txtFechaFin" ValidateEmptyText="True" Font-Italic="True" Font-Size="Small" ForeColor="Red"></asp:CustomValidator>
            </div>


                
            <div class="form-group col-md-6">
                <asp:Label runat="server" Text="Marca de vehículo"></asp:Label>
                <asp:DropDownList ID="sMarca" runat="server" Cssclass="form-control">
                    
                </asp:DropDownList>
                  <asp:CustomValidator ID="CustomValidator5" runat="server" ErrorMessage="Debe seleccionar una opción" ClientValidationFunction="validarVacio" ControlToValidate="sMarca" ValidateEmptyText="True" Font-Italic="True" Font-Size="Small" ForeColor="Red"></asp:CustomValidator>                           
            </div>

                <div class="form-group col-md-6">
                <asp:Label runat="server" Text="Modelo de vehículo"></asp:Label>
                <asp:DropDownList ID="sTipo" runat="server" Cssclass="form-control">
                   
                </asp:DropDownList>
                 <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="Debe seleccionar una opción" ClientValidationFunction="validarVacio" ControlToValidate="sTipo" ValidateEmptyText="True" Font-Italic="True" Font-Size="Small" ForeColor="Red"></asp:CustomValidator>                            
            </div>


                <asp:GridView ID="gridVehiculosDisponibles" runat="server"></asp:GridView>

            

            <asp:Button ID="btnAlquiler" runat="server" Text="Alquilar" CssClass="btn" />

                
                <br />
                <br />

                
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>

                <br />
                <asp:Label ID="lblExito" runat="server" ForeColor="Green"></asp:Label>

                <h3 id="lblPrecio"></h3>
               

            </asp:Panel>
        </div>
    </div>

</asp:Content>
