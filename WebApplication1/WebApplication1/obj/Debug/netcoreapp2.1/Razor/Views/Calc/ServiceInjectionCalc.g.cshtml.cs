#pragma checksum "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a57ffb8eda0550514bb1458eecb76dcf134b7f96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_ServiceInjectionCalc), @"mvc.1.0.view", @"/Views/Calc/ServiceInjectionCalc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calc/ServiceInjectionCalc.cshtml", typeof(AspNetCore.Views_Calc_ServiceInjectionCalc))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a57ffb8eda0550514bb1458eecb76dcf134b7f96", @"/Views/Calc/ServiceInjectionCalc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_ServiceInjectionCalc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
  
    ViewData["Title"] = "ServiceInjectionCalc";

#line default
#line hidden
            BeginContext(112, 52, true);
            WriteLiteral("\r\n<h2>ServiceInjectionCalc</h2>\r\n<div>First number: ");
            EndContext();
            BeginContext(165, 15, false);
#line 7 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
              Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(180, 28, true);
            WriteLiteral("</div>\r\n<div>Second number: ");
            EndContext();
            BeginContext(209, 16, false);
#line 8 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
               Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(225, 19, true);
            WriteLiteral("</div>\r\n<div>Plus: ");
            EndContext();
            BeginContext(245, 15, false);
#line 9 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
      Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(260, 3, true);
            WriteLiteral(" + ");
            EndContext();
            BeginContext(264, 16, false);
#line 9 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                         Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(280, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(284, 16, false);
#line 9 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                                             Write(Calculate.Plus());

#line default
#line hidden
            EndContext();
            BeginContext(300, 20, true);
            WriteLiteral("</div>\r\n<div>Minus: ");
            EndContext();
            BeginContext(321, 15, false);
#line 10 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
       Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(336, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(340, 16, false);
#line 10 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                          Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(356, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(360, 15, false);
#line 10 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                                              Write(Calculate.Min());

#line default
#line hidden
            EndContext();
            BeginContext(375, 23, true);
            WriteLiteral("</div>\r\n<div>Multiply: ");
            EndContext();
            BeginContext(399, 15, false);
#line 11 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
          Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(414, 3, true);
            WriteLiteral(" * ");
            EndContext();
            BeginContext(418, 16, false);
#line 11 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                             Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(434, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(438, 17, false);
#line 11 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                                                 Write(Calculate.Multi());

#line default
#line hidden
            EndContext();
            BeginContext(455, 29, true);
            WriteLiteral("</div>\r\n<div>\r\n    Division: ");
            EndContext();
            BeginContext(485, 15, false);
#line 13 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
         Write(Calculate.value);

#line default
#line hidden
            EndContext();
            BeginContext(500, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(504, 16, false);
#line 13 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                            Write(Calculate.value2);

#line default
#line hidden
            EndContext();
            BeginContext(520, 3, true);
            WriteLiteral(" = ");
            EndContext();
#line 13 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                                                      if (Calculate.Div() == -1)
    {

#line default
#line hidden
            BeginContext(559, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(569, 8, true);
            WriteLiteral(" error\r\n");
            EndContext();
#line 16 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
    }
    else
    {
        

#line default
#line hidden
            BeginContext(610, 15, false);
#line 19 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
   Write(Calculate.Div());

#line default
#line hidden
            EndContext();
#line 19 "D:\uni\labs\6 семестр\WEBBB\WebApplication1\WebApplication1\Views\Calc\ServiceInjectionCalc.cshtml"
                        
    }

#line default
#line hidden
            BeginContext(634, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public WebApplication1.Services.Idispatcher Calculate { get; private set; }
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
