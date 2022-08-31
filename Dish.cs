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
            for(int i = 0; i < ingredients.Count; i++)
            {
                weight = double.Parse(ingredients[i].weight);
                total = (serve / servings) * weight;
                ingredients[i].weight = total.ToString();
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

    }
}
