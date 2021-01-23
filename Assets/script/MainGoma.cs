using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGoma : MonoBehaviour
{
    public GameObject player;
    public GameObject Fade;
    public Sprite charather;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("Scene");
        PlayerPrefs.Save();
        Screen.SetResolution(1920, 1080, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ani_Evente()
    {
        player.SetActive(false);
    }
    public void Nag()
    {
        player.GetComponent<Animator>().enabled = false;
        player.GetComponent<SpriteRenderer>().sprite = charather;
    }
    public void end()
    {
        Fade.SetActive(true);
    }
}
