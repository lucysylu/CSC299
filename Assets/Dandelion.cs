using UnityEngine;
using System.Collections;

public class Dandelion : MonoBehaviour
// The sine path of the dandelion seed
// Modified from the code on 
//http://answers.unity3d.com/questions/803434/how-to-make-projectile-to-shoot-in-a-sine-wave-pat.html
// and http://answers.unity3d.com/questions/434717/how-to-make-a-sine-wave-with-a-transform.html
{
    public GameObject DandelionSeed;
    private float MoveSpeed; // Speed of movement
    private float frequency; // Frequency of sine waves
    private float amplitude;  // Height of sine wave
    private float x, y, y_of_cam;
    private float height; // Camera height
    private float width; // Camera width
    public bool isCollided;

    void Start()
    {
        isCollided = false;
        height = 2 * Camera.main.orthographicSize;
        MoveSpeed = Random.Range(5f, 10f);
        frequency = Random.Range(0.1f, 1f);
        amplitude = Random.Range(-0.5f, 0.5f); // dandelion could start going down, or up
        //width = height * (Camera.main.aspect);

        x = GameObject.Find("Spider").transform.position.x - 60; // Start from edge of camera view
        y_of_cam = GameObject.Find("Spider").transform.position.y;
        y = Random.Range(y_of_cam - height / 2, y_of_cam + height / 2);
    }


    void Update()
    {
        if (isCollided == false)
        {
            x += Time.deltaTime * MoveSpeed;
            y += (Time.deltaTime * MoveSpeed) * // Speed and smoothing factor
                Mathf.Sin(Time.time * frequency) *  // to add onto y
                amplitude;
            transform.position = new Vector3(x, y, 30);
        }

        else
        {
            transform.position = new Vector3
                (
                    x = GameObject.Find("Spider").transform.position.x,
                    y = GameObject.Find("Spider").transform.position.y,
                    30
                );

        }

    }
}
