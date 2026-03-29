using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Decorator
{
    public interface IHero
    {
        string GetDescription();
        int GetPower(); // базова сила героя + бонуси від інвентаря
    }
}

