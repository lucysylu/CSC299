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

    public Evapouration isEvapourating { get; private set; }

    void Update ()
    {
        isEvapourating = new Evapouration();
        float moveVertical = Input.GetAxis("Vertical");

        if (isEvapourating.isClick())
        {
            Vector3 movement = new Vector3(transform.position.x, moveVertical, 0.0f);
            GetComponent<Rigidbody>().velocity = movement * speed;
        }

        GetComponent<Rigidbody>().position = new Vector3
        (
            transform.position.x, transform.position.y,
            //Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.yMin, boundary.yMax), 
            0.0f
        );
	}
}
