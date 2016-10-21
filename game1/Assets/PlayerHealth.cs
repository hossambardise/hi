using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;                            
    public int currentHealth;                                   
    public Slider healthSlider;
    public Slider powerSlider;
    public Image damageImage;                                   
    public AudioClip deathClip;                                 
    public float flashSpeed = 5f;                               
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     


    Animator anim;        
                                         
<<<<<<< HEAD
   // AudioSource playerAudio;                                   
=======
    AudioSource playerAudio;                                   
>>>>>>> origin/master
    PlayerMovement playerMovement;
    playerAttack playerattack;                 
    bool isDead;                                               
    bool damaged;


    void Start () {
        playerattack = GetComponent<playerAttack>();
        playerMovement = GetComponent<PlayerMovement>();
<<<<<<< HEAD
       // playerAudio = GetComponent<AudioSource>();
=======
        playerAudio = GetComponent<AudioSource>();
>>>>>>> origin/master
        anim = GetComponent<Animator>();
        currentHealth = startingHealth;
    }
    
    void Update () {

        if (damaged)
        {  
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }

    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
<<<<<<< HEAD
        //Debug.LogError(isDead+"   "+currentHealth);
=======
        Debug.LogError(isDead+"   "+currentHealth);
>>>>>>> origin/master
        healthSlider.value = currentHealth;
       // playerAudio.Play();
        if (currentHealth <= 0 && !isDead)
        {
            isDead = true;
            anim.SetTrigger("D");
            //audio and enable the attack 
            playerMovement.enabled = false;
            playerattack.enabled = false;



        }

    }

}
