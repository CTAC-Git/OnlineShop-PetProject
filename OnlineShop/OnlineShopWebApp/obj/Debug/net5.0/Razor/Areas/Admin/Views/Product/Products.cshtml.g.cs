#pragma checksum "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b9c0f1d2be66b80091cde9c27d9361cc0cb5f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Products), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Products.cshtml")]
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
#line 3 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b9c0f1d2be66b80091cde9c27d9361cc0cb5f40", @"/Areas/Admin/Views/Product/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313fe019740a4859c3d6912300bfb7fb82f6be18", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313fe019740a4859c3d6912300bfb7fb82f6be18", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Product_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<style>\r\n    table, th, td {\r\n        border: 1px solid black;\r\n    }\r\n    table {width: 100%;}\r\n</style>\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Список товаров</h1>\r\n</div>\r\n");
#nullable restore
#line 13 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
Write(await Html.PartialAsync("AdminMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br><br>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b9c0f1d2be66b80091cde9c27d9361cc0cb5f405164", async() => {
                WriteLiteral("Создать новый продукт &#10133;");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Название</th>\r\n            <th>Описание</th>\r\n            <th>Стоимость</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
     foreach (var item in Model)
        {
            string RemoveModalId = "RemoveModal" + item.Id + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 30 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 31 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 32 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 33 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
               Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 885, "\"", 929, 2);
            WriteAttributeValue("", 892, "/user/product/productDetails/", 892, 29, true);
#nullable restore
#line 35 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
WriteAttributeValue("", 921, item.Id, 921, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Подробнее</a>\r\n                <a href=\"#\" class=\"btn\" data-toggle=\"modal\" data-target=\"#");
#nullable restore
#line 36 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
                                                                     Write(RemoveModalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Удалить</a>\r\n<!-- МАДОЛЬНОЕ ОКНО ДЛЯ ПОДТВЕРЖДЕНИЯ УДАЛЕНИЯ ПРОДУКТА -->\r\n            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1145, "\"", 1164, 1);
#nullable restore
#line 38 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
WriteAttributeValue("", 1150, RemoveModalId, 1150, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1193, "\"", 1225, 1);
#nullable restore
#line 38 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
WriteAttributeValue("", 1211, RemoveModalId, 1211, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog\">\r\n                    <div class=\"modal-content\">\r\n                        <div class=\"modal-header\">\r\n                            <h4 class=\"modal-title\"");
            BeginWriteAttribute("id", " id=\"", 1444, "\"", 1470, 2);
#nullable restore
#line 42 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
WriteAttributeValue("", 1449, RemoveModalId, 1449, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1463, "accept", 1464, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Вы уверены?</h4>\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Отмена</button>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1716, "\"", 1760, 2);
            WriteAttributeValue("", 1723, "/admin/product/removeproduct/", 1723, 29, true);
#nullable restore
#line 46 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
WriteAttributeValue("", 1752, item.Id, 1752, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" stryle=""background-color:brown"" class=""btn"" role=""button"">Удалить</a>
                        </div>
                    </div>
                </div>
            </div>
<!-- МАДОЛЬНОЕ ОКНО ДЛЯ ПОДТВЕРЖДЕНИЯ УДАЛЕНИЯ ПРОДУКТА -->
            </tr>
");
#nullable restore
#line 53 "C:\Users\DlyaS\Desktop\Всё\C#\PetWebsite\ASP.NET_Core_4.0\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\Product\Products.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
