#pragma checksum "C:\Tai_Lieu\Kỳ học 20192\Project2\Project2\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05048c1e7ad5e74f4cbeecebda0df08656771b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Tai_Lieu\Kỳ học 20192\Project2\Project2\Views\_ViewImports.cshtml"
using Project2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Tai_Lieu\Kỳ học 20192\Project2\Project2\Views\_ViewImports.cshtml"
using Project2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Tai_Lieu\Kỳ học 20192\Project2\Project2\Views\_ViewImports.cshtml"
using Project2.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05048c1e7ad5e74f4cbeecebda0df08656771b53", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91bb3d6c82eb442eb207b74d05c64248a1abb50a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            DefineSection("hero", async() => {
                WriteLiteral(@"
    <div class=""page-header-overlay"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <header class=""entry-header"">
                        <h1>CONTACT</h1>
                    </header><!-- .entry-header -->
                </div><!-- .col -->
            </div><!-- .row -->
        </div><!-- .container -->
    </div><!-- .page-header-overlay -->
");
            }
            );
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""breadcrumbs"">
                <ul class=""flex flex-wrap align-items-center p-0 m-0"">
                    <li><a href=""#""><i class=""fa fa-home""></i> Home</a></li>
                    <li>Contact</li>
                </ul>
            </div><!-- .breadcrumbs -->
        </div><!-- .col -->
    </div><!-- .row -->

    <div class=""row justify-content-between"">
        <div class=""col-12"">
            <div class=""contact-gmap"">
                <iframe frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0"" src=""https://www.google.com/maps/embed/v1/place?key=AIzaSyAyCkIjViJ_7vt5PMIHai_NjcdR64QYycw&q=Space+Needle,Seattle+WA"" allowfullscreen></iframe>
            </div><!-- .contact-gmap -->
        </div><!-- .col -->

        <div class=""col-12 col-lg-6"">
            <div class=""contact-form"">
                <h3>Contact Form</h3>

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05048c1e7ad5e74f4cbeecebda0df08656771b534938", async() => {
                WriteLiteral(@"
                    <input type=""text"" placeholder=""Your Name"">
                    <input type=""email"" placeholder=""Your Email"">
                    <input type=""text"" placeholder=""Subject"">
                    <textarea placeholder=""Your Message"" rows=""4""></textarea>
                    <input type=""submit"" value=""Send Message"">
                ");
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
            WriteLiteral(@"
            </div><!-- .contact-form -->
        </div><!-- .col -->

        <div class=""col-12 col-lg-6"">
            <div class=""contact-info"">
                <h3>Contact Information</h3>

                <p>Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia dese mollit anim id est laborum. </p>

                <ul class=""p-0 m-0"">
                    <li><span>Location:</span>40 Baria Sreet 133/2 NewYork City, US</li>
                    <li><span>Email:</span><a href=""#"">info.deeercreative@gmail.com</a></li>
                    <li><span>Phone:</span><a href=""#"">(203) 123-6666</a></li>
                </ul>
            </div><!-- .contact-info -->
        </div><!-- .col -->
    </div><!-- .row -->
</div><!-- .container -->
");
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