using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryUse : MonoBehaviour
{
    void Start()
    {
        Demon demonLv1 = DemonFactory.CreateDemon(DemonType.Imp);
        Demon demonLv2 = DemonFactory.CreateDemon(DemonType.Fatty);
        Demon demonLv3 = DemonFactory.CreateDemon(DemonType.Boss);

        demonLv1.move();
        demonLv2.move();
        demonLv3.move();
    }

}
