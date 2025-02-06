
namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Single Dim. Array

            //a- Declaration

            string[] friends = new string[5];

            // Accessing Element

            friends[0] = "Ali";
            friends[1] = "Reem";
            friends[2] = "Faisel";
            friends[3] = "Ahmed";
            friends[4] = "Abeer";

            //b- Intialization = Declaration + Accessing

            string[] friends2 = new string[5] {

             "Ali",
             "Reem",
             "Faisel",
             "Ahmed",
             "Abeer"
            };

            // or 
            string[] friends3 =  {

             "Ali",
             "Reem",
             "Faisel",
             "Ahmed",
             "Abeer"
            };


            friends.Print();

            //2. Multi Dim. Array (rectangular array)
            int[,] suduko =
            {
                {9,6,2,1,4,7,3,7,8 },
                {1,8,5,6,7,3,4,2,9 },
                {3,7,4,2,9,8,5,6,1 },
                {5,3,1,7,6,2,9,8,4 },
                {6,9,4,3,8,1,2,5,7 },
                {8,2,7,4,5,9,6,1,3 },
                {4,9,6,5,1,7,8,3,2 },
                {2,1,8,9,3,6,7,4,5 },
                {7,5,3,8,2,4,1,9,6 }

            };

            //3. Jagged Array (array inside array)
            var jagged = new int[][]
            {
                new int[] {1,2},
                new int[] {2,3,6},
                new int[] {4}

            };

            // Indice and Range
            var first = friends[0];      // {Ali}
            var slice1 = friends[..2];    // {Ali, Reem}
            var slice2 = friends[2..];   // { Faisel, Ahmed, Abeer}
            var slice3 = friends[2..3];  // { Faisel}
            var slice4 = friends[2..^2]; // { Faisel}

            var sliceRange = 2..^3;
            var slice5 = friends[sliceRange]; // { Faisel}

            // Bound Checking
          //  var item = friends[5]; // IndexOutOfRangeException
            Console.ReadKey();
        }
    }

    public static class Extensions
    {
        public static void Print<T>(this T[] source)
        {
            if (!source.Any())
            {
                Console.WriteLine("{}");
                return;
            }
            Console.Write("{");
            for (var i = 0; i < source.Length; i++)
            {
                Console.Write($"{source[i]}");
                Console.Write(i < source.Length - 1 ? "," : "");
            }
            Console.WriteLine("}");
        }
    }

}