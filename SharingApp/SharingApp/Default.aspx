<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SharingApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <link rel="stylesheet" href="https://rawgithub.com/yesmeck/jquery-jsonview/master/dist/jquery.jsonview.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" />
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
           
            </div>
        <div id="json" runat="server"></div>
    </form>


    <script src="js/jquery-1.12.1.min.js"></script>
  <script type="text/javascript" src="https://rawgithub.com/yesmeck/jquery-jsonview/master/dist/jquery.jsonview.js"></script>


    <script>
                
        $(function(){

            var jsonStr = $("#json").text();
        var jsonObj = JSON.parse(jsonStr);
        var jsonPretty = JSON.stringify(jsonObj, null, '\t');

       // $("#json").text(jsonPretty);


            $('#json').JSONView(jsonPretty);

            //$('#collapse-btn').on('click', function () {
            //    $('#json').JSONView('collapse');
            //});

            //$('#expand-btn').on('click', function () {
            //    $('#json').JSONView('expand');
            //});

            //$('#toggle-btn').on('click', function () {
            //    $('#json').JSONView('toggle');
            //});

            //$('#toggle-level1-btn').on('click', function () {
            //    $('#json').JSONView('toggle', 1);
            //});

            //$('#toggle-level2-btn').on('click', function () {
            //    $('#json').JSONView('toggle', 2);
            //});
  




        });
    </script>

</body>
</html>
















 
