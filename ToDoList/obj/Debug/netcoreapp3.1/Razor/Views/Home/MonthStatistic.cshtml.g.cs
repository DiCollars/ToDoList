#pragma checksum "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c49b0f234d3cfc1822bb28ea860549e5af48e96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MonthStatistic), @"mvc.1.0.view", @"/Views/Home/MonthStatistic.cshtml")]
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
#line 1 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\_ViewImports.cshtml"
using ToDoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\_ViewImports.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c49b0f234d3cfc1822bb28ea860549e5af48e96", @"/Views/Home/MonthStatistic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57829472ded1cf7bde1d515ed88d0e9bc5d97088", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MonthStatistic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/MonthStatistic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
  
    ViewData["Title"] = "Home Page";
    string colorControl(Priority priority)
    {
        string result;

        if (priority == Priority.High)
        {
            result = "#f3ffbf";
        }

        else if (priority == Priority.Medium)
        {
            result = "#adf7cf";
        }

        else if (priority == Priority.Low)
        {
            result = "#c2dffc";
        }

        else
        {
            result = "#ddded7";
        }
        return result;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 31 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
 if (Model.ListCountDays == default)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">\r\n            Choose month:\r\n        </h1>\r\n    </div>\r\n    <h1> </h1>\r\n");
#nullable restore
#line 39 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
     for (int i = 0; i < 12; i = i + 3)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c49b0f234d3cfc1822bb28ea860549e5af48e965229", async() => {
#nullable restore
#line 43 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                                                                                                                                         Write(Model.AllMonths[i].Value);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 850, "btn", 850, 3, true);
            AddHtmlAttributeValue(" ", 853, "btn-outline-", 854, 13, true);
#nullable restore
#line 43 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 866, ViewBag.Theme, 866, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 880, "btn-lg", 881, 7, true);
            AddHtmlAttributeValue(" ", 887, "btn-block", 888, 10, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 905, "~/Home/MonthStatistic/", 905, 22, true);
#nullable restore
#line 43 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 927, Model.AllMonths[i].Key, 927, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c49b0f234d3cfc1822bb28ea860549e5af48e967986", async() => {
#nullable restore
#line 46 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                                                                                                                                             Write(Model.AllMonths[i + 1].Value);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1074, "btn", 1074, 3, true);
            AddHtmlAttributeValue(" ", 1077, "btn-outline-", 1078, 13, true);
#nullable restore
#line 46 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 1090, ViewBag.Theme, 1090, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1104, "btn-lg", 1105, 7, true);
            AddHtmlAttributeValue(" ", 1111, "btn-block", 1112, 10, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1129, "~/Home/MonthStatistic/", 1129, 22, true);
#nullable restore
#line 46 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 1151, Model.AllMonths[i + 1].Key, 1151, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c49b0f234d3cfc1822bb28ea860549e5af48e9610769", async() => {
#nullable restore
#line 49 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                                                                                                                                             Write(Model.AllMonths[i + 2].Value);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1306, "btn", 1306, 3, true);
            AddHtmlAttributeValue(" ", 1309, "btn-outline-", 1310, 13, true);
#nullable restore
#line 49 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 1322, ViewBag.Theme, 1322, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1336, "btn-lg", 1337, 7, true);
            AddHtmlAttributeValue(" ", 1343, "btn-block", 1344, 10, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1361, "~/Home/MonthStatistic/", 1361, 22, true);
#nullable restore
#line 49 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 1383, Model.AllMonths[i + 2].Key, 1383, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <span> </span>\r\n");
#nullable restore
#line 53 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
     
}
else if (Model.ListTasks != default)
{
    if (!Model.ListTasks.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center\">\r\n            <h1 class=\"display-4\">\r\n                Ooops!\r\n            </h1>\r\n            <span>Unfortunatly there are no tasks in this day ☺.</span>\r\n        </div>\r\n");
#nullable restore
#line 65 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center\">\r\n            <h1 class=\"display-4\">\r\n                Tasks:\r\n            </h1>\r\n        </div>\r\n        <div>\r\n");
#nullable restore
#line 74 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
             foreach (var task in Model.ListTasks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n");
#nullable restore
#line 77 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                     if (@task.Status == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\" style=\"justify-content:center;margin:auto;width:auto;\">\r\n                            <div class=\"col-10\">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 2329, "\"", 2373, 4);
            WriteAttributeValue("", 2337, "border", 2337, 6, true);
            WriteAttributeValue(" ", 2343, "border-", 2344, 8, true);
#nullable restore
#line 81 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
WriteAttributeValue("", 2351, ViewBag.Theme, 2351, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2365, "rounded", 2366, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 2374, "\"", 2422, 2);
            WriteAttributeValue("", 2382, "background:", 2382, 11, true);
#nullable restore
#line 81 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
WriteAttributeValue(" ", 2393, colorControl(task.Priority), 2394, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <del>\r\n                                        <span>");
#nullable restore
#line 83 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                                         Write(task.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </del>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <span> </span>\r\n");
#nullable restore
#line 89 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\" style=\"justify-content:center;margin:auto;width:auto;\">\r\n                            <div class=\"col-10\">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 2985, "\"", 3029, 4);
            WriteAttributeValue("", 2993, "border", 2993, 6, true);
            WriteAttributeValue(" ", 2999, "border-", 3000, 8, true);
#nullable restore
#line 94 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
WriteAttributeValue("", 3007, ViewBag.Theme, 3007, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3021, "rounded", 3022, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 3030, "\"", 3078, 2);
            WriteAttributeValue("", 3038, "background:", 3038, 11, true);
#nullable restore
#line 94 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
WriteAttributeValue(" ", 3049, colorControl(task.Priority), 3050, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <span>");
#nullable restore
#line 95 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                                     Write(task.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <span> </span>\r\n");
#nullable restore
#line 100 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 102 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 104 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1> </h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c49b0f234d3cfc1822bb28ea860549e5af48e9619594", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3409, "btn", 3409, 3, true);
            AddHtmlAttributeValue(" ", 3412, "btn-outline-", 3413, 13, true);
#nullable restore
#line 106 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 3425, ViewBag.Theme, 3425, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3447, "~/Home/MonthStatistic/", 3447, 22, true);
#nullable restore
#line 106 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 3469, ViewBag.Day, 3469, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 107 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">\r\n            Choose day:\r\n        </h1>\r\n    </div>\r\n    <div>\r\n        <div class=\"d-flex text-white\" style=\"justify-content:center;margin:auto;width:auto;\">\r\n");
#nullable restore
#line 117 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
             for (int i = 0; i < Model.ListCountDays.Length / 2; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 3847, "\"", 3878, 3);
            WriteAttributeValue("", 3855, "cube", 3855, 4, true);
            WriteAttributeValue("  ", 3859, "bg-", 3861, 5, true);
#nullable restore
#line 119 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
WriteAttributeValue("", 3864, ViewBag.Theme, 3864, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div>\r\n                        <p><small>");
#nullable restore
#line 121 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                             Write(Model.ListCountDays[i].Item2.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                    </div>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c49b0f234d3cfc1822bb28ea860549e5af48e9623540", async() => {
                WriteLiteral("<p><small>");
#nullable restore
#line 124 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                                                                                                                                               Write(Model.ListCountDays[i].Item1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4078, "~/Home/MonthStatistic/", 4078, 22, true);
#nullable restore
#line 124 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 4100, Model.ListCountDays[i].Item2.Day, 4100, 33, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4133, "/", 4133, 1, true);
#nullable restore
#line 124 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 4134, Model.ListCountDays[i].Item2.Day, 4134, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 127 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"d-flex text-white\" style=\"justify-content:center;margin:auto;width:auto;\">\r\n");
#nullable restore
#line 130 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
             for (int i = Model.ListCountDays.Length / 2; i < Model.ListCountDays.Length; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 4550, "\"", 4580, 3);
            WriteAttributeValue("", 4558, "cube", 4558, 4, true);
            WriteAttributeValue(" ", 4562, "bg-", 4563, 4, true);
#nullable restore
#line 132 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
WriteAttributeValue("", 4566, ViewBag.Theme, 4566, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div>\r\n                        <p><small>");
#nullable restore
#line 134 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                             Write(Model.ListCountDays[i].Item2.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                    </div>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c49b0f234d3cfc1822bb28ea860549e5af48e9627569", async() => {
                WriteLiteral("<p><small>");
#nullable restore
#line 137 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
                                                                                                                                                 Write(Model.ListCountDays[i].Item1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4780, "~/Home/MonthStatistic/", 4780, 22, true);
#nullable restore
#line 137 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 4802, Model.ListCountDays[i].Item2.Month, 4802, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4837, "/", 4837, 1, true);
#nullable restore
#line 137 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 4838, Model.ListCountDays[i].Item2.Day, 4838, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 140 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <h1> </h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c49b0f234d3cfc1822bb28ea860549e5af48e9630264", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5069, "btn", 5069, 3, true);
            AddHtmlAttributeValue(" ", 5072, "btn-outline-", 5073, 13, true);
#nullable restore
#line 144 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
AddHtmlAttributeValue("", 5085, ViewBag.Theme, 5085, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 145 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\MonthStatistic.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591