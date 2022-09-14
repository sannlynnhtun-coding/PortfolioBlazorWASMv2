using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PortfolioBlazorWASMv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PortfolioBlazorWASMv2.Pages
{
    public partial class Index
    {
        [Inject]
        public HttpClient _HttpClient { get; set; }
        [Inject]
        public IJSRuntime _JSRuntime { get; set; }

        private UserModel data;
        protected override async Task OnInitializedAsync()
        {
            data = await _HttpClient.GetFromJsonAsync<UserModel>("data/db.json");
            Console.WriteLine(data);
        }

        private string targetId = "Home";

        private string IsActive(string name)
        {
            return targetId.ToLower() == name.ToLower() ? "active" : "";
        }

        private async Task SetMenu(string _targetId)
        {
            targetId = _targetId.ToLower();
            await _JSRuntime.InvokeVoidAsync("scrollIntoView", targetId);
        }
    }
}
