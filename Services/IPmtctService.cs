﻿using BHAMCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Services
{
    public interface IPmtctService
    {

       public bool VerifyName(string na);
        //bool VerifyName(DateTime ServiceDate,string ID, string SN, bool ResponseName,string NambaMshiriki01, string ServiceName, string RemarksName);
        //bool VerifyName(string NambaMshiriki01, string ServiceName, int? id);
        
    }
}
