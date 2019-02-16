using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {title, playing, over}

public class GameMaster : MonoBehaviour
{
	public GameState state;
	public bool paused;

	public GameObject pausePanel;

    void Start()
    {
		pausePanel.SetActive (false);
		state = GameState.playing;
    }	

	public void TogglePause()
	{
		if (paused) {
			paused = false;
			pausePanel.SetActive (false);
			Time.timeScale = 1;
		} else {
			paused = true;
			pausePanel.SetActive (true);
			Time.timeScale = 0;
		}

	}
		
    void Update()
    {
		if (state == GameState.playing) {
			if (Input.GetKeyDown (KeyCode.Escape)) {
				TogglePause ();
			}
		}
    }
}
