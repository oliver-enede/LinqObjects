namespace LinqObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string likes = "I like fruit";
            string[] fruit = { "Orange", "Apple", "Grapefruit", "Pear", "Pineapple", "Grapes", "Peach","Melon","Coconut" };
            int[] numbers = {5,6,3,8,2,9,1,6,15,66,34,23,32,45,29,30 };
            var getNumbers = from number
                in numbers
                where number < 10
                select number;

            Console.WriteLine(string.Join(", ", getNumbers));

            var getFruits = from f 
                in fruit
                where f.Contains('G') && f.Length < 8
                select f;

            Console.WriteLine("Fruits containing 'G' and length less than 8: " + string.Join(", ", getFruits));

            var evenNumbers = from number 
                in numbers
                where number % 2 == 0
                orderby number ascending
                select number;

            Console.WriteLine("Even numbers in ascending order: " + string.Join(", ", evenNumbers));

            Console.ReadLine();

        }
    }
}