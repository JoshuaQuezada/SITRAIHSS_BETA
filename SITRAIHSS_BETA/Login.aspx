<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SITRAIHSS_BETA.Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Inicio de Sesion</title>

  <!-- Google Font: Source Sans Pro -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="Content/plugins/fontawesome-free/css/all.min.css">
  <!-- icheck bootstrap -->
  <link rel="stylesheet" href="Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="Content/dist/css/adminlte.min.css">
</head>
<body class="hold-transition login-page" runat="server">
<div class="login-box">
  <!-- /.login-logo -->
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
      <a href="../../index2.html" class="h1"><b>SITRA</b>IHSS</a>
    </div>
    <div class="card-body">
      <p class="login-box-msg">Inicio de Sesion</p>

      <form runat="server">
        <div class="input-group mb-3">
          <input type="text" class="form-control" placeholder="joshua.quezada" runat="server" id="txtUsername">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
          <input type="password" class="form-control" placeholder="Contraseña" runat="server" id="txtPassword">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
        <a id="Error" Visible="false" runat="server">Usuario o contraseña incorrecta</a>
        <div class="row">
          <div class="col-8">
          </div>
          <!-- /.col -->
          <div class="col-12">
              <asp:Button ID="btnIniciarSesion" CssClass="btn btn-primary btn-block" runat="server" Text="Iniciar Sesion" OnClick="btnIniciarSesion_Click"/>
          </div>
          <!-- /.col -->
        </div>
      </form>
    </div>
    <!-- /.card-body -->
  </div>
  <!-- /.card -->
</div>
<!-- /.login-box -->

<!-- jQuery -->
<script src="Content/plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="Content/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="vdist/js/adminlte.min.js"></script>
</body>
</html>