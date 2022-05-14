using System;

namespace TaskApe3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weapon weapon = new Weapon();
            Console.Write("Capacity: ");
            weapon.Capacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("CountG: ");
            weapon.CountG = Convert.ToInt32(Console.ReadLine());

            bool check = true;
            do
            {
                
                int selector = Convert.ToInt32(Console.ReadLine());




                switch (selector)
                {
                    case 0:
                        {
                            Console.WriteLine("0 - İnformasiya almaq üçün");
                            Console.WriteLine("1 - Shoot metodu üçün");
                            Console.WriteLine("2 - Fire metodu üçün");
                            Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
                            Console.WriteLine("4 - Reload metodu üçün");
                            Console.WriteLine("5 - ChangeFireMode metodu üçün");
                            Console.WriteLine("6 - Proqramdan dayandırmaq üçün qısayoldur.");

                        }
                        break;
                    case 1:
                        {
                            Console.WriteLine("Shoot metod:");
                            weapon.Shoot();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Fire  metod:");
                            weapon.Fire();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine(" GetRemainBulletCount metod:");
                            Console.WriteLine(weapon.GetRemainBulletCount());
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Reolad metod:");
                            weapon.Reolad();
                        }
                        break;

                    case 5:
                        {
                            Console.WriteLine("ChangeFireMode");
                            weapon.ChangeFireMode();
                        }
                        break;

                    case 6:
                        {
                            check = false;
                        }
                        break;
                }

            } while (check);
        }
    }
}
