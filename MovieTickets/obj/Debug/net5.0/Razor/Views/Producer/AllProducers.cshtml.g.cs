#pragma checksum "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Producer\AllProducers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "769c97a593e2074c5b898a6f157da3bb32ea7c8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producer_AllProducers), @"mvc.1.0.view", @"/Views/Producer/AllProducers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769c97a593e2074c5b898a6f157da3bb32ea7c8e", @"/Views/Producer/AllProducers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b49651ebfc01c17d2c504639d71ebc8cab0ef1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Producer_AllProducers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Producer>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
            WriteLiteral("\n\n");
#nullable restore
#line 6 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Producer\AllProducers.cshtml"
  
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""slider movie-items"">
	<div class=""container"">
	<div class=""container"">
		<div class=""row ipad-width"">
<div class=""col-md-12"">
				
				<div class=""title-hd"">
					<h2>Producers</h2>
				</div>
				<div class=""tabs"">
					<ul class=""tab-links-2"">
						<li><a href=""#tab21"">#Popular</a></li>
						<li class=""active""><a href=""#tab22""> #Coming soon</a></li>
						<li><a href=""#tab23"">  #Top rated  </a></li>
						<li><a href=""#tab24""> #Most reviewed</a></li>                        
					</ul>
				    <div class=""tab-content"">
				        
				        <div id=""tab22"" class=""tab active"">
				           <div class=""row"">
				            	<div class=""slick-multiItem h-100"">
				            		<div class=""slide-it"">
");
#nullable restore
#line 31 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Producer\AllProducers.cshtml"
                                         foreach(var i in Model)
										{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<div class=\"movie-item\">\n\n\t\t\t\t\t            \t\t\t<div class=\"mv-img\">\n\t\t\t\t\t            \t\t\t\t<img src=\"images/uploads/mv-item5.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1033, "\"", 1039, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"185\" height=\"284\">\n\t\t\t\t\t            \t\t\t</div>\n\t\t\t\t\t            \t\t\t<div class=\"hvr-inner\">\n\t\t\t\t\t            \t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "769c97a593e2074c5b898a6f157da3bb32ea7c8e5800", async() => {
                WriteLiteral(" Read more <i class=\"ion-android-arrow-dropright\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Producer\AllProducers.cshtml"
                                                                        WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Interstellar</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
");
#nullable restore
#line 46 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Producer\AllProducers.cshtml"
										}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t            \t\t\t\n\t\t\t\t            \t\t</div>\n\t\t\t\t\t\t\t\t\t<div class=\"slide-it\">\n\t\t\t\t\t\t\t\t\t\t<div class=\"movie-item\">\n\t\t\t\t\t            \t\t\t<div class=\"mv-img\">\n\t\t\t\t\t            \t\t\t\t<img src=\"images/uploads/mv-item6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1774, "\"", 1780, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The revenant</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
									</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2452, "\"", 2458, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Die hard</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3135, "\"", 3141, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The walk</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3818, "\"", 3824, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Interstellar</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
									<div class=""slide-it"">
										<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4487, "\"", 4493, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The revenant</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
									</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5165, "\"", 5171, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Die hard</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5848, "\"", 5854, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The walk</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6531, "\"", 6537, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Interstellar</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
									<div class=""slide-it"">
										<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7200, "\"", 7206, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The revenant</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
									</div>
				            	</div>
				            </div>
				        </div>
				        <div id=""tab23"" class=""tab"">
				        	<div class=""row"">
				            	<div class=""slick-multiItem"">
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8063, "\"", 8069, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Interstellar</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
									<div class=""slide-it"">
										<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8732, "\"", 8738, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The revenant</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
									</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9410, "\"", 9416, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Die hard</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10093, "\"", 10099, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The walk</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10776, "\"", 10782, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Interstellar</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
									<div class=""slide-it"">
										<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11445, "\"", 11451, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The revenant</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
									</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12123, "\"", 12129, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Die hard</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12806, "\"", 12812, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The walk</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13489, "\"", 13495, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Die hard</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            	</div>
				            </div>
			       	 	</div>
			       	 	 <div id=""tab24"" class=""tab"">
				        	<div class=""row"">
				            	<div class=""slick-multiItem"">
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14360, "\"", 14366, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Interstellar</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
									<div class=""slide-it"">
										<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15029, "\"", 15035, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The revenant</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
									</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15707, "\"", 15713, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Die hard</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16390, "\"", 16396, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">The walk</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            		<div class=""slide-it"">
				            			<div class=""movie-item"">
					            			<div class=""mv-img"">
					            				<img src=""images/uploads/mv-item3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17073, "\"", 17079, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">Die hard</a></h6>
					            				<p><i class=""ion-android-star""></i><span>7.4</span> /10</p>
					            			</div>
					            		</div>
				            		</div>
				            	</div>
				            </div>
			       	 	</div>
				    </div>
				</div>
			</div>
			</div>
			</div>
			</div>
			</div>
");
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Producer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
