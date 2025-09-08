/*
 *  Creador: Miguel Rodríguez Gallego
 *  Fecha: 25.dic.2021
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miguel_Rodríguez_01
{
    class Character
    {
        public enum CharacterType
        {
            Sword   =   0,
            Axe     =   1,
            Spear   =   2
        }

        protected CharacterType type { get; private set; }
        public string name { get; private set; }

        public Character(CharacterType type, string name = "None")
        {
            this.type = type;
            this.name = name;
        }
    }

    class ChPlayer : Character, IAttacker
    {
        public Image picture { get; private set; }
        private int dmg;

        public ChPlayer
        (
            Image picture,
            CharacterType type,
            string name = "None",
            int dmg = 1
        )
        : base (type, name)
        {
            this.picture    =   picture;
            this.dmg        =   dmg;
        }

        public int GetDmg()
        {
            return dmg;
        }
        public CharacterType GetDmgType()
        {
            return type;
        }
    }

    class ChEnemy : Character, IDefender
    {
        public int health { get; private set; }

        public ChEnemy(CharacterType type, string name = "None", int health = 1) : base(type, name)
        {
            this.health = health;
        }

        public void ReceiveDmg(int dmg, CharacterType attType)
        {
            health -= Battle.CalculateDmg(attType, type, dmg);
        }
    }

    static class Battle
    {
        private static float[,] typeTable = new float[,] //[row, column]
        {
            //[att, def]     Sword  Axe   Spear
            /*Sword*/       { 1.0f, 2.0f, 0.5f },
            /*Axe*/         { 0.5f, 1.0f, 2.0f },
            /*Spear*/       { 2.0f, 0.5f, 1.0f }
        };

        public static int CalculateDmg
        (
            Character.CharacterType attType,
            Character.CharacterType defType,
            int attDmg
        )
        {
            return ((int)typeTable   [(int)attType, (int)defType]    *   attDmg);
        }
    }
}
