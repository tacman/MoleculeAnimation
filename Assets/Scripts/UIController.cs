using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public Button pauseButton;
    // this event is invoked when we pause
    public void ShowPauseMenu()
    {
        pauseButton.gameObject.SetActive(true);
    }
    
    public void HidePauseMenu()
    {
        pauseButton.gameObject.SetActive(false);
    }
    
}
