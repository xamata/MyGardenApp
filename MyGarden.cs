using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyGardenApp
{
    internal class MyGarden
    {
        public MyGarden()
        {
            // Game Intro for User
            WriteLine(FiggleFonts.FlowerPower.Render("My Garden"));
            WriteLine("Welcome to My Garden!");

            WriteLine("> Flower 1");
            Flowers rosieTheRose = new Flowers("Rosie", 17, "Rose", true);
            rosieTheRose.Greet();
            rosieTheRose.Water();
            rosieTheRose.Photosynthesis();
            rosieTheRose.Blooming();
            rosieTheRose.Play();

            Flowers sunnyTheSunflower = new Flowers("Sunny", 21, "Sunflower", true);
            WriteLine("");
            WriteLine("> Flower 2");
            sunnyTheSunflower.Greet();
            sunnyTheSunflower.Water();
            sunnyTheSunflower.Play();
            //sunnyTheSunflower.SeeFlower();

            Flowers tulieTheTulup = new Flowers("Tulie", 82, "Tulip", false);
            WriteLine("");
            WriteLine("> Flower 3");
            tulieTheTulup.Greet();
            tulieTheTulup.Water();
            tulieTheTulup.SeeFlower();
            tulieTheTulup.Blooming();
            tulieTheTulup.SeeFlower();

            // Prevents the command prompt from exiting after code completion
            ReadKey();
        }
    }
}
