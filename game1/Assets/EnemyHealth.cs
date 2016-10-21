using UnityEngine;


public class EnemyHealth : MonoBehaviour
{
    public float sinkSpeed = 2.5f;              // The speed at which the enemy sinks through the floor when dead.
    bool isdead;

    Animator anim;                              // Reference to the animator.

    CapsuleCollider capsuleCollider;            // Reference to the capsule collider.
   


    void Awake()
    {
        // Setting up the references.
        anim = GetComponent<Animator>();
        //  enemyAudio = GetComponent<AudioSource>();
        capsuleCollider = GetComponent<CapsuleCollider>();

        // Setting the current health when the enemy first spawns.

    }




    public void TakeDamage()
    {
        // ... the enemy is dead.
        if (!isdead)
        {
            isdead = true;
            capsuleCollider.isTrigger = true;
           // Destroy(this.gameObject);
            anim.SetTrigger("Dead");
        }

    }
}