using Microsoft.EntityFrameworkCore;
using BHAMCApp.Data;
using BHAMCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Services
{
    public class PmtctService 
    {
        private readonly ApplicationDbContext _context;

        public PmtctService(ApplicationDbContext context)
        {
            _context = context;
        }
                

       
    }
}
