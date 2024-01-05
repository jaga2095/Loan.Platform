﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StandardRail.RailCarLounge.Models.Entities;

namespace StandardRail.RailCarLounge.Business.Pact
{
    public interface ILEContentService
    {

        Task<IList<LEContent>> GetLEContents();

    }
}
