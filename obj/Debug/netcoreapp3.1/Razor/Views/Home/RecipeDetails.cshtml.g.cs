#pragma checksum "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48f50f6dfa0bb1fba1bf7f5cd3fbb0e5b858cb5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RecipeDetails), @"mvc.1.0.view", @"/Views/Home/RecipeDetails.cshtml")]
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
#line 1 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\_ViewImports.cshtml"
using WAD_Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\_ViewImports.cshtml"
using WAD_Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48f50f6dfa0bb1fba1bf7f5cd3fbb0e5b858cb5e", @"/Views/Home/RecipeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f21cd6d9435a75740fa97db71d323155fc01f5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RecipeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WAD_Assignment.Models.Recipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("RecipeImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"detailsContainer\">\r\n     <h1 class=\"contentTitle\">");
#nullable restore
#line 8 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"flexContainer\">\r\n        <div class=\"imageContainer\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48f50f6dfa0bb1fba1bf7f5cd3fbb0e5b858cb5e4146", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 266, "~/images/FoodImages/", 266, 20, true);
#nullable restore
#line 10 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
AddHtmlAttributeValue("", 286, Model.Image, 286, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n        <div class=\"imageContainer\">\r\n            <h2>Info</h2>\r\n            <p>Cooking Time: ");
#nullable restore
#line 13 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                        Write(Model.CookingTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Minutes</p>\r\n            <p>Date Added: ");
#nullable restore
#line 14 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                      Write(Model.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h2>Ingredients</h2>\r\n            <ul class=\"RecipeIngredients\">\r\n");
#nullable restore
#line 18 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                 if (@Model.Ingredient1 != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 20 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                   Write(Model.Ingredient1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 21 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                 if (@Model.Ingredient2 != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 24 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                   Write(Model.Ingredient2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 25 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                 if (@Model.Ingredient3 != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 28 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                   Write(Model.Ingredient3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                 if (@Model.Ingredient4 != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 32 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                   Write(Model.Ingredient4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 33 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                 if (@Model.Ingredient5 != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 36 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                   Write(Model.Ingredient5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 37 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                 if (@Model.Ingredient6 != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 40 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                   Write(Model.Ingredient6);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 41 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                 if (@Model.Ingredient7 != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 44 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                   Write(Model.Ingredient7);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 45 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n    <h2 class=\"contentTitle\">Method</h2>\r\n        <div class=\"RecipeSteps\">\r\n");
#nullable restore
#line 51 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
             if (@Model.Step1 != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>1) ");
#nullable restore
#line 52 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
              Write(Model.Step1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 52 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
             if (@Model.Step2 != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>2) ");
#nullable restore
#line 54 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
              Write(Model.Step2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 54 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
             if (@Model.Step3 != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>3) ");
#nullable restore
#line 56 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
              Write(Model.Step3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 56 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
             if (@Model.Step4 != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>4) ");
#nullable restore
#line 58 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
              Write(Model.Step4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 58 "C:\Users\niall\source\repos\WAD-Assignment1\WAD-Assignment1\Views\Home\RecipeDetails.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WAD_Assignment.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
