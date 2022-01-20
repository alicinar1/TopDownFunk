using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Statics;

namespace TopDownFunk.Damage
{
    public static class DamagebleHelper
    {
        public static Dictionary<int, IDamagable> DamagableList = new Dictionary<int, IDamagable>();

        public  static void InitializeDamageble(this IDamagable damagable)
        {
            DamagableList.Add(damagable.InstanceID, damagable);
            
        }

        public static void DestroyDamageble(this IDamagable damagable)
        {
            DamagableList.Remove(damagable.InstanceID);
        }
    }

    public interface IDamagable
    {
        int InstanceID { get; }
        void Damage();
        abstract void DestroyObject();
    }
}
