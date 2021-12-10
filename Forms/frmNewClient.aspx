<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmNewClient.aspx.cs" Inherits="DMS.Forms.frmNewClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="form-horizontal">
        <h4>Crear un nuevo Cliente</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />

           <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Tipo" CssClass="col-md-2 control-label">Tipo Cliente</asp:Label>
            <div class="col-md-10">

                <asp:DropDownList ID="tipo" runat="server" CssClass="form-control"></asp:DropDownList>
                
                 <asp:RequiredFieldValidator runat="server" ControlToValidate="tipo"
                    CssClass="text-danger" ErrorMessage="El campo de Tipo Cliente es obligatorio." />
                
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Nombre" CssClass="col-md-2 control-label">Nombre o Razón Social</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Nombre" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Nombre"
                    CssClass="text-danger" ErrorMessage="El campo de Nombre es obligatorio." />
            </div>
        </div>
        
           <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Correo electrónico</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="El campo de correo electrónico es obligatorio." />
            </div>
        </div>

          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Documento" CssClass="col-md-2 control-label">Cedula o Nit</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Documento" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Documento"
                    CssClass="text-danger" ErrorMessage="El campo de Cedula o Nit  es obligatorio." />
            </div>
        </div>


          
          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Telefono" CssClass="col-md-2 control-label">Telefono</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Telefono" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Telefono"
                    CssClass="text-danger" ErrorMessage="El campo de Telefono es obligatorio." />
            </div>
        </div>


            
          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Pais" CssClass="col-md-2 control-label">Pais</asp:Label>
            <div class="col-md-10">
               <asp:DropDownList ID="Pais" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Pais"
                    CssClass="text-danger" ErrorMessage="El campo de Pais es obligatorio." />
            </div>
        </div>

          
          <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Linea" CssClass="col-md-2 control-label">Linea</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="Linea" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Linea"
                    CssClass="text-danger" ErrorMessage="El campo de Linea es obligatorio." />
            </div>
        </div>

             <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Area" CssClass="col-md-2 control-label">Area</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="Area" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Area"
                    CssClass="text-danger" ErrorMessage="El campo de Area es obligatorio." />
            </div>
        </div>


             <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="CodigoPostal" CssClass="col-md-2 control-label">Código Postal </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="CodigoPostal" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="CodigoPostal"
                    CssClass="text-danger" ErrorMessage="El campo de ACódigo Postal rea es obligatorio." />
            </div>
        </div>

            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Direccion" CssClass="col-md-2 control-label">Dirección</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Direccion" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Direccion"
                    CssClass="text-danger" ErrorMessage="El campo de Dirección es obligatorio." />
            </div>
        </div>


              <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Encuesta" CssClass="col-md-2 control-label">¿Envio de encuesta de satisfacción?</asp:Label>
            <div class="col-md-10">
                <asp:CheckBox ID="Encuesta" runat="server" CssClass="form-control"  />
            </div>
        </div>

              <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Firma" CssClass="col-md-2 control-label">Firma Correo Electronico </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Firma" CssClass="form-control" Height="147px" Width="1510px" TextMode="MultiLine"  />
                
            </div>
        </div>







        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateClient_Click" Text="Guardar Cliente" CssClass="btn btn-default" />
            </div>
        </div>
    </div>


</asp:Content>
