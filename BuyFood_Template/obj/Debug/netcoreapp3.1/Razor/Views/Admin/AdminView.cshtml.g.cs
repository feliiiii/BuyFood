#pragma checksum "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Admin\AdminView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bafea2dba0eb51d549cc09f8c85d11a1a557289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminView), @"mvc.1.0.view", @"/Views/Admin/AdminView.cshtml")]
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
#line 1 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\_ViewImports.cshtml"
using BuyFood_Template;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\_ViewImports.cshtml"
using BuyFood_Template.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bafea2dba0eb51d549cc09f8c85d11a1a557289", @"/Views/Admin/AdminView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f52bc86e72f64e29fd651d74892b57efe0e70f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/NEW CSS/NEWCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/NEW CSS/page.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Admin\AdminView.cshtml"
   
    Layout = "_LayoutAd";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4bafea2dba0eb51d549cc09f8c85d11a1a5572894461", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4bafea2dba0eb51d549cc09f8c85d11a1a5572895573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <div class=""box-module height100b margin0"">
        <div class=""box-title"">個人信息</div>
        <div class=""box-content padding15"">

            <!--個人信息-->
            <div class=""add_content clearfix mt15"">
                <div class=""clearfix"" id=""user_details"">

                    <ul class=""info_list"" id=""VerifyTips"">
                        <li class=""clearfix content_look mb15"">
                            <label class=""label_name"">用戶頭像：</label>
                            <span class=""info_data"">
                                <div class=""gradeimg-style"">
                                    <div class=""Upload-screenshot"">
                                        <img class=""addImg"" src=""images/zjbg_03.png"" onerror=""this.src='images/zjbg_03.png',this.onerror=null"">
                                        <input name=""url"" type=""file"" class=""upload_input"" accept=""image/*"">
                                        <input type=""hidden"" id=""img"" name=""img"">
                                        <div ");
            WriteLiteral("class=\"preBlock\">\n                                            <img class=\"preview\"");
            BeginWriteAttribute("alt", " alt=\"", 1258, "\"", 1264, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""pic"" onerror=""this.src='images/zjbg_03.png',this.onerror=null"">
                                        </div>
                                        <img class=""delete"" src=""images/delete.png"">
                                    </div>
                                </div>
                            </span>
                        </li>
                        <li class="" clearfix content_look mb15"">
                            <label class=""label_name""><em style=""color:Red;"">*</em>用戶名：</label>
                            <span class=""info_data""><input data-name=""用戶名"" type=""text"" value=""胡海天堂"" name=""Required"" class=""text_input col-sm-4"" data-verify=""verify""></span>
                        </li>
                        <li class="" clearfix content_look mb15"">
                            <label class=""label_name"">性別：</label>
                            <span class=""info_data"">

                                <input data-name=""性別"" type=""text""");
            BeginWriteAttribute("name", " name=\"", 2230, "\"", 2237, 0);
            EndWriteAttribute();
            WriteLiteral(@" value=""男"" class=""text_input col-sm-4"" data-verify=""verify"">

                            </span>
                        </li>
                        <li class="" clearfix content_look mb15"">
                            <label class=""label_name"">年齡：</label>
                            <span class=""info_data""><input data-name=""年齡"" type=""text""");
            BeginWriteAttribute("name", " name=\"", 2582, "\"", 2589, 0);
            EndWriteAttribute();
            WriteLiteral(@" value=""28"" class=""text_input col-sm-4"" data-verify=""verify""></span>
                        </li>
                        <li class="" clearfix content_look mb15"">
                            <label class=""label_name""><em style=""color:Red;"">*</em>部門：</label>
                            <span class=""info_data""><input data-name=""部門"" name=""Required"" value=""技術部"" type=""text"" class=""text_input col-sm-4"" data-verify=""verify""></span>
                        </li>
                        <li class="" clearfix content_look mb15"">
                            <label class=""label_name""><em style=""color:Red;"">*</em>職位：</label>
                            <span class=""info_data""><input data-name=""職位"" name=""Required"" value=""經理"" type=""text"" class=""text_input col-sm-4"" data-verify=""verify""></span>
                        </li>
                        <li class="" clearfix content_look mb15"">
                            <label class=""label_name"">角色：</label>
                            <span class=""info_data"">




                ");
            WriteLiteral(@"                <input data-name=""角色"" type=""text"" class=""text_input"" value=""普通管理員"" readonly=""readonly"">




                                <em style=""color:#999999; margin-left: 10px;"">該角色由最高權限管理員修改</em>
                            </span>
                        </li>
                        <li class="" clearfix content_look mb15"">
                            <label class=""label_name""><em style=""color:Red;"">*</em>手機：</label>
                            <span class=""info_data""><input data-name=""手機號碼"" name=""Required"" type=""text"" value=""18923456789"" class=""text_input col-sm-4"" data-prompt=""phone"" data-verify=""verify""></span>
                        </li>
                        <li class="" clearfix content_look mb15"">
                            <label class=""label_name""><em style=""color:Red;"">*</em>郵箱：</label>
                            <span class=""info_data""><input data-name=""郵箱"" name=""Required"" type=""text"" value=""lux.23454543@xinlian.com"" class=""text_input col-sm-4"" data-prompt=""mailbox"" data-verify=""veri");
            WriteLiteral(@"fy""></span>
                        </li>
                        <li class="" clearfix content_look mb15"">
                            <label class=""label_name"">說明：</label>
                            <span class=""info_data"">
                                <textarea data-name=""說明""");
            BeginWriteAttribute("name", " name=\"", 4920, "\"", 4927, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-textarea textarea-info\" id=\"form_textarea\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4983, "\"", 4997, 0);
            EndWriteAttribute();
            WriteLiteral(@">注意安全操作</textarea>
                                <span class=""word_count"">剩余字数 :<em class=""colorred number"">194</em>字符</span>
                            </span>
                        </li>
                    </ul>

                </div>
                <div class=""buttonstyle""><button type=""button"" class=""btn padding10 bg-deep-blue"" onclick=""modifybtn()"">保存修改</button></div>
            </div>
        </div>
    </div>


<script>
    $(function () {
        $(""#pagestyle"").Hupage({
            scrollbar: function (e) {
                e.niceScroll({
                    cursorcolor: ""#dddddd"",
                    cursoropacitymax: 1,
                    touchbehavior: false,
                    cursorwidth: ""3px"",
                    cursorborder: ""0"",
                    cursorborderradius: ""3px"",
                });
            },
            expand: function (thisBox, settings) {
                settings.scrollbar(
                    $("".box-content"").css({
                        height: $(window).h");
            WriteLiteral(@"eight() - $('.box-title').outerHeight() - (settings.padding * 2)
                    })); //設置當前頁滾動樣式
            }
        })
    });
    (function ($) {
        $.getUrlParam = function (name) {
            var reg = new RegExp(""(^|&)"" + name + ""=([^&]*)(&|$)"");
            var r = window.location.search.substr(1).match(reg);
            if (r != null) return unescape(r[2]);
            return null;
        }
    })(jQuery); //設置url
    var userid = $.getUrlParam('userid');
    //編輯數據
    var userinfo = function (callback) {
        $.ajax({
            url: ""json/userData.json"",
            type: ""GET"",
            dataType: 'json',
            success: function (ret) {
                typeof callback == 'function' && callback(ret);
            },
        });
    };
    userinfo(function (listArr) {
        var listhtml = $('#user_details');
        var html = template('userinfoHtml', {
            id: userid,
            grade: listArr.grade,
            list: listArr.administrator
        });
        lis");
            WriteLiteral(@"thtml.html(html);
        $(""#userinfoHtml"").remove();
        var api = """";//調用的api接口
        var type = 1;//類型
        //調用圖片上傳
        imgUpload(api, type);
        //設置字數
        new Wordcount(""form_textarea"", 200);
    });
    //提交操作

    function modifybtn() {

        new huprompt(""VerifyTips"");

    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591