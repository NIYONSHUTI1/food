#pragma checksum "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ebfd067a990743f45b593f833d64360da918688"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ebfd067a990743f45b593f833d64360da918688", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OdeToFood.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/food.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Index.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div>\n    <marquee><h5>Welcome our platform, we help you to find your favorite restaurant and order whatever you want</h5></marquee>\n    <div>\n        <div class=\"row\">\n");
#nullable restore
#line 14 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Index.cshtml"
             foreach (var resto in Model.Restaurants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 mb-2\">\n   \n                    <div class=\"card booking-card\">\n\n                        <!-- Card image -->\n                        <div class=\"view overlay\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1ebfd067a990743f45b593f833d64360da9186884654", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <div class=\"mask rgba-white-slight\"></div>\n                        </div>\n\n                        <div class=\"card-body\">\n                            <h4 class=\"card-title font-weight-bold\">");
#nullable restore
#line 27 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Index.cshtml"
                                                               Write(Html.ActionLink(resto.Name, "Details", new {id = resto.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            <div class=\"btn-group\"><button type=\"button\"  class=\"btn btn-success\" >");
#nullable restore
#line 28 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Index.cshtml"
                                                                                              Write(Html.ActionLink("Edit","Edit",new {id = resto.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button> <button type=\"button\" class=\"btn btn-danger\">");
#nullable restore
#line 28 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Index.cshtml"
                                                                                                                                                                                                        Write(Html.ActionLink("Delete","Delete",new {id = resto.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></div>\n                        </div>\n\n                    </div>\n         \n                </div>\n");
#nullable restore
#line 34 "/Users/gilberttuyishime/Documents/CST Year 3/NOTES YEAR 3/C#/EF_Core_Sqlite_ASP.NetCore_MVC-master/OdeToFood/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
