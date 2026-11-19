using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject clipboard;
    public GameObject manual;
    public bool isActiveBool;
    void Start()
    {
        isActiveBool = true;
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
    }
}
