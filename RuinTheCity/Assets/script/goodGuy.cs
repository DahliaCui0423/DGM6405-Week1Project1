using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class goodGuy : MonoBehaviour
{
    public GameObject TX;
    public GameObject Wtext;
    public int point;
    public static int numOfPoints = 2;
    void Start()
    {
        Wtext.active = false;
        TX.active = false;
       
        
    }
    private void OnMouseDown()
    { 
        numOfPoints--;
        Destroy(gameObject);
        TX.active = true;
        if (numOfPoints == 0)
            {
                Wtext.active = true;
                playGame();
            }
    }
    void Update()
    {
        if (point > numOfPoints)
        {
            point = numOfPoints;
        }
    }

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
