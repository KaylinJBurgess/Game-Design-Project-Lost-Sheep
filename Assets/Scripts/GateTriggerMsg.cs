/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GateTriggerMsg : MonoBehaviour
{

    public GameObject DialogBox;
    public GameObject dialogText;
    public string dialog;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& playerInRange)
        {
            if (DialogBox.activeInHierarchy)
            {
                DialogBox.SetActive(false);
            }
            else
            {
                DialogBox.SetActive(true);
                var dialogText = GetComponent<Text>();
                dialogText.text = dialog.ToString();
                    //dialogText.GetComponent<Text>(dialog);
            }

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sheep"))
        {
            playerInRange = true;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sheep"))
        {
            playerInRange = false;

            DialogBox.SetActive(false);
        }

    }
}

*/