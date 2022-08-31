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
        private List<Dish> dishes = new List<Dish>();

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
            setMenuNames();
            textBoxHeadingTitle.Text = dishes[0].name;
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonMenu1_Click(object sender, RoutedEventArgs e)
        {
            setHeading(0);
        }

        private void buttonMenu2_Click(object sender, RoutedEventArgs e)
        {
            setHeading(1);
        }

        private void buttonMenu3_Click(object sender, RoutedEventArgs e)
        {
            setHeading(2);

        }

        private void buttonMenu4_Click(object sender, RoutedEventArgs e)
        {
            setHeading(3);
        }

        private void buttonMenu5_Click(object sender, RoutedEventArgs e)
        {
            setHeading(4);
        }

        private void buttonMenu6_Click(object sender, RoutedEventArgs e)
        {
            setHeading(5);
        }

        private void buttonMenu7_Click(object sender, RoutedEventArgs e)
        {
            setHeading(6);
        }
        // button will populate ingredients
        // change heading text
        private void buttonMenu8_Click(object sender, RoutedEventArgs e)
        {
            setHeading(7);
        }

        private void setHeading(int dishNumber)
        {
            textBoxHeadingTitle.Text = dishes[dishNumber].name;
        }
        #region Populate
        private void populateData()
        {
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
            dishes[0].ingredients = chickenPops;

            dishes[1].name = "CHICKEN SKEWER";
            List<Ingredient> chickenSkewer = new List<Ingredient>();
            chickenSkewer.Add(getIngredient("Baking Soda"));
            chickenSkewer.Add(getIngredient("Chicken Breast"));
            chickenSkewer.Add(getIngredient("Cooking Salt"));
            chickenSkewer.Add(getIngredient("Essentials Chef Tomato Sauce"));
            chickenSkewer.Add(getIngredient("Garlic Bag"));
            chickenSkewer.Add(getIngredient("Masterfoods Soy Sauce"));
            chickenSkewer.Add(getIngredient("Raw Sugar"));
            chickenSkewer.Add(getIngredient("Sprite"));
            chickenSkewer.Add(getIngredient("Trumps Black Pepper"));
            dishes[1].ingredients = chickenSkewer;

            dishes[2].name = "GRAHAM CAKE";
            List<Ingredient> grahamCake = new List<Ingredient>();
            grahamCake.Add(getIngredient("Condensed Milk"));
            grahamCake.Add(getIngredient("Graham Crackers"));
            grahamCake.Add(getIngredient("Thickened Cream"));
            dishes[2].ingredients = grahamCake;

            dishes[3].name = "HONEY CHICKEN BAO";
            List<Ingredient> honeyChickenBao = new List<Ingredient>();
            honeyChickenBao.Add(getIngredient("Bao(pcs)"));
            honeyChickenBao.Add(getIngredient("Chicken Thigh"));
            honeyChickenBao.Add(getIngredient("Cooking Salt"));
            honeyChickenBao.Add(getIngredient("Garlic Bag"));
            honeyChickenBao.Add(getIngredient("Ginger"));
            honeyChickenBao.Add(getIngredient("Honey"));
            honeyChickenBao.Add(getIngredient("Kewpie Mayonnaise"));
            honeyChickenBao.Add(getIngredient("Potato Starch"));
            honeyChickenBao.Add(getIngredient("Raw Sugar"));
            honeyChickenBao.Add(getIngredient("Salted Butter"));
            honeyChickenBao.Add(getIngredient("Tanaka Cooking Sake"));
            honeyChickenBao.Add(getIngredient("Trumps Black Pepper"));
            dishes[3].ingredients = honeyChickenBao;

            dishes[4].name = "HONEY CHICKEN POP";
            List<Ingredient> honeyChickenPop = new List<Ingredient>();
            honeyChickenPop.Add(getIngredient("Chicken Thigh"));
            honeyChickenPop.Add(getIngredient("Cooking Salt"));
            honeyChickenPop.Add(getIngredient("Garlic Bag"));
            honeyChickenPop.Add(getIngredient("Ginger"));
            honeyChickenPop.Add(getIngredient("Honey"));
            honeyChickenPop.Add(getIngredient("Kewpie Mayonnaise"));
            honeyChickenPop.Add(getIngredient("Potato Starch"));
            honeyChickenPop.Add(getIngredient("Raw Sugar"));
            honeyChickenPop.Add(getIngredient("Salted Butter"));
            honeyChickenPop.Add(getIngredient("Tanaka Cooking Sake"));
            honeyChickenPop.Add(getIngredient("Trumps Black Pepper"));
            dishes[4].ingredients = honeyChickenPop;

            dishes[5].name = "PORK BAO";
            List<Ingredient> porkBao = new List<Ingredient>();
            porkBao.Add(getIngredient("Bao(pcs)"));
            porkBao.Add(getIngredient("Cooking Salt"));
            porkBao.Add(getIngredient("KewPie Mayonnaise"));
            porkBao.Add(getIngredient("Kikkoman Soy Sauce"));
            porkBao.Add(getIngredient("Lemon Juice"));
            porkBao.Add(getIngredient("Onion"));
            porkBao.Add(getIngredient("Pork"));
            porkBao.Add(getIngredient("Red Chilli Big"));
            porkBao.Add(getIngredient("Seasoning Soy"));
            porkBao.Add(getIngredient("Trumps Black Pepper"));
            dishes[5].ingredients = porkBao;

            dishes[6].name = "PORK SKEWER";
            List<Ingredient> porkSkewer = new List<Ingredient>();
            porkSkewer.Add(getIngredient("Bakiong Soda"));
            porkSkewer.Add(getIngredient("Cooking Salt"));
            porkSkewer.Add(getIngredient("Essentials Chef Tomato Sauce"));
            porkSkewer.Add(getIngredient("Garlic Bag"));
            porkSkewer.Add(getIngredient("MasterFoods Soy Sauce"));
            porkSkewer.Add(getIngredient("Pork"));
            porkSkewer.Add(getIngredient("Raw Sugar"));
            porkSkewer.Add(getIngredient("Sprite"));
            porkSkewer.Add(getIngredient("Trumps Black Pepper"));
            dishes[6].ingredients = porkSkewer;

            dishes[7].name = "PRAWN NACHOS";
            List<Ingredient> prawnNachos = new List<Ingredient>();
            prawnNachos.Add(getIngredient("Cayenne Pepper"));
            prawnNachos.Add(getIngredient("Coriander"));
            prawnNachos.Add(getIngredient("Cumin Powder"));
            prawnNachos.Add(getIngredient("Onion"));
            prawnNachos.Add(getIngredient("Prawns King Raw"));
            prawnNachos.Add(getIngredient("Smoked Paprika"));
            prawnNachos.Add(getIngredient("Sour Cream Light"));
            prawnNachos.Add(getIngredient("Sriracha Sauce"));
            prawnNachos.Add(getIngredient("Tomato"));
            dishes[7].ingredients = prawnNachos;
        }

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

        private void setMenuNames()
        {
            buttonMenu1.Content = dishes[0].name;
            buttonMenu2.Content = dishes[1].name;
            buttonMenu3.Content = dishes[2].name;
            buttonMenu4.Content = dishes[3].name;
            buttonMenu5.Content = dishes[4].name;
            buttonMenu6.Content = dishes[5].name;
            buttonMenu7.Content = dishes[6].name;
            buttonMenu8.Content = dishes[7].name;
        }
        #endregion
    }
}
