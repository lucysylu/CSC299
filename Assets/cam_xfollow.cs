using UnityEngine;
using System.Collections;

public class cam_xfollow : MonoBehaviour
{

    private float x;
    private float y;

    void Update()
    {
        x = GameObject.Find("Spider").transform.position.x;
        y = GameObject.Find("Spider").transform.position.y;

        transform.position = new Vector2(x, y);

    }
}
