namespace StringCalculator.Domain
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrWhiteSpace(numbers))
                return 0;

            var parts = numbers.Split(",");

            var excedesCount = parts.Length > 2;
            var consecutiveCommas = parts.Any(string.IsNullOrWhiteSpace);
            var anyNonNumbers = parts.Any(x => !int.TryParse(x, out _));

            if (excedesCount || consecutiveCommas || anyNonNumbers)
                throw new ArgumentException(nameof(numbers));

            var sum = parts.Sum(Convert.ToInt32);

            return sum;
        }


    }
}