#pragma checksum "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c5188cafd53b789dac23cf453c33aa6dc58bdfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Delete), @"mvc.1.0.view", @"/Views/Booking/Delete.cshtml")]
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
#line 1 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/_ViewImports.cshtml"
using HollyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/_ViewImports.cshtml"
using HollyProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c5188cafd53b789dac23cf453c33aa6dc58bdfb", @"/Views/Booking/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5bfadaed8fd9f97ae925a379b23aeed43af7d21", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HollyProject.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Booking</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.date_checkin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.date_checkin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.date_checkout));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.date_checkout));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.jml_orang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.jml_orang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.jml_hari));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.jml_hari));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.is_accepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.is_accepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.is_canceled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.is_canceled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.is_rescheduled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.is_rescheduled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.is_rejected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.is_rejected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.request_reschedule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.request_reschedule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.request_cancel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.request_cancel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.User.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hotel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hotel.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c5188cafd53b789dac23cf453c33aa6dc58bdfb13213", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c5188cafd53b789dac23cf453c33aa6dc58bdfb13478", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 95 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Booking/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c5188cafd53b789dac23cf453c33aa6dc58bdfb15250", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HollyProject.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
