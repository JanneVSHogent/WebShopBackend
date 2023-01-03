﻿using WebShopAPI.Models;

namespace WebShopAPI.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}