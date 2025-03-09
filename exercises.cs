using System;

class Exercises
{
    public static void Main(){
        // Run a method here for the app to be compile-able.
        qn14();
    }
    public static void qn3(){
        Console.Write("Enter 2 numbers : ");
        string input = Console.ReadLine();
        string[] numers = input.Split(' ');
        int a = int.Parse(numers[0]);
        int b = int.Parse(numers[1]);
        int c  = a*b;
        Console.WriteLine($"the product of {a} in {b} is {c}");
    }
    public static void qn5(){
        int height = 9;
        int width = 9;
        for(int i=0 ; i < height ; i++){
            for(int j=0 ; j < width ; j++){
                if(i == 0 || i == height -1 || j == 0 || j == width - 1 ){
                    Console.Write("*");
                
                }
                else {
                    Console.Write(" ");
                }
                
            }
        Console.WriteLine();
        }
    }
    public static void qn8(){
        Console.Write("Enter 2 numbers : ");
        string input = Console.ReadLine();
        string[] numers = input.Split(' ');
        int a = int.Parse(numers[0]);
        int b = int.Parse(numers[1]);
        if(b % a == 0){
            Console.WriteLine("It is");
        
        }
        else {
            Console.WriteLine("it is not");
        }
    }
    static bool IsPrime(int num) // This method is to find prime numbers for later use
    {
        if (num < 2) return false; 
        for (int i = 2; i * i <= num; i++) 
        {
            if (num % i == 0) return false;
        }
        return true;
    }
    public static void qn11(){
        Console.Write("Enter number : ");
        string input = Console.ReadLine();
        int num = int.Parse(input);
        int counter = 0;
        while(counter <= num){
            if(IsPrime(counter)){
                Console.Write($"{counter}\t");
            }
            counter += 1;
        }
        Console.WriteLine();
    }
    public static void qn15(){
        int height = 10;
        for (int i=1; i <= height; i++){
            for (int j=1; j <= height; j++){
                Console.Write($"{i*j}\t");
            }
            Console.WriteLine();
        }
    }
    public static void qn13(){
        Console.Write("Enter 2 numbers : ");
        string input = Console.ReadLine();
        string[] numers = input.Split(' ');
        int a = int.Parse(numers[0]);
        int b = int.Parse(numers[1]);
        int max,min;
        if(a > b){
            max = a;
            min = b;
        }
        else{
            max = b;
            min = a;
        }
        for(int i = min ; i <= max ; i++){
            Console.Write($"{i}\t");
        }
        Console.WriteLine();
    }
    public static void qn14(){
        int counter = 1;
        int max=0,avg=0,sum=0;
        while(counter > 0){
        Console.Write("Enter a number : ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        if(max < number){
            max = number;
            avg += number;
            sum += 1;
        }
        counter = number;
        }
        Console.WriteLine(sum);
        Console.WriteLine($"AVG : {avg/sum} \t Maximum number inputed : {max}");
    }
    public static void qn16(){ // This one was retarded , we use casting here.

        Console.Write("Enter a character: ");
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine(); 
        
        int asciiValue = (int)inputChar;

        Console.WriteLine($"Character: {inputChar}");
        Console.WriteLine($"ASCII Code: {asciiValue}");
    }
}
