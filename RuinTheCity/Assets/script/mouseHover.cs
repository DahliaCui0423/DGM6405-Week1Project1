using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseHover : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boxText;

    void Start()
    {
        boxText.SetActive(false);
    }

    public void OnMouseOver()
    {
        boxText.SetActive(true);
    }

    public void OnMouseExit()
    {
        boxText.SetActive(false );
    }
}
