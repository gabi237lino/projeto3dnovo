using UnityEngine;

namespace NavGame.Core 
{
    //CHARACTER EVENTS
    public delegate void OnAttckHitEvent(Vector3 position);
    public delegate void OnHealthChangedEvent(int maxHealth, int currentHealth);
    public delegate void OnDiedEvent();
}
