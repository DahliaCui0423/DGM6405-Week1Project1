using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public int health;
    public static int numOfHearts = 3;
    public GameObject gtext;
    public GameObject text;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Start()
    {
        gtext.active = false;
        text.active = false;
    }

    void OnMouseDown()
    {
        numOfHearts--;
        //Debug.Log(numOfHearts);
        //gameObject.SetActive(false);
        text.active = true;
        //Destroy(gameObject, 5f);
        Destroy(text, 5f);
        if (numOfHearts == 0)
        {
            gtext.active = true;
        }
    }

    void Update()
    {

        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
