#pragma checksum "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\Home\SentenceTaskView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e025326117ca82275a86ab4147f306a3717d46e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SentenceTaskView), @"mvc.1.0.view", @"/Views/Home/SentenceTaskView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SentenceTaskView.cshtml", typeof(AspNetCore.Views_Home_SentenceTaskView))]
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
#line 1 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\_ViewImports.cshtml"
using EnglishTest;

#line default
#line hidden
#line 2 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\_ViewImports.cshtml"
using EnglishTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e025326117ca82275a86ab4147f306a3717d46e", @"/Views/Home/SentenceTaskView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a378ae84643e2852e7b9a41659f9c2de2cadb65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SentenceTaskView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SentenceTask>
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
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\Home\SentenceTaskView.cshtml"
  
    var parts = Model.Second.Split("_");

#line default
#line hidden
            BeginContext(72, 336, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("markdown", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "068acda749b2453bb9d48422a89b2a6f", async() => {
                BeginContext(82, 262, true);
                WriteLiteral(@"

    ##### **Complete the second sentence so that it has a similar meaning to the first sentence, using the word given.** #####
    ##### **Do not change the word given. You must use between two and five words, including the word given.** #####

    ##### ");
                EndContext();
                BeginContext(345, 11, false);
#line 11 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\Home\SentenceTaskView.cshtml"
     Write(Model.First);

#line default
#line hidden
                EndContext();
                BeginContext(356, 19, true);
                WriteLiteral(" #####\r\n    ##### *");
                EndContext();
                BeginContext(376, 10, false);
#line 12 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\Home\SentenceTaskView.cshtml"
      Write(Model.Word);

#line default
#line hidden
                EndContext();
                BeginContext(386, 11, true);
                WriteLiteral("* #####\r\n\r\n");
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
            BeginContext(408, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\Home\SentenceTaskView.cshtml"
 using (Html.BeginForm("CheckAnswer", "Home", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(485, 8, false);
#line 18 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\Home\SentenceTaskView.cshtml"
Write(parts[0]);

#line default
#line hidden
            EndContext();
            BeginContext(500, 50, false);
#line 19 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\Home\SentenceTaskView.cshtml"
Write(Html.TextBox("userAnswer", (string)ViewBag.Answer));

#line default
#line hidden
            EndContext();
            BeginContext(557, 8, false);
#line 20 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\Home\SentenceTaskView.cshtml"
Write(parts[1]);

#line default
#line hidden
            EndContext();
            BeginContext(565, 80, true);
            WriteLiteral("<br />\r\n    <p>\r\n        <input type=\"submit\" value=\"Check\" />\r\n    </p><br />\r\n");
            EndContext();
#line 24 "C:\Users\a_yas\Documents\Getting-ready-to-exams\EnglishTest\Views\Home\SentenceTaskView.cshtml"
}

#line default
#line hidden
            BeginContext(648, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SentenceTask> Html { get; private set; }
    }
}
#pragma warning restore 1591
