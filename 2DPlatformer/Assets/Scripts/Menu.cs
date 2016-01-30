using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject mainMenuHolder;
	public GameObject storyHolder;
	public GameObject continueBtn;

	public void Play()
	{
		SceneManager.LoadScene("Level1");
	}

	public void PlayIntro()
	{
		mainMenuHolder.SetActive(false);
		storyHolder.SetActive(true);
	}
}
