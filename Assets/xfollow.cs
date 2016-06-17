using UnityEngine;
using System.Collections;

public class xfollow : MonoBehaviour
{

    private float x;
    public float y = 50;
    private Vector2 pos;

    void Update()
    {
        x = GameObject.Find("Spider").transform.position.x - 20;
        transform.position = new Vector3(x, y, 30);

    }
}
