using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    // Абстрактный класс (не может быть реализован).
    public abstract class Question : Test
    {
        public override void Show_date()
        {
            Console.WriteLine("Дата задания вопроса: 04.01.2021.");
        }
    }
}
