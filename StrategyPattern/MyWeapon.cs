using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon : MonoBehaviour
{
    //������
    private IWeapon weapon;

    //���� ��ȯ �����ϰ�
    public void setWeapon(IWeapon weapon)
    {
        this.weapon = weapon;
    }
    public void Shoot()
    {
        weapon.Shoot();
    }
}
