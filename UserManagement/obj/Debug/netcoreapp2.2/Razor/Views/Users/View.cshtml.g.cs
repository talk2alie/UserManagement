#pragma checksum "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b566942b48143482773ecfbfa9cd154e8d4a9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_View), @"mvc.1.0.view", @"/Views/Users/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/View.cshtml", typeof(AspNetCore.Views_Users_View))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b566942b48143482773ecfbfa9cd154e8d4a9a", @"/Views/Users/View.cshtml")]
    public class Views_Users_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserManagement.Data.User>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(62, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(91, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59b566942b48143482773ecfbfa9cd154e8d4a9a3128", async() => {
                BeginContext(97, 86, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>View</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(192, 1298, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59b566942b48143482773ecfbfa9cd154e8d4a9a4402", async() => {
                BeginContext(198, 109, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(308, 45, false);
#line 21 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(353, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(417, 41, false);
#line 24 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(458, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(521, 44, false);
#line 27 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(565, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(629, 40, false);
#line 30 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(669, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(732, 45, false);
#line 33 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
                EndContext();
                BeginContext(777, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(841, 41, false);
#line 36 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
                EndContext();
                BeginContext(882, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(945, 48, false);
#line 39 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
                EndContext();
                BeginContext(993, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1057, 44, false);
#line 42 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddress));

#line default
#line hidden
                EndContext();
                BeginContext(1101, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(1164, 51, false);
#line 45 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayNameFor(model => model.MembershipToken));

#line default
#line hidden
                EndContext();
                BeginContext(1215, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1279, 47, false);
#line 48 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
       Write(Html.DisplayFor(model => model.MembershipToken));

#line default
#line hidden
                EndContext();
                BeginContext(1326, 67, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1393, "\"", 1417, 1);
#line 53 "C:\Repos\UserManagement\UserManagement\Views\Users\View.cshtml"
WriteAttributeValue("", 1408, Model.Id, 1408, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1418, 65, true);
                WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1490, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserManagement.Data.User> Html { get; private set; }
    }
}
#pragma warning restore 1591