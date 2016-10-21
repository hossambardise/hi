using UnityEngine;
using System.Collections;

public class chase : MonoBehaviour {
	GameObject player;
	static Animator anim;
	public bool isatt;
<<<<<<< HEAD
    PlayerHealth playerhealth;
	// Use this for initialization
	void Start () {
        
		player = GameObject.FindGameObjectWithTag ("Player");
        playerhealth = player.GetComponent<PlayerHealth>();
        anim = GetComponent<Animator> ();
=======
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		anim = GetComponent<Animator> ();
>>>>>>> origin/master
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

<<<<<<< HEAD
        if (playerhealth.currentHealth <= 0)
        {
            anim.SetBool("killed", true);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isWalking", false);

            //            anim.SetBool("isAttacking", true);
            //          anim.SetBool("killed", true);
        }
    }
=======

		//Vector3 direction = player.position - this.transform.position;
		//float angle = Vector3.Angle (direction, this.transform.forward);
		//if (Vector3.Distance (player.position, this.transform.position) < 1) {
			
			//this.transform.rotation = Quaternion.Slerp (this.transform.rotation,
				              //          Quaternion.LookRotation(direction), 0.3f);
		/*	anim.SetBool ("isIdle", false);
			if (direction.magnitude < 2) {
				this.transform.Translate (0, 0, 0.2f);
				anim.SetBool ("isWalking", true);
				anim.SetBool ("isAttacking", false);
			} else {
				anim.SetBool ("isAttacking", true);
				anim.SetBool ("isWalking", false);
			}
				
		else {
			anim.SetBool ("isIdle", true);
			anim.SetBool ("isWalking", false);
			anim.SetBool ("isAttacking", false);
		}
	*/}
>>>>>>> origin/master
	public void setattack(bool flag){
		isatt = flag;
	}
	public bool getattack(){
		return isatt; 
	}

}
