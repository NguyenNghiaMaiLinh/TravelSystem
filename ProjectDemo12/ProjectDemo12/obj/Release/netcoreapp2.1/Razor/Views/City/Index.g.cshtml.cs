#pragma checksum "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6bd847f6b0379a08e870da01c57d7096473164c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_City_Index), @"mvc.1.0.view", @"/Views/City/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/City/Index.cshtml", typeof(AspNetCore.Views_City_Index))]
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
#line 3 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6bd847f6b0379a08e870da01c57d7096473164c", @"/Views/City/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cca6609a9bc55c263b0a4f9268287b17810f23", @"/Views/_ViewImports.cshtml")]
    public class Views_City_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ProjectDemo12.Models.City>>
    {
        private global::AspNetCore.Views_City_Index.__Generated__PagerViewComponentTagHelper __PagerViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(184, 58, true);
            WriteLiteral("\r\n<h2>City Page</h2>\r\n\r\n<div class=\"row form-group\">\r\n    ");
            EndContext();
            BeginContext(242, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc9c7e0e175844a0b736ce819fe67837", async() => {
                BeginContext(286, 10, true);
                WriteLiteral("Create new");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(300, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(312, 358, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "137ea64f25a743c899c2f0ce186e9709", async() => {
                BeginContext(351, 93, true);
                WriteLiteral("\r\n    <div class=\"row input-group \">\r\n        <input type=\"text\" name=\"txtSearch\" id=\"search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 444, "\"", 472, 1);
#line 16 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
WriteAttributeValue("", 452, ViewBag.SearchValue, 452, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(473, 190, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"Search\" />\r\n        <div class=\"input-group-btn\">\r\n            <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\" />\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(670, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
 if (Model == null || Model.Count == 0)
{

#line default
#line hidden
            BeginContext(714, 48, true);
            WriteLiteral("<h3 class=\"label-warning\">No Record found!</h3> ");
            EndContext();
#line 23 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
                                                 }
else
{

#line default
#line hidden
            BeginContext(774, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(879, 42, false);
#line 30 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CityID));

#line default
#line hidden
            EndContext();
            BeginContext(921, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(989, 44, false);
#line 33 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CityName));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1101, 48, false);
#line 36 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CityLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1217, 48, false);
#line 39 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.OtherDetails));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1333, 44, false);
#line 42 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.RegionID));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 48 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1540, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1613, 41, false);
#line 52 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CityID));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1734, 43, false);
#line 55 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CityName));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1857, 47, false);
#line 58 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CityLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1984, 47, false);
#line 61 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OtherDetails));

#line default
#line hidden
            EndContext();
            BeginContext(2031, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2111, 50, false);
#line 64 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.tbl_Region.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 137, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"row form-group\">\r\n                            ");
            EndContext();
            BeginContext(2298, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20f641653a9a4b519e1a33c301d3330d", async() => {
                BeginContext(2371, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
                                                                           WriteLiteral(item.CityID);

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
            BeginContext(2379, 32, true);
            WriteLiteral("\r\n\r\n                            ");
            EndContext();
            BeginContext(2411, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0782b7758e984ba6b139026fb6490d84", async() => {
                BeginContext(2485, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
                                                                            WriteLiteral(item.CityID);

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
            BeginContext(2495, 84, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 74 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2594, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 77 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2629, 61, true);
            WriteLiteral("    <nav aria-label=\"Suppilers navigation example\">\r\n        ");
            EndContext();
            BeginContext(2690, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9192f11bc384896ac41dc264c5bc04a", async() => {
            }
            );
            __PagerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_City_Index.__Generated__PagerViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PagerViewComponentTagHelper);
#line 79 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
__PagerViewComponentTagHelper.pagingList = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("paging-list", __PagerViewComponentTagHelper.pagingList, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2723, 14, true);
            WriteLiteral("\r\n    </nav>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2759, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 82 "G:\Chuyen_Nganh_5\PRN292\New folder\WebTravel\ProjectDemo12\ProjectDemo12\Views\City\Index.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2833, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ProjectDemo12.Models.City>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pager")]
        public class __Generated__PagerViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__PagerViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public ReflectionIT.Mvc.Paging.IPagingList pagingList { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Pager", new { pagingList });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591