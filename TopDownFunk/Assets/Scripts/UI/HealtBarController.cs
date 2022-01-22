using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TopDownFunk.Statics;
using TopDownFunk.PlayerController;
using TopDownFunk.Enemy;

namespace TopDownFunk.UI
{
    public class HealtBarController : MonoBehaviour
    {
        [SerializeField] private Image healtBar;
        [SerializeField] private Image ArmorBar;

        private void Awake()
        {
            Player.OnDamageTake += SetHealthBar;
            AbstractEnemy.OnDamageTake += SetHealthBar;
            Debug.Log("Health bar code enabled");
        }

        public void SetHealthBar(Stats stats)
        {
            healtBar.fillAmount = stats.Health * 0.01f;
            ArmorBar.fillAmount = stats.Armor * 0.01f;
            Debug.Log("Hellö");
        }
    }
}
