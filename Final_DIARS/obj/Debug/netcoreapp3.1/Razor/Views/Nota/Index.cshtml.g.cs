#pragma checksum "C:\Users\Edwin\source\repos\Final_DIARS\Final_DIARS\Views\Nota\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5538b3f7b13428b059e03608d0ebc36b1a767f09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota_Index), @"mvc.1.0.view", @"/Views/Nota/Index.cshtml")]
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
#line 1 "C:\Users\Edwin\source\repos\Final_DIARS\Final_DIARS\Views\_ViewImports.cshtml"
using Final_DIARS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Edwin\source\repos\Final_DIARS\Final_DIARS\Views\_ViewImports.cshtml"
using Final_DIARS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5538b3f7b13428b059e03608d0ebc36b1a767f09", @"/Views/Nota/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff14e01371d4a869f0827bfd0a64ebfe80888092", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <br />\r\n    <h1 class=\"display-9\">APLICACIÓN DE NOTAS</h1>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n<br />\r\n<a href=\"#\" data-toggle=\"modal\" data-target=\"#crear\" class=\"btn btn-outline-success float-right\">Crear nota</a>\r\n\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5538b3f7b13428b059e03608d0ebc36b1a767f094522", async() => {
                WriteLiteral(@"


    <center>
        <div class=""col-md-4"">
            <div class=""form-group mb-8"">
                <input class=""form-control mr-sm-2"" id=""Nombre"" style=""background-size:cover; "" type=""search"" name=""search"">
                <button class=""btn btn-outline-info"" id=""buscar"" type=""submit""> Buscar</button>
            </div>
        </div>
    </center>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""form-group"" style=""padding: 0px;"">
    <div id=""nav"" class=""float-left rounded-lg border border-dark"" style=""background-color:gold ; color:black;"">
        <div class=""titulonav text-black text-center"" style=""font-family: Cambria, Cambria, Cambria, Cambria, Cambria, serif"">
            <b>ETIQUETAS</b>
        </div>

        <div class=""cuerporec"" style="" margin: 10px;"">
");
#nullable restore
#line 41 "C:\Users\Edwin\source\repos\Final_DIARS\Final_DIARS\Views\Nota\Index.cshtml"
             foreach (var eti in ViewBag.Etiquetas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"text-black list-unstyled\">\r\n                    <li><a class=\"text-black\" href=\"#\">☛ ");
#nullable restore
#line 44 "C:\Users\Edwin\source\repos\Final_DIARS\Final_DIARS\Views\Nota\Index.cshtml"
                                                    Write(eti.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                </ul>");
#nullable restore
#line 45 "C:\Users\Edwin\source\repos\Final_DIARS\Final_DIARS\Views\Nota\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>


<div class=""row"" id=""Lista"">

</div>

<!-- Modal -->
<div class=""modal fade"" id=""crear"" tabindex=""-1"" aria-labelledby=""crear"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Crear Nota</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""crearNota"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""submitFormCreate()"">Guardar</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $.ajax({
            url: '/Nota/Create',
            type: 'get'
        }).done(function (html) {
            $('#crearNota').html(html);
        })

        function submitFormCreate() {
            $('#createNota').submit();
        }

        function guardar(event) {
            event.preventDefault();
            var dataString = new FormData($('#crear form')[0]);
            $.ajax({
                url: ""/Nota/Create"",
                type: ""post"",
                processData: false,
                contentType: false,
                cache: false,
                data: dataString
            }).done(function (html) {
                location.reload();
            }).fail(function (html) {
                $('#crearNota').html(html.responseText);
            });
        }
    </script>

    <script>
        function init() {
            $.ajax({
                url: '/Nota/_Index?search=' + $('#Nombre').val()
            }).done(function (notas)");
                WriteLiteral(" {\r\n                $(\'#Lista\').html(notas);\r\n            });\r\n        }\r\n\r\n        $(\'#buscar\').click(function (e) {\r\n            e.preventDefault();\r\n            init();\r\n        });\r\n        init();\r\n    </script>\r\n");
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
