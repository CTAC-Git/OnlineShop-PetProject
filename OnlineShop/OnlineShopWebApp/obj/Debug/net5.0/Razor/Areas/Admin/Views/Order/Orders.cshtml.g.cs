#pragma checksum "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c82c19923db1cb4513804a4ff07280f210ab6aa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Orders), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Orders.cshtml")]
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
#line 1 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
using OnlineShopWebApp.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c82c19923db1cb4513804a4ff07280f210ab6aa9", @"/Areas/Admin/Views/Order/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313fe019740a4859c3d6912300bfb7fb82f6be18", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313fe019740a4859c3d6912300bfb7fb82f6be18", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Order_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\ntable, th, td {\r\n    border: 1px solid black;\r\n}\r\ntable {width: 100%;}\r\n</style>\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Список заказов</h1>\r\n</div>\r\n");
#nullable restore
#line 14 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
Write(await Html.PartialAsync("AdminMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br><br><br>

<style>
    table, th, td {
        border: 1px solid black;
    }
    table {width: 100%;}
</style>
<table>
    <thead>
        <tr>
            <th>Id</th>
            <th>Сумма</th>
            <th>Статус</th>
            <th>Заказчик</th>
            <th>Дата и время создания</th>
        </tr>
");
#nullable restore
#line 31 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
     foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 34 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 35 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
               Write(item.FullPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 36 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
               Write(EnumHelper.GetDisplayName(item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 37 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 37 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 38 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
               Write(item.DataTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th><a");
            BeginWriteAttribute("href", " href=\"", 917, "\"", 958, 2);
            WriteAttributeValue("", 924, "/admin/order/orderdetails/", 924, 26, true);
#nullable restore
#line 39 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
WriteAttributeValue("", 950, item.Id, 950, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color:red\" class=\"btn\" role=\"button\">Подробнее</a>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Order\Orders.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </thead>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
