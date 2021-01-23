using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imgchange : MonoBehaviour
{
    public Sprite[] Img_list;
    public int Img_Num;
    public GameObject Howto_Btn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void imgChange()
    {
        Img_Num++;
        GetComponent<Image>().sprite = Img_list[Img_Num];
        if (Img_Num >= Img_list.Length-1)
        {
            Img_Num = -1;
            Howto_Btn.GetComponent<popup>().Popup();
        }
    }
}
