using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keyInventoryUIElla : MonoBehaviour
{
    private TextMeshProUGUI keyText;
    private int total;

    // Start is called before the first frame update
    void Start()
    {
        keyText = GetComponent<TextMeshProUGUI>();
    }


    public void UpdateKeyText(keyInventoryElla keyInventoryElla)

    {
        total = keyInventoryElla.NumberOfkeysElla;
        keyText.text = total.ToString();

    }
}
