namespace ArrayProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rainfall = new int[7];
            for(int i=0;i<rainfall.Length;i++)
            {
                Console.WriteLine($"Enter {i} value");
                rainfall[i] =Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<rainfall.Length;i++)
            {
                Console.WriteLine($"Rainfall[{i}] = {rainfall[i]} ");
            }
        }
    }
}