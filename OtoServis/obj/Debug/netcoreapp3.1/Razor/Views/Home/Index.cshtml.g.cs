#pragma checksum "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8311ae38756717d95f4149345a8a60a0624035f7"
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
#line 1 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\_ViewImports.cshtml"
using OtoServis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\_ViewImports.cshtml"
using OtoServis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8311ae38756717d95f4149345a8a60a0624035f7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f70862e747e5dbb83f7043e5de2595c4743c37a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OtoServis.UI.Models.ServiceOperationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    DateTime DateOfArrival = DateTime.Today;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main>\r\n    <div class=\"container-fluid\">\r\n");
#nullable restore
#line 10 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
         using (Html.BeginForm("Add", "Home", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-sm-4"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <p class=""text-muted text-small mb-2"">ARAÇ BİLGİLERİ</p>


                            <div class=""row form-group col-md-12"">
                                ");
#nullable restore
#line 21 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                           Write(Html.Label("Araç Plakası"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 22 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                           Write(Html.TextBoxFor(m => m.serviceOperation.LicensePlate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <div class=\"form-group col-md-6\">\r\n                                    ");
#nullable restore
#line 27 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Marka"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 28 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.TextBoxFor(m => m.serviceOperation.Brand, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group col-md-6\">\r\n                                    ");
#nullable restore
#line 31 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Model"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 32 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.TextBoxFor(m => m.serviceOperation.Model, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <div class=\"form-group col-md-6\">\r\n                                    ");
#nullable restore
#line 38 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("KM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 39 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.TextBoxFor(m => m.serviceOperation.KM, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group col-md-6\">\r\n                                    ");
#nullable restore
#line 42 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Tarih"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <input class=\"datepicker form-control\" name=\"serviceOperation.DateOfArrival\" data-date-format=\"dd/mm/yyyy\"");
            BeginWriteAttribute("value", " value=\"", 2087, "\"", 2129, 1);
#nullable restore
#line 43 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
WriteAttributeValue("", 2095, DateOfArrival.ToShortDateString(), 2095, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-8"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <p class=""text-muted text-small mb-2"">SERVİS HİZMETLERİ</p>



                            <div class=""row"">
                                <div class=""form-group col-md-3"">

                                    ");
#nullable restore
#line 59 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Şasi Yağlama"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <input class=""form-control col-md-2 ml-5"" type=""checkbox"" value=""Şasi Yağlama"" name=""serviceOperation.ChassisLubrication"">

                                </div>
                                <div class=""form-group col-md-3"">
                                    ");
#nullable restore
#line 64 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Antifiriz Ekleme"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <input class=""form-control col-md-2 ml-5"" type=""checkbox"" value=""Antifiriz Ekleme"" name=""serviceOperation.AddingAntifreeze"">
                                </div>
                                <div class=""form-group col-md-3"">
                                    ");
#nullable restore
#line 68 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Yağ Değişimi"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <input class=""form-control col-md-2 ml-5"" type=""checkbox"" value=""Yağ Değişimi"" name=""serviceOperation.OilChange"">
                                </div>
                                <div class=""form-group col-md-3"">
                                    ");
#nullable restore
#line 72 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Lastik Rot Ayarı"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <input class=""form-control col-md-2 ml-5"" type=""checkbox"" value=""Lastik Rot Ayarı"" name=""serviceOperation.TireWheelAlignment"">
                                </div>

                            </div>
                            <div class=""row"">
                                <div class=""form-group col-md-3"">
                                    ");
#nullable restore
#line 79 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Hava Filtresi Değişimi"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <input class=""form-control col-md-2 ml-5"" type=""checkbox"" value=""Hava Filtresi Değişimi"" name=""serviceOperation.AirFilterReplacement"">
                                </div>
                                <div class=""form-group col-md-3"">
                                    ");
#nullable restore
#line 83 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Soğutma Sistemi Temizliği"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <input class=""form-control col-md-2 ml-5"" type=""checkbox"" value=""Sağoutma Sistemi Temizliği"" name=""serviceOperation.CoolingSystemCleaning"">
                                </div>
                                <div class=""form-group col-md-3"">
                                    ");
#nullable restore
#line 87 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Yağ Filtresi Değişimi"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <input class=""form-control col-md-2 ml-5"" type=""checkbox"" value=""Yağ Filtresi Değişimi"" name=""serviceOperation.OilFilterReplacement"">
                                </div>
                                <div class=""form-group col-md-3"">
                                    ");
#nullable restore
#line 91 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                               Write(Html.Label("Balans Ayarı"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <input class=""form-control col-md-2 ml-5"" type=""checkbox"" value=""Balans Ayarı"" name=""serviceOperation.BalanceAdjustment"">
                                </div>


                            </div>
                            <div class=""row form-group col-md-12"">
                                ");
#nullable restore
#line 98 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                           Write(Html.Label("Diğer Bakımlar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 99 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
                           Write(Html.TextBoxFor(m => m.serviceOperation.OtherOperations, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
#nullable restore
#line 104 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
           Write(Html.HiddenFor(m => m.serviceOperation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                <button type=\"submit\" class=\"btn btn-success\">Araç Bilgilerini Kaydet</button>\r\n\r\n            </div>\r\n");
#nullable restore
#line 110 "C:\Users\Cuma Yıldırım\source\repos\OtoServis\OtoServis\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OtoServis.UI.Models.ServiceOperationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
