using UnityEngine;
using System.Collections;

public class chase : MonoBehaviour {
	GameObject player;
	static Animator anim;
	public bool isatt;
    PlayerHealth playerhealth;
	// Use this for initialization
	void Start () {
        
		player = GameObject.FindGameObjectWithTag ("Player");
        playerhealth = player.GetComponent<PlayerHealth>();
        anim = GetComponent<Animator> ();
		anim.SetBool ("isWalking", true);
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject == player) {
			anim.SetBool ("isAttacking",true);
			setattack(true);
			anim.SetBool ("isWalking", false);

		
		}

	
	}
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            anim.SetBool("isAttacking", true);
            setattack(true);
            anim.SetBool("isWalking", false);


        }

    }
    void OnTriggerExit(Collider other){
		anim.SetBool ("isAttacking",false);
		setattack(false);
		anim.SetBool ("isWalking", true);


	}

	// Update is called once per frame
	void Update () {

        if (playerhealth.currentHealth <= 0)
        {
            anim.SetBool("killed", true);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isWalking", false);

            //            anim.SetBool("isAttacking", true);
            //          anim.SetBool("killed", true);
        }
    }
	public void setattack(bool flag){
		isatt = flag;
	}
	public bool getattack(){
		return isatt; 
	}

}
