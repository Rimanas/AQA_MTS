using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRailComplexApi.Models
{
    public record Group
    {
        public string Password { get; init; } = string.Empty;
    }
}
