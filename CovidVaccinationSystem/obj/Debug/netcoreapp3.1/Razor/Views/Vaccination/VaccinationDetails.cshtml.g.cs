#pragma checksum "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab456e8704ff27c340c04a0f3522f4d65841e6f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vaccination_VaccinationDetails), @"mvc.1.0.view", @"/Views/Vaccination/VaccinationDetails.cshtml")]
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
#line 1 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\_ViewImports.cshtml"
using CovidVaccinationSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\_ViewImports.cshtml"
using CovidVaccinationSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab456e8704ff27c340c04a0f3522f4d65841e6f5", @"/Views/Vaccination/VaccinationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23c5116485636f2bfbd4b571c41b2abe46be683", @"/Views/_ViewImports.cshtml")]
    public class Views_Vaccination_VaccinationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CovidVaccinationSystem.Models.Vaccine_History>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PatientList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
  
    ViewData["Title"] = "VaccinationDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>VaccinationDetails</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Pat_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayFor(model => model.Pat_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Vacc_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayFor(model => model.Vacc_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Vacc_1_ScheduleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayFor(model => model.Vacc_1_ScheduleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Vacc_1_LotNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayFor(model => model.Vacc_1_LotNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Vacc_2_ScheduleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayFor(model => model.Vacc_2_ScheduleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Vacc_2_LotNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayFor(model => model.Vacc_2_LotNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Pat_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
       Write(Html.DisplayFor(model => model.Pat_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 58 "E:\Rosmin\CovidVaccinationSystem\CovidVaccinationSystem\Views\Vaccination\VaccinationDetails.cshtml"
Write(Html.ActionLink("Edit", "VaccinationAdd", new { Pat_Id = ViewBag.patid }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab456e8704ff27c340c04a0f3522f4d65841e6f59119", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CovidVaccinationSystem.Models.Vaccine_History> Html { get; private set; }
    }
}
#pragma warning restore 1591
