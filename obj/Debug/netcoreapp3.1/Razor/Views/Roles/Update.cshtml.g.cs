#pragma checksum "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817146639cf60c34b751c28bee6c00a7cc07b8aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Update), @"mvc.1.0.view", @"/Views/Roles/Update.cshtml")]
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
#line 1 "C:\Users\Mateo\Desktop\VintageStuff\Views\_ViewImports.cshtml"
using VintageStuff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mateo\Desktop\VintageStuff\Views\_ViewImports.cshtml"
using VintageStuff.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
using VintageStuff.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817146639cf60c34b751c28bee6c00a7cc07b8aa", @"/Views/Roles/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128546089a04ea7ad327823474e99a187d650841", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EdicionRol>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Actualizar rol</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817146639cf60c34b751c28bee6c00a7cc07b8aa5261", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817146639cf60c34b751c28bee6c00a7cc07b8aa6499", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 6 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817146639cf60c34b751c28bee6c00a7cc07b8aa8079", async() => {
                WriteLiteral("\n    <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 278, "\"", 301, 1);
#nullable restore
#line 8 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
WriteAttributeValue("", 286, Model.Rol.Name, 286, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 344, "\"", 365, 1);
#nullable restore
#line 9 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
WriteAttributeValue("", 352, Model.Rol.Id, 352, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n    <h2>Añadir a ");
#nullable restore
#line 11 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
            Write(Model.Rol.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n    <table class=\"table table-sm table-bordered\">\n");
#nullable restore
#line 13 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
         foreach (var usuario in Model.NoMiembros)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 16 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
   Write(usuario.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n    <td><input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 586, "\"", 605, 1);
#nullable restore
#line 17 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
WriteAttributeValue("", 594, usuario.Id, 594, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"AumentarIds\" /></td>\n</tr>");
#nullable restore
#line 18 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
     }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\n    <h2>Remover de ");
#nullable restore
#line 20 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
              Write(Model.Rol.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n    <table class=\"table table-sm table-bordered\">\n");
#nullable restore
#line 22 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
         foreach (var usuario in Model.Miembros)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 25 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
   Write(usuario.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n    <td><input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 869, "\"", 888, 1);
#nullable restore
#line 26 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
WriteAttributeValue("", 877, usuario.Id, 877, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"BorrarIds\" /></td>\n</tr>");
#nullable restore
#line 27 "C:\Users\Mateo\Desktop\VintageStuff\Views\Roles\Update.cshtml"
     }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\n    <input type=\"submit\" value=\"Grabar\" class=\"btn btn-primary\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EdicionRol> Html { get; private set; }
    }
}
#pragma warning restore 1591
