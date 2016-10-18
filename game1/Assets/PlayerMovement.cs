using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float movementSpeed = 100;
    Animator anim;
   
     //public float turningSpeed = 60;
    public static Camera   GameCamera;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

	void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
		transform.Translate(0, 0, horizontal);
		float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate(-vertical, 0,0 );
        animation(h, v);

	}
    void animation(float h,float v)
    {
        bool walking = h != 0f || v != 0f;
        anim.SetBool("PIsWalking",walking);
        anim.SetBool("IsIdle", !walking);

        //	if(walking)anim.SetBool ("SAttack", false);

    }
} /* public class PlayerMovement : MonoBehaviour {
	public float movementSpeed = 10;
	public float turningSpeed = 60;

	void Update() {
		float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
		transform.Rotate(0, horizontal, 0);

		float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate(0, 0, vertical);
	}
}*/