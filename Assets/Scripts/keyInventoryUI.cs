using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keyInventoryUI : MonoBehaviour
{
    private TextMeshProUGUI keyText;
    private int total;

    // Start is called before the first frame update
    void Start()
    {
        keyText = GetComponent<TextMeshProUGUI>();
    }


    public void UpdateKeyText(keyInventory keyInventory )

    {
        total = keyInventory.NumberOfkeys;
        keyText.text = total.ToString();

    }
}
