using System;
using System.Collections.Generic;
using System.Text;

namespace TaskApe3_11
{
    internal class Weapon
    {
        public int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value > 0)
                {
                    _capacity = value;
                }
            }
        }
        public int _count;
        public int CountG
        {
            get { return _count; }
            set
            {
                if (_count < Capacity)
                {
                    _count = value;
                }
            }
        }


        public bool Mode { get; set; }


        public void Shoot()
        {
            Console.WriteLine(CountG - 1);
        }
        public void Fire()
        {
            if (Mode == true)
            {
                Console.WriteLine(CountG = 0);
            }
            else
            {
                Console.WriteLine(--CountG);
            }
        }

        public int GetRemainBulletCount()
        {
            return Capacity -= CountG;
        }

        public void Reolad()
        {
            if (CountG < Capacity)
            {
                for (int i = CountG; i <= Capacity; i++)
                {
                        Console.WriteLine(CountG++);

                }
            }
            else
            {
                Console.WriteLine("Drag doludur");
            }

           

        }

        public void ChangeFireMode()
        {
            if (Mode == true)
            {
                Console.WriteLine(Mode = false);
            }
            else if (Mode == false)
            {
                Console.WriteLine(Mode = true);
            }
        }
    }
}
