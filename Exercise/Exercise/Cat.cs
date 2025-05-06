namespace Exercise
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, bool lazy, int livesLeft)
        : base(name, "Cat", age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Cat name: {Name}, age: {Age}, is lazy: {Lazy}, live lleft: {LivesLeft}");
        }
    }
}
