using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float _projectileSpeed = 10f;

    float _damageCaused;

    private void OnTriggerEnter(Collider collider)
    {
        Component damageableComponent = collider.gameObject.GetComponent(typeof(IDamageable));
        if (damageableComponent)
        {
            (damageableComponent as IDamageable).TakeDamage(_damageCaused);
        }
    }

    public void setDamage(float _damage)
    {
        _damageCaused = _damage;
    }
}
