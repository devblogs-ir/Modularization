namespace Design.Cohesion
{
    internal class VotingSystem
    {
        public void Main()
        {
            var yes = new Counter("Yes", 4);
            var no = new Counter("No", 4);
            var maybe = new Counter("Maybe", 4);
            var Hopefully = new Counter("Hopefully", 4);
            var manager = new CounterManager(yes, no, maybe, Hopefully);

            manager.AnounceWinner();
        }
    }
    public class Counter
    {
        private double? _percent;
        public string Name { get; }
        public int Count { get; }
        public Counter(string name, int count)
        {
            Count = count;
            Name = name;
        }
        public double GetPercent(int total) => _percent ?? (_percent = Math.Round((Count * 100.0) / total, 2)).Value;
        public void AddExcess(double excess) => _percent += excess;
    }
    public class CounterManager
    {
        public List<Counter> Counters { get; set; }
        public CounterManager(params Counter[] counters)
        {
            Counters = new List<Counter>(counters);
        }
        public int Total() => Counters.Sum(x => x.Count);
        public double TotalPercentage() => Counters.Sum(x => x.GetPercent(Total()));
        public void AnounceWinner()
        {
            var excess = Math.Round(100 - TotalPercentage(), 2);
            Console.WriteLine($"Excees:{excess}");
            var biggestAmountVotes = Counters.Max(x => x.Count);
            var winners = Counters.Where(x => x.Count == biggestAmountVotes).ToList();
            if (winners.Count == 1)
            {
                var winner = winners.First();
                winner.AddExcess(excess);
                Console.WriteLine($"{winner.Name} Won!");
            }
            else
            {
                if (winners.Count != Counters.Count)
                {
                    var lowestAmountVotes = Counters.Min(x => x.Count);
                    var loser = Counters.First(x => x.Count == lowestAmountVotes);
                    loser.AddExcess(excess);
                }
                Console.WriteLine(string.Join(" -DRAW- ", winners.Select(x => x.Name)));
            }
            foreach (var item in Counters)
            {
                Console.WriteLine($"{item.Name} Counts: {item.Count}, Percentage: {item.GetPercent(Total())}%");
            }
            Console.WriteLine($"Total Percentage:{Math.Round(TotalPercentage(), 2)}%");
        }
    }
}
