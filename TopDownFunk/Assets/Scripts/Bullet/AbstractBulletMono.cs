using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.Bullets
{
    public abstract class AbstractBulletMono : MonoBehaviour
    {
        [SerializeField] public BulletScriptableObject bulletScriptableObject;
        [SerializeField] private Renderer _renderer;
        private MaterialPropertyBlock _materialPropertyBlock;
        public string BulletName { get { return bulletScriptableObject.bulletName; } }
        public string BulletTag { get { return bulletScriptableObject.bulletTag; } }
        public string BulletType { get { return bulletScriptableObject.bulletType; } }
        public Material BulletMaterial { get { return bulletScriptableObject.bulletMaterial; } }
        public BulletStats BulletStat { get { return bulletScriptableObject.bulletStats; } }

        private void OnEnable()
        {
            bulletScriptableObject.SetBullet(this);
            _materialPropertyBlock = new MaterialPropertyBlock();
            _materialPropertyBlock.SetColor("_Color", bulletScriptableObject.color);
            _renderer.SetPropertyBlock(_materialPropertyBlock);
        }


    }
}
