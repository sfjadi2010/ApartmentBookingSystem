using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Domain.Entities.Apartments
{
    public record Address(string Street, string City, string State, string ZipCode, string Country);
}
