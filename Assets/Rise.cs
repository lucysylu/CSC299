using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rise : MonoBehaviour {

	public Text text;
	public Image arrows;
	public RectTransform rect;
	public RectTransform imgRect;
	public Color color;
	public Color color2;
	public Vector2 startPosition;
	public Vector2 endPosition;
	public Vector2 imgStartPos;
	public float time; 
	public bool go;


	// Use this for initialization
	void Start () {
		go = false;
		endPosition = new Vector2(startPosition.x, 700f);
		rect.anchoredPosition = startPosition;
		imgRect.anchoredPosition = imgStartPos;
		color2 = new Color(1, 1, 1, 1);
		color = new Color (1, 1, 1, 1);
	}

	// Update is called once per frame
	void Update () {

		if (rect.anchoredPosition.y < 360f && go == true) {

			time += Time.deltaTime;

			float totalTime = 3f;

			rect.transform.position = Vector3.Lerp (startPosition, endPosition, time/totalTime);
			if (color2.a != 0f) {
				color2.a -= 0.008f;
			}
			if (color.a != 0f) {
				color.a -= 0.015f;
			}
			text.color = color2;
			arrows.color = color;
			imgRect.transform.position = Vector3.Lerp (imgStartPos, endPosition, time/totalTime);
		} else {

			rect.anchoredPosition = startPosition;
			imgRect.anchoredPosition = imgStartPos;
			color.a = 1f;
			color2.a = 1f;
			text.color = color;
			arrows.color = color2;
			time = 0;
			go = false;
		}

	}
}
