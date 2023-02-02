using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {
		// Set the font size and color to the win color and disable the timer
		collision.gameObject.GetComponent<Timer>().enabled = false;
		collision.gameObject.GetComponent<Timer>().TimerText.fontSize = 80;
		collision.gameObject.GetComponent<Timer>().TimerText.color = Color.green;
    }
}