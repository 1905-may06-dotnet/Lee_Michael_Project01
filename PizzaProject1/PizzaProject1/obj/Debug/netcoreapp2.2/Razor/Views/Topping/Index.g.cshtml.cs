#pragma checksum "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe0705023637de55a1dbfc5845803463c6f55fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topping_Index), @"mvc.1.0.view", @"/Views/Topping/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Topping/Index.cshtml", typeof(AspNetCore.Views_Topping_Index))]
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
#line 1 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\_ViewImports.cshtml"
using PizzaProject1;

#line default
#line hidden
#line 2 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\_ViewImports.cshtml"
using PizzaProject1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe0705023637de55a1dbfc5845803463c6f55fb", @"/Views/Topping/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebce91295ae552a7683e40b74ad59f7d383f09a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Topping_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaProject1.Models.Topping>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(61, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfe0705023637de55a1dbfc5845803463c6f55fb3615", async() => {
                BeginContext(84, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(98, 58, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(255, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(290, 47, false);
#line 13 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingName));

#line default
#line hidden
            EndContext();
            BeginContext(337, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(393, 41, false);
#line 16 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
            EndContext();
            BeginContext(434, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(560, 65, true);
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(657, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
            BeginContext(769, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(804, 46, false);
#line 31 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingName));

#line default
#line hidden
            EndContext();
            BeginContext(850, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(906, 40, false);
#line 34 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
            EndContext();
            BeginContext(946, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1071, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1106, 65, false);
#line 40 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1192, 71, false);
#line 41 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1284, 69, false);
#line 42 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Michael Lee\Desktop\Lee_Michael_Project01\PizzaProject1\PizzaProject1\Views\Topping\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1392, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaProject1.Models.Topping>> Html { get; private set; }
    }
}
#pragma warning restore 1591
