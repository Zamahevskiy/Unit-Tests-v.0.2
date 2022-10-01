using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tests
{
    public class Cu_cu_lator
    {

        public double first = 0;
        public double second = 0;
        public string xpen;
        public double answ = 0;

        public void Start()
        {
            Console.Write("Введите число число: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Действие(+, -, /, *, ^): ");
            xpen = Convert.ToString(Console.ReadLine());
            Console.Write("Не опять, а снова введите число: ");
            second = Convert.ToDouble(Console.ReadLine());
        }
        public void aboba()
        {
            switch (xpen)
            {
                case "+":
                    sum();
                    break;
                case "-":
                    min();
                    break;
                case "*":
                    umn();
                    break;
                case "/":
                    del();
                    break;
                case "^":
                    step();
                    break;
            }
            if (xpen != "+" && xpen != "-" && xpen != "/" && xpen != "*" && xpen != "^")
            {
                Console.Write("Некоректное действие, введите заново: ");
                xpen = Convert.ToString(Console.ReadLine());
                aboba();
            }
        }
        public void sum()
        {
            answ = first + second;
            Console.WriteLine("Ответ: " + answ);
        }
        public void min()
        {
            answ = first - second;
            Console.WriteLine("Ответ: " + answ);
        }
        public void umn()
        {
            answ = first * second;
            Console.WriteLine("Ответ: " + answ);
        }
        public void del()
        {
            answ = first / second;
            Console.WriteLine("Ответ: " + answ);
        }
        public void step()
        {
            answ = Math.Pow(first, second);
            Console.WriteLine("Ответ: " + answ);
        }
    }
}