using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ParticleSystem _deathEffect;

    public event UnityAction<Enemy> Dying;
    
    public void Die()
    {
        Instantiate(_deathEffect, transform.position, Quaternion.identity);
        Dying?.Invoke(this);
        Destroy(gameObject);
    }
}