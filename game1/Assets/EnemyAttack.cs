using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    public float betweenAttack = 0.5f;
    public int attackDam = 5;
<<<<<<< HEAD
   // Animator eAnim;
    Animator Anim;
=======
    Animator eAnim;
    //Animator Anim;
>>>>>>> origin/master

    GameObject player;
	GameObject enemy;
    PlayerHealth playerhealth;
<<<<<<< HEAD
    public EnemyHealth enemyhealth;
    chase a;
    bool attackplayer;
    float timer;
        void Start () {
        //enemyhealth = GetComponent<EnemyHealth>();
=======
	chase a;
    bool attackplayer;
    float timer;
        void Start () {
>>>>>>> origin/master
		enemy = GameObject.FindGameObjectWithTag("Respawn");
        player = GameObject.FindGameObjectWithTag("Player");
        playerhealth = player.GetComponent<PlayerHealth>();
    //    eAnim = GetComponent<Animator>();-
		a=enemy.GetComponent<chase>();
	
	}

   void OnTriggerEnter(Collider sword)
    {
		if ((sword.gameObject == player)&&a.getattack())
        {
            attackplayer = true;

        }
    }
    void OnTriggerStay(Collider sword)
    {
        if ((sword.gameObject == player) && a.getattack())
        {
            attackplayer = true;
        }

    }
        void OnTriggerExit(Collider sword)
    {
        if (sword.gameObject == player)
        {
            attackplayer = false;
        }

    }

    void Update () {
        timer += Time.deltaTime;
        if (timer >= betweenAttack && attackplayer)
        {
            attack();
        }
<<<<<<< HEAD
      
=======
        if (playerhealth.currentHealth <= 0)
        {
           // eAnim.SetTrigger("D");
        }
>>>>>>> origin/master
	}
    void attack()
    {
        timer = 0f;
        if (playerhealth.currentHealth > 0)
        {
            playerhealth.TakeDamage(attackDam);
        }
    }
}
