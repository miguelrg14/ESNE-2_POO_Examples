using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miguel_Rodríguez_01
{
    interface IAttacker
    {
        int GetDmg();
        Character.CharacterType GetDmgType();
    }

    interface IDefender
    {
        void ReceiveDmg(int dmg, Character.CharacterType AttType);
    }
}
