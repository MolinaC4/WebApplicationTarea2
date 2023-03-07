<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empleados.aspx.cs" Inherits="WebApplicationTarea2.empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Formulario Empleados</h1>

        <fieldset> 
          <legend>Contacto</legend> 
          <label class="contacto" for="nombre">Nombre Completo<em>*</em></label> 
          <input id="nombre"/><br/>
  
          <label class="contacto" for="ced">Cedula <em>*</em></label> 
          <input id="cedula"/><br/> 
          <label class="contacto" for="fec_ingreso">Fecha Ingreso <em>*</em></label> 
          <input id="fec_ingreso"/><br/> 
        </fieldset>

        <fieldset> 
          <label class="personal" for="puesto">Puesto</label> 
          <select id="puesto"> 
          <option value="puesto1">Puesto1</option> 
          <option value="puesto2">Puesto2</option> 
          </select><br/> 
        </fieldset>

        <fieldset> 
          <label class="personal" for="edificio">Edificio</label> 
          <select id="edificio"> 
          <option value="edi1">edificio1</option> 
          <option value="edi2">edificio2</option> 
          </select><br/> 
        </fieldset>
        </div>
    </form>
</body>
</html>
