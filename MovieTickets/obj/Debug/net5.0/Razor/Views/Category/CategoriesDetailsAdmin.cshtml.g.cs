#pragma checksum "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\CategoriesDetailsAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda4f40eb025d202c4bf2f463649dffc341e5bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoriesDetailsAdmin), @"mvc.1.0.view", @"/Views/Category/CategoriesDetailsAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda4f40eb025d202c4bf2f463649dffc341e5bca", @"/Views/Category/CategoriesDetailsAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b49651ebfc01c17d2c504639d71ebc8cab0ef1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_CategoriesDetailsAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\CategoriesDetailsAdmin.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-3\" style=\"max-width: 540px;\">\n  <div class=\"row no-gutters\">\n    <div class=\"col-md-4\">\n");
#nullable restore
#line 13 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\CategoriesDetailsAdmin.cshtml"
      if (Model.Image != null)
                        {
                            var base64 = Convert.ToBase64String(@Model.Image);
                            var imgSrc = String.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 424, "\"", 437, 1);
#nullable restore
#line 17 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\CategoriesDetailsAdmin.cshtml"
WriteAttributeValue("", 430, imgSrc, 430, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:100%; \">\n");
#nullable restore
#line 18 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\CategoriesDetailsAdmin.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <div class=\"col-md-8\">\n      <div class=\"card-body\">\n          <h3 class=\"card-title\">");
#nullable restore
#line 22 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\CategoriesDetailsAdmin.cshtml"
                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <h5 class=\"card-title\">");
#nullable restore
#line 23 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\CategoriesDetailsAdmin.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <p class=\"card-text\">");
#nullable restore
#line 24 "D:\ASP.Net Projects\Movie_Ticket_Reservation-main\MovieTickets\Views\Category\CategoriesDetailsAdmin.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n      </div>\n    </div>\n  </div>\n</div>\n\n\n");
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