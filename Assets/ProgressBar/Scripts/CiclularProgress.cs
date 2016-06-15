using UnityEngine;
using System.Collections;

public class CiclularProgress : MonoBehaviour {
	
	public int timeToComplete = 3;
	public Evapouration evap;
	public bool raincomplete = false;
	
	// Use this for initialization
	void Start () {
		//Use this to Start progress
		gameObject.GetComponent<Renderer> ().material.SetFloat ("_Progress", 0);
//		StartCoroutine(RadialProgress(timeToComplete));
	}

	void SetProgress (float prog) {

		gameObject.GetComponent<Renderer> ().material.SetFloat ("_Progress", prog);
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