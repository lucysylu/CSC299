using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float yMin, yMax;

}

public class Flotation : MonoBehaviour {

    public float speed;
    public Boundary boundary;
	public GameObject cloud;
	private Rigidbody rb;

	void Start (){

		rb = GetComponent<Rigidbody> ();

	}
    void Update ()
    {
        float moveVertical = Input.GetAxis("Vertical");

		if (cloud.GetComponent<Renderer>().material.color.a != 1.0f)
        {
            Vector3 movement = new Vector3(transform.position.x, moveVertical, 0.0f);
            rb.velocity = movement * speed;
        }

		rb.position = new Vector3
        (
            transform.position.x, transform.position.y,
            //Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.yMin, boundary.yMax), 
            0.0f
        );
	}
}
