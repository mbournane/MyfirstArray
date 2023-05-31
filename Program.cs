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
        
        thirdArray[0]= firstArray[0];
        thirdArray[1]= firstArray[1];
        thirdArray[2]= firstArray[2];
        thirdArray[3]= firstArray[3];
        thirdArray[4]= firstArray[4];
        thirdArray[5]= secondArray[0];
        thirdArray[6]= secondArray[1];
        thirdArray[7]= secondArray[2];
        thirdArray[8]= secondArray[3];
        thirdArray[9]= secondArray[4];

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
