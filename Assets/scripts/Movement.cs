using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float MoveSpeed = 5.0f;

    public float frequency = 2.0f; // Speed of sine movement
    public float magnitude = 0.5f;  //Size of sine movement
    private float x, y;
  
    private float horzExtent = Camera.main.orthographicSize* Screen.width / Screen.height;


    void Start () {
        //Debug.log("ortho camera width", horzExtent);
        x = GameObject.Find("Spider").transform.position.x - horzExtent;
        y = Random.Range(30, 40);
    }
	

	void Update () {
        x += GameObject.Find("Spider").transform.position.x - x;
        y += (Time.deltaTime * MoveSpeed) * Mathf.Sin(Time.time * frequency) * magnitude;
        transform.position = new Vector3(x, y, 0); 

	}
}
