using Domain.App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.App.Context
{
   public class APP_Context:DbContext
    {
        public APP_Context(DbContextOptions<APP_Context> options):base(options)
        {


        }
        public DbSet<Users> users { get; set; }
    }
}
