﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DTO;


namespace DAL
{
    class ApplicationDataContext : DbContext
    {
        public DbSet<machine_monitoring_poortenDTO> machine_Monitoring_Poorten{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string server = "Server=studmysql01.fhict.local;Uid=dbi340421;Database=dbi340421;Pwd=Dreaming;";
            optionsBuilder.UseMySql(server, ServerVersion.AutoDetect(server), options => options.EnableRetryOnFailure());
        }

    }
}