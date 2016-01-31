using UnityEngine;
using System.Collections;

public class StoryController : MonoBehaviour {

	public GameObject[] introBackgrounds;
	public GameObject continueBtn;
	int introIndex = 0;

	void Start()
	{
		introBackgrounds[introIndex].SetActive(true);
		introIndex++;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (introIndex == introBackgrounds.Length)
			{
				continueBtn.SetActive(true);
			}
			else
			{
				ChangeSlide();
			}
		}
	}

	void ChangeSlide()
	{
		introBackgrounds[introIndex - 1].SetActive(false);
		introBackgrounds[introIndex].SetActive(true);
		introIndex++;
	}
}
