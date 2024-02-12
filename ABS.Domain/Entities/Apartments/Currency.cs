using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Domain.Entities.Apartments
{
    public record Currency
    {
        internal static readonly Currency None = new("");
        public static readonly Currency USD =  new("USD");
        public static readonly Currency EUR = new("EUR");
        private Currency(string code) => Code = code;

        public string Code { get; init; }

        public static Currency FromCode(string code)
        {
            return All.FirstOrDefault(c => c.Code == code) ?? 
                throw new ArgumentException($"Currency {code} is not supported", nameof(code));
        }
        public static readonly IReadOnlyCollection<Currency> All = new[] { USD, EUR };
    }
}
