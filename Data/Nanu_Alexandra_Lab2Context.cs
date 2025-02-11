﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nanu_Alexandra_Lab2.Models;

namespace Nanu_Alexandra_Lab2.Data
{
    public class Nanu_Alexandra_Lab2Context : DbContext
    {
        public Nanu_Alexandra_Lab2Context (DbContextOptions<Nanu_Alexandra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nanu_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Nanu_Alexandra_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
