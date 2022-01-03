using System;

namespace ThisPointerApp.Modal
{
    class Player
    {
        private int id;
        private string name;
        private int age;

        public Player(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Player(int id, string name):this(id, name, 18)
        {
            
        }

        public int ID
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public Player WhoisElder(Player secondplayer)
        {
            if (Age > secondplayer.age)
                return this;

            return secondplayer;
        }
    }
}
