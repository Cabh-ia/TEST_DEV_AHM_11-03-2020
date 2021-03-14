using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorCrud.Auth
{
    public class AuthStateProviderFake : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            return await Task.FromResult(new AuthenticationState(new System.Security.Claims.ClaimsPrincipal(identity)));
        }
    }
}
