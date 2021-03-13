﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TulioPaim.Results.Samples
{
    public static class FakeService
    {
        public static List<string> Names => new List<string>
            {
                "Tulio", "Daniel", "Joao", "Luca", "Andressa", "Lucas"
            };

        public static IEnumerable<string> SelectAllNames()
        {
            return Names;
        }
        
        public static string SelectFirstName()
        {
            return Names.FirstOrDefault();
        }

        public static long CountNames()
        {
            return Names.Count();
        }

        public static IEnumerable<string> SelectPaginated(int page, int pageSize)
        {
            return Names.Skip((page - 1)* pageSize).Take(pageSize);
        }

        public static Result CheckIfIsOdd()
        {
            var rand = new Random();

            var number = rand.Next(1, 100);
            if (number % 2 == 1)
            {
                var errorMessage = $"Error, {number} is odd!";

                return Result.ErrorResult(errorMessage);
            }

            var successMessage = $"Success, {number} is not odd!";

            return Result.SuccessResult(successMessage);
        }

        public static string SelectNameByIndex(int index)
        {
            return Names[index];
        }
    }
}
