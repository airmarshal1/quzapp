using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlib
{
   public class clsTurtlesQuiz
    {
        public int id { get; set; }
        public string type { get; set; }
        public string question { get; set; }
        public string ans1 { get; set; }
        public string ans2 { get; set; }
        public string ans3 { get; set; }
        public string ans4 { get; set; }
        public string selected { get; set; }
        public string correct { get; set; }
        public string score { get; set; }

        public static List<clsTurtlesQuiz> GetAllTurtlesQuiz()
        {
            List<clsTurtlesQuiz> x = new List<clsTurtlesQuiz>();
            clsTurtlesQuiz x1 = new clsTurtlesQuiz
            {
                id = 1,
                type = "text",
                question = "How much can a loggerhead weigh?",
                ans1 = "Up to 20kg",
                ans2 = "Up to 115kg",
                ans3 = "Up to 220kg",
                ans4 = "Up to 500kg",
                selected = null,
                correct = "ans2",
                score = null
            };
            clsTurtlesQuiz x2 = new clsTurtlesQuiz
            {
                id = 2,
                type = "text",
                question = "What is the typical lifespan of a Green Sea Turtle?",
                ans1 = "150 years",
                ans2 = "10 years",
                ans3 = "80 years",
                ans4 = "40 years",
                selected = null,
                correct = "ans3",
                score = null
            };
            clsTurtlesQuiz x3 = new clsTurtlesQuiz
            {
                id = 3,
                type = "image",
                question = "Which of these is the Alligator Snapping Turtle?",
                ans1 = "../turtles/img1.jpg",
                ans2 = "../turtles/img3.jpg",
                ans3 = "../turtles/img5.jpg",
                ans4 = "../turtles/img7.jpg",
                selected = null,
                correct = "ans4",
                score = null
            };
            clsTurtlesQuiz x4 = new clsTurtlesQuiz
            {
                id = 4,
                type = "image",
                question = "Which of these is the Green Turtle?",
                ans1 = "../turtles/img1.jpg",
                ans2 = "../turtles/img2.jpg",
                ans3 = "../turtles/img6.jpg",
                ans4 = "../turtles/img8.jpg",
                selected = null,
                correct = "ans1",
                score = null
            };
            clsTurtlesQuiz x5 = new clsTurtlesQuiz
            {
                id = 5,
                type = "text",
                question = "Where does the Kemp's Ridley Sea Turtle live?",
                ans1 = "Tropical waters all around the world",
                ans2 = "Eastern Australia",
                ans3 = "Coastal North Atlantic",
                ans4 = "South pacific islands",
                selected = null,
                correct = "ans3",
                score = null
            };
            clsTurtlesQuiz x6 = new clsTurtlesQuiz
            {
                id = 6,
                type = "text",
                question = "What is the most common turtle in US waters?",
                ans1 = "Loggerhead turtle",
                ans2 = "Leatherback turtle",
                ans3 = "Hawksbill Turtle",
                ans4 = "Alligator Snapping Turtle",
                selected = null,
                correct = "ans1",
                score = null
            };
            clsTurtlesQuiz x7 = new clsTurtlesQuiz
            {
                id = 7,
                type = "text",
                question = "What is the largest sea turtle on earth?",
                ans1 = "Eastern Snake Necked Turtle",
                ans2 = "Olive Ridley Sea Turtle",
                ans3 = "Kemp's Ridley Sea Turtle",
                ans4 = "Leatherback",
                selected = null,
                correct = "ans4",
                score = null
            };
            clsTurtlesQuiz x8 = new clsTurtlesQuiz
            {
                id = 8,
                type = "image",
                question = "Which of these is the Olive Ridley Turtle?",
                ans1 = "../turtles/img3.jpg",
                ans2 = "../turtles/img2.jpg",
                ans3 = "../turtles/img8.jpg",
                ans4 = "../turtles/img7.jpg",
                selected = null,
                correct = "ans3",
                score = null
            };
            clsTurtlesQuiz x9 = new clsTurtlesQuiz
            {
                id = 9,
                type = "text",
                question = "How Heavy can a leatherback turtle be?",
                ans1 = "900kg",
                ans2 = "40kg",
                ans3 = "110kg",
                ans4 = "300kg",
                selected = null,
                correct = "ans1",
                score = null
            };
            clsTurtlesQuiz x10 = new clsTurtlesQuiz
            {
                id = 10,
                type = "text",
                question = "Which of these turtles are herbivores?",
                ans1 = "Loggerhead Turtle",
                ans2 = "Hawksbill Turtle",
                ans3 = "Leatherback Turtle",
                ans4 = "Green Turtle",
                selected = null,
                correct = "ans3",
                score = null
            };
            x.Add(x1);
            x.Add(x2);
            x.Add(x3);
            x.Add(x4);
            x.Add(x5);
            x.Add(x6);
            x.Add(x7);
            x.Add(x8);
            x.Add(x9);
            x.Add(x10);

            return x;
        }
    }
}
