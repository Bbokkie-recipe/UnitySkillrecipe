using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�߻�Ŭ����
public abstract class Demon
{//�߻��Լ�
    public abstract void move(); 
}

public class Imp : Demon
{
    public Imp()
    {
        Debug.Log("Imp�� ����...");
    }
    public override void move()
    {
        Debug.Log("Imp�� �̵�..");
    }

}
public class Fatty : Demon
{
    public Fatty()
    {
        Debug.Log("Fatty�� ����...");
    }
    public override void move()
    {
        Debug.Log("Fatty�� �̵�...");
    }
}

public class Boss : Demon
{
    public Boss()
    {
        Debug.Log("Boss�� ����...");
    }
    public override void move()
    {
        Debug.Log("Boss�� �̵�...");
    }
}