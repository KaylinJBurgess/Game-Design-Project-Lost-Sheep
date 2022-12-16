using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public GameObject TooFar;

    private void OnTriggerExit(Collider Obeject)
    {
        Debug.Log("Obeject Exited the Trigger");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
