using System;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Стандартное переопределение.
            Exam exam = new Exam();
            exam.Show_date();

            // Переопределение с использованием Upcast.
            Test test = new Test();            
            Quest quest = test;
            quest.Show_date();

            // Upcast при инициализации.
            Quest final_exam = new Final_Exam();
            final_exam.Show_date();

            // Ошибка, невозможно создать экземпляр
            // абстрактного класса:
            // Question question = new Question();
            // (но можно создать класс-наследник).

            // Переопределённый метод ToString().
            Console.WriteLine(final_exam.ToString());

            // Не переопределённый метод ToString().
            Console.WriteLine(quest.ToString());
        }
    }
}
