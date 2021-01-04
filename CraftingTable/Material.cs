using System;
using System.Collections.Generic;
using System.Text;

namespace CraftingTable
{
    public class Material
    {
        private string _name;
        private int _weight;
        private int _index;

        public Material()
        {
            _name = "Empty";
            _index = 0;
            _weight = 0;
        }
        public Material(int index, int weight)
        {
            _index = index;
            _weight = weight;
        }
        public Material(string name,int index, int weight)
        {
            _name = name;
            _index = index;
            _weight = weight;
        }
        
        public string GetName()
        {
            return _name;
        }
        public int GetIndex()
        {
            return _index;
        }
        public int GetWeight()
        {
            return _weight;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public static Material operator +(Material first, Material second)
        {
            return new Material(first.GetIndex() + second.GetIndex(),first.GetWeight()+second.GetWeight());
        }


    }
}
