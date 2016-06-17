using UnityEngine;
using System.Collections;

public class gui_xfollow : MonoBehaviour
{

    private float x;
    private float y;
    private Vector2 pos;

    void Update()
    {
        x = GameObject.Find("Spider").transform.position.x + 5;
        y = GameObject.Find("Spider").transform.position.y + 11;
        transform.position = new Vector3(x, y, 30);

    }
}
