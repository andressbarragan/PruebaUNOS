

namespace UNOSquare.Models
{
	internal class ItemCollection
	{
        public ItemCollection(string branch, string model, string year)
        {
            Branch = branch;
            Model = model;
            Year = year;
        }

        public string Branch { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }
    }
}
