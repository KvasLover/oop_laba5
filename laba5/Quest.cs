using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    public class Quest : IRealizable
    {
        public virtual void Show_date()
        {
            Console.WriteLine("Дата не определена");
        }        
    }
}
