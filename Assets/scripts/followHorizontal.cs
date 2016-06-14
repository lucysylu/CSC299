using UnityEngine;
using System.Collections;

public class followHorizontal : MonoBehaviour {

    private float x;
    public float y = 46;
    private Vector2 pos; 

	void Update () {
        x = GameObject.Find("Spider").transform.position.x - 14;
        transform.position = new Vector2(x, y);

    }
}
