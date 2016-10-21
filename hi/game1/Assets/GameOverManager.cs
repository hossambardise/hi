using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour
{

    public PlayerHealth playerhealth;
    public float restartDelay = 5f;
    GameObject player;
    Animator anim;
    float restartTime;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerhealth=player.GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerhealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
            restartTime += Time.deltaTime;
            if (restartTime >= restartDelay)
            {
                Application.LoadLevel("startmenu");
            }
        }

    }
}
