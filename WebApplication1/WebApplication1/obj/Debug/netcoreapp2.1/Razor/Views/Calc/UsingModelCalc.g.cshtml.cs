#pragma checksum "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c814f9dbabd1e5b3d4ebde279ebf8447b92e3ab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_UsingModelCalc), @"mvc.1.0.view", @"/Views/Calc/UsingModelCalc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calc/UsingModelCalc.cshtml", typeof(AspNetCore.Views_Calc_UsingModelCalc))]
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
#line 1 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c814f9dbabd1e5b3d4ebde279ebf8447b92e3ab9", @"/Views/Calc/UsingModelCalc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_UsingModelCalc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.MyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
  
    ViewData["Title"] = "UsingModelCalc";

#line default
#line hidden
            BeginContext(93, 46, true);
            WriteLiteral("\r\n<h2>UsingModelCalc</h2>\r\n<div>First number: ");
            EndContext();
            BeginContext(140, 11, false);
#line 9 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
              Write(Model.first);

#line default
#line hidden
            EndContext();
            BeginContext(151, 28, true);
            WriteLiteral("</div>\r\n<div>Second number: ");
            EndContext();
            BeginContext(180, 12, false);
#line 10 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
               Write(Model.second);

#line default
#line hidden
            EndContext();
            BeginContext(192, 19, true);
            WriteLiteral("</div>\r\n<div>Plus: ");
            EndContext();
            BeginContext(212, 11, false);
#line 11 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
      Write(Model.first);

#line default
#line hidden
            EndContext();
            BeginContext(223, 3, true);
            WriteLiteral(" + ");
            EndContext();
            BeginContext(227, 12, false);
#line 11 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
                     Write(Model.second);

#line default
#line hidden
            EndContext();
            BeginContext(239, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(243, 13, false);
#line 11 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
                                     Write(Model.resPlus);

#line default
#line hidden
            EndContext();
            BeginContext(256, 20, true);
            WriteLiteral("</div>\r\n<div>Minus: ");
            EndContext();
            BeginContext(277, 11, false);
#line 12 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
       Write(Model.first);

#line default
#line hidden
            EndContext();
            BeginContext(288, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(292, 12, false);
#line 12 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
                      Write(Model.second);

#line default
#line hidden
            EndContext();
            BeginContext(304, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(308, 12, false);
#line 12 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
                                      Write(Model.resMin);

#line default
#line hidden
            EndContext();
            BeginContext(320, 23, true);
            WriteLiteral("</div>\r\n<div>Multiply: ");
            EndContext();
            BeginContext(344, 11, false);
#line 13 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
          Write(Model.first);

#line default
#line hidden
            EndContext();
            BeginContext(355, 3, true);
            WriteLiteral(" * ");
            EndContext();
            BeginContext(359, 12, false);
#line 13 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
                         Write(Model.second);

#line default
#line hidden
            EndContext();
            BeginContext(371, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(375, 14, false);
#line 13 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
                                         Write(Model.resMulti);

#line default
#line hidden
            EndContext();
            BeginContext(389, 29, true);
            WriteLiteral("</div>\r\n<div>\r\n    Division: ");
            EndContext();
            BeginContext(419, 11, false);
#line 15 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
         Write(Model.first);

#line default
#line hidden
            EndContext();
            BeginContext(430, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(434, 12, false);
#line 15 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
                        Write(Model.second);

#line default
#line hidden
            EndContext();
            BeginContext(446, 3, true);
            WriteLiteral(" = ");
            EndContext();
#line 15 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
                                              if (Model.resDiv == -1)
    {

#line default
#line hidden
            BeginContext(482, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(492, 8, true);
            WriteLiteral(" error\r\n");
            EndContext();
#line 18 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
    }
    else
    {
        

#line default
#line hidden
            BeginContext(533, 12, false);
#line 21 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
   Write(Model.resDiv);

#line default
#line hidden
            EndContext();
#line 21 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\UsingModelCalc.cshtml"
                     
    }

#line default
#line hidden
            BeginContext(554, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.MyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591