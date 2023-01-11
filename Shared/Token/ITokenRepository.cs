﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Token
{
    public interface ITokenRepository
    {
        Task<string> CreateToken(TokenRequest request);
    }
}
