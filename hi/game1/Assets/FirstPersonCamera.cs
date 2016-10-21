using UnityEngine;
using System.Collections;

public class FirstPersonCamera : MonoBehaviour {
	// Rigidbody r;
	/*public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;

	public float minimumX = -360F;
	public float maximumX = 360F;

	public float minimumY = -360F;
	public float maximumY = 360F;

	float rotationY = 0F;

	void Update()
	{
		if (axes == RotationAxes.MouseXAndY)
		{
			float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

			transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
		}
		else if (axes == RotationAxes.MouseX)
		{
			transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

			transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
		}
	}

	void Start()
	{

	}
}*/ public float looksense = 5f;
	public float xRotation;
	public float yRotation;
	public float currentxRotation;
	public float currentyRotation;
	public float xRotationV;
	public float yRotationV;
	public float looksmoothDamp = 0.4f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		xRotation -= Input.GetAxis("Mouse Y") * looksense;
		yRotation += Input.GetAxis("Mouse X") * looksense;
		xRotation = Mathf.Clamp(xRotation, -90, 90);
		//currentxRotation = Mathf.SmoothDamp(currentxRotation, xRotation, ref xRotation, looksmoothDamp);
		//  currentyRotation = Mathf.SmoothDamp(currentyRotation, yRotation, ref yRotation, looksmoothDamp);

		transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
	}
}

