#pragma checksum "C:\Users\natha\OneDrive\Documents\PloomesAPI\MyVerse.API\MyVerse\Views\Verses1\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cba82f0556bd30212cd42cd9ba78fde39af917af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Verses1_Create), @"mvc.1.0.view", @"/Views/Verses1/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba82f0556bd30212cd42cd9ba78fde39af917af", @"/Views/Verses1/Create.cshtml")]
    public class Views_Verses1_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyVerse.Models.Verses>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\natha\OneDrive\Documents\PloomesAPI\MyVerse.API\MyVerse\Views\Verses1\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Verses</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Book"" class=""control-label""></label>
                <input asp-for=""Book"" class=""form-control"" />
                <span asp-validation-for=""Book"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Verse"" class=""control-label""></label>
                <input asp-for=""Verse"" class=""form-control"" />
                <span asp-validation-for=""Verse"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Chapter"" class=""control-label""></label>
                <input asp-for=""Chapter"" class=""form-control"" />
                <span asp-validation-for=""Chapter"" class=""text-danger""></span>
            </div>");
            WriteLiteral(@"
            <div class=""form-group"">
                <label asp-for=""Text"" class=""control-label""></label>
                <input asp-for=""Text"" class=""form-control"" />
                <span asp-validation-for=""Text"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\natha\OneDrive\Documents\PloomesAPI\MyVerse.API\MyVerse\Views\Verses1\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyVerse.Models.Verses> Html { get; private set; }
    }
}
#pragma warning restore 1591
