using UnityEngine;
using System.Collections;

public class swordattack : MonoBehaviour {
    playerAttack playerattack;
    GameObject player;
   
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerattack = player.GetComponent<playerAttack>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter(Collider sword)
    {
        if ((sword.gameObject.tag == "Respawn")&&playerattack.anim.GetBool("SAttack"))
        {
            
                Animator anim = sword.gameObject.GetComponent<Animator>();
            anim.SetTrigger("Dead");
            CapsuleCollider capsuleCollider = sword.gameObject.GetComponent<CapsuleCollider>();
            capsuleCollider.isTrigger = true;





            //            Debug.LogError("jlhoho");
            Destroy(sword.gameObject, 3);
        }
    
    }

}
