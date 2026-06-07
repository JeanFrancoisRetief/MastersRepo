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
        

        if(other.tag == "DoorOriginCentre")
        {
            if (LoadingPanel != null)
                LoadingPanel.SetActive(true);
            SceneManager.LoadScene("Museum");
        }
        else if (other.tag == "DoorDigitalArts")
        {
            if (LoadingPanel != null)
                LoadingPanel.SetActive(true);
            SceneManager.LoadScene("DigitalArts");
        }
        else if (other.tag == "DoorFineArts")
        {
            if (LoadingPanel != null)
                LoadingPanel.SetActive(true);
            SceneManager.LoadScene("");
        }
        else if (other.tag == "DoorAnthropology")
        {
            if (LoadingPanel != null)
                LoadingPanel.SetActive(true);
            SceneManager.LoadScene("");
        }
        else if (other.tag == "DoorAdler")
        {
            if (LoadingPanel != null)
                LoadingPanel.SetActive(true);
            SceneManager.LoadScene("");
        }
        else if (other.tag == "DoorLifeSciences")
        {
            if (LoadingPanel != null)
                LoadingPanel.SetActive(true);
            SceneManager.LoadScene("");
        }
        else if (other.tag == "DoorExit")
        {
            if (LoadingPanel != null)
                LoadingPanel.SetActive(true);
            SceneManager.LoadScene("MainHall");
        }
        else if (other.tag == "DoorGallery")
        {
            if (LoadingPanel != null)
                LoadingPanel.SetActive(true);
            SceneManager.LoadScene("PhotoModeGallery");
        }
        else if (other.tag == "DoorJoke")
        {
            if (LoadingPanel != null)
                LoadingPanel.SetActive(true);
            SceneManager.LoadScene("Joke");
        }

    }
}
