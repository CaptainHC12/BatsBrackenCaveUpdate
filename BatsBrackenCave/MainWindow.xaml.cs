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

namespace BatsBrackenCave
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Entity> entities = new List<Entity>();
        public MainWindow()
        {
            InitializeComponent();
        }
        // Got help from Mack with tutoring on the areas 
        //Got help from Duncan with tutoring
        Areas[] AreasNames = { new Areas("Cave","Dark cold place", "Images/PlaceHolder.png"),new Areas("Forest","Warm rain", "Images/PlaceHolder.png"), new Areas("Desert","Hot and dry", "Images/PlaceHolder.png"), new Areas("Jungle","Pretty", "Images/PlaceHolder.png") };
        //Got help from duncan
        void Places()
        {
            for (int i = 0; i < AreasNames.Length; i++)
            {
                string path = $"../../Data/{AreasNames[i].Name}.bmp";
                AreasNames[i].image = new BitmapImage(new Uri(path, UriKind.Relative));
            }
        }

        public int i;
        //Got help from Mack and Duncan
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            i++;
            if (i >= AreasNames.Length)
            {
                i = 0;
            }
            LocationTextBox.Text = AreasNames[i].Name;
            LocationImage.Source = AreasNames[i].image;


            

            //if ( i < AreasNames.Length )
            //{
            //    LocationTextBox.Text = AreasNames[i];
            //    i++;
            //}
           
            
        }

        
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            entities = DataLoader.LoadEntities("../../data/Data.xml");
            Output.Text = DataLoader.LoadText("../../data/About.txt");
            Output.Text += GetEntityData();
        }

        private string GetEntityData()
        {
            string output = "";
            foreach (Entity e in entities)
            {
                output += $"{e.name} {e.species}\n";
            }


            return output;
        }
    }

}
