#pragma checksum "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a269c29dd0957d6c5871316aa1e4cfa6de510278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_DetailsUser), @"mvc.1.0.view", @"/Views/Category/DetailsUser.cshtml")]
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
#line 1 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a269c29dd0957d6c5871316aa1e4cfa6de510278", @"/Views/Category/DetailsUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b49651ebfc01c17d2c504639d71ebc8cab0ef1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_DetailsUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
  
	Layout="~/Views/Shared/_UserLayout.cshtml";
	ViewData["Title"] = "Details Page";
	var base64 = "";
	string imgsrc;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""hero hero3"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-md-12"">
				<!-- <h1> movie listing - list</h1>
				<ul class=""breadcumb"">
					<li class=""active""><a href=""#"">Home</a></li>
					<li> <span class=""ion-ios-arrow-right""></span> movie listing</li>
				</ul> -->
			</div>
		</div>
	</div>
</div>
<!-- celebrity single section-->

<div class=""page-single movie-single cebleb-single"">
	<div class=""container"">
		<div class=""row ipad-width"">
			<div class=""col-md-4 col-sm-12 col-xs-12"">
				<div class=""mv-ceb"">
");
#nullable restore
#line 28 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
                      
						if(Model.Image!=null){
							base64=	Convert.ToBase64String(@Model.Image);
                imgsrc= string.Format("data:images/*;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 858, "\"", 871, 1);
#nullable restore
#line 32 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
WriteAttributeValue("", 864, imgsrc, 864, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 872, "\"", 878, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:350px; height:500px; object-fit:cover\">\n");
#nullable restore
#line 33 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-8 col-sm-12 col-xs-12\">\n\t\t\t\t<div class=\"movie-single-ct\">\n\t\t\t\t\t<h1 class=\"bd-hd\">");
#nullable restore
#line 38 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t\t\t\t<p class=\"ceb-single\" >");
#nullable restore
#line 39 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
					<div class=""social-link cebsingle-socail"" hidden>
						<br />
						<br />
					</div>
					<div class=""movie-tabs"">
						<div class=""tabs"">
							<div class=""tabs"">
							<ul class=""tab-links tabs-mv"">
								<li class=""active""><a href=""#overviewceb"">Overview</a></li>
								                      
							</ul>
						    <div class=""tab-content"">
						        <div id=""overviewceb"" class=""tab active"">
						            <div class=""row"">
						            	<div class=""col-md-8 col-sm-12 col-xs-12"">
						            	
						            	
											<!-- movie cast -->
											<div class=""mvcast-item"">	
");
#nullable restore
#line 59 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
                                                 foreach(var item in Model.Movies){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"cast-it\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"cast-left cebleb-film\">\n");
#nullable restore
#line 62 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
                                                          
															if(item.Image!=null) {
																base64=	Convert.ToBase64String(@item.Image);
														imgsrc= string.Format("data:images/*;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 2095, "\"", 2108, 1);
#nullable restore
#line 66 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
WriteAttributeValue("", 2101, imgsrc, 2101, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  style=\"width:120px; height:90px; object-fit:cover\" >\n");
#nullable restore
#line 67 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
															}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a269c29dd0957d6c5871316aa1e4cfa6de5102789000", async() => {
#nullable restore
#line 69 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
                                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\n");
#nullable restore
#line 76 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\DetailsUser.cshtml"
												}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t            \t</div>\n\t\t\t\t\t\t            \n\t\t\t\t\t\t            </div>\n\n\t\t\t\t\t\t    </div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n\t</div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
