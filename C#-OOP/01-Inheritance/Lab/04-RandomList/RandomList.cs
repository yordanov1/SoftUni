using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();

        public string RandomString()
        {
            var elementIndex = random.Next(0, this.Count);

            return this[elementIndex];
        }
    }
}
