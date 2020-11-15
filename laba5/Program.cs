using System;

namespace laba5
{
    public abstract class Quest
    {
        public int Name { get; set; }
    }    
    public class Exam : Quest
    {

    }
    public class Final_Exam : Exam
    {

    }
    public class Test : Quest
    {

    }
    public sealed class Question : Test
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nothing");
        }
    }
}
