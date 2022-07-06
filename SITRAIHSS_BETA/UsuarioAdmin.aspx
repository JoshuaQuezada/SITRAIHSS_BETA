<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UsuarioAdmin.aspx.cs" Inherits="SITRAIHSS_BETA.UsuarioAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <section class="Content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="card">
                        <div class="card-header">
                            <div class="ion-card-title">
                                <h3>Administrar Usuarios</h3>
                            </div>
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-md-6 form-group">
                                        <label>Nombre De Usuario</label>
                                        <input class="form-control" runat="server" id="txtNombreUsuario" type="text" autocomplete="off" placeholder="joshua.quezada"/>
                                    </div>
                                    <div class="col-md-6 form-group">
                                        <label>Contraseña</label>
                                        <input class="form-control" runat="server" id="txtContraseña" type="password" autocomplete="off"/>
                                    </div>
                                    <div class="form-group">
                                        <asp:Button text="Guardar" runat="server" CssClass="btn btn-info" id="btnGuardar" onclick="btnGuardar_Click"/>
                                        <asp:Button text="Editar" runat="server" CssClass="btn btn-info" OnClick="btnEditar_Click" ID="btnEditar"/>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
