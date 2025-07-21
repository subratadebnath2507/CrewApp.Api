﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewApp.Domain.Options
{
    public class ConnectionStringOptions
    {
        public const string SectionName = "ConnectionStrings";

        public string DefaultConnection { get; set; } = null!;

    }
}
