<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edificios.aspx.cs" Inherits="WebApplicationTarea2.edificios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ingresar Nuevos Edificios</title>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Formulario Edificios</h1>
        <div>
        <fieldset> 
          <legend>Contacto</legend> 
          <label class="contacto" for="nombre">Edificio<em>*</em></label> 
          <input id="nombre"/><br/>
          <button type="submit" name="button" class="btn login_btn">Guardar</button>
        </fieldset> 
        </div>
    </form>
</body>
</html>
