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
        private int current = -1;

        public MainWindow()
        {
            InitializeComponent();
            #region Database
            groceries.Add(createIngredients("Baking Soda", "500", "2.49", "Spudshed", "g"));
            groceries.Add(createIngredients("Bao", "6", "3.49", "Spudshed", "pcs"));
            groceries.Add(createIngredients("Beer Batter Chips", "750", "3.99", "NP SuperMarket", "g"));
            groceries.Add(createIngredients("Cayenne Pepper", "50", "2.00", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Chicken Breast", "1000", "6.99", "Effie's Gourmet", "g"));
            groceries.Add(createIngredients("Chicken Salt", "1000", "9.17", "Campbells", "g"));
            groceries.Add(createIngredients("Chicken Thigh", "1000", "10.49", "Effie's Gourmet", "g"));
            groceries.Add(createIngredients("Condensed Milk", "397", "3.49", "Spudshed", "g"));
            groceries.Add(createIngredients("Cooking Salt", "2000", "1.52", "Campbells", "g"));
            groceries.Add(createIngredients("Coriander", "9", "1.79", "MCQ SuperMarket", "stems"));
            groceries.Add(createIngredients("Cumin Powder", "100", "1.99", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Essentials Chef Canola Oil", "20000", "55.89", "Campbells", "ml"));
            groceries.Add(createIngredients("Essentials Chef Tomato Sauce", "4000", "6.34", "Campbells", "ml"));
            groceries.Add(createIngredients("Garlic Bag", "500", "2.99", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Ginger", "1000", "42.95", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Graham Crackers", "28", "11.49", "NP SuperMarket", "pcs"));
            groceries.Add(createIngredients("Green Chilli", "1000", "7.99", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Honey", "1000", "7.99", "Spudshed", "g"));
            groceries.Add(createIngredients("KewPie Mayonnaise", "1000", "14.49", "NP SuperMarket", "g"));
            groceries.Add(createIngredients("Kikkoman Soy Sauce", "1000", "8.75", "Campbells", "ml"));
            groceries.Add(createIngredients("Lemon Juice", "250", "1.17", "Coles", "ml"));
            groceries.Add(createIngredients("Lime", "1000", "5.99", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("MasterFoods Soy Sauce", "3000", "17.67", "Campbells", "ml"));
            groceries.Add(createIngredients("Onion", "2000", "1.49", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Pork", "1000", "8.00", "Continental Meats", "g"));
            groceries.Add(createIngredients("Potato Starch", "500", "4.79", "NP SuperMarket", "g"));
            groceries.Add(createIngredients("Prawns King Raw", "1000", "20.99", "Effie's Gourmet", "g"));
            groceries.Add(createIngredients("Raw Sugar", "2000", "3.10", "Campbells", "g"));
            groceries.Add(createIngredients("Red Chilli Big", "1000", "13.95", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Salted Butter", "5000", "62.28", "Campbells", "g"));
            groceries.Add(createIngredients("Seasoning Soy", "500", "9.95", "Coles", "ml"));
            groceries.Add(createIngredients("Sesame Seed", "1000", "6.47", "Campbells", "g"));
            groceries.Add(createIngredients("Smoked Paprika", "140", "5.80", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Sour Cream Light", "1000", "5.69", "Spudshed", "g"));
            groceries.Add(createIngredients("Sprite", "2000", "3.49", "Spudshed", "ml"));
            groceries.Add(createIngredients("Sriracha Sauce", "500", "3.29", "Spudshed", "ml"));
            groceries.Add(createIngredients("Tanaka Cooking Sake", "500", "2.79", "MCQ SuperMarket", "ml"));
            groceries.Add(createIngredients("Thickened Cream", "1200", "6.80", "Spudshed", "ml"));
            groceries.Add(createIngredients("Tomato", "1000", "2.99", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Trumps Black Pepper", "1000", "13.86", "Campbells", "g"));
            groceries.Add(createIngredients("Vinegar", "2000", "1.99", "Spudshed", "ml"));
            groceries.Add(createIngredients("Whipping Cream", "1000", "4.99", "Spudshed", "ml"));
            groceries.Add(createIngredients("Wonton Skin", "500", "3.99", "NP SuperMarket", "g"));
            #endregion
            populateData();
            setMenuNames();
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
            current = 0;
        }

        private void buttonMenu2_Click(object sender, RoutedEventArgs e)
        {
            setHeading(1);
            current = 1;
        }

        private void buttonMenu3_Click(object sender, RoutedEventArgs e)
        {
            setHeading(2);
            current = 2;


        }
        private void buttonMenu4_Click(object sender, RoutedEventArgs e)
        {
            setHeading(3);
            current = 3;
        }
        private void buttonMenu5_Click(object sender, RoutedEventArgs e)
        {
            setHeading(4);
            current = 4;

        }
        private void buttonMenu6_Click(object sender, RoutedEventArgs e)
        {
            setHeading(5);
            current = 5;

        }
        private void buttonMenu7_Click(object sender, RoutedEventArgs e)
        {
            setHeading(6);
            current = 6;

        }

        private void buttonMenu8_Click(object sender, RoutedEventArgs e)
        {
            setHeading(7);
            current = 7;
        }
        private void listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Enter)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void setHeading(int dishNumber)
        {
            textBoxHeadingTitle.Text = dishes[dishNumber].name;
        }
        // button will populate ingredients
        // change heading text
        private void populateListView(int dishNumber)
        {
            listView.Items.Clear();
            for (int i = 0; i < dishes[dishNumber].ingredients.Count; i++)
            {
                listView.Items.Add(dishes[dishNumber].ingredients[i]);
            }
        }

        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {
            if(current >= 0)
            {
                switch (current)
                {
                    case 0:
                        dishes[0].ingredients = resetChickenPops(); // Switch case this to resetDifferentDish
                        break;
                    case 1:
                        dishes[1].ingredients = resetChickenSkewer();
                        break;
                    case 2:
                        dishes[2].ingredients = resetGrahamCake();
                        break;
                    case 3:
                        dishes[3].ingredients = resetHoneyChickenBao();
                        break;
                    case 4:
                        dishes[4].ingredients = resetChickenPops();
                        break;
                    case 5:
                        dishes[5].ingredients = resetChickenPops();
                        break;
                    case 6:
                        dishes[6].ingredients = resetChickenPops();
                        break;
                    case 7:
                        dishes[7].ingredients = resetChickenPops();
                        break;
                }
                int servings = int.Parse(textBoxInput.Text);
                dishes[current].updateIngredients(servings);
                dishes[current].addPrefix();
                populateListView(current);
            }
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
            dishes[0].ingredients = resetChickenPops();
            dishes[0].servings = 10;
            dishes[0].updateIngredients(10);
            dishes[0].addPrefix();

            dishes[1].name = "CHICKEN SKEWER";
            dishes[1].ingredients = resetChickenSkewer();
            dishes[1].servings = 52;
            dishes[1].updateIngredients(52);
            dishes[1].addPrefix();

            dishes[2].name = "GRAHAM CAKE";
            dishes[2].ingredients = resetGrahamCake();
            dishes[2].servings = 12;
            dishes[2].updateIngredients(12);
            dishes[2].addPrefix();

            dishes[3].name = "HONEY CHICKEN BAO";
            dishes[3].ingredients = resetHoneyChickenBao();
            dishes[3].servings = 15;
            dishes[3].updateIngredients(15);
            dishes[3].addPrefix();

            dishes[4].name = "HONEY CHICKEN POP";
            dishes[4].ingredients = resetHoneyChickenPop();
            dishes[4].servings = 10;
            dishes[4].updateIngredients(10);
            dishes[4].addPrefix();

            dishes[5].name = "PORK BAO";
            dishes[5].ingredients = resetPorkBao();
            dishes[5].servings = 24;
            dishes[5].updateIngredients(24);
            dishes[5].addPrefix();


            dishes[6].name = "PORK SKEWER";
            dishes[6].ingredients = resetPorkSkewer();
            dishes[6].servings = 50;
            dishes[6].updateIngredients(50);
            dishes[6].addPrefix();

            dishes[7].name = "PRAWN NACHOS";
            dishes[7].ingredients = resetPrawnNachos();
            dishes[7].servings = 14;
            dishes[7].updateIngredients(14);
            dishes[7].addPrefix();
        }

        private Ingredient getIngredient(string name)
        {
           var index = groceries.FirstOrDefault(o => o.name == name);
           return index;
        }
        private List<Ingredient> resetChickenPops()
        {
            List<Ingredient> chickenPops = new List<Ingredient>();
            chickenPops.Add(getIngredient("Chicken Thigh"));
            chickenPops.Add(getIngredient("Ginger"));
            chickenPops.Add(getIngredient("Garlic Bag"));
            chickenPops.Add(getIngredient("Tanaka Cooking Sake"));
            chickenPops.Add(getIngredient("Raw Sugar"));
            chickenPops.Add(getIngredient("Potato Starch"));
            chickenPops.Add(getIngredient("Cooking Salt"));
            chickenPops.Add(getIngredient("Trumps Black Pepper"));

            // Dish update example
            chickenPops[0].weight = "1000";
            chickenPops[1].weight = "62.5";
            chickenPops[2].weight = "24";
            chickenPops[3].weight = "44";
            chickenPops[4].weight = "12";
            chickenPops[5].weight = "190";
            chickenPops[6].weight = "3";
            chickenPops[7].weight = "1.2";

            // Change cost
            chickenPops[0].cost = "5.09";
            chickenPops[1].cost = "2.69";
            chickenPops[2].cost = "0.70";
            chickenPops[3].cost = "0.25";
            chickenPops[4].cost = "0.04";
            chickenPops[5].cost = "1.82";
            chickenPops[6].cost = "0.002";
            chickenPops[7].cost = "0.02";

            return chickenPops;
        }

        private List<Ingredient> resetChickenSkewer()
        {
            List<Ingredient> chickenSkewer = new List<Ingredient>();
            chickenSkewer.Add(getIngredient("Baking Soda"));
            chickenSkewer.Add(getIngredient("Chicken Breast"));
            chickenSkewer.Add(getIngredient("Cooking Salt"));
            chickenSkewer.Add(getIngredient("Essentials Chef Tomato Sauce"));
            chickenSkewer.Add(getIngredient("Garlic Bag"));
            chickenSkewer.Add(getIngredient("MasterFoods Soy Sauce"));
            chickenSkewer.Add(getIngredient("Raw Sugar"));
            chickenSkewer.Add(getIngredient("Sprite"));
            chickenSkewer.Add(getIngredient("Trumps Black Pepper"));

            // Dish update example
            chickenSkewer[0].weight = "29";
            chickenSkewer[1].weight = "5";
            chickenSkewer[2].weight = "576";
            chickenSkewer[3].weight = "472";
            chickenSkewer[4].weight = "20";
            chickenSkewer[5].weight = "480";
            chickenSkewer[6].weight = "1200";
            chickenSkewer[7].weight = "1400";
            chickenSkewer[8].weight = "234";

            // Change cost
            chickenSkewer[0].cost = "0.10";
            chickenSkewer[1].cost = "48.93";
            chickenSkewer[2].cost = "0.48";
            chickenSkewer[3].cost = "0.75";
            chickenSkewer[4].cost = "0.06";
            chickenSkewer[5].cost = "2.83";
            chickenSkewer[6].cost = "3.72";
            chickenSkewer[7].cost = "2.44";
            chickenSkewer[8].cost = "3.24";

            return chickenSkewer;
        }
        
        private List<Ingredient> resetGrahamCake()
        {
            List<Ingredient> grahamCake = new List<Ingredient>();
            grahamCake.Add(getIngredient("Condensed Milk"));
            grahamCake.Add(getIngredient("Graham Crackers"));
            grahamCake.Add(getIngredient("Thickened Cream"));

            // Dish update example
            grahamCake[0].weight = "397";
            grahamCake[1].weight = "13";
            grahamCake[2].weight = "1200";

            // Change cost
            grahamCake[0].cost = "1.50";
            grahamCake[1].cost = "5.53";
            grahamCake[2].cost = "6.80";

            return grahamCake;
        }

        private List<Ingredient> resetHoneyChickenBao()
        {
            List<Ingredient> honeyChickenBao = new List<Ingredient>();
            honeyChickenBao.Add(getIngredient("Bao"));
            honeyChickenBao.Add(getIngredient("Chicken Thigh"));
            honeyChickenBao.Add(getIngredient("Cooking Salt"));
            honeyChickenBao.Add(getIngredient("Garlic Bag"));
            honeyChickenBao.Add(getIngredient("Ginger"));
            honeyChickenBao.Add(getIngredient("Honey"));
            honeyChickenBao.Add(getIngredient("KewPie Mayonnaise"));
            honeyChickenBao.Add(getIngredient("Potato Starch"));
            honeyChickenBao.Add(getIngredient("Raw Sugar"));
            honeyChickenBao.Add(getIngredient("Salted Butter"));
            honeyChickenBao.Add(getIngredient("Tanaka Cooking Sake"));
            honeyChickenBao.Add(getIngredient("Trumps Black Pepper"));

            // Dish update example
            honeyChickenBao[0].weight = "15";
            honeyChickenBao[1].weight = "1000";
            honeyChickenBao[2].weight = "3";
            honeyChickenBao[3].weight = "24";
            honeyChickenBao[4].weight = "62.5";
            honeyChickenBao[5].weight = "42";
            honeyChickenBao[6].weight = "29";
            honeyChickenBao[7].weight = "190";
            honeyChickenBao[8].weight = "12";
            honeyChickenBao[9].weight = "28";
            honeyChickenBao[10].weight = "44";
            honeyChickenBao[11].weight = "1.2";

            // Change cost
            honeyChickenBao[0].cost = "8.73";
            honeyChickenBao[1].cost = "5.09";
            honeyChickenBao[2].cost = "0.00";
            honeyChickenBao[3].cost = "0.70";
            honeyChickenBao[4].cost = "2.69";
            honeyChickenBao[5].cost = "0.34";
            honeyChickenBao[6].cost = "0.36";
            honeyChickenBao[7].cost = "1.82";
            honeyChickenBao[8].cost = "0.04";
            honeyChickenBao[9].cost = "0.22";
            honeyChickenBao[10].cost = "0.25";
            honeyChickenBao[11].cost = "0.02";

            return honeyChickenBao;
        }

        private List<Ingredient> resetHoneyChickenPop()
        {
            List<Ingredient> honeyChickenPop = new List<Ingredient>();
            honeyChickenPop.Add(getIngredient("Chicken Thigh"));
            honeyChickenPop.Add(getIngredient("Cooking Salt"));
            honeyChickenPop.Add(getIngredient("Garlic Bag"));
            honeyChickenPop.Add(getIngredient("Ginger"));
            honeyChickenPop.Add(getIngredient("Honey"));
            honeyChickenPop.Add(getIngredient("KewPie Mayonnaise"));
            honeyChickenPop.Add(getIngredient("Potato Starch"));
            honeyChickenPop.Add(getIngredient("Raw Sugar"));
            honeyChickenPop.Add(getIngredient("Salted Butter"));
            honeyChickenPop.Add(getIngredient("Tanaka Cooking Sake"));
            honeyChickenPop.Add(getIngredient("Trumps Black Pepper"));

            // Dish update example
            honeyChickenPop[0].weight = "1000";
            honeyChickenPop[1].weight = "3";
            honeyChickenPop[2].weight = "28";
            honeyChickenPop[3].weight = "24";
            honeyChickenPop[4].weight = "62.5";
            honeyChickenPop[5].weight = "42";
            honeyChickenPop[6].weight = "29";
            honeyChickenPop[7].weight = "190";
            honeyChickenPop[8].weight = "12";
            honeyChickenPop[9].weight = "44";
            honeyChickenPop[10].weight = "1.2";

            // Change cost
            honeyChickenPop[0].cost = "5.09";
            honeyChickenPop[1].cost = "0.00";
            honeyChickenPop[2].cost = "0.22";
            honeyChickenPop[3].cost = "0.70";
            honeyChickenPop[4].cost = "2.69";
            honeyChickenPop[5].cost = "0.34";
            honeyChickenPop[6].cost = "0.36";
            honeyChickenPop[7].cost = "1.82";
            honeyChickenPop[8].cost = "0.04";
            honeyChickenPop[9].cost = "0.25";
            honeyChickenPop[10].cost = "0.02";

            return honeyChickenPop;
        }

        private List<Ingredient> resetPorkBao()
        {
            List<Ingredient> porkBao = new List<Ingredient>();
            porkBao.Add(getIngredient("Bao"));
            porkBao.Add(getIngredient("Cooking Salt"));
            porkBao.Add(getIngredient("KewPie Mayonnaise"));
            porkBao.Add(getIngredient("Kikkoman Soy Sauce"));
            porkBao.Add(getIngredient("Lemon Juice"));
            porkBao.Add(getIngredient("Onion"));
            porkBao.Add(getIngredient("Pork"));
            porkBao.Add(getIngredient("Red Chilli Big"));
            porkBao.Add(getIngredient("Seasoning Soy"));
            porkBao.Add(getIngredient("Trumps Black Pepper"));

            // Dish update example
            porkBao[0].weight = "24";
            porkBao[1].weight = "17";
            porkBao[2].weight = "43";
            porkBao[3].weight = "15";
            porkBao[4].weight = "44";
            porkBao[5].weight = "480";
            porkBao[6].weight = "2000";
            porkBao[7].weight = "75";
            porkBao[8].weight = "45";
            porkBao[9].weight = "2";

            // Change cost
            porkBao[0].cost = "13.96";
            porkBao[1].cost = "0.01";
            porkBao[2].cost = "0.53";
            porkBao[3].cost = "0.13";
            porkBao[4].cost = "0.21";
            porkBao[5].cost = "0.36";
            porkBao[6].cost = "17.28";
            porkBao[7].cost = "1.05";
            porkBao[8].cost = "0.90";
            porkBao[9].cost = "0.03";

            return porkBao;
        }

        private List<Ingredient> resetPorkSkewer()
        {
            List<Ingredient> porkSkewer = new List<Ingredient>();
            porkSkewer.Add(getIngredient("Baking Soda"));
            porkSkewer.Add(getIngredient("Cooking Salt"));
            porkSkewer.Add(getIngredient("Essentials Chef Tomato Sauce"));
            porkSkewer.Add(getIngredient("Garlic Bag"));
            porkSkewer.Add(getIngredient("MasterFoods Soy Sauce"));
            porkSkewer.Add(getIngredient("Pork"));
            porkSkewer.Add(getIngredient("Raw Sugar"));
            porkSkewer.Add(getIngredient("Sprite"));
            porkSkewer.Add(getIngredient("Trumps Black Pepper"));

            // Dish update example
            porkSkewer[0].weight = "43";
            porkSkewer[1].weight = "576";
            porkSkewer[2].weight = "472";
            porkSkewer[3].weight = "20";
            porkSkewer[4].weight = "5000";
            porkSkewer[5].weight = "1000";
            porkSkewer[6].weight = "480";
            porkSkewer[7].weight = "1400";
            porkSkewer[8].weight = "234";

            // Change cost
            porkSkewer[0].cost = "0.15";
            porkSkewer[1].cost = "0.48";
            porkSkewer[2].cost = "0.75";
            porkSkewer[3].cost = "0.06";
            porkSkewer[4].cost = "40.27";
            porkSkewer[5].cost = "3.10";
            porkSkewer[6].cost = "2.83";
            porkSkewer[7].cost = "2.44";
            porkSkewer[8].cost = "3.24";

            return porkSkewer;
        }
        private List<Ingredient> resetPrawnNachos()
        {
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

            // Dish update example
            prawnNachos[0].weight = "2";
            prawnNachos[1].weight = "9";
            prawnNachos[2].weight = "2";
            prawnNachos[3].weight = "340";
            prawnNachos[4].weight = "2000";
            prawnNachos[5].weight = "2";
            prawnNachos[6].weight = "425";
            prawnNachos[7].weight = "182";
            prawnNachos[8].weight = "450";

            // Change cost
            prawnNachos[0].cost = "0.08";
            prawnNachos[1].cost = "1.79";
            prawnNachos[2].cost = "0.04";
            prawnNachos[3].cost = "0.25";
            prawnNachos[4].cost = "41.97";
            prawnNachos[5].cost = "0.10";
            prawnNachos[6].cost = "2.42";
            prawnNachos[7].cost = "1.38";
            prawnNachos[8].cost = "1.35";

            return prawnNachos;
        }

        private Ingredient createIngredients(string name, string weight, string cost, string location, string metric)
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
