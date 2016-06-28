using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public GameObject player;
	public Vector3 position;
	public bool rise;
    public int weighedDownBy = 0;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
		position = new Vector3 (player.GetComponent<Rigidbody>().position.x, 0, 0);
        rb = GetComponent<Rigidbody>();
    }


    void Update ()
    {
		position.x += Time.deltaTime * 1.5f;
		position.y = player.GetComponent<Rigidbody> ().position.y;
		position.z = player.GetComponent<Rigidbody> ().position.z;

        // Spider movement: check for cloud tap
		if (rise)
        {
			if (position.y < 46f)
            {
				position.y += Time.deltaTime * 5;
			}
			player.GetComponent<Rigidbody> ().useGravity = false;
		}

        else
        {
			player.GetComponent<Rigidbody> ().useGravity = true;
		}

		player.GetComponent<Rigidbody> ().position = position;


        // Check for death
        if (position.y == 0.5)
        {
            //activate death sequences
        }
    }

  

}
