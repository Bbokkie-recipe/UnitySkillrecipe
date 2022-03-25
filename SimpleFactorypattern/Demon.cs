using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//추상클래스
public abstract class Demon
{//추상함수
    public abstract void move(); 
}

public class Imp : Demon
{
    public Imp()
    {
        Debug.Log("Imp의 등장...");
    }
    public override void move()
    {
        Debug.Log("Imp의 이동..");
    }

}
public class Fatty : Demon
{
    public Fatty()
    {
        Debug.Log("Fatty의 등장...");
    }
    public override void move()
    {
        Debug.Log("Fatty의 이동...");
    }
}

public class Boss : Demon
{
    public Boss()
    {
        Debug.Log("Boss의 등장...");
    }
    public override void move()
    {
        Debug.Log("Boss의 이동...");
    }
}