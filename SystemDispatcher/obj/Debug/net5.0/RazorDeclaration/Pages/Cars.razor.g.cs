// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SystemDispatcher.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using SystemDispatcher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using SystemDispatcher.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Cars")]
    public partial class Cars : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
       

    private List<CarModel> cars;
    private CarModel newCar = new CarModel();

    protected override async Task OnInitializedAsync()
    {
        toastService.ShowInfo("Use the Add, Edit, Delete buttons to add, edit and delete entries.");
        cars = await _db.GetCar();
    }

    public async void ActionBeginHandler(ActionEventArgs<CarModel> Args)
    {
        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Save))
        {
            if (Args.Action == "Add")
            {
                await _db.InsertCar(Args.Data);

                cars.Add(Args.Data);

                newCar = new CarModel();

                toastService.ShowSuccess("Post added successfully, please refresh the page..");
            }
            else
            {
                await _db.UpdateCar(Args.Data);
                toastService.ShowSuccess("The record has been successfully modified, please refresh the page.");
            }
        }

        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Delete))
        {
            await _db.DeleteCar(Args.Data);
            toastService.ShowSuccess("Post deleted successfully, please refresh the page.");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarData _db { get; set; }
    }
}
#pragma warning restore 1591
