#pragma checksum "C:\Users\JancoSteenkamp\Desktop\SportStore\BlazorApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f7e44c6f775cae7014b2059bb04d77c70bf850e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\JancoSteenkamp\Desktop\SportStore\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\JancoSteenkamp\Desktop\SportStore\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\JancoSteenkamp\Desktop\SportStore\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\JancoSteenkamp\Desktop\SportStore\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\JancoSteenkamp\Desktop\SportStore\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\JancoSteenkamp\Desktop\SportStore\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#line 7 "C:\Users\JancoSteenkamp\Desktop\SportStore\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "C:\Users\JancoSteenkamp\Desktop\SportStore\BlazorApp\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
