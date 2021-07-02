#pragma checksum "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d75321e2fb7c994790a5a4901e1907a334e7dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieNight), @"mvc.1.0.view", @"/Views/Home/MovieNight.cshtml")]
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
#line 1 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\_ViewImports.cshtml"
using OMDb_API_Key;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\_ViewImports.cshtml"
using OMDb_API_Key.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d75321e2fb7c994790a5a4901e1907a334e7dc", @"/Views/Home/MovieNight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730930d34fa8ce22c66e998f436b23c775fbdce0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieNight : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h2>Search 3 Movies by Titles</h2>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1d75321e2fb7c994790a5a4901e1907a334e7dc3583", async() => {
                WriteLiteral(@"
    <p>Title 1</p>
    <input type=""text"" name=""title1"" />
    <br />
    <p>Title 2</p>
    <input type=""text"" name=""title2"" />
    <br />
    <p>Title 3</p>
    <input type=""text"" name=""title3"" />
    <br />
    <br/>
    <input type=""submit"" />
    <br />
    <br/>


");
#nullable restore
#line 20 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
     try
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
         foreach (Movie m in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div style=\"border: 1px solid black\">\r\n                <p>Title: ");
#nullable restore
#line 25 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                     Write(m.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Year: ");
#nullable restore
#line 26 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                    Write(m.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Rated: ");
#nullable restore
#line 27 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                     Write(m.Rated);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Released: ");
#nullable restore
#line 28 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                        Write(m.Released);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Runtime: ");
#nullable restore
#line 29 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                       Write(m.Runtime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Genre: ");
#nullable restore
#line 30 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                     Write(m.Genre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Director: ");
#nullable restore
#line 31 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                        Write(m.Director);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Writer: ");
#nullable restore
#line 32 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                      Write(m.Writer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Actor: ");
#nullable restore
#line 33 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                     Write(m.Actors);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Plot: ");
#nullable restore
#line 34 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                    Write(m.Plot);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Language: ");
#nullable restore
#line 35 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                        Write(m.Language);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Country: ");
#nullable restore
#line 36 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                       Write(m.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Awards: ");
#nullable restore
#line 37 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                      Write(m.Awards);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Poster: ");
#nullable restore
#line 38 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                      Write(m.Poster);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 39 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                 foreach (Rating r in m.Ratings)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p>Rating: ");
#nullable restore
#line 41 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                          Write(r.Source);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>Value: ");
#nullable restore
#line 42 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                         Write(r.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 43 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>Metascore: ");
#nullable restore
#line 44 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                         Write(m.Metascore);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>imdbRating: ");
#nullable restore
#line 45 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                          Write(m.imdbRating);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>imdbVotes: ");
#nullable restore
#line 46 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                         Write(m.imdbVotes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>imdbID: ");
#nullable restore
#line 47 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                      Write(m.imdbID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Type: ");
#nullable restore
#line 48 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                    Write(m.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>DVD: ");
#nullable restore
#line 49 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                   Write(m.DVD);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>BoxOffice: ");
#nullable restore
#line 50 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                         Write(m.BoxOffice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Production: ");
#nullable restore
#line 51 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                          Write(m.Production);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Website: ");
#nullable restore
#line 52 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                       Write(m.Website);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Response: ");
#nullable restore
#line 53 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                        Write(m.Response);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 55 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Andre\source\repos\OMDb API Key\OMDb API Key\Views\Home\MovieNight.cshtml"
                 
                }
                catch (NullReferenceException)
                {

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
