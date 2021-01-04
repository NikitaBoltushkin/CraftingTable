using System;
using System.Collections.Generic;
using System.Text;

namespace CraftingTable
{
    public class Tool
    {
        private int _totalIndex;
        private int _totalWeight;

        public Tool(int totalIndex, int totalWeight)
        {
            _totalIndex = totalIndex;
            _totalWeight = totalWeight;
        }
        public int GetTotalIndex()
        {
            return _totalIndex;
        }
        public int GetTotalWeight()
        {
            return _totalWeight;
        }
    }
}
