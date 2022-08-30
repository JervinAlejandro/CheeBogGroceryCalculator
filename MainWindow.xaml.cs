using System;
using System.Collections.Generic;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
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
            dishes[1].name = "CHICKEN SKEWER";
            dishes[2].name = "GRAHAM CAKE";
            dishes[3].name = "HONEY CHICKEN BAO";
            dishes[4].name = "HONEY CHICKEN POP";
            dishes[5].name = "PORK BAO";
            dishes[6].name = "PORK SKEWER";
            dishes[7].name = "PRAWN NACHOS";
        }

        private List<Ingredient> setIngredients(Dish dish,int counter)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            for(int i = 0; i < counter; i++)
            {
                Ingredient ingredient = new Ingredient();
            }

            return ingredients;
        }
    }
}
