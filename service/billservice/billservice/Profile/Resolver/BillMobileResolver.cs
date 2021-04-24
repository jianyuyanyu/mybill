﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using billservice.models;
using billservice.models.Dto;
using Microsoft.AspNetCore.Http;

namespace billservice.Profile.Resolver
{
    public class BillMobileResolver : IValueResolver<BillDto , bills , string>
    {
        readonly IHttpContextAccessor _context;

        public BillMobileResolver ( IHttpContextAccessor _context )
        {
            this._context = _context;
        }



        public string Resolve ( BillDto source , bills destination , string destMember , ResolutionContext context )
        {
            var user = _context.HttpContext.User;

            var claims = user.Claims;

            if ( claims != null && claims.Count() > 0 )
            {
                var mobile = claims.FirstOrDefault( item => item.Type == System.Security.Claims.ClaimTypes.Name )?.Value;

                return mobile;
            }

            return string.Empty;
        }



    }
}
