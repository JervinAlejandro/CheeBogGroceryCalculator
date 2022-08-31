using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for(int i = 0; i < ingredients.Count; i++)
            {
                weight = double.Parse(ingredients[i].weight);
                total = (serve / servings) * weight;
                ingredients[i].weight = (Math.Round(total,2)).ToString();

                cost = double.Parse(ingredients[i].cost);
                total = (serve / servings) * cost;
                ingredients[i].cost = (Math.Round(total,2)).ToString();
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

        public void checkMetric()
        {
            foreach (Ingredient item in ingredients)
            {
                if(double.Parse(item.weight) > 1000)
                {
                    switch (item.metric)
                    {
                    }
                }
            }
        }

    }
}
