using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityBill;

namespace UtilityBill
{
    public enum Season { autumn, winter, spring, summer }
}    public static class Admission
     {
         private static Season Season { get; set; }

         public static void Payment(int SquareMetres, List<Humans> humans, Season Season)
         {
             int sumWater = 0, sumGas = 0, sumHeating = 1, sumRepair = 1;
             int labourVeteran = 0, WarVeteran = 0;
             foreach (Humans item in humans)
             {
                 sumWater += item.waterTariff;
                 sumGas += item.gasTariff;
                 sumHeating = item.heatingTariff * SquareMetres;
                 sumRepair = item.repairTariff * SquareMetres;
             }

             if (Season == Season.autumn || Season == Season.winter)
                 sumHeating = ((sumHeating / 10) * 12);

             foreach (Humans item in humans)
             {
                 if (item.privileges == Privileges.labourVeteran)
                     ++labourVeteran;
                 if (item.privileges == Privileges.WarVeteran)
                     ++WarVeteran;
             }

             Console.Write("Bill type: {0} common, {1} privileged\n\n", humans.Count() - (WarVeteran + labourVeteran), labourVeteran + WarVeteran);
             Console.Write("To be paid:\n Water: {0}\n Gas: {1}\n Heating: {2}\n Repairs: {3}\n\n",
                 sumWater, sumGas, sumHeating, sumRepair);
             Console.Write("Preferential Discount: {0} 30% discounts, {1} 50% discounts\n\n", labourVeteran, WarVeteran);
             Console.WriteLine("Total: {0}", sumGas + sumHeating + sumRepair + sumWater);
         }

     }