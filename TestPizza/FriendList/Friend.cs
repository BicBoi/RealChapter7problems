using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FriendList
{
    class Friend : IComparable
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        int IComparable.CompareTo(Object o)
        {
            Friend temp = (Friend)o;
            return this.Name.CompareTo(temp.Name);
        }
    }
}