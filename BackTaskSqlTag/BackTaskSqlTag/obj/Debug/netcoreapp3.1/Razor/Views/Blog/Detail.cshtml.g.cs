#pragma checksum "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a26aa9cd4de1090b91c37b38b0eb764b1c1bea57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
#line 1 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\_ViewImports.cshtml"
using BackTaskSqlTag;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\_ViewImports.cshtml"
using BackTaskSqlTag.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\_ViewImports.cshtml"
using BackTaskSqlTag.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a26aa9cd4de1090b91c37b38b0eb764b1c1bea57", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"781fbfe65d8636418109f76b7d6f7c8040efc3f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post-author"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" BlogVM\r\n\r\n");
#nullable restore
#line 3 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main id=""main"">

    <!-- ======= Blog Header ======= -->
    <div class=""header-bg page-area"">
        <div class=""container position-relative"">
            <div class=""row"">
                <div class=""col-md-12 col-sm-12 col-xs-12"">
                    <div class=""slider-content text-center"">
                        <div class=""header-bottom"">
                            <div class=""layer2"">
                                <h1 class=""title2"">Blog Details </h1>
                            </div>
                            <div class=""layer3"">
                                <h2 class=""title3"">profesional Blog Page</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div><!-- End Blog Header -->
    <!-- ======= Blog Page ======= -->
    <div class=""blog-page area-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 ");
            WriteLiteral("col-md-4\">\r\n                    <div class=\"page-head-blog\">\r\n                        <div class=\"single-blog-page\">\r\n                            <!-- search option start -->\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a26aa9cd4de1090b91c37b38b0eb764b1c1bea576285", async() => {
                WriteLiteral(@"
                                <div class=""search-option"">
                                    <input type=""text"" placeholder=""Search..."">
                                    <button class=""button"" type=""submit"">
                                        <i class=""bi bi-search""></i>
                                    </button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <!-- search option end -->
                        </div>
                        <div class=""single-blog-page"">
                            <!-- recent start -->
                            <div class=""left-blog"">
                                <h4>recent post</h4>
                                <div class=""recent-post"">
                                    <!-- start single post -->
");
#nullable restore
#line 53 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                     foreach (Blog blog in Model.Blogs)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"recent-single-post\">\r\n                                            <div class=\"post-img\">\r\n                                                <a href=\"#\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a26aa9cd4de1090b91c37b38b0eb764b1c1bea579003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2516, "~/assets/img/blog/", 2516, 18, true);
#nullable restore
#line 58 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 2534, blog.Image, 2534, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </a>\r\n                                            </div>\r\n                                            <div class=\"pst-content\">\r\n");
#nullable restore
#line 62 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                                 if (blog.BlockQuote.Length >= 20)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <p><a href=\"#\">");
#nullable restore
#line 64 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                                              Write(blog.BlockQuote.Substring(0, 15));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a></p>\r\n");
#nullable restore
#line 65 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <p><a href=\"#\">");
#nullable restore
#line 68 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                                              Write(blog.BlockQuote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n");
#nullable restore
#line 69 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                         </div>\r\n");
#nullable restore
#line 72 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!-- End single post -->\r\n                                    <!-- start single post -->\r\n");
            WriteLiteral("                                    <!-- End single post -->\r\n                                    <!-- start single post -->\r\n");
            WriteLiteral("                                    <!-- End single post -->\r\n                                    <!-- start single post -->\r\n");
            WriteLiteral(@"                                    <!-- End single post -->
                                </div>
                            </div>
                            <!-- recent end -->
                        </div>
                        <div class=""single-blog-page"">
                            <div class=""left-blog"">
                                <h4>categories</h4>
                                <ul>
                                    <li>
                                        <a href=""#"">Portfolio</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Project</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Design</a>
                                    </li>
                                    <li>
                                        <a href=""#"">wordpress</a>
                                    </li>
  ");
            WriteLiteral(@"                                  <li>
                                        <a href=""#"">Joomla</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Html</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Website</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""single-blog-page"">
                            <div class=""left-blog"">
                                <h4>archive</h4>
                                <ul>
                                    <li>
                                        <a href=""#"">07 July 2016</a>
                                    </li>
                                    <li>
                                        <a href=""#"">29 June 2016</a>
         ");
            WriteLiteral(@"                           </li>
                                    <li>
                                        <a href=""#"">13 May 2016</a>
                                    </li>
                                    <li>
                                        <a href=""#"">20 March 2016</a>
                                    </li>
                                    <li>
                                        <a href=""#"">09 Fabruary 2016</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""single-blog-page"">
                            <div class=""left-tags blog-tags"">
                                <div class=""popular-tag left-side-tags left-blog"">
                                    <h4>popular tags</h4>
                                    <ul>
                                        <li>
                                            <a href=""#"">Portfoli");
            WriteLiteral(@"o</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Project</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Design</a>
                                        </li>
                                        <li>
                                            <a href=""#"">wordpress</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Joomla</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Html</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Masonry</a>
                                        </li>
 ");
            WriteLiteral(@"                                       <li>
                                            <a href=""#"">Website</a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- End left sidebar -->
                <!-- Start single blog -->
                <div class=""col-md-8 col-sm-8 col-xs-12"">
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12 col-xs-12"">
                            <!-- single-blog start -->
                            <article class=""blog-post-wrapper"">
                                <div class=""post-thumbnail"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a26aa9cd4de1090b91c37b38b0eb764b1c1bea5718315", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10736, "~/assets/img/blog/", 10736, 18, true);
#nullable restore
#line 207 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 10754, Model.Blog.Image, 10754, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 207 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 10778, Model.Blog.Title, 10778, 17, false);

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
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"post-information\">\r\n                                    <h2>");
#nullable restore
#line 210 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                   Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                    <div class=""entry-meta"">
                                        <span class=""author-meta""><i class=""bi bi-person""></i> <a href=""#"">admin</a></span>
                                        <span><i class=""bi bi-clock""></i>");
#nullable restore
#line 213 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                                                    Write(Model.Blog.Date.ToString("hh:m dddd.MMMM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        <span class=""tag-meta"">
                                            <i class=""bi bi-folder""></i>
                                            <a href=""#"">painting</a>,
                                            <a href=""#"">work</a>
                                        </span>
                                        <span>
                                            <i class=""bi bi-tags""></i>
                                            <a href=""#"">tools</a>,
                                            <a href=""#""> Humer</a>,
                                            <a href=""#"">House</a>
                                        </span>
                                        <span><i class=""bi bi-chat""></i> <a href=""#"">2 comments</a></span>
                                    </div>
                                    <div class=""entry-content"">
                                        <p>
                                            ");
#nullable restore
#line 229 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                       Write(Model.Blog.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <blockquote>\r\n                                            <p>\r\n                                                ");
#nullable restore
#line 233 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                           Write(Model.Blog.BlockQuote);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </blockquote>
                                    </div>
                                </div>
                            </article>
                            <div class=""clear""></div>
                            <div class=""single-post-comments"">
                                <div class=""comments-area"">
                                    <div class=""comments-heading"">
                                        <h3>2 comments</h3>
                                    </div>
                                    <div class=""comments-list"">
                                        <ul>

");
#nullable restore
#line 248 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                             foreach (var comment in Model.Blog.Comments)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <li class=""threaded-comments"">
                                                    <div class=""comments-details"">
                                                        <div class=""comments-list-img"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a26aa9cd4de1090b91c37b38b0eb764b1c1bea5724360", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 13685, "~/assets/img/blog/", 13685, 18, true);
#nullable restore
#line 253 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 13703, comment.Image, 13703, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                        <div class=""comments-content-wrap"">
                                                            <span>
                                                                <b><a href=""#""> ");
#nullable restore
#line 257 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                                                           Write(comment.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></b>\r\n\r\n                                                                <span class=\"post-time\">");
#nullable restore
#line 259 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                                                                   Write(comment.Date.ToString("dd.MMMM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                                <a href=\"#\">Reply</a>\r\n                                                            </span>\r\n                                                            <p>");
#nullable restore
#line 262 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                                          Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        </div>\r\n                                                    </div>\r\n                                                </li>\r\n");
#nullable restore
#line 266 "E:\3.Asp.Net.Core\BackTaskSqlTag\BackTaskSqlTag\Views\Blog\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"                                        </ul>
                                    </div>
                                </div>
                                <div class=""comment-respond"">
                                    <h3 class=""comment-reply-title"">Leave a Reply </h3>
                                    <span class=""email-notes"">Your email address will not be published. Required fields are marked *</span>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a26aa9cd4de1090b91c37b38b0eb764b1c1bea5728389", async() => {
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-lg-4 col-md-4"">
                                                <p>Name *</p>
                                                <input type=""text"" />
                                            </div>
                                            <div class=""col-lg-4 col-md-4"">
                                                <p>Email *</p>
                                                <input type=""email"" />
                                            </div>
                                            <div class=""col-lg-4 col-md-4"">
                                                <p>Website</p>
                                                <input type=""text"" />
                                            </div>
                                            <div class=""col-lg-12 col-md-12 col-sm-12 comment-form-comment"">
                                                <p>Website</p");
                WriteLiteral(@">
                                                <textarea id=""message-box"" cols=""30"" rows=""10""></textarea>
                                                <input type=""submit"" value=""Post Comment"" />
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                            <!-- single-blog end -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div><!-- End Blog Page -->

</main><!-- End #main -->
");
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
