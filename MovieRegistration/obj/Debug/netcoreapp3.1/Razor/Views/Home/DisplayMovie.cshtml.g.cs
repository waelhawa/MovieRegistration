#pragma checksum "F:\GrandCircus\C#\MovieRegistration\MovieRegistration\Views\Home\DisplayMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "878a7651e35a4fd49c81ba638e2b81baaeff79f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayMovie), @"mvc.1.0.view", @"/Views/Home/DisplayMovie.cshtml")]
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
#line 1 "F:\GrandCircus\C#\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GrandCircus\C#\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878a7651e35a4fd49c81ba638e2b81baaeff79f4", @"/Views/Home/DisplayMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 4 "F:\GrandCircus\C#\MovieRegistration\MovieRegistration\Views\Home\DisplayMovie.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 4 "F:\GrandCircus\C#\MovieRegistration\MovieRegistration\Views\Home\DisplayMovie.cshtml"
         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h4>Genre: ");
#nullable restore
#line 5 "F:\GrandCircus\C#\MovieRegistration\MovieRegistration\Views\Home\DisplayMovie.cshtml"
      Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Year: ");
#nullable restore
#line 6 "F:\GrandCircus\C#\MovieRegistration\MovieRegistration\Views\Home\DisplayMovie.cshtml"
     Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h6>Actors: ");
#nullable restore
#line 7 "F:\GrandCircus\C#\MovieRegistration\MovieRegistration\Views\Home\DisplayMovie.cshtml"
       Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>Directors: ");
#nullable restore
#line 8 "F:\GrandCircus\C#\MovieRegistration\MovieRegistration\Views\Home\DisplayMovie.cshtml"
          Write(Model.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>Added Successfully!</h6>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
