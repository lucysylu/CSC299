using UnityEngine;
using System.Collections;

public class CiclularProgress : MonoBehaviour {
	
	public int timeToComplete = 3;
	public Evapouration evap;
	public bool raincomplete = false;
    public float progress;
	
	// Use this for initialization
	void Start () {
		//Use this to Start progress
		gameObject.GetComponent<Renderer> ().material.SetFloat ("_Progress", 0);
	}

	public void SetProgress (float prog) {

        progress += prog;
        progress = progress/30f;
        print(progress);
        if (progress > 1)
        {
            progress = 1;
        }
		gameObject.GetComponent<Renderer> ().material.SetFloat ("_Progress", progress);

        if (raincomplete == true)
        {
            progress = 0;
        }
	}

//	IEnumerator RadialProgress(float time)
//	{
//		float rate = 1 / time;
//		float i = 0;
//
//		if (raincomplete) {
//			gameObject.GetComponent<Renderer> ().material.SetFloat ("_Progress", 0);
//			i = 0;
//		}
//		while (i < 0.5)
//		{
//			i += Time.deltaTime * rate;
//			gameObject.GetComponent<Renderer>().material.SetFloat("_Progress", i);
//			yield return 0;
//		}
//	}
}