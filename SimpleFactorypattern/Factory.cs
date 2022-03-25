using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DemonType
{
    Imp,
    Fatty,
    Boss
}
public class DemonFactory
{
    public static Demon CreateDemon(DemonType demonType)
    {
        Demon demon = null;
        switch(demonType)
        {
            case DemonType.Imp:
                demon = new Imp();
                break;
            case DemonType.Fatty:
                demon = new Fatty();
                break;
            case DemonType.Boss:
                demon = new Boss();
                break;
        }

        return demon;
    }

}
