using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.	Написать программу, рассчитывающую сумму коммунальных платежей: 
 * есть базовые тарифы на отопление (на 1 м2 площади), на воду (на 1 чел), 
 * на газ (на 1 чел), на текущий ремонт (на 1 м2 площади).
 * Задается метраж помещения, количество проживающих людей, 
 * сезон (осенью и зимой отопление дороже), наличие льгот 
 * (ветеран труда– 30 % от его части; ветеран войны- 50% от его части). 
 * Вывести таблицу со столбцами: Вид платежа, Начислено, Льготная скидка,
 * Итого. Посчитать итоговую сумму.*/

namespace UtilityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            try
            {
                List<Humans> humans = new List<Humans>();
                for (int i = 0; i < rand.Next(1, 30); i++)
                {
                    if (i % 2 == 0)
                        humans.Add(new Humans());
                    else if ((i % 3 == 0))
                        humans.Add(new Humans(Privileges.WarVeteran));
                    else
                        humans.Add(new Humans(Privileges.labourVeteran));
                }
                Console.WriteLine("Human living: {0} \n", humans.Count());
                Console.WriteLine("<-Summer bill->\n");

                Admission.Payment(70, humans, Season.summer); // Square meters, number of people living, summer payment
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine("<-Winter bill->\n");
                Admission.Payment(125, humans, Season.winter); // Square meters, number of people living, winter payment-- Heating is more expensive at winter period
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
