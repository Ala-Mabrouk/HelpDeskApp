#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\DashBoard\getPie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfc9b108a274f4e9c3734c4aafe17a780780cc71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_getPie), @"mvc.1.0.view", @"/Views/DashBoard/getPie.cshtml")]
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
#nullable restore
#line 1 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\_ViewImports.cshtml"
using HelpDesk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\_ViewImports.cshtml"
using HelpDesk.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc9b108a274f4e9c3734c4aafe17a780780cc71", @"/Views/DashBoard/getPie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_DashBoard_getPie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.DashBoardModels.DashBoardModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\DashBoard\getPie.cshtml"
  
    ViewData["Title"] = "test dashBoard";
    Layout = null;



    var XLabels = Newtonsoft.Json.JsonConvert.SerializeObject(Model.nbTicketByStatus.Select(u => u.Label).ToList());
    var YValues = Newtonsoft.Json.JsonConvert.SerializeObject(Model.nbTicketByStatus.Select(x => x.Value).ToList());

    //  var XlabelsLine = Newtonsoft.Json.JsonConvert.SerializeObject(Model.evolutionOfTicketsNbByMonths.Select(x => x.X)).ToList();
    //var YlabelsLine = Newtonsoft.Json.JsonConvert.SerializeObject(Model.evolutionOfTicketsNbByMonths.Select(x => x.Y)).ToList();
    ViewData["Title"] = "Bar Chart";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<style>
    .fullWidth {
        width: 100%
    }

    .flex-d-column {
        display: flex;
        flex-direction: column;
    }

    .flex-d-row {
        display: flex;
        flex-direction: row;
    }

    .chart-container {
        flex: 1;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfc9b108a274f4e9c3734c4aafe17a780780cc714681", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.2.2/Chart.bundle.min.js\"></script>\r\n");
            WriteLiteral(@"
<script>
    $(document).ready(function () {

        let pieChart1 = null;
        let lineChart1 = null;
 
        function drawChart(chartInstance, canvasId, chartSettings) {

            if (chartInstance != null) {
                //update chart with new configuration
                chartInstance.options = { ...chartSettings.options };
                chartInstance.data = { ...chartSettings.data };

                chartInstance.update();
                return chartInstance;
            } else {
                //create new chart.
                var ctx = document.getElementById(canvasId).getContext('2d');
                return new Chart(ctx, chartSettings);
            }
        }


        function makeRandomColor() {
            return ""#"" + Math.floor(Math.random() * 16777215).toString(16);
        }

");
            WriteLiteral(@"
        function drawPieChart(chartInstance, canvasId, data, labels, titleText) {

            //generate random color for each label.
            let bgColors = [];

            if (labels) {
                bgColors = labels.map(() => {
                    return makeRandomColor();
                });
            }

            var settings = {
                // The type of chart we want to create
                type: 'pie',

                // The data for our dataset
                data: {
                    labels: labels,
                    datasets: [{
                        backgroundColor: bgColors,
                        borderColor: bgColors,
                        data: data
                    }],
                },

                // Configuration options go here
                options: {
                    tooltips: {
                        callbacks: {
                            label: function (tooltipItem, data) {
                                /");
            WriteLiteral(@"/create custom display.
                                var label = data.labels[tooltipItem.index] || '';
                                var currentData = data.datasets[0].data[tooltipItem.index];

                                if (label) {
                                    label = `${label} ${Number(currentData)} %`;
                                }

                                return label;
                            }
                        }
                    },
                    title: {
                        display: true,
                        text: titleText,
                        fontSize: 16
                    },
                }
            };

            return drawChart(chartInstance, canvasId, settings);
        }

        function filterDashboardDataByYear(currentYear) {

              let data1 = [];
            let labels1 = [];

                data1 =[5,2,8,6];
            labels1 = [""5"", ""2"", ""8"", ""6""];



            let data2 = []");
            WriteLiteral(";\r\n            let labels2 = [];\r\n\r\n               data2 =");
#nullable restore
#line 163 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\DashBoard\getPie.cshtml"
                 Write(Html.Raw(YValues));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                labels2 =");
#nullable restore
#line 164 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\DashBoard\getPie.cshtml"
                    Write(Html.Raw(XLabels));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n\r\n            pieChart1 = drawPieChart(pieChart1, \"mypieChart1\", data2, labels2,\r\n                `tickets By status`);\r\n");
            WriteLiteral("        }\r\n\r\n        filterDashboardDataByYear();\r\n\r\n\r\n    });\r\n\r\n\r\n\r\n</script>\r\n\r\n<div class=\"text-center\">\r\n    \r\n    <div class=\"flex-d-column\">\r\n");
            WriteLiteral("        <div class=\"flex-d-row fullWidth\">\r\n            <div class=\"chart-container\">\r\n                <canvas id=\"mypieChart1\"></canvas>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.DashBoardModels.DashBoardModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
