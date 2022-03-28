using UnityEngine;

public class TargetShooting : MonoBehaviour
{
    public float health = 50f;


    public void TakeDamage(float damage_amount)
    {
        health -= damage_amount;
        if(health <= 0f)
        {
            Die();
        }
    }

     void Die()
     {
        Destroy(gameObject);
     }
    

}
