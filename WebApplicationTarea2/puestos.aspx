<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="puestos.aspx.cs" Inherits="WebApplicationTarea2.puestos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Formulario Puestos</h1>
        <div>
        <fieldset> 
          <legend>Contacto</legend> 
          <label class="contacto" for="nombre">Puesto<em>*</em></label> 
          <input id="nombre"/><br/>
        </fieldset>

        <fieldset> 
          <label class="personal" for="puesto">Tipo Puesto</label> 
          <select id="puesto"> 
          <option value="bachiller">Bachiller</option> 
          <option value="licenciatura">Licenciatura</option> 
          <option value="tecnico">Tecnico</option>
          <option value="sexto">Sexto grado</option> 
          </select><br/> 
        </fieldset>
        </div>
    </form>
</body>
</html>
