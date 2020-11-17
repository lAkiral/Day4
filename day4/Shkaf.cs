using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    public class Shkaf
    {
        public int hight { get; set; }
        public int width { get; set; }
        public int depth { get; set; }
        public bool opening { get; set; }
        public string[] drop = new string[100];
        public List<string> drop1 = new List<string>();
        
        
            
        public void stq()
        {
            
        }
        public void start()
        {
            
            for (; ; )
            {
                Console.WriteLine("Перед вами шкаф, шо робим?");
                Console.WriteLine("Посмотреть на шкаф: a");
                Console.WriteLine("Открыть/закрыть: b");
                Console.WriteLine("Положить, что то: c");
                Console.WriteLine("Уйти: d");
                string answer = Console.ReadLine();
                if (answer == "a") { this.LookAtShkaf(); }
                if (answer == "b") { this.question(); }
                if (answer == "c") { this.put(); }
                if (answer == "d") { break; }

                if (answer!="a" && answer != "b" && answer != "c" && answer != "d") { Console.WriteLine("Ты говно вводи то что нужно"); }
            }
        }
        public void LookAtShkaf()
        {
            if (this.opening == false) { Console.WriteLine($"Shkaf hight: {hight}, Shkaf width {width}, Shkaf depth {depth}, Shkaf opening {opening}"); return; }
            Console.WriteLine($"Shkaf hight: {hight}, Shkaf width {width}, Shkaf depth {depth}, Shkaf opening {opening}");
            //for (int i=0; i < drop.Length; i++)
            //{
            //    Console.WriteLine($"Шмот в шкафу: {drop[i]}");
            //}
            foreach (string dino in drop1)
            {
                Console.WriteLine(dino);
            }
        }
        public void OpenShkaf()
        {
            this.opening = true;
            Console.WriteLine("Shkaf open");
        }
        public void CloseShkaf()
        {
            this.opening = false;
            Console.WriteLine("Shkaf close");
        }
        public void question()
        {
            Console.Write("Open the door(y/n)?");
            string yn = Console.ReadLine();
            if (yn == "y") { this.OpenShkaf(); }
            if (yn == "n") { this.CloseShkaf(); }
            if (yn!="y" && yn != "n") { Console.WriteLine("Only y/n"); this.question(); }
        }
        public void put()
        {
            if(this.opening == false) { Console.WriteLine("Соси хер, шкаф закрыт"); return; }
            Console.WriteLine("Что закинем в шкаф?");
            string newdrop = Console.ReadLine();
            drop1.Add(newdrop);
        }
    }
}
