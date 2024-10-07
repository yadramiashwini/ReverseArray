

namespace ReverseArray
{
   public class ArrayReverse
    {
    
        static void Main(string[] args)
        {
         
            Console.WriteLine("enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter array elements:");
           for(int i = 0; i < arr.Length ; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine("reverse elements are:");
           for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
