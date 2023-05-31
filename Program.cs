namespace MyfirstArray;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] firstArray = new int[5];
        int[] secondArray = new int[5];
        int[] thirdArray = new int[10];

        firstArray = new int[] {0,1,2,3,4};
        secondArray = new int[] {5,6,7,8,9};
        
        firstArray.CopyTo(thirdArray, 0);
        secondArray.CopyTo(thirdArray, firstArray.Length);

        Console.WriteLine("Valeurs du premier tableau");
        for (int i = 0; i< firstArray.Length; i++)
        {
            Console.WriteLine(firstArray[i]);
        }

        Console.WriteLine("Valeurs du deuxième tableau");

        for (int i = 0; i< secondArray.Length; i++)
        {
            Console.WriteLine(secondArray[i]);
        }

        Console.WriteLine("Valeurs du troisième tableau");

        for (int i = 0; i< thirdArray.Length; i++)
        {
            Console.WriteLine(thirdArray[i]);
        }
        

    }
}
