namespace AdentOfCode.Day1
{
    public class Trebuchet
    {
        public static class Part1
        {
            public static async Task PrintResultAsync()
            {
                Console.WriteLine(Solver(await File.ReadAllLinesAsync(@"Day1\input.txt")));
            }

            public static int Solver(IEnumerable<string> lines)
            {
                int total = 0;

                foreach (string line in lines)
                {
                    var firstNumber = line.First(char.IsDigit) - '0';
                    var secondNumber = line.Last(char.IsDigit) - '0';

                    total += firstNumber * 10 + secondNumber;
                }

                return total;
            }
        }

        public static class Part2
        {
            private static Dictionary<string, int> _numberMap = new Dictionary<string, int>()
            {
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9}
            };

            static Part2()
            {
                foreach (var i in Enumerable.Range(1, 10))
                    _numberMap.Add(i.ToString(), i);
            }


            public static int Solver(IEnumerable<string> lines)
            {
                int total = 0;


                foreach (var line in lines)
                {
                    int firstNumber = 0;
                    int secondNumber = 0;
                    int firstIndex = line.Length;
                    int lastIndex = -1;


                    foreach (var number in _numberMap)
                    {
                        var index = line.IndexOf(number.Key);
                        if (index == -1)
                            continue;

                        if (index < firstIndex)
                        {
                            firstNumber = number.Value;
                            firstIndex = index;
                        }

                        index = line.LastIndexOf(number.Key);

                        if (index > lastIndex)
                        {
                            lastIndex = index;
                            secondNumber = number.Value;
                        }
                    }

                    var fullNumber = firstNumber * 10 + secondNumber;
                    total += fullNumber;
                }

                return total;
            }
        }
    }
}
