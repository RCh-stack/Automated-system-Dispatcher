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
#line 3 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Waybill")]
    public partial class Waybill : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 219 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
       

    SfListBox<string, PointModel> BoxObjLoad;

    private readonly string scope = "combined-list";

    public int zoom = 12;
    public int value, speed = 0;
    public string speedOutput = "";
    public void selectedValue(Syncfusion.Blazor.DropDowns.ChangeEventArgs<int, CarModel> args)
    {
        value = args.Value;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 231 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         foreach (var item in cars)
        {
            if (item.ID == value)
                speed = item.Speed;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 235 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         
        speedOutput = speed.ToString() + " km/h.";
    }

    private List<CarModel> cars;

    private List<ClaimModel> claims;
    private List<ClaimModel> claimsgrid = new List<ClaimModel>();

    private List<WaybillModel> waybills;
    private WaybillModel newWaybill = new WaybillModel();

    private List<PointModel> points = new List<PointModel>();

    // -- waypoints --
    public class PointModel
    {
        public int ID;
        public string Point;
    }

    protected override async Task OnInitializedAsync()
    {
        toastService.ShowInfo("Select a driver through the drop-down list, and drag " +
            "applications to the table below.");

        cars = await _dbcar.GetCar();
        claims = await _dbclaim.GetClaim();
        waybills = await _dbwaybill.GetWaybill();
    }

    public async Task outputPoint()
    {
        int i = 1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 269 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         foreach (var item in claimsgrid)
        {
            PointModel temp = new PointModel();

            temp.ID = i;
            temp.Point = item.Loading;
            points.Add(temp);
            temp = new PointModel();
            i++;

            temp.ID = i;
            temp.Point = item.Unloading;
            points.Add(temp);
            temp = new PointModel();
            i++;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 284 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         

        points.Distinct().ToList();
        await BoxObjLoad.AddItemsAsync(points);

        toastService.ShowInfo("Waypoints are displayed.");
    }

    public async Task removePoint()
    {
        await BoxObjLoad.SelectItemsAsync(BoxObjLoad.Value, false);
        await BoxObjLoad.RemoveItemAsync(points);

        points = new List<PointModel>();

        toastService.ShowInfo("Waypoints reset.");
    }

    public string firstPoint = "", secondPoint = "";
    public void onDropped()
    {
        var data = BoxObjLoad.GetDataList();

        List<PointModel> ds = JsonConvert.DeserializeObject<List<PointModel>>(JsonConvert.SerializeObject(data));
        firstPoint = ds[0].Point;

        bool correct = true;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 311 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         foreach(var item in claimsgrid)
        {
            if (item.Loading == firstPoint)
            { 
                correct = true;
                break;
            }
            else
                correct = false;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 320 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         

        secondPoint = ds[1].Point;
        bool isUnload = true;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 324 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         foreach(var item in claimsgrid)
        {
            if (item.Loading == firstPoint && item.Unloading == secondPoint)
            {
                isUnload = true;
                break;
            }
            else if (item.Loading == secondPoint)
                isUnload = true;
            else
                isUnload = false;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 335 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         

        if (isUnload && correct)
            toastService.ShowSuccess("Correct waybill.");
        else if (!correct)
            toastService.ShowWarning("Unloading occurs before loading.");
        else
            toastService.ShowWarning("The unloading point does not match the loading point.");
    }

    public string startX = "0", startY = "0", endX = "0", endY = "0";

    public double distance = 0, time = 0;
    public string distanceOutput = "";
    public string timeOutput = "";

    public const int R = 6371;

    public void manhattanDistance()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 355 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         foreach (var item in claimsgrid)
        {
            startX = item.PointYStart; endX = item.PointYEnd;
            startY = item.PointXStart; endY = item.PointXEnd;

            double x1 = (double.Parse(startX) * 3.14) / 180;
            double x2 = (double.Parse(endX) * 3.14) / 180;
            double y1 = (double.Parse(startY) * 3.14) / 180;
            double y2 = (double.Parse(endY) * 3.14) / 180;

            double sincos = Math.Pow(Math.Sin((x2 - x1) / 2), 2) + Math.Cos(x1) * Math.Cos(x2)
                * Math.Pow(Math.Sin((y2 - y1) / 2), 2);
            double sqrt = Math.Sqrt(sincos);

            distance += 2 * R * Math.Asin(sqrt);
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 370 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         

        if (distance == 0)
            toastService.ShowError("Points for distance calculation are not selected.");
        else
        {
            distanceOutput = Math.Round(distance, 2).ToString() + " km.";

            if (speed == 0)
            {
                toastService.ShowWarning("Distance calculated. Select a driver to calculate travel time.");
                distance = 0;
            }
            else
            {
                time = (distance / speed) + 1.0;
                var ts = TimeSpan.FromHours(time);
                timeOutput = ts.Hours.ToString() + " h. " + ts.Minutes.ToString() + " min.";

                distance = 0;
                toastService.ShowSuccess("Distance and travel time calculated.");
            }
        }
    }

    public async void saveWaybill()
    {
        int cargoWeight = 0;
        bool save = true;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 399 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         foreach (var item in claimsgrid)
        {
            cargoWeight += item.Weight;
            if (item.ID == 0)
                save = false;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 406 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         foreach (var item in cars)
        {
            if (item.ID == value)
            {
                if (cargoWeight > item.Capacity)
                {
                    toastService.ShowError("The total weight of the load exceeds the carrying capacity of the vehicle.");
                    save = false;
                }
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 416 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
         

        if (value == 0)
            save = false;

        if (save)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 423 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
             foreach (var item in claimsgrid)
            {
                newWaybill.ID_Car = value;
                newWaybill.ID_Claim = item.ID;
                newWaybill.PointStart = item.Loading;
                newWaybill.PointEnd = item.Unloading;
                newWaybill.TodayDate = DateTime.Today;

                WaybillModel wayb = new WaybillModel
                {
                    ID_Car = newWaybill.ID_Car,
                    ID_Claim = newWaybill.ID_Claim,
                    PointStart = newWaybill.PointStart,
                    PointEnd = newWaybill.PointEnd,
                    TodayDate = newWaybill.TodayDate
                };

                waybills.Add(wayb);

                await _dbwaybill.InsertWaybill(wayb);

                newWaybill = new WaybillModel();
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 445 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Waybill.razor"
             

            toastService.ShowSuccess("Waybill saved.");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWaybillData _dbwaybill { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClaimData _dbclaim { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarData _dbcar { get; set; }
    }
}
#pragma warning restore 1591
