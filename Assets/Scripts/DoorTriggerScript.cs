using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTriggerScript : MonoBehaviour
{
    public GameObject LoadingPanel;

    private void Awake()
    {
        if (LoadingPanel != null)
            LoadingPanel.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(LoadingPanel != null)
            LoadingPanel.SetActive(true);

        if(other.tag == "DoorOriginCentre")
        {
            SceneManager.LoadScene("Museum");
        }
        else if (other.tag == "DoorDigitalArts")
        {
            SceneManager.LoadScene("DigitalArts");
        }
        else if (other.tag == "DoorFineArts")
        {
            SceneManager.LoadScene("");
        }
        else if (other.tag == "DoorAnthropology")
        {
            SceneManager.LoadScene("");
        }
        else if (other.tag == "DoorAdler")
        {
            SceneManager.LoadScene("");
        }
        else if (other.tag == "DoorLifeSciences")
        {
            SceneManager.LoadScene("");
        }
        else if (other.tag == "DoorExit")
        {
            SceneManager.LoadScene("MainHall");
        }
        else if (other.tag == "DoorGallery")
        {
            SceneManager.LoadScene("PhotoModeGallery");
        }
        else if (other.tag == "DoorJoke")
        {
            SceneManager.LoadScene("Joke");
        }

    }
}
