#pragma checksum "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73fb338ab0f067d86426ba3fc2cbf3a76f86983e"
// <auto-generated/>
#pragma warning disable 1591
namespace CA3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\deivi\source\repos\CA3\CA3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deivi\source\repos\CA3\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\deivi\source\repos\CA3\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\deivi\source\repos\CA3\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\deivi\source\repos\CA3\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\deivi\source\repos\CA3\CA3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\deivi\source\repos\CA3\CA3\_Imports.razor"
using CA3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\deivi\source\repos\CA3\CA3\_Imports.razor"
using CA3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Cryptocurrency</h1>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
 if (coins == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 10 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Symbol</th>
                <th>Rank</th>
                <th>New</th>
                <th>Active</th>
                <th>Type</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 26 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
             foreach (var c in coins){

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, "Name: ");
            __builder.AddContent(15, 
#nullable restore
#line 28 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
                           c.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, "ID: ");
            __builder.AddContent(19, 
#nullable restore
#line 29 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
                         c.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, "Symbol: ");
            __builder.AddContent(23, 
#nullable restore
#line 30 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
                             c.symbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, ">Rank: ");
            __builder.AddContent(27, 
#nullable restore
#line 31 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
                            c.rank

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, "New?: ");
            __builder.AddContent(31, 
#nullable restore
#line 32 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
                           c.is_new

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, "Active?: ");
            __builder.AddContent(35, 
#nullable restore
#line 33 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
                              c.is_active

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, "Type: ");
            __builder.AddContent(39, 
#nullable restore
#line 34 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
                           c.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 36 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 39 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\r\n<div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\deivi\source\repos\CA3\CA3\Pages\Index.razor"
       
    string displayData;

    private List<Coin> coins;

    protected override async Task OnInitializedAsync()
    {
        coins = await Http.GetFromJsonAsync<List<Coin>>("https://api.coinpaprika.com/v1/coins");
    }

    public class Coin
    {
        public string id { get; set; }

        public string name { get; set; }

        public string symbol { get; set; }

        public int rank { get; set; }

        public bool is_new { get; set; }

        public bool is_active { get; set; }

        public string type { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
