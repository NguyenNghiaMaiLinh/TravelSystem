#pragma checksum "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f01304b8e04df41da624854349224173eeeeec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_Report), @"mvc.1.0.view", @"/Views/Manage/Report.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/Report.cshtml", typeof(AspNetCore.Views_Manage_Report))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\_ViewImports.cshtml"
using ProjectDemo12;

#line default
#line hidden
#line 2 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\_ViewImports.cshtml"
using ProjectDemo12.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f01304b8e04df41da624854349224173eeeeec", @"/Views/Manage/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cca6609a9bc55c263b0a4f9268287b17810f23", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#a9d8d7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(8, 3173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bd9ac51d71c4024a42084e0bf9b2e5d", async() => {
                BeginContext(14, 1175, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script type=""text/javascript"">

//chart_div
  google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);

      function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Year', 'Sales', 'Expenses'],
          ['2017',  1000,      400],
          ['2018',  1170,      460],
          ['2019',  660,       1120],
        ]);

        var options = {
          title: 'Luona Tavel System Performance',
          hAxis: {title: 'Year',  titleTextStyle: {color: '#333'}},
          vAxis: {minValue: 0}
        };

        var chart = new google.visualization.AreaChart(document.getElementById('chart_div'));
        chart.draw(data, options);
      }

//piechart_3d
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart1);
        function drawChart");
                WriteLiteral("1() {\r\n            var data = google.visualization.arrayToDataTable([\r\n                [\'Age\', \'User age in the system\'],\r\n                [\'0 -> 18\', ");
                EndContext();
                BeginContext(1190, 20, false);
#line 34 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                       Write(ViewBag.ageFrom0To18);

#line default
#line hidden
                EndContext();
                BeginContext(1210, 33, true);
                WriteLiteral("],\r\n                [\'18 -> 40\', ");
                EndContext();
                BeginContext(1244, 21, false);
#line 35 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                        Write(ViewBag.ageFrom18To40);

#line default
#line hidden
                EndContext();
                BeginContext(1265, 33, true);
                WriteLiteral("],\r\n                [\'40 -> 60\', ");
                EndContext();
                BeginContext(1299, 21, false);
#line 36 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                        Write(ViewBag.ageFrom40To60);

#line default
#line hidden
                EndContext();
                BeginContext(1320, 33, true);
                WriteLiteral("],\r\n                [\'60 ->100\', ");
                EndContext();
                BeginContext(1354, 22, false);
#line 37 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                        Write(ViewBag.ageFrom60To100);

#line default
#line hidden
                EndContext();
                BeginContext(1376, 895, true);
                WriteLiteral(@"],
            ]);

            var options = {
                title: 'User age in the system',
                is3D: true,
            };

            var chart = new google.visualization.PieChart(document.getElementById('piechart_3d'));
            chart.draw(data, options);
        }

//regions_div
            google.charts.load('current', {
                'packages': ['geochart'],
            // Note: you will need to get a mapsApiKey for your project.
            // See: https://developers.google.com/chart/interactive/docs/basic_load_libs#load-settings
            'mapsApiKey': 'AIzaSyD-9tSrke72PouQMnMX-a7eZSW0jkFMBWY'
          });
          google.charts.setOnLoadCallback(drawRegionsMap);

      function drawRegionsMap() {
        var data = google.visualization.arrayToDataTable([
              ['Country', 'Number Tour'],
            ['South Korea', ");
                EndContext();
                BeginContext(2272, 22, false);
#line 61 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                       Write(ViewBag.getTourByKorea);

#line default
#line hidden
                EndContext();
                BeginContext(2294, 32, true);
                WriteLiteral("],\r\n            [\'Philippines\', ");
                EndContext();
                BeginContext(2327, 28, false);
#line 62 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                       Write(ViewBag.getTourByPhilippines);

#line default
#line hidden
                EndContext();
                BeginContext(2355, 26, true);
                WriteLiteral("],\r\n            [\'Japan\', ");
                EndContext();
                BeginContext(2382, 22, false);
#line 63 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                 Write(ViewBag.getTourByJapan);

#line default
#line hidden
                EndContext();
                BeginContext(2404, 29, true);
                WriteLiteral("],\r\n            [\'Malaysia\', ");
                EndContext();
                BeginContext(2434, 25, false);
#line 64 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                    Write(ViewBag.getTourByMalaysia);

#line default
#line hidden
                EndContext();
                BeginContext(2459, 27, true);
                WriteLiteral("],\r\n            [\'Brazil\', ");
                EndContext();
                BeginContext(2487, 23, false);
#line 65 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                  Write(ViewBag.getTourByBrazil);

#line default
#line hidden
                EndContext();
                BeginContext(2510, 27, true);
                WriteLiteral("],\r\n            [\'Canada\', ");
                EndContext();
                BeginContext(2538, 23, false);
#line 66 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                  Write(ViewBag.getTourByCanada);

#line default
#line hidden
                EndContext();
                BeginContext(2561, 26, true);
                WriteLiteral("],\r\n            [\'China\', ");
                EndContext();
                BeginContext(2588, 22, false);
#line 67 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                 Write(ViewBag.getTourByChina);

#line default
#line hidden
                EndContext();
                BeginContext(2610, 29, true);
                WriteLiteral("],\r\n             [\'Vietnam\', ");
                EndContext();
                BeginContext(2640, 24, false);
#line 68 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                    Write(ViewBag.getTourByVietNam);

#line default
#line hidden
                EndContext();
                BeginContext(2664, 27, true);
                WriteLiteral("],\r\n            [\'Russia\', ");
                EndContext();
                BeginContext(2692, 23, false);
#line 69 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                  Write(ViewBag.getTourByRussia);

#line default
#line hidden
                EndContext();
                BeginContext(2715, 27, true);
                WriteLiteral("],\r\n            [\'Ireland\',");
                EndContext();
                BeginContext(2743, 24, false);
#line 70 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                  Write(ViewBag.getTourByIreland);

#line default
#line hidden
                EndContext();
                BeginContext(2767, 34, true);
                WriteLiteral("],\r\n            [\'United States\', ");
                EndContext();
                BeginContext(2802, 29, false);
#line 71 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                         Write(ViewBag.getTourByUnitedStates);

#line default
#line hidden
                EndContext();
                BeginContext(2831, 27, true);
                WriteLiteral("],\r\n            [\'France\', ");
                EndContext();
                BeginContext(2859, 23, false);
#line 72 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Manage\Report.cshtml"
                  Write(ViewBag.getTourByFrance);

#line default
#line hidden
                EndContext();
                BeginContext(2882, 292, true);
                WriteLiteral(@"],
            ]);
    
          var options = { title: 'User age in the system', is3D: true,};
            var chart = new google.visualization.GeoChart(document.getElementById('regions_div'));
         
            chart.draw(data, options);
          }
    
    
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3183, 580, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a5f2e4487f0470494fbb9fc515a8767", async() => {
                BeginContext(3222, 447, true);
                WriteLiteral(@"
    <table>
        <tr>
            <td>
                <p style=""margin-top:50px; font-style:unset;"">Tour number of each country</p>
                <div id=""regions_div"" style=""width: 600px; height: 450px; margin-right:50px""></div>
            </td>
            <td>
                <div id=""piechart_3d"" style=""width: 600px; height: 450px;margin-top:80px; margin-right:50px""></div>
            </td>

        </tr>
    </table>
");
                EndContext();
                BeginContext(3754, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3763, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
