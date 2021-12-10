<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="DMS.Forms.frmCliente" %>


<asp:Content ID="Header" ContentPlaceHolderID="HeaderContent" runat="server">

     <!--Load the AJAX API-->
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">

        // Load the Visualization API and the corechart package.
        google.charts.load('current', { 'packages': ['corechart'] });

        // Set a callback to run when the Google Visualization API is loaded.
        google.charts.setOnLoadCallback(drawChart);
        google.charts.setOnLoadCallback(drawChart2);

        // Callback that creates and populates a data table,
        // instantiates the pie chart, passes in the data and
        // draws it.
        function drawChart() {

            // Create the data table.
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Area');
            data.addColumn('number', 'Contador');
            data.addRows([               

                ['Empresa', 3],
                ['Exportaciones', 1],
                ['Hogar', 1],
                ['Venta', 1],
                
            ]);

            // Set chart options
            var options = {
                'title': 'Indicador de Cliente por Area',
                'width': 400,
                'height': 300
            };

            // Instantiate and draw our chart, passing in some options.
            var chart = new google.visualization.PieChart(document.getElementById('chart_div'));
            chart.draw(data, options);
        }


        function drawChart2() {

            // Create the data table.
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Linea');
            data.addColumn('number', 'Contador');
            data.addRows([

                ['Auxiliares', 1],
                ['Cuero', 2],
                ['Tintas', 1],
                ['Papel', 9],
                ['Pintura', 1],
                ['Resinas', 1],

            ]);

            // Set chart options
            var options = {
                'title': 'Indicador de Cliente por Linea',
                'width': 400,
                'height': 300
            };

            // Instantiate and draw our chart, passing in some options.
            var chart = new google.visualization.PieChart(document.getElementById('chart_div2'));
            chart.draw(data, options);
        }


        function drawChart3() {

            // Create the data table.
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Pais');
            data.addColumn('number', 'Contador');
            data.addRows([

                ['Alemania', 5],
                ['Argentina', 2],
                ['Brasil', 1],
                ['Canadá', 2],
                ['Colombia', 1],
                ['Perú', 1],

            ]);

            // Set chart options
            var options = {
                'title': 'Indicador de Cliente por Pais',
                'width': 400,
                'height': 300
            };

            // Instantiate and draw our chart, passing in some options.
            var chart = new google.visualization.PieChart(document.getElementById('chart_div3'));
            chart.draw(data, options);
        }
    </script>

 </asp:Content>





<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>
                &nbsp; 
            </td>
        </tr>
        <tr>
            <td>
                  <p>
                    <asp:HyperLink runat="server" ID="NewClient" ViewStateMode="Disabled"  href="frmNewClient" >Nuevo Cliente</asp:HyperLink>
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <div id="chart_div"></div>
            </td>
            <td>
                 <div id="chart_div2"></div>
            </td>
            <td>
                <div id="chart_div3"></div>
            </td>
        </tr>
    </table>


      



    <table>
        <tr>
            <td>
              
                <asp:GridView ID="grdCliente" runat="server" AutoGenerateColumns="false" GridLines="None"
            CssClass="table table-bordered table-striped">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="Usuario" Visible="false" />
                 <asp:BoundField DataField="Tipo" HeaderText="Access Group" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Documento" HeaderText="Documento" />
               <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
               <asp:BoundField DataField="Pais" HeaderText="Pais" />
               <asp:BoundField DataField="Linea" HeaderText="Linea" />
                <asp:BoundField DataField="Area" HeaderText="Area" />
                <asp:BoundField DataField="CodigoPostal" HeaderText="CodigoPostal" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="Encuesta" HeaderText="Encuesta" />
                <asp:BoundField DataField="EmailCliente" HeaderText="EmailCliente" />
            </Columns>
        </asp:GridView>


        
              






            </td>
        </tr>
    </table>
     

</asp:Content>
