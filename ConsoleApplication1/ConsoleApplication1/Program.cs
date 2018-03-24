using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boys boy = new Boys();
            LoveBoys2 boy2 = new LoveBoys2();            
            boy.Favorite();
            //boy2.Favorite();
        }
    }
    abstract class Boy
    {
        public abstract void Favorite();
    }
    class Boys : Boy
    {
        public override void Favorite()
        {
            DateTime dt = new DateTime(1990, 03, 03);
            Girl g = new Girl(dt);
            Console.WriteLine("名前は{0}、誕生日は{1}、好きな音楽は{2}、仕事は{3}、血液型は{4}", g.name, g.Birthday, g.music, g.work, g.bloodType);
        }
    }
    class LoveBoys2 : Boy
    {
        public override void Favorite()
        {
            Girl2 g2 = new Girl2("ピンク", "新小岩");
            
            //Console.WriteLine("パンツの色は{0},家は{1},胸のでかさはB{2},趣味は{3}", g2.color, g2.house, g2.size, g2.hobby);
        }
    }
    class Girl
    {
        public string name { get; set; }
        public DateTime Birthday { get; set; }
        public string music = "Owl City";
        public string work = "営業";
        public string bloodType = "AB型";
        public Girl(DateTime birthday)
        {
            name = "A子";
            Birthday = birthday;
        }
    }
    class Girl2
    {
        public string color { get; private set; } 
        public string house { get; }
        public int size { get; private set; }
        public string hobby { get; set; } = "飲み歩き";
        public Girl2(string Color, string House)
        {
            this.color = Color;
            this.house = House;
            this.size = 72;
        }
    }
}