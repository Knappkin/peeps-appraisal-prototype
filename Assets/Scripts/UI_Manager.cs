using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;

public class UI_Manager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject clipboard;
    public GameObject manual;
    public bool isActiveBool;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;

    public PlayerScript playerScript;
    //private GameObject currentImage;
    private List<GameObject> pages;
    int whichIMG;
    void Start()
    {
        isActiveBool = false;
        pages = new List<GameObject>();
        pages.Add(page1);
        pages.Add(page2);
        pages.Add(page3);

        //currentImage = pages[0];
        whichIMG = 0;

        page1.SetActive(true);
        page2.SetActive(false);
        page3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        clipboard.SetActive(isActiveBool);
        manual.SetActive(isActiveBool);
    }

    public void ToggleUI()
    {
        isActiveBool = !isActiveBool;
        playerScript.canMove = !isActiveBool;
    }

    public void NextPage()
    {
        if (whichIMG < 2)
        {
            pages[whichIMG].SetActive(false) ;
            whichIMG++;
            pages[whichIMG].SetActive(true);
        }
        
    }

    public void PrevPage()
    {
        if (whichIMG > 0)
        {
            pages[whichIMG].SetActive(false);
            whichIMG--;
            pages[whichIMG].SetActive(true);
        }
    }
}
