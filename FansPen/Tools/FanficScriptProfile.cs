﻿using AutoMapper;
using FansPen.Domain.Models;
using FansPen.Web.Models.ScriptModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FansPen.Web.Tools
{
    public class FanficScriptProfile : Profile
    {
        public FanficScriptProfile()
        {
            CreateMap<FanficScriptModel, Fanfic>();
        }
    }
}
