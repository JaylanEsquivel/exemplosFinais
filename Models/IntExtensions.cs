using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFinais.Models
{
    public static class IntExtensions
    {
        public static bool EhPah(this int numero) { 
            return numero % 2 == 0;
        }
    }
}