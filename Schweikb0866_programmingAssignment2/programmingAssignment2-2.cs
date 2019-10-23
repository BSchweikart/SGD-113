using System;
using System.IO;
using System.Text;

namespace programmingAssignment2-2
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? itemtwodesc;
         ?? itemtwoprice;
         ?? tiptotal;
         ?? tip;
         ?? total;
         ?? itemoneprice;
         ?? itemthreeprice;
         ?? itemonedesc;
         ?? subtotal;
         ?? itemthreedesc;
      
         itemOnedesc ="Soda ";
         itemTwodesc ="Steak ";
         itemThreedesc ="Chips ";
         set_precision(2);
         itemOneprice =1.99;
         itemTwoprice =9.99;
         itemThreeprice =2.99;
         subTotal =itemOneprice+itemTwoprice+itemThreeprice;
         Console.WriteLine(itemOnedesc+"$"+itemOneprice);
         Console.WriteLine(itemTwodesc+"$"+itemTwoprice);
         Console.WriteLine(itemThreedesc+"$"+itemThreeprice);
         raptor_prompt_variable_zzyz ="Please Choose 15 or 20 %  tip";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         tip= Double.Parse(Console.ReadLine());
         if (tip==15)
         {
            tip =tip/100;
            tipTotal =subTotal*tip;
         }
         else
         {
            tip =tip/100;
            tipTotal =subTotal*tip;
         }
         Console.WriteLine("Subtotal "+"$"+subTotal);
         Console.WriteLine("Tip "+"$"+tipTotal);
         total =subTotal+tipTotal;
         Console.WriteLine("Total "+"$"+total);
      }
   }
}
