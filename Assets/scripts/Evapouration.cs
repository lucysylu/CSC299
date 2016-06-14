using UnityEngine;
using System.Collections;

public class Evapouration : MonoBehaviour {



    public bool isClick()
    { 
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
