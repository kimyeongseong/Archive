using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public GameObject GomaGom;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void restart()
    {
        PlayerPrefs.SetInt("Scene", 1);
        PlayerPrefs.Save();
    }
    public void exit()
    {
        PlayerPrefs.SetInt("Scene", 0);
        PlayerPrefs.Save();
    }
    public void Loding()
    {
        SceneManager.LoadSceneAsync("LodingScene");
    }
    public void Change_Scene()
    {
        GomaGom.GetComponent<Animator>().enabled = true;
        PlayerPrefs.SetInt("Scene", 1);
        PlayerPrefs.Save();
        //SceneManager.LoadSceneAsync(Scene_name);
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
         Application.Quit();
#endif
    }
}
