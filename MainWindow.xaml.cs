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
            // Name, Weight, Price, Location, Metric
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
            // New
            groceries.Add(createIngredients("Chicken Meat Mixed", "2126", "6.36", "MCQ SuperMarket", "g"));
            groceries.Add(createIngredients("Bay Leaf", "20", "5.90", "Coles", "g"));
            groceries.Add(createIngredients("Baking Powder", "125", "2.85", "Coles", "g"));
            groceries.Add(createIngredients("Fresh Milk", "3000", "6.20", "Coles", "l"));
            groceries.Add(createIngredients("Garlic Powder", "50", "2", "Woolworths", "g"));
            groceries.Add(createIngredients("Onion Powder", "42", "2.45", "Coles", "g"));
            groceries.Add(createIngredients("Paprika", "190", "4.10", "Coles", "g"));
            groceries.Add(createIngredients("Self Raising Flour", "1000", "1.15", "Woolworths", "g"));
            groceries.Add(createIngredients("Water", "236.59", "0", "Home", "ml"));


            #endregion
            populateData();
            setMenuNames();
        }
        #region buttons
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
        #endregion
        private void listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string text = "";
            foreach(Ingredient item in dishes[current].ingredients)
            {
                text += item.name + ", " + item.weight + ", " + item.cost + ", " + item.location + "\n";
            }
            Clipboard.SetText(text);
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
            if (current >= 0)
            {
                switch (current)
                {
                    case 0:
                        dishes[0].ingredients = resetChickenPops(); // Switch case this to resetDifferentDish
                        break;
                    case 1:
                        dishes[1].ingredients = resetFriedChicken();
                        break;
                    case 2:
                        dishes[2].ingredients = resetGrahamCake();
                        break;
                    case 3:
                        dishes[3].ingredients = resetHoneyChickenBao();
                        break;
                    case 4:
                        dishes[4].ingredients = resetHoneyChickenPop();
                        break;
                    case 5:
                        dishes[5].ingredients = resetPorkBao();
                        break;
                    case 6:
                        dishes[6].ingredients = resetPorkSkewer();
                        break;
                    case 7:
                        dishes[7].ingredients = resetPrawnNachos();
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

            dishes[1].name = "FRIED CHICKEN";
            dishes[1].ingredients = resetFriedChicken();
            dishes[1].servings = 40;
            dishes[1].updateIngredients(40);
            dishes[1].addPrefix();

            dishes[2].name = "GRAHAM CAKE";
            dishes[2].ingredients = resetGrahamCake();
            dishes[2].servings = 11;
            dishes[2].updateIngredients(11);
            dishes[2].addPrefix();

            dishes[3].name = "HONEY CHICKEN BAO";
            dishes[3].ingredients = resetHoneyChickenBao();
            dishes[3].servings = 22;
            dishes[3].updateIngredients(22);
            dishes[3].addPrefix();

            dishes[4].name = "HONEY CHICKEN POP";
            dishes[4].ingredients = resetHoneyChickenPop();
            dishes[4].servings = 10;
            dishes[4].updateIngredients(10);
            dishes[4].addPrefix();

            dishes[5].name = "PORK BAO";
            dishes[5].ingredients = resetPorkBao();
            dishes[5].servings = 60;
            dishes[5].updateIngredients(60);
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
            return (Ingredient)index.Clone();
        }
        private List<Ingredient> resetChickenPops()
        {
            List<Ingredient> chickenPops = new List<Ingredient>();
            chickenPops.Add(getIngredient("Chicken Thigh"));
            chickenPops.Add(getIngredient("Ginger"));
            chickenPops.Add(getIngredient("Garlic Bag"));
            chickenPops.Add(getIngredient("MasterFoods Soy Sauce"));
            chickenPops.Add(getIngredient("Tanaka Cooking Sake"));
            chickenPops.Add(getIngredient("Raw Sugar"));
            chickenPops.Add(getIngredient("Potato Starch"));
            chickenPops.Add(getIngredient("Cooking Salt"));
            chickenPops.Add(getIngredient("Trumps Black Pepper"));

            // Dish update example
            chickenPops[0].weight = "1000";
            chickenPops[1].weight = "62.5";
            chickenPops[2].weight = "24";
            chickenPops[3].weight = "80";
            chickenPops[4].weight = "83";
            chickenPops[5].weight = "160";
            chickenPops[6].weight = "190";
            chickenPops[7].weight = "17";
            chickenPops[8].weight = "7";

            // Change cost
            setCost(chickenPops, 9);

            //chickenPops.Sort();
            return chickenPops;
        }

        private List<Ingredient> resetFriedChicken()
        {
            List<Ingredient> friedChicken = new List<Ingredient>();
            friedChicken.Add(getIngredient("Baking Powder"));
            friedChicken.Add(getIngredient("Bay Leaf"));
            friedChicken.Add(getIngredient("Chicken Meat Mixed"));
            friedChicken.Add(getIngredient("Cooking Salt"));
            friedChicken.Add(getIngredient("Fresh Milk"));
            friedChicken.Add(getIngredient("Garlic Powder"));
            friedChicken.Add(getIngredient("Onion Powder"));
            friedChicken.Add(getIngredient("Paprika"));
            friedChicken.Add(getIngredient("Raw Sugar"));
            friedChicken.Add(getIngredient("Self Raising Flour"));
            friedChicken.Add(getIngredient("Trumps Black Pepper"));
            friedChicken.Add(getIngredient("Water"));

            // Dish update example
            friedChicken[0].weight = "4";
            friedChicken[1].weight = "0.15";
            friedChicken[2].weight = "2126";
            friedChicken[3].weight = "45.52";
            friedChicken[4].weight = "236.59";
            friedChicken[5].weight = "17.4";
            friedChicken[6].weight = "25.15";
            friedChicken[7].weight = "3.45";
            friedChicken[8].weight = "33.4";
            friedChicken[9].weight = "312.5";
            friedChicken[10].weight = "25.3";
            friedChicken[11].weight = "236";

            // Change cost
            setCost(friedChicken, 12);

            return friedChicken;
        }

        private List<Ingredient> resetGrahamCake()
        {
            List<Ingredient> grahamCake = new List<Ingredient>();
            grahamCake.Add(getIngredient("Condensed Milk"));
            grahamCake.Add(getIngredient("Graham Crackers"));
            grahamCake.Add(getIngredient("Thickened Cream"));

            // Dish update example
            grahamCake[0].weight = "596";
            grahamCake[1].weight = "12";
            grahamCake[2].weight = "1200";

            // Change cost
            setCost(grahamCake, 3);

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
            honeyChickenBao.Add(getIngredient("MasterFoods Soy Sauce"));
            honeyChickenBao.Add(getIngredient("Potato Starch"));
            honeyChickenBao.Add(getIngredient("Raw Sugar"));
            honeyChickenBao.Add(getIngredient("Salted Butter"));
            honeyChickenBao.Add(getIngredient("Tanaka Cooking Sake"));
            honeyChickenBao.Add(getIngredient("Trumps Black Pepper"));

            // Dish update example
            honeyChickenBao[0].weight = "22";
            honeyChickenBao[1].weight = "1000";
            honeyChickenBao[2].weight = "17";
            honeyChickenBao[3].weight = "24";
            honeyChickenBao[4].weight = "62.5";
            honeyChickenBao[5].weight = "42";
            honeyChickenBao[6].weight = "29";
            honeyChickenBao[7].weight = "83";
            honeyChickenBao[8].weight = "190";
            honeyChickenBao[9].weight = "83";
            honeyChickenBao[10].weight = "28";
            honeyChickenBao[11].weight = "80";
            honeyChickenBao[12].weight = "7";

            // Change cost
            setCost(honeyChickenBao, 13);

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
            honeyChickenPop.Add(getIngredient("MasterFoods Soy Sauce"));
            honeyChickenPop.Add(getIngredient("Potato Starch"));
            honeyChickenPop.Add(getIngredient("Raw Sugar"));
            honeyChickenPop.Add(getIngredient("Salted Butter"));
            honeyChickenPop.Add(getIngredient("Tanaka Cooking Sake"));
            honeyChickenPop.Add(getIngredient("Trumps Black Pepper"));

            // Dish update example
            honeyChickenPop[0].weight = "1000";
            honeyChickenPop[1].weight = "17";
            honeyChickenPop[2].weight = "24";
            honeyChickenPop[3].weight = "62.5";
            honeyChickenPop[4].weight = "42";
            honeyChickenPop[5].weight = "29";
            honeyChickenPop[6].weight = "83";
            honeyChickenPop[7].weight = "190";
            honeyChickenPop[8].weight = "160";
            honeyChickenPop[9].weight = "28";
            honeyChickenPop[10].weight = "80";
            honeyChickenPop[11].weight = "7";

            // Change cost
            setCost(honeyChickenPop, 12);

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
            porkBao[0].weight = "60";
            porkBao[1].weight = "34";
            porkBao[2].weight = "73";
            porkBao[3].weight = "45";
            porkBao[4].weight = "74";
            porkBao[5].weight = "487";
            porkBao[6].weight = "2000";
            porkBao[7].weight = "82";
            porkBao[8].weight = "75";
            porkBao[9].weight = "4";

            // Change cost
            setCost(porkBao, 10);

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
            porkSkewer[4].weight = "480";
            porkSkewer[5].weight = "5000";
            porkSkewer[6].weight = "1000";
            porkSkewer[7].weight = "1400";
            porkSkewer[8].weight = "234";

            // Change cost
            setCost(porkSkewer, 9);

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
            prawnNachos[3].weight = "285";
            prawnNachos[4].weight = "1460";
            prawnNachos[5].weight = "2";
            prawnNachos[6].weight = "250";
            prawnNachos[7].weight = "182";
            prawnNachos[8].weight = "450";

            // Change cost
            setCost(prawnNachos, 9);

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

        private string calculateCost(List<Ingredient> grocery, int index)
        {
            grocery[index].cost = "0";
            int groceriesIndex = 0;
            foreach (Ingredient item in groceries)
            {
                if (item.name == grocery[index].name)
                {
                    groceriesIndex = groceries.IndexOf(item);
                }
            }
            double cost = double.Parse(groceries[groceriesIndex].cost) / double.Parse(groceries[groceriesIndex].weight);
            cost *= double.Parse(grocery[index].weight);

            return cost.ToString();
        }

        private void setCost(List<Ingredient> ingredientsList, int numberLoop)
        {
            for(int i = 0; i < numberLoop; i++)
            {
                ingredientsList[i].cost = calculateCost(ingredientsList, i);
            }
        }
        #endregion
    }
}
