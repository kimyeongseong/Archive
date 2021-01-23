using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class popup : MonoBehaviour
{
    public GameObject PopUp_Obj;
    public bool OnOff_obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void result()
    {
        PopUp_Obj.GetComponent<Pause>().pause();
    }
    public void Popup()
    {
        if (OnOff_obj)
        {
            OnOff_obj = false;
            PopUp_Obj.SetActive(OnOff_obj);
        }
        else if(!OnOff_obj)
        {
            OnOff_obj = true;
            PopUp_Obj.SetActive(true);
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
