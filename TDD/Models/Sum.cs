namespace TDD.Models
{
    public class Sum
    {
        public int Execute(string numbers)
        {
            if(numbers =="" || numbers == "0")
            {
                return 0;
            }

            if(numbers.EndsWith(","))
            {
                numbers=numbers.Substring(0,numbers.Length-1);
            }

            string[] strinNumber = numbers.Split(",");
            int[] intNumber = Array.ConvertAll(strinNumber, s => int.Parse(s));
            return intNumber.Sum();
            
        }
    }
}
