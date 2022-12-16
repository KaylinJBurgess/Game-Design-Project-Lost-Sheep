using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class marbleInventoryUI : MonoBehaviour
{
    private TextMeshProUGUI MarbleText;
    private int totalMarble;

    // Start is called before the first frame update
    void Start()
    {
        MarbleText = GetComponent<TextMeshProUGUI>();
    }


    public void UpdateMarbleText(marbleInventory marbleInventory)

    {
        totalMarble = marbleInventory.NumberOfMarbles;
        MarbleText.text = totalMarble.ToString();

    }
}