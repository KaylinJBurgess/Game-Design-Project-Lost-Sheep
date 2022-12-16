using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EllamarbleInventoryUI : MonoBehaviour
{
    private TextMeshProUGUI MarbleText;
    private int totalMarble;

    // Start is called before the first frame update
    void Start()
    {
        MarbleText = GetComponent<TextMeshProUGUI>();
    }


    public void UpdateMarbleText(EllamarbleInventory EllamarbleInventory)

    {
        totalMarble = EllamarbleInventory.NumberOfMarblesElla;
        MarbleText.text = totalMarble.ToString();

    }
}



