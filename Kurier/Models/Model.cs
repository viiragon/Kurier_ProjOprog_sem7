using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPSNET.Models
{
    public class Model : IModel
    {
        public int sumNumbers(int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}