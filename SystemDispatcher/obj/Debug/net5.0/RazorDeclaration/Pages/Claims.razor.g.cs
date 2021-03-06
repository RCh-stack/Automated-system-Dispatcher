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
#line 3 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Claims.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Claims.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Claims.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Claims.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Claims")]
    public partial class Claims : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Claims.razor"
       

    public int zoom = 12;
    private List<ClaimModel> claims;
    private ClaimModel newClaim = new ClaimModel();

    protected override async Task OnInitializedAsync()
    {
        toastService.ShowInfo("Use the Add, Edit, Delete buttons to add, edit and delete entries.");
        claims = await _db.GetClaim();
    }

    public string clickedPositionX = "", clickedPositionY = "";
    public string startX = "", endX = "", startY = "", endY = "";

    void onMapClick(GoogleMapClickEventArgs args)
    {
        clickedPositionX = args.Position.Lng.ToString();
        clickedPositionY = args.Position.Lat.ToString();

        toastService.ShowInfo("Point coordinates are set: " + clickedPositionX + ", " + clickedPositionY);
    }

    public void startPointClick()
    {
        if (clickedPositionX == String.Empty || clickedPositionY == String.Empty)
        {
            toastService.ShowError("Point not selected.");
        }
        else
        {
            startX = clickedPositionX;
            startY = clickedPositionY;
            toastService.ShowSuccess("The starting point coordinates are set.");
            clickedPositionX = ""; clickedPositionY = "";
        }
    }

    public void endPointClick()
    {
        if (clickedPositionX == String.Empty || clickedPositionY == String.Empty)
        {
            toastService.ShowError("Point not selected.");
        }
        else
        {
            endX = clickedPositionX;
            endY = clickedPositionY;
            toastService.ShowSuccess("The ending point coordinates are set.");
            clickedPositionX = ""; clickedPositionY = "";
        }
    }

    public async void ActionBeginHandler(ActionEventArgs<ClaimModel> Args)
    {
        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Save))
        {
            if (Args.Action == "Add")
            {
                Args.Data.PointXStart = startX;
                Args.Data.PointYStart = startY;
                Args.Data.PointXEnd = endX;
                Args.Data.PointYEnd = endY;

                await _db.InsertClaim(Args.Data);

                claims.Add(Args.Data);

                newClaim = new ClaimModel();

                toastService.ShowSuccess("Post added successfully, please refresh the page.");
            }
            else
            {
                Args.Data.PointXStart = startX;
                Args.Data.PointYStart = startY;
                Args.Data.PointXEnd = endX;
                Args.Data.PointYEnd = endY;

                await _db.UpdateClaim(Args.Data);
                toastService.ShowSuccess("The record has been successfully modified, please refresh the page.");
            }
        }

        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Delete))
        {
            await _db.DeleteClaim(Args.Data);
            toastService.ShowSuccess("Post deleted successfully, please refresh the page.");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClaimData _db { get; set; }
    }
}
#pragma warning restore 1591
