#pragma checksum "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\TextTaskView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f27ead8055d94f17de5c93b30c9c122d267e929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TextTaskView), @"mvc.1.0.view", @"/Views/Home/TextTaskView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TextTaskView.cshtml", typeof(AspNetCore.Views_Home_TextTaskView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f27ead8055d94f17de5c93b30c9c122d267e929", @"/Views/Home/TextTaskView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a378ae84643e2852e7b9a41659f9c2de2cadb65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TextTaskView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextTask>
    {
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
        private global::Westwind.AspNetCore.Markdown.MarkdownTagHelper __Westwind_AspNetCore_Markdown_MarkdownTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(19, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("markdown", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3410e8363eef493cb62cf26a91139510", async() => {
                BeginContext(29, 72, true);
                WriteLiteral("\r\n    ##### **Click in the gaps and type one word in each gap.** #####\r\n");
                EndContext();
            }
            );
            __Westwind_AspNetCore_Markdown_MarkdownTagHelper = CreateTagHelper<global::Westwind.AspNetCore.Markdown.MarkdownTagHelper>();
            __tagHelperExecutionContext.Add(__Westwind_AspNetCore_Markdown_MarkdownTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(112, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\TextTaskView.cshtml"
  
    var parts = Model.Text.Split("_");

#line default
#line hidden
            BeginContext(163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\TextTaskView.cshtml"
 using (Html.BeginForm("CheckAnswer", "Home", FormMethod.Post))
{
    for (var i = 0; i < parts.Length - 1; i++)
    {
        

#line default
#line hidden
            BeginContext(297, 8, false);
#line 15 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\TextTaskView.cshtml"
   Write(parts[i]);

#line default
#line hidden
            EndContext();
            BeginContext(316, 50, false);
#line 16 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\TextTaskView.cshtml"
   Write(Html.TextBox("answer", (string)ViewBag.Answer?[i]));

#line default
#line hidden
            EndContext();
#line 16 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\TextTaskView.cshtml"
                                                           
    }
    

#line default
#line hidden
            BeginContext(380, 23, false);
#line 18 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\TextTaskView.cshtml"
Write(parts[parts.Length - 1]);

#line default
#line hidden
            EndContext();
            BeginContext(403, 80, true);
            WriteLiteral("<br />\r\n    <p>\r\n        <input type=\"submit\" value=\"Check\" />\r\n    </p><br />\r\n");
            EndContext();
#line 22 "C:\Users\111\Documents\EnglishTest\Getting-ready-to-exams\EnglishTest\Views\Home\TextTaskView.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextTask> Html { get; private set; }
    }
}
#pragma warning restore 1591
