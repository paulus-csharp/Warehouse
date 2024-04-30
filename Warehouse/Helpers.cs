namespace Warehouse
{
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
}