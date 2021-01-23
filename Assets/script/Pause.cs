using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pause_type;
    public GameObject pause_Popup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pause()
    {
        if(pause_type)
        {
            pause_type = false;
            Time.timeScale = 1;
            pause_Popup.SetActive(false);
        }
        else if (!pause_type)
        {
            pause_type = true;
            Time.timeScale = 0;
            pause_Popup.SetActive(true);
        }
    }
}
