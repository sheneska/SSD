using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int RegularCone = 50;
        static int WaffleCone = 25;
        static int SugarCone = 10;

        static int ChocolateFlavor = 2560;
        static int VanillaFlavor = 6400;

        static int ChocolateTopping = 640;
        static int CaramelTopping = 256;

        static int ChocolateChipSprinkles = 16;
        static int ColoredSprinkles = 16;
        static int Marshmallows = 16;

        public void Cones(string TypeOfCone)
        {
            if (TypeOfCone.ToLower() == "regular")
            {
                RegularCone--;
            }
            else if (TypeOfCone.ToLower() == "waffle")
            {
                WaffleCone--;
            }
            else
            {
                SugarCone--;

            }

        }

        public void IceCream(string TypeOfFlavor)
        {
            if (TypeOfFlavor.ToLower() == "chocolate")
            {
                ChocolateFlavor -= 8;
            }
            else
            {
                VanillaFlavor -= 8;
            }
        }

        public void Topping(string TypeOfTopping)
        {
            if(TypeOfTopping.ToLower() == "chocolate")
            {
                ChocolateTopping -= 4;
            }
            else
            {
                CaramelTopping -= 4;
            }
        }

        public void Sprinkles(string TypeOfSprinkle)
        {
            if(TypeOfSprinkle.ToLower() == "chocolate chip")
            {
                ChocolateChipSprinkles -= 2;
            }
            else if(TypeOfSprinkle.ToLower() == "colored")
            {
                ColoredSprinkles -= 2;
            }
            else
            {
                Marshmallows -= 2;
            }
        }

        public bool check(string TypeOfCone, string TypeOfFlavor, string TypeOfTopping, string TypeOfSprinkle)
        {
            //Validating cone entries 
            if(TypeOfCone.ToLower() == "regular")
            {
                if (RegularCone-1 < 0)
                {
                    MessageBox.Show("Cone Type out of stock.Please place a new order.");
                    return false;
                }
            }
            else if(TypeOfCone.ToLower() == "sugar")
            {
                if (SugarCone-1 < 0)
                {
                    MessageBox.Show("Cone Type out of stock.Please place a new order.");
                    return false;
                }
            }
            else if(TypeOfCone.ToLower() == "waffle")
            {
                if (WaffleCone-1 < 0)
                {
                    MessageBox.Show("Cone Type out of stock.Please place a new order.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error, Invalid.");
                return false;
            }

            //Validating Ice Cream Flavor entries
            if (TypeOfFlavor.ToLower() == "vanilla" )
            {
                if (VanillaFlavor-8 < 0)
                {
                    MessageBox.Show("Flavor out of stock.Please place a new order.");
                    return false;
                }
            }
            else if (TypeOfFlavor.ToLower() == "chocolate")
            {
                if (ChocolateFlavor-8 < 0)
                {
                    MessageBox.Show("Flavor out of stock.Please place a new order.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error, Invalid.");
                return false;
            }

            //Validating Toppings entries
            if (TypeOfTopping.ToLower() == "chocolate")
            {
                if (ChocolateTopping-4 < 0)
                {
                    MessageBox.Show("Topping out of stock.Please place a new order.");
                    return false;
                }
            }
            else if (TypeOfTopping.ToLower() == "caramel")
            {
                if (ChocolateFlavor-4 < 0)
                {
                    MessageBox.Show("Topping out of stock.Please place a new order.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error, Invalid.");
                return false;
            }

            //Validating Sprinkles entries
            if (TypeOfSprinkle.ToLower() == "chocolate chip")
            {
                if (ChocolateChipSprinkles-2 < 0)
                {
                    MessageBox.Show("Sprinkle out of stock.Please place a new order.");
                    return false;
                }
            }
            else if (TypeOfSprinkle.ToLower() == "colored")
            {
                if (ChocolateChipSprinkles-2 < 0)
                {
                    MessageBox.Show("Sprinkle out of stock.Please place a new order.");
                    return false;
                }
            }
            else if (TypeOfSprinkle.ToLower() == "marshmallows")
            {
                if (Marshmallows-2 < 0)
                {
                    MessageBox.Show("Sprinkle out of stock.Please place a new order.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error, Invalid.");
                return false;
            }



            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypeOfCone;
            string TypeOfFlavor;
            string TypeOfTopping;
            string TypeOfSprinkle;

            //Get user input
            TypeOfCone = ConesRemaining.Text;
            TypeOfFlavor = IceCreamRemaining.Text;
            TypeOfTopping = ToppingsRemaining.Text;
            TypeOfSprinkle = SprinklesRemaining.Text;

            if (check(TypeOfCone, TypeOfFlavor, TypeOfTopping, TypeOfSprinkle))
            {
                Cones(TypeOfCone);
                IceCream(TypeOfFlavor);
                Topping(TypeOfTopping);
                Sprinkles(TypeOfSprinkle);

                ConesRemaining.Text = "Regular: " + RegularCone + "\nSugar: " + SugarCone + "\nWaffle:" + WaffleCone;
                IceCreamRemaining.Text = "Chocolate: " + ChocolateFlavor + "\nVanilla: " + VanillaFlavor;
                ToppingsRemaining.Text = "Chocolate: " + ChocolateTopping + "\nCaramel: " + CaramelTopping;
                SprinklesRemaining.Text = "Chocolate chip: " + ChocolateChipSprinkles + "\nColored: " + ColoredSprinkles + "\nMarshmallows: " + Marshmallows;
            }
        }
    }
}
