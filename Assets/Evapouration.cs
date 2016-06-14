using UnityEngine;
using UnityEngine.UI;
using ProgressBar;
using System.Collections;

public class Evapouration : MonoBehaviour {

	public GameObject cloud;
	private Color color;
	public bool evap = false;
	public Text text;
	public Image arrows;
	private float start;
	public Light light;
	public float time = 0;
	public float speed;
	public float speed2;
	public float duration = 3f;
	public Vector3 direction;
	private Color color2;
	public RectTransform rect;
	public RectTransform imgRect;
	public Vector2 startPosition;
	public Vector2 imgStartPos;
	public bool click = false;
	public Rise rise;
	public ProgressBarBehaviour bar;
	public float totalTime;

	void Start() {

		startPosition = new Vector2(960, -40);
		imgStartPos = new Vector2(960, 0);
		rise.startPosition = startPosition;
		rise.imgStartPos = imgStartPos;
		text.enabled = false;
		arrows.enabled = false;
	}

	void TextReset(){

		if (rect.anchoredPosition.y > 350) {

			text.enabled = false;
			arrows.enabled = false;
			rect.anchoredPosition = startPosition;
			imgRect.anchoredPosition = imgStartPos;
			rise.go = false;
		}
	}

	void Update() { 

		if (Input.GetMouseButton(0)){
				
			color = cloud.GetComponent<Renderer> ().material.color;
			color.a = 0.2f; color.r = 1; color.g = 1; color.b = 1;
			cloud.GetComponent<Renderer> ().material.color = color;
		
			light.enabled = true;
			text.enabled = true;
			color2 = new Color (1, 1, 1, 1);
			color = new Color (1, 1, 1, 1);
			text.color = color2;
			arrows.color = color2;
			arrows.enabled = true;
			rise.go = true;
			evap = true;
			time += Time.deltaTime;
			TextReset ();

		} 
		else {
			color.a = 1.0f; color.r = 1; color.g = 1; color.b = 1;
			cloud.GetComponent<Renderer> ().material.color = color;
			evap = false;
			light.enabled = false;
			click = false;
			TextReset ();
			bar.IncrementValue (time);
			totalTime += time;
			time = 0;
		}
			
	}
}
