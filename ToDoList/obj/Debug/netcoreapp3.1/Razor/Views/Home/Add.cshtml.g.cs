#pragma checksum "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7ef906c204ff3ac78d3c9a3e22ef3e8b86c8107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Add), @"mvc.1.0.view", @"/Views/Home/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ef906c204ff3ac78d3c9a3e22ef3e8b86c8107", @"/Views/Home/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57829472ded1cf7bde1d515ed88d0e9bc5d97088", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\Add.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7ef906c204ff3ac78d3c9a3e22ef3e8b86c81073387", async() => {
                WriteLiteral(@"
        <div class=""form-group"">

            <label for=""exampleInputEmail1"">Description: </label>
            <textarea class=""form-control"" name=""Summary"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
            <h1> </h1>
            <label for=""exampleInputEmail1"">Priority: </label>
            <div>
                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio"" name=""Priority"" value=""Low"">
                    <label class=""form-check-label"" for=""inlineRadio1"">Low</label>
                </div>
                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio"" name=""Priority"" value=""Medium"">
                    <label class=""form-check-label"" for=""inlineRadio1"">Medium</label>
                </div>
                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio"" name=""Priority"" value=""High"">
           ");
                WriteLiteral("         <label class=\"form-check-label\" for=\"inlineRadio1\">High</label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <button type=\"submit\"");
                BeginWriteAttribute("class", " class=\"", 1242, "\"", 1280, 3);
                WriteAttributeValue("", 1250, "btn", 1250, 3, true);
                WriteAttributeValue(" ", 1253, "btn-outline-", 1254, 13, true);
#nullable restore
#line 26 "A:\Stack\Projects\petProjects\Mvc\ToDoList\ToDoList\Views\Home\Add.cshtml"
WriteAttributeValue("", 1266, ViewBag.Theme, 1266, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Submit</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
