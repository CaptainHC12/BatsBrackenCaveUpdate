using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BatsBrackenCave
{
    class Areas
    {
        public string Name;
        public string Description;
        public BitmapImage image;
        //Got help from Duncan
        public Areas(string N, string D, string imagepath )
        {
            Name = N;
            Description = D;
            image = new BitmapImage(new Uri(imagepath, UriKind.Relative));

        }
    }
}
