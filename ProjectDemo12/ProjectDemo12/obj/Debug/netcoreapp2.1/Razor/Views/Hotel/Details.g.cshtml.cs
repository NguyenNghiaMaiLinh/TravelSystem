#pragma checksum "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efba6d459ac7378b9bfc8db44604681698f4da35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_Details), @"mvc.1.0.view", @"/Views/Hotel/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hotel/Details.cshtml", typeof(AspNetCore.Views_Hotel_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efba6d459ac7378b9bfc8db44604681698f4da35", @"/Views/Hotel/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cca6609a9bc55c263b0a4f9268287b17810f23", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDemo12.Models.Hotel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 99, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Hotel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(135, 38, false);
#line 8 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(173, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(217, 34, false);
#line 11 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(251, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(311, 40, false);
#line 15 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(351, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(395, 36, false);
#line 18 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(431, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(491, 47, false);
#line 22 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(538, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(582, 43, false);
#line 25 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(625, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(685, 43, false);
#line 29 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(728, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(772, 39, false);
#line 32 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(811, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(871, 41, false);
#line 36 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(912, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(956, 37, false);
#line 39 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(993, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1053, 47, false);
#line 43 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1144, 43, false);
#line 46 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1247, 46, false);
#line 50 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1337, 42, false);
#line 53 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1439, 41, false);
#line 57 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.isHot));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1524, 37, false);
#line 60 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.isHot));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1621, 41, false);
#line 64 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1706, 37, false);
#line 67 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1743, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1803, 42, false);
#line 71 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1889, 38, false);
#line 74 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1987, 45, false);
#line 78 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.isParking));

#line default
#line hidden
            EndContext();
            BeginContext(2032, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2076, 41, false);
#line 81 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.isParking));

#line default
#line hidden
            EndContext();
            BeginContext(2117, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2177, 44, false);
#line 85 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.isCredit));

#line default
#line hidden
            EndContext();
            BeginContext(2221, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2265, 40, false);
#line 88 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.isCredit));

#line default
#line hidden
            EndContext();
            BeginContext(2305, 59, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2365, 44, false);
#line 92 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.tbl_City));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2453, 49, false);
#line 95 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
       Write(Html.DisplayFor(model => model.tbl_City.CityName));

#line default
#line hidden
            EndContext();
            BeginContext(2502, 210, true);
            WriteLiteral("\r\n        </dd>\r\n        <hr />\r\n        <dt>\r\n            Convenients\r\n        </dt>\r\n        <dd>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\"></label>\r\n                ");
            EndContext();
            BeginContext(2712, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "261522b8df414fdc93eaec4e84450746", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 104 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.listGetConvenient;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2788, 83, true);
            WriteLiteral("\r\n            </div>\r\n        </dd>\r\n        <hr />\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2871, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a60f1c3016e41d8a09f36694c5e70da", async() => {
                BeginContext(2941, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 111 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\Hotel\Details.cshtml"
                                                   WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2949, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2957, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34ede80090eb4899a6f8986480c3e711", async() => {
                BeginContext(3003, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3019, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDemo12.Models.Hotel> Html { get; private set; }
    }
}
#pragma warning restore 1591
