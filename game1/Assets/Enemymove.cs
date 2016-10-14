using UnityEngine;
using System.Collections;

public class Enemymove : MonoBehaviour {
    Transform Player;
    NavMeshAgent nav;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(Player.position);
	
	}
}
