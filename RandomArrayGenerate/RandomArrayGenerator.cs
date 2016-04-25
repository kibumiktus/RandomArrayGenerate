using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArrayGenerate
{
    public class RandomArrayGenerator
    {
        private const int valueFromIndexIncrement = 1;
        private int _size;

        public RandomArrayGenerator(int size)
        {
            _size = size;
        }

        public int[] Generate()
        {
            Random _random = new Random();
            return Enumerable.Range(0, _size)
                        .Select(sortValue => _random.Next(_size))
                        .Select((sortValue, index) => new { randomValue = index, sortValue = sortValue })
                        .OrderBy(item => item.sortValue)
                        .Select(item => item.randomValue + valueFromIndexIncrement)
                        .ToArray();
        }


    }
}
