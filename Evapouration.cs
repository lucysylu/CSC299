using UnityEngine;
using System.Collections;

public class Evapouration : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {

    public bool isClick() { 
        if (Input.GetMouseButtonDown(0))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
