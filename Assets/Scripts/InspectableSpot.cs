using UnityEngine;

public class InspectableSpot : MonoBehaviour
{
    public GameObject player;
    public GameObject ObservationSection;
    public float interactDist;
    public GameObject interactIcon;
    private bool canInteract;

    public UI_Manager uiManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactIcon.SetActive(false);
        ObservationSection.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = player.transform.position;
        if (((Vector2)transform.position - playerPos).magnitude < interactDist)
        {
            canInteract = true;
            interactIcon.SetActive(true);
        }
        else
        {
            canInteract = false;
            interactIcon.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            ObservationSection.SetActive(true);
            uiManager.isActiveBool = true;
            Destroy(gameObject);
        }

    }
}
