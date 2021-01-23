using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public int tree;
    public GameObject boat;
    public Sprite[] boatsprite;
    public int clearPoint;
    public int clearType;
    public bool nottree;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (tree == 0)//1~4
        {
            if (clearPoint <= 20)
            {
                clearType = 0;
            }
            else if (clearPoint >= 21)
            {
                clearType = 1;
            }
        }
    }
    public void Upgrade()
    {
        clearPoint = Random.Range(0, 100);

        if (tree >= 1 && tree <= 4)//1~4
        {
            boat.GetComponent<SpriteRenderer>().sprite = boatsprite[0];
            if (clearPoint <= 20)
            {
                clearType = 2;
            }
            else if (clearPoint >= 21)
            {
                clearType = 3;
            }
        }
        else if (tree >= 5 && tree <= 15)//5~15
        {
            boat.GetComponent<SpriteRenderer>().sprite = boatsprite[1];
            if (clearPoint <= 40)
            {
                clearType = 4;
            }
            else if (clearPoint >= 41)
            {
                clearType = 5;
            }
        }
        else if (tree >= 16 && tree <= 30)//16~30
        {
            boat.GetComponent<SpriteRenderer>().sprite = boatsprite[2];
            if (clearPoint <= 50)
            {
                clearType = 6;
            }
            else if (clearPoint >= 51)
            {
                clearType = 7;
            }
        }
        else if (tree >= 31 && tree <= 39)//31~39
        {
            boat.GetComponent<SpriteRenderer>().sprite = boatsprite[3];
            if (clearPoint <= 60)
            {
                clearType = 8;
            }
            else if (clearPoint >= 61)
            {
                clearType = 9;
            }
        }
        else if (tree >= 50)//50~
        {
            boat.GetComponent<SpriteRenderer>().sprite = boatsprite[5];
            if (clearPoint >= 0)
            {
                clearType = 10;
            }
        }
    }
}
