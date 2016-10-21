using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {

			Application.LoadLevel("level 2");
        }  
         }

}
