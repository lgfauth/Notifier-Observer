﻿using System.Diagnostics.CodeAnalysis;

namespace SingleLog.Models
{
    [ExcludeFromCodeCoverage]
    public sealed class TraceLog
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
