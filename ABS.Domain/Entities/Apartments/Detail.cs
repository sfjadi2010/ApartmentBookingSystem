using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Domain.Entities.Apartments
{
    public record Detail(int Rooms, int Bathrooms, int Size, bool IsAvailable);
}
