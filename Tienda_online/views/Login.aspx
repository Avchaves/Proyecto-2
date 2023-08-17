<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tienda_online.views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../assets/Lib/css/bootstrap.min.css" />
</head>
<body>
    <div class="container-fluid">
        <div class="row mt-5 mb-5">

        </div>
         <div class="row">
             <div class="col-md-4">

             </div>
              <div class="col">
             <form id="form2" runat="server">
                 <div>
                     <div class="row">
                      <div class="col-md-4"></div>
                         <div class="col-md-8">
                           <img src="../assets/Images/boton1.png" />
                         </div>
                     </div>
                 </div>
                 <div class="mt-3">
                        <label for="" class="form-label">User Name</label>
                        <input type="text" placeholder="User Name" autocomplete="off" class="form-control" id="UnameTb" />
                 </div>
                 <div class="mt-3 ">
                        <label for="" class="form-label">Password</label>
                        <input type="Password" placeholder="Password" autocomplete="off" class="form-control" id="PasswordTb" />
                 </div>
                 <div class="mt-3 d-grid">
                     <asp:Button Text="Login" runat="server" Class="btn-success btn" ID="LoginBtn" OnClick="LoginBtn_Click" />
                 </div>
            </form>
             </div>
             <div class="col-md-4">

             </div>
           
        </div>

    </div>
   
</body>
</html>
