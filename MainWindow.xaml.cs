using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CheeBogGrocery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Ingredient> groceries = new List<Ingredient>();
        public MainWindow()
        {
            InitializeComponent();
            groceries.Add(createIngredients("Baking Soda", 500, 2.49, "Spudshed", "g"));
            groceries.Add(createIngredients("Bao(pcs)", 6, 3.49, "Spudshed", "g"));
            groceries.Add(createIngredients("Beer Batter Chips", 750, 3.99, "NP SuperMarket", "g"));
            groceries.Add(createIngredients("Cayenne Pepper", 50, 2.00, "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Chicken Breast", 1, 6.99, "Effie's Gourmet", "kg"));
            groceries.Add(createIngredients("Chicken Salt", 1, 9.17, "Campbells", "kg"));
            groceries.Add(createIngredients("Chicken Thigh", 1, 10.49, "Effie's Gourmet", "kg"));
            groceries.Add(createIngredients("Condensed Milk", 397, 3.49, "Spudshed", "g"));
            groceries.Add(createIngredients("Cooking Salt", 2, 1.52, "Campbells", "kg"));
            groceries.Add(createIngredients("Coriander", 9, 1.79, "MCQ SuperMarket", "stems"));
            groceries.Add(createIngredients("Cumin Powder", 100, 1.99, "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Essentials Chef Canola Oil", 20, 55.89, "Campbells", "l"));
            groceries.Add(createIngredients("Essentials Chef Tomato Sauce", 4, 6.34, "Campbells", "l"));
            groceries.Add(createIngredients("Garlic Bag", 500, 2.99, "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Ginger", 1, 42.95, "MCQ SuperMarket", "kg"));
            groceries.Add(createIngredients("Graham Crackers", 28, 11.49, "NP SuperMarket", "pcs"));
            groceries.Add(createIngredients("Green Chilli", 1, 7.99, "MCQ SuperMarket", "kg"));
            groceries.Add(createIngredients("Honey", 1, 7.99, "Spudshed", "kg"));
            groceries.Add(createIngredients("KewPie Mayonnaise", 1, 14.49, "NP SuperMarket", "kg"));
            groceries.Add(createIngredients("Kikkoman Soy Sauce", 1, 8.75, "Campbells", "l"));
            groceries.Add(createIngredients("Lemon Juice", 250, 1.17, "Coles", "ml"));
            groceries.Add(createIngredients("Lime", 1, 5.99, "MCQ SuperMarket", "kg"));
            groceries.Add(createIngredients("MasterFoods Soy Sauce", 3, 17.67, "Campbells", "l"));
            groceries.Add(createIngredients("Onion", 2, 1.49, "MCQ SuperMarket", "kg"));
            groceries.Add(createIngredients("Pork", 1, 8.00, "Continental Meats", "kg"));
            groceries.Add(createIngredients("Potato Starch", 500, 4.79, "NP SuperMarket", "g"));
            groceries.Add(createIngredients("Prawns King Raw", 1, 20.99, "Effie's Gourmet", "kg"));
            groceries.Add(createIngredients("Raw Sugar", 2, 3.10, "Campbells", "kg"));
            groceries.Add(createIngredients("Red Chilli Big", 1, 13.95, "MCQ SuperMarket", "kg"));
            groceries.Add(createIngredients("Salted Butter", 5, 62.28, "Campbells", "kg"));
            groceries.Add(createIngredients("Seasoning Soy", 500, 9.95, "Coles", "ml"));
            groceries.Add(createIngredients("Sesame Seed", 1, 6.47, "Campbells", "kg"));
            groceries.Add(createIngredients("Smoked Paprika", 140, 5.80, "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Sour Cream Light", 1, 5.69, "Spudshed", "kg"));
            groceries.Add(createIngredients("Sprite", 2, 3.49, "Spudshed", "l"));
            groceries.Add(createIngredients("Sriracha Sauce", 500, 3.29, "Spudshed", "ml"));
            groceries.Add(createIngredients("Tanaka Cooking Sake", 500, 2.79, "MCQ SuperMarket", "ml"));
            groceries.Add(createIngredients("Thickened Cream", 1.2, 6.80, "Spudshed", "l"));
            groceries.Add(createIngredients("Tomato", 1, 2.99, "MCQ SuperMarket", "kg"));
            groceries.Add(createIngredients("Trumps Black Pepper", 1, 13.86, "Campbells", "kg"));
            groceries.Add(createIngredients("Vinegar", 2, 1.99, "Spudshed", "l"));
            groceries.Add(createIngredients("Whipping Cream", 1, 4.99, "Spudshed", "l"));
            groceries.Add(createIngredients("Wonton Skin", 500, 3.99, "NP SuperMarket", "g"));
            populateData();
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void populateData()
        {
            List<Dish> dishes = new List<Dish>();
            for (int i = 0; i < 8; i++)
            {
                Dish dish = new Dish();
                dishes.Add(dish);
            }


            dishes[0].name = "CHICKEN POPCORN";
            List<Ingredient> chickenPops = new List<Ingredient>();
            chickenPops.Add(getIngredient("Chicken Thigh"));
            chickenPops.Add(getIngredient("Ginger"));
            chickenPops.Add(getIngredient("Garlic Bag"));
            chickenPops.Add(getIngredient("Tanaka Cooking Sake"));
            chickenPops.Add(getIngredient("MasterFoods Soy Sauce"));
            chickenPops.Add(getIngredient("Raw Sugar"));
            chickenPops.Add(getIngredient("Potato Starch"));
            chickenPops.Add(getIngredient("Cooking Salt"));
            chickenPops.Add(getIngredient("Trumps Black Pepper"));


            chickenPops.Add(groceries[8]);
            chickenPops.Add(groceries[13]);
            chickenPops.Add(groceries[14]);
            chickenPops.Add(groceries[22]);
            chickenPops.Add(groceries[25]);
            chickenPops.Add(groceries[27]);
            chickenPops.Add(groceries[36]);
            chickenPops.Add(groceries[39]);
            dishes[0].ingredients = chickenPops;


            dishes[1].name = "CHICKEN SKEWER";



            dishes[2].name = "GRAHAM CAKE";
            dishes[3].name = "HONEY CHICKEN BAO";
            dishes[4].name = "HONEY CHICKEN POP";
            dishes[5].name = "PORK BAO";
            dishes[6].name = "PORK SKEWER";
            dishes[7].name = "PRAWN NACHOS";
        }

        //Baking Soda, 500, 2.49, Spudshed, g
        //Bao(pcs), 6, 3.49, Spudshed, g
        //Beer Batter Chips, 750, 3.99, NP SuperMarket, g
        //Cayenne Pepper, 50, 2.00, MCQ SuperMarket, g
        //Chicken Breast, 1, 6.99, Effie's Gourmet, kg
        //Chicken Salt, 1, 9.17, Campbells, kg
        //Chicken Thigh, 1, 10.49, Effie's Gourmet, kg
        //Condensed Milk, 397, 3.49, Spudshed, g
        //Cooking Salt, 2, 1.52, Campbells, kg
        //Coriander, 9, 1.79, MCQ SuperMarket, stems
        //Cumin Powder, 100, 1.99, MCQ SuperMarket, g
        //Essentials Chef Canola Oil, 20, 55.89, Campbells, l
        //Essentials Chef Tomato Sauce, 4, 6.34, Campbells, l
        //Garlic Bag, 500, 2.99, MCQ SuperMarket, g
        //Ginger, 1, 42.95, MCQ SuperMarket, kg
        //Graham Crackers, 28, 11.49, NP SuperMarket, pcs
        //Green Chilli, 1, 7.99, MCQ SuperMarket, kg
        //Honey, 1, 7.99, Spudshed, kg
        //KewPie Mayonnaise, 1, 14.49, NP SuperMarket, kg
        //Kikkoman Soy Sauce, 1, 8.75, Campbells, l
        //Lemon Juice, 250, 1.17, Coles, ml
        //Lime, 1, 5.99, MCQ SuperMarket, kg
        //MasterFoods Soy Sauce, 3, 17.67, Campbells, l
        //Onion, 2, 1.49, MCQ SuperMarket, kg
        //Pork, 1, 8.00, Continental Meats, kg
        //Potato Starch, 500, 4.79, NP SuperMarket, g
        //Prawns King Raw, 1, 20.99, Effie's Gourmet, kg
        //Raw Sugar, 2, 3.10, Campbells, kg
        //Red Chilli Big, 1, 13.95, MCQ SuperMarket, kg
        //Salted Butter, 5, 62.28, Campbells, kg
        //Seasoning Soy, 500, 9.95, Coles, ml
        //Sesame Seed, 1, 6.47, Campbells, kg
        //Smoked Paprika, 140, 5.80, MCQ SuperMarket, g
        //Sour Cream Light, 1, 5.69, Spudshed, kg
        //Sprite, 2, 3.49, Spudshed, l
        //Sriracha Sauce, 500, 3.29, Spudshed, ml
        //Tanaka Cooking Sake, 500, 2.79, MCQ SuperMarket, ml
        //Thickened Cream, 1.2, 6.80, Spudshed, l
        //Tomato, 1, 2.99, MCQ SuperMarket, kg
        //Trumps Black Pepper, 1, 13.86, Campbells, kg
        //Vinegar, 2, 1.99, Spudshed, l
        //Whipping Cream, 1, 4.99, Spudshed, l
        //Wonton Skin, 500, 3.99, NP SuperMarket, g

        private Ingredient getIngredient(string name)
        {
           var index = groceries.FirstOrDefault(o => o.name == name);
           return index;
        }

        private Ingredient createIngredients(string name, double weight, double cost, string location, string metric)
        {
            Ingredient ingredient = new Ingredient();
            ingredient.name = name;
            ingredient.weight = weight;
            ingredient.cost = cost;
            ingredient.location = location;
            ingredient.metric = metric;
            return ingredient;
        }
    }
}
