#pragma checksum "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e486980d1758269e60c88722d3c2f30c846ac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ListCategory), @"mvc.1.0.view", @"/Views/Product/ListCategory.cshtml")]
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
#line 1 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\_ViewImports.cshtml"
using BuyFood_Template;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\_ViewImports.cshtml"
using BuyFood_Template.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e486980d1758269e60c88722d3c2f30c846ac2", @"/Views/Product/ListCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7063af1aed637f0edaf01ce998250970c36fbeb", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ListCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BuyFood_Template.ViewModels.CCategoryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary  btn-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/vendors/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
  
    Layout = "_LayoutAd";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"ibox\" style=\"z-index:0\">\r\n    <div class=\"ibox-head\">\r\n        <div class=\"ibox-title\">\r\n            <a class=\"btn btn-danger btn-rounded\"");
            BeginWriteAttribute("onclick", " onclick=\"", 256, "\"", 266, 0);
            EndWriteAttribute();
            WriteLiteral(">刪除多筆</a>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e486980d1758269e60c88722d3c2f30c846ac26062", async() => {
                WriteLiteral("新增類別");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"        </div>
    </div>

    <div class=""ibox-body"">
        <div class=""table-responsive"">
            <table class=""table table-hover"">
                <thead class=""thead-default"">
                    <tr>
                        <th width=""50px"">
                            <label class=""ui-checkbox"">
                                <input type=""checkbox"" id=""chElt"" onclick=""checkOrCancelAll();"">
                                <span class=""input-span""></span>
                            </label>
                        </th>
                        <th>
                            序
                        </th>
                        <th>
                            ");
#nullable restore
#line 31 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
                       Write(Html.DisplayNameFor(model => model.CCategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>操作</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
                      int count = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
                     foreach (var item in Model)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr>
                            <td>
                                <label class=""ui-checkbox"">
                                    <input type=""checkbox"" name=""interest"">
                                    <span class=""input-span""></span>
                                </label>
                            </td>
                            <td>");
#nullable restore
#line 48 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 50 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CCategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
                           Write(Html.ActionLink("修改", "Edit", new { id = item.CProductCategoryId }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                                ");
#nullable restore
#line 55 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
                           Write(Html.ActionLink("刪除", "Delete", new { id = item.CProductCategoryId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <button class=\"btn btn-default btn-xs m-r-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2530, "\"", 2619, 3);
            WriteAttributeValue("", 2540, "clickLink(\'", 2540, 11, true);
#nullable restore
#line 58 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
WriteAttributeValue("", 2551, Url.Action("ActionName", "ControllerName", new{ /*routeValue*/ }), 2551, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2617, "\')", 2617, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-pencil font-14\"></i></button>\r\n                                <button class=\"btn btn-default btn-xs\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2738, "\"", 2827, 3);
            WriteAttributeValue("", 2748, "clickLink(\'", 2748, 11, true);
#nullable restore
#line 59 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
WriteAttributeValue("", 2759, Url.Action("ActionName", "ControllerName", new{ /*routeValue*/ }), 2759, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2825, "\')", 2825, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash font-14\"></i></button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 69 "C:\Users\User\Desktop\BuyFood_購物車v3_0405_2300\BuyFood_購物車v3_0405_1900\BuyFood_Template\Views\Product\ListCategory.cshtml"
Write(Html.ActionLink("返回產品列表", "List", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<!-- BEGIN PAGA BACKDROPS-->\r\n<div class=\"sidenav-backdrop backdrop\"></div>\r\n<div class=\"preloader-backdrop\">\r\n    <div class=\"page-preloader\">Loading</div>\r\n</div>\r\n<!-- END PAGA BACKDROPS-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e486980d1758269e60c88722d3c2f30c846ac213885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    function checkOrCancelAll() {
        //1.獲取checkbo的元素對象
        var chElt = document.getElementById(""chElt"");
        //2.獲取選中狀態
        var checkedElt = chElt.checked;
        console.log(checkedElt)
        //3.若checked=true,將所有的復選框選中,checked=false,將所有的復選框取消
        var allCheck = document.getElementsByName(""interest"");
        //4.循環遍歷取出每一個復選框中的元素
        //var mySpan=document.getElementById(""mySpan"");
        if (checkedElt) {
            //全選
            for (var i = 0; i < allCheck.length; i++) {
                //設置復選框的選中狀態
                allCheck[i].checked = true;
            }
            //mySpan.innerHTML=""取消全選"";
        } else {
            //取消全選
            for (var i = 0; i < allCheck.length; i++) {
                allCheck[i].checked = false;
            }
            //mySpan.innerHTML=""全選"";
        }
    };
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BuyFood_Template.ViewModels.CCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
