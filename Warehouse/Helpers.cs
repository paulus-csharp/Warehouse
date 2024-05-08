using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse;

public class Helpers
{
    public int GiveMeNumber()
    {
        SomeStructure stru = new SomeStructure();
            
        int number = 5;
        return number;
    }

    public enum ItemType
    {
        Grocery,
        Clothing,
        Electronics
    }

    public class ItemService
    {
        public void AddItem()
        { }

        public void RemoveItem()
        { }
    }

    public struct SomeStructure
    {
        private int numberForStructure;
        private string nameOfStructure;

        public SomeStructure(int number, string name)
        {
            numberForStructure = number;
            nameOfStructure = name;
        }
    }
}