#pragma checksum "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\ImageTaskView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b3099085ca67bbfe9a8e557753a42802084764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ImageTaskView), @"mvc.1.0.view", @"/Views/Home/ImageTaskView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ImageTaskView.cshtml", typeof(AspNetCore.Views_Home_ImageTaskView))]
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
#line 1 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\_ViewImports.cshtml"
using EnglishTest;

#line default
#line hidden
#line 2 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\_ViewImports.cshtml"
using EnglishTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b3099085ca67bbfe9a8e557753a42802084764", @"/Views/Home/ImageTaskView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"117f11283dcf03ded7c34fbfb7e733245ff3e951", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ImageTaskView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImageTask>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 90, true);
            WriteLiteral("\r\n<h4>Look at the text. What does it say? Choose the correct answer.</h4>\r\n<div>\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 108, "\"", 166, 1);
#line 5 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\ImageTaskView.cshtml"
WriteAttributeValue("", 114, Url.Action("GetImage", new { id = @Model.ImageId }), 114, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(167, 119, true);
            WriteLiteral(" style=\"width:150px;height:200px;\" /><br>\r\n\r\n    <input type=\"radio\" id=\"radioButton1\">\r\n    <label for=\"radioButton1\">");
            EndContext();
            BeginContext(287, 11, false);
#line 8 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\ImageTaskView.cshtml"
                         Write(Model.First);

#line default
#line hidden
            EndContext();
            BeginContext(298, 90, true);
            WriteLiteral("</label><br>\r\n\r\n    <input type=\"radio\" id=\"radioButton2\">\r\n    <label for=\"radioButton2\">");
            EndContext();
            BeginContext(389, 12, false);
#line 11 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\ImageTaskView.cshtml"
                         Write(Model.Second);

#line default
#line hidden
            EndContext();
            BeginContext(401, 90, true);
            WriteLiteral("</label><br>\r\n\r\n    <input type=\"radio\" id=\"radioButton3\">\r\n    <label for=\"radioButton3\">");
            EndContext();
            BeginContext(492, 11, false);
#line 14 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\ImageTaskView.cshtml"
                         Write(Model.Third);

#line default
#line hidden
            EndContext();
            BeginContext(503, 63, true);
            WriteLiteral("</label><br>\r\n</div>\r\n<div>\r\n    <button>Check</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageTask> Html { get; private set; }
    }
}
#pragma warning restore 1591
