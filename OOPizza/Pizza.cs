using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOPizza
{
    public enum size
    {
        Small,
        Medium,
        Large

    }

    class Pizza
    {
        public string name { get; set; }
        public List<string> toppings { get; set; }
        public size size { get; set; }
        public int slices { get; set; }
        public string notes { get; set; }
        public decimal price { get; set; }

        public Pizza()
        {
            name = "Build Your Own";
            basePrice();
        }

        public override string ToString()
        {
            string s = string.Format("{0} {1}", size, name);
            return s;
        }

        /// <summary>
        /// This method returns a string that collects
        /// all of the properties in a specific format
        /// use like toString but slightly more complicated
        /// </summary>
        /// <returns></returns>
        public string printLayout()
        {
            string notes = "";
            string nl = Environment.NewLine;

            //use the toString override to start the line with the
            //size and name
            notes += this.ToString();

            //check that there are toppings
            if (this.toppings.Count > 0)
            {
                //if there are add the Toppings heading and toppings with 8 spaces before
                notes += nl;
                notes += "    Toppings:";
                foreach (string top in toppings)
                {
                    notes += nl;
                    notes += "        " + top;
                }
            }
            //check if there are notes, if yes then add them to the layout
            if (this.notes != null)
            {
                notes += nl;
                notes += "    Notes: ";
                notes += nl;
                notes += "        " + this.notes;
            }
            //add the price on a new line
            notes += nl;
            notes += "Price: ";
            notes += price.ToString();

            return notes;

        }


        public void basePrice()
        {
            if (name == "Build Your Own")
            {
                switch (size)
                {
                    case size.Small:
                        price = 8.89m;
                        break;
                    case size.Medium:
                        price = 10.99m;
                        break;
                    case size.Large:
                        price = 12.69m;
                        break;
                }
            
            }
            else
            {
                switch (size)
                {
                    case size.Small:
                        price = 14.49m;
                        break;
                    case size.Medium:
                        price = 17.09m;
                        break;
                    case size.Large:
                        price = 19.79m;
                        break;
                }
            }
        }
    }

    class Surpreme : Pizza
    {
        public Surpreme()
        {
            name = "Surpreme";
            toppings = new List<string>()
            {
                "Sausage",
                "Pepperoni",
                "Mushrooms",
                "Green Pepper",
                "Onion"

            };

        }
    }

    class BBQChicken : Pizza
    {
        public BBQChicken()
        {
            name = "BBQ Chicken";
            toppings = new List<string>()
            {
                "Chicken",
                "BBQ Sauce",
                "Bacon",
                "Banana Peppers",
                "Onion"
            };
        }
    }

    class Hawaiian : Pizza
    {
        public Hawaiian()
        {
            name = "Hawaiian";
            toppings = new List<string>()
            {
                "Ham",
                "Bacon",
                "Pineapple"
            };
        }
    }

    class MeatLovers : Pizza
    {
        public MeatLovers()
        {
            name = "Meat Lovers";
            toppings = new List<string>()
            {
                "Sausage",
                "Pepperoni",
                "Bacon",
                "Ham",
                "beef"
            };
        }
        
    }

    class Veggy : Pizza
    {
        public Veggy()
        {
            name = "Vegetarian";
            toppings = new List<string>()
            {
                "Green Peppers",
                "Green Olives",
                "Black Olives",
                "Onion",
                "Mushrooms",
                "Tomatoes"
            };
        }
    }

    class Greek : Pizza
    {
        public Greek()
        {
            name = "Greek";
            toppings = new List<string>()
            {
                "Feta Cheese",
                "Calamata Olives",
                "Banana Peppers",
                "Tzatziki"
            };
            notes = "No pizza sauce";
        }
    }

    class Cheeseburger : Pizza
    {
        public Cheeseburger()
        {
            name = "Cheeseburger";
            toppings = new List<string>()
            {
                "Beef",
                "Katchup",
                "Mustard",
                "American Cheese"
            };
            notes = "No pizza sauce";
        }
    }
}
