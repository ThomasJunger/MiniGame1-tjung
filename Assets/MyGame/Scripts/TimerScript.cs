using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour 
{
  public int timeLeft = 60; //Seconds Overall
  public TextMeshProUGUI countdown; //UI Text Object
  public Canvas timeOver;

  void Start () {
    StartCoroutine("LoseTime");
    Time.timeScale = 1; //Just making sure that the timeScale is right
  }

  void Update () 
  {
    countdown.text = (" " + timeLeft); //Showing the Score on the Canvas
	if (timeLeft == 0)
	{
		SceneManager.LoadScene("EndScene");
	}
  }

  //Simple Coroutine
  IEnumerator LoseTime()
  {
    while (true) {
      yield return new WaitForSeconds (1);
      timeLeft--; 
    }

  }
}