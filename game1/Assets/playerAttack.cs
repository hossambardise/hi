using UnityEngine;
using System.Collections;

public class playerAttack : MonoBehaviour
{
    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("SAttack", true);
        }
        else if (Input.GetKeyUp("space"))
        {
            anim.SetBool("SAttack", false);
        }
    }
}
