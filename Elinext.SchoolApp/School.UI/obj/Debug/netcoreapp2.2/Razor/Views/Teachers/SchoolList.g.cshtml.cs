#pragma checksum "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\Teachers\SchoolList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a35dd92afcb735ded92b2e40432c35921a213f06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teachers_SchoolList), @"mvc.1.0.view", @"/Views/Teachers/SchoolList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teachers/SchoolList.cshtml", typeof(AspNetCore.Views_Teachers_SchoolList))]
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
#line 1 "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\_ViewImports.cshtml"
using School.UI;

#line default
#line hidden
#line 2 "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\_ViewImports.cshtml"
using School.DAL.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a35dd92afcb735ded92b2e40432c35921a213f06", @"/Views/Teachers/SchoolList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1aa11f72d925589146e95844fa14e926d44c01", @"/Views/_ViewImports.cshtml")]
    public class Views_Teachers_SchoolList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<School.DAL.Entities.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\Teachers\SchoolList.cshtml"
  
    ViewData["Title"] = "SchoolList";

#line default
#line hidden
            BeginContext(117, 128, true);
            WriteLiteral("\r\n<h2>List of school classes and their students</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(246, 47, false);
#line 13 "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\Teachers\SchoolList.cshtml"
       Write(Html.DisplayNameFor(model => model[0].FullName));

#line default
#line hidden
            EndContext();
            BeginContext(293, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(337, 52, false);
#line 16 "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\Teachers\SchoolList.cshtml"
       Write(Html.DisplayNameFor(model => model[0].StudentsClass));

#line default
#line hidden
            EndContext();
            BeginContext(389, 74, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\Teachers\SchoolList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(504, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(553, 43, false);
#line 26 "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\Teachers\SchoolList.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(596, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(652, 53, false);
#line 29 "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\Teachers\SchoolList.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentsClass.Name));

#line default
#line hidden
            EndContext();
            BeginContext(705, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "H:\Программирование\ElinextRepository\Elinext.SchoolApp\School.UI\Views\Teachers\SchoolList.cshtml"
    }

#line default
#line hidden
            BeginContext(748, 28, true);
            WriteLiteral("    \r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<School.DAL.Entities.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
