using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.Bullets
{
    public class Bullet : AbstractBulletMono
    {
        private void OnCollisionEnter(Collision collision)
        {
            this.gameObject.SetActive(false);
        }
    }
}
