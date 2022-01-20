using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TopDownFunk.Statics;

[Serializable]
public struct BulletStats
{
    public float Speed;
    public float Damage;
    public int bulletPerShot;
    public int bulletPerMagazine;
    public float reloadTime;
    public float bulletInaccuracyRate;
    public float bulletFireRate;
    public float armorPenentration;
}
