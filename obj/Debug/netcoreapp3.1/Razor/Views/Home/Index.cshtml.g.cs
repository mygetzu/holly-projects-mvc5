#pragma checksum "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbed84e6878d9bbca3e0f29cbf64b5fb6b4c0ca3"
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
#nullable restore
#line 1 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/_ViewImports.cshtml"
using HollyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/_ViewImports.cshtml"
using HollyProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbed84e6878d9bbca3e0f29cbf64b5fb6b4c0ca3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5bfadaed8fd9f97ae925a379b23aeed43af7d21", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
  
    Layout = "_Layout_HomePage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
  
    var session = (User) ViewData["session"];
    var hotels = (List<Hotel>) ViewData["hotels"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""welcome-area welcome-section"">
    <div class=""welcome-slides owl-carousel"">
        <!-- Single Welcome Slide -->
        <div class=""single-welcome-slide bg-img bg-overlay"" style=""background-image: url(img/bg-img/16.jpg);"" data-img-url=""img/bg-img/16.jpg"">
            <!-- Welcome Content -->
            <div class=""welcome-content h-100"">
                <div class=""container h-100"">
                    <div class=""row h-100 align-items-center"">
                        <!-- Welcome Text -->
                        <div class=""col-12"">
                            <div class=""welcome-text text-center"">
                                <h6 data-animation=""fadeInLeft"" data-delay=""200ms"">Hotel &amp; Resort</h6>
                                <h2 data-animation=""fadeInLeft"" data-delay=""500ms"">Welcome To HOLLY</h2>
                                <a href=""#hotels"" class=""btn roberto-btn btn-2"" data-animation=""fadeInLeft"" data-delay=""800ms"">
                                    Disco");
            WriteLiteral(@"ver Hotel Now
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Single Welcome Slide -->
        <div class=""single-welcome-slide bg-img bg-overlay"" style=""background-image: url(img/bg-img/17.jpg);"" data-img-url=""img/bg-img/17.jpg"">
            <!-- Welcome Content -->
            <div class=""welcome-content h-100"">
                <div class=""container h-100"">
                    <div class=""row h-100 align-items-center"">
                        <!-- Welcome Text -->
                        <div class=""col-12"">
                            <div class=""welcome-text text-center"">
                                <h6 data-animation=""fadeInUp"" data-delay=""200ms"">Hotel &amp; Resort</h6>
                                <h2 data-animation=""fadeInUp"" data-delay=""500ms"">Welcome To HOLLY</h2>
                                <a href=""#hotels"" class=""btn");
            WriteLiteral(@" roberto-btn btn-2"" data-animation=""fadeInUp"" data-delay=""800ms"">Discover Hotel Now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Single Welcome Slide -->
        <div class=""single-welcome-slide bg-img bg-overlay"" style=""background-image: url(img/bg-img/18.jpg);"" data-img-url=""img/bg-img/18.jpg"">
            <!-- Welcome Content -->
            <div class=""welcome-content h-100"">
                <div class=""container h-100"">
                    <div class=""row h-100 align-items-center"">
                        <!-- Welcome Text -->
                        <div class=""col-12"">
                            <div class=""welcome-text text-center"">
                                <h6 data-animation=""fadeInDown"" data-delay=""200ms"">Hotel &amp; Resort</h6>
                                <h2 data-animation=""fadeInDown"" data-delay=""500ms"">Welcome To HOLLY</h2>
                    ");
            WriteLiteral(@"            <a href=""#hotels"" class=""btn roberto-btn btn-2"" data-animation=""fadeInDown"" data-delay=""800ms"">Discover Hotel Now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Welcome Area End -->

<!-- Hotels Area Start -->
<section class=""roberto-blog-area section-padding-100-0"" id=""hotels"">
    <div class=""container"">
        <div class=""row"">
            <!-- Section Heading -->
            <div class=""col-12"">
                <div class=""section-heading text-center wow fadeInUp"" data-wow-delay=""100ms"">
                    <h6>Welcome</h6>
                    <h2>Populer Hotels</h2>
                </div>
            </div>
        </div>

        <div class=""row"">

");
#nullable restore
#line 89 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
             foreach (var hotel in hotels) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 col-md-6 col-lg-4\">\r\n                    <div class=\"single-post-area mb-100 wow fadeInUp\" data-wow-delay=\"300ms\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4280, "\"", 4315, 2);
            WriteAttributeValue("", 4287, "/HotelPage/Details/", 4287, 19, true);
#nullable restore
#line 92 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
WriteAttributeValue("", 4306, hotel.id, 4306, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-thumbnail\"><img src=\"img/bg-img/2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4367, "\"", 4373, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        <!-- Post Meta -->\r\n                        <div class=\"post-meta\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4504, "\"", 4539, 2);
            WriteAttributeValue("", 4511, "/HotelPage/Details/", 4511, 19, true);
#nullable restore
#line 95 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
WriteAttributeValue("", 4530, hotel.id, 4530, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-date\">");
#nullable restore
#line 95 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
                                                                                Write(hotel.city);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 95 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
                                                                                             Write(hotel.country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4622, "\"", 4657, 2);
            WriteAttributeValue("", 4629, "/HotelPage/Details/", 4629, 19, true);
#nullable restore
#line 96 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
WriteAttributeValue("", 4648, hotel.id, 4648, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-catagory\">Hotel</a>\r\n                        </div>\r\n                        <!-- Post Title -->\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4795, "\"", 4830, 2);
            WriteAttributeValue("", 4802, "/HotelPage/Details/", 4802, 19, true);
#nullable restore
#line 99 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
WriteAttributeValue("", 4821, hotel.id, 4821, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-title\">");
#nullable restore
#line 99 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
                                                                             Write(hotel.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4894, "\"", 4929, 2);
            WriteAttributeValue("", 4901, "/HotelPage/Details/", 4901, 19, true);
#nullable restore
#line 100 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
WriteAttributeValue("", 4920, hotel.id, 4920, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-catagory price_hotel\" style=\"font-size: 24px; color: #f09614\">\r\n                            Rp. ");
#nullable restore
#line 101 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
                           Write(Html.Raw(@String.Format("{0:N2}", hotel.price)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                        </a>\r\n                        <br>\r\n                        <p>");
#nullable restore
#line 104 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
                      Write(hotel.deskripsi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5227, "\"", 5262, 2);
            WriteAttributeValue("", 5234, "/HotelPage/Details/", 5234, 19, true);
#nullable restore
#line 106 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
WriteAttributeValue("", 5253, hotel.id, 5253, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn roberto-btn mb-50\"><i class=\"fa fa-long-arrow-right\" aria-hidden=\"true\"></i> See Details</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 109 "/media/mygetzu/BENY/MEGA/Project/C#/DOTNET/MVC/HollyProject/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</section>
<!-- Hotels Area End -->

<!-- Projects Area Start -->
<section class=""roberto-project-area"">
    <!-- Projects Slide -->
    <div class=""projects-slides owl-carousel"">
        <!-- Single Project Slide -->
        <div class=""single-project-slide active bg-img"" style=""background-image: url(img/bg-img/5.jpg);"">
            <!-- Project Text -->
            <div class=""project-content"">
                <div class=""text"">
                    <h6>Entertaiment</h6>
                    <h5>Racing Bike</h5>
                </div>
            </div>
            <!-- Hover Effects -->
            <div class=""hover-effects"">
                <div class=""text"">
                    <h6>Entertaiment</h6>
                    <h5>Racing Bike</h5>
                    <p>I focus a lot on helping the first time or inexperienced traveler head out prepared and confident...</p>
                </div>
                <a href=""#hotels"" class=""btn project-btn"">Discover ");
            WriteLiteral(@"Hotel Now <i class=""fa fa-long-arrow-right"" aria-hidden=""true""></i></a>
            </div>
        </div>

        <!-- Single Project Slide -->
        <div class=""single-project-slide bg-img"" style=""background-image: url(img/bg-img/6.jpg);"">
            <!-- Project Text -->
            <div class=""project-content"">
                <div class=""text"">
                    <h6>Entertaiment</h6>
                    <h5>Racing Bike</h5>
                </div>
            </div>
            <!-- Hover Effects -->
            <div class=""hover-effects"">
                <div class=""text"">
                    <h6>Entertaiment</h6>
                    <h5>Racing Bike</h5>
                    <p>I focus a lot on helping the first time or inexperienced traveler head out prepared and confident...</p>
                </div>
                <a href=""#hotels"" class=""btn project-btn"">Discover Hotel Now <i class=""fa fa-long-arrow-right"" aria-hidden=""true""></i></a>
            </div>
        </div>

  ");
            WriteLiteral(@"      <!-- Single Project Slide -->
        <div class=""single-project-slide bg-img"" style=""background-image: url(img/bg-img/7.jpg);"">
            <!-- Project Text -->
            <div class=""project-content"">
                <div class=""text"">
                    <h6>Entertaiment</h6>
                    <h5>Racing Bike</h5>
                </div>
            </div>
            <!-- Hover Effects -->
            <div class=""hover-effects"">
                <div class=""text"">
                    <h6>Entertaiment</h6>
                    <h5>Racing Bike</h5>
                    <p>I focus a lot on helping the first time or inexperienced traveler head out prepared and confident...</p>
                </div>
                <a href=""#hotels"" class=""btn project-btn"">Discover Hotel Now <i class=""fa fa-long-arrow-right"" aria-hidden=""true""></i></a>
            </div>
        </div>

        <!-- Single Project Slide -->
        <div class=""single-project-slide bg-img"" style=""background-image: ur");
            WriteLiteral(@"l(img/bg-img/8.jpg);"">
            <!-- Project Text -->
            <div class=""project-content"">
                <div class=""text"">
                    <h6>Entertaiment</h6>
                    <h5>Racing Bike</h5>
                </div>
            </div>
            <!-- Hover Effects -->
            <div class=""hover-effects"">
                <div class=""text"">
                    <h6>Entertaiment</h6>
                    <h5>Racing Bike</h5>
                    <p>I focus a lot on helping the first time or inexperienced traveler head out prepared and confident...</p>
                </div>
                <a href=""#hotels"" class=""btn project-btn"">Discover Hotel Now <i class=""fa fa-long-arrow-right"" aria-hidden=""true""></i></a>
            </div>
        </div>
    </div>
</section>
<!-- Projects Area End -->


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        
        
        $(document).ready(function() {
            function formatRupiah(angka, prefix){
                var number_string = angka.replace(/[^,\d]/g, '').toString(),
                split   		= number_string.split(','),
                sisa     		= split[0].length % 3,
                rupiah     		= split[0].substr(0, sisa),
                ribuan     		= split[0].substr(sisa).match(/\d{3}/gi);
    
                // tambahkan titik jika yang di input sudah menjadi angka ribuan
                if(ribuan){
                    separator = sisa ? '.' : '';
                    rupiah += separator + ribuan.join('.');
                }
    
                rupiah = split[1] != undefined ? rupiah + ',' + split[1] : rupiah;
                return prefix == undefined ? rupiah : (rupiah ? 'Rp. ' + rupiah : '');
            }
            
            var rupiah = document.getElementByClassName('price_hotel');
            rupiah.innerHtml = formatRupiah(rupiah.tex");
                WriteLiteral("tContent, \'Rp. \');\r\n            console.log(\"Test\")\r\n        });\r\n\r\n\t</script>\r\n");
            }
            );
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
