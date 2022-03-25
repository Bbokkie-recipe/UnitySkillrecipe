using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    MyWeapon myWeapon;
    void Start()
    {
        myWeapon = new MyWeapon();
        myWeapon.setWeapon(new Bullet());
    }
    public void ChangeBullet()
    {
        myWeapon.setWeapon(new Bullet());
    }
    public void ChangeMissile()
    {
        myWeapon.setWeapon(new Missile());
    }
    public void ChangeArrow()
    {
        myWeapon.setWeapon(new Arrow());
    }
    public void Fire()
    {
        myWeapon.Shoot();
    }
}
