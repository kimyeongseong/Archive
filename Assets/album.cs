using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class album : MonoBehaviour
{
    public string album_tag;
    public int album_num;
    public GameObject ending_Ani_Obj;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt(album_tag) == 1)
        {
            GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
        if (PlayerPrefs.GetInt(album_tag) == 0)
        {
            GetComponent<Image>().color = new Color(0.4f, 0.4f, 0.4f, (255 / 255));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void album_click()
    {
       
    }
    public void album_Btn()
    {
        if(PlayerPrefs.GetInt(album_tag)==1)
        {
            ending_Ani_Obj.SetActive(true);
        }
    }
}
