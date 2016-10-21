using UnityEngine;
using System.Collections;

public class playerAttack : MonoBehaviour
{   
   public Animator anim;
   // public bool attacked=false;
   // int shootablelayer;
    EnemyHealth enemyhealth;
    // Use this for initialization
    void Start()
    {
        
     //   shootablelayer = LayerMask.GetMask("shootable");
        
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    { //  if()
        if (Input.GetKeyDown("space"))
        {
            //attacked = true;
            anim.SetBool("SAttack", true);

        }
        else if (Input.GetKeyUp("space"))
        {
           // attacked = false;
            anim.SetBool("SAttack", false);
        }
    }
    
}
