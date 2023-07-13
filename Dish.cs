using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CheeBogGrocery
{
    internal class Dish
    {
        public double servings { get; set; }
        public string name { get; set; }
        public List <Ingredient> ingredients { get; set; }
        
        public void updateIngredients(int serve)
        {
            double weight;
            double total;
            double cost;

            foreach (Ingredient item in ingredients)
            {
                weight = double.Parse(item.weight);
                total = (serve / servings) * weight;
                total = checkMetric(item, total);
                if(item.metric.Equals("stems") || item.metric.Equals("pcs"))
                {
                    item.weight = (Math.Round(total, 0)).ToString();

                }
                else
                {
                    item.weight = (Math.Round(total, 2)).ToString();
                }

                cost = double.Parse(item.cost);
                total = (serve / servings) * cost;
                item.cost = (Math.Round(total, 2)).ToString();
            }
        }

        public void addPrefix()
        {
            foreach (Ingredient item in ingredients)
            {
                item.weight += item.metric;
                item.cost = "$" + item.cost;
            }
        }

        public double checkMetric(Ingredient item, double total)
        {
            if(total >= 1000)
            {
                switch (item.metric)
                {
                    case "g":
                        item.metric = "kg";
                        break;
                    case "ml":
                        item.metric = "l";
                        break;

                }
                total = total / 1000;
            }
            else
            {
                switch (item.metric)
                {
                    case "kg":
                        item.metric = "g";
                        break;
                    case "l":
                        item.metric = "ml";
                        break;
                }
            }
            return total;
        }

    }
}
