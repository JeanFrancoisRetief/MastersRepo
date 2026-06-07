using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToPainter : MonoBehaviour
{
    public GameObject Player;

    
    public GameObject Painter;

    public GameObject TextHint;

    private bool isNearPaint;

    // Start is called before the first frame update
    void Start()
    {
        TextHint.SetActive(false);
        isNearPaint = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Painter.SetActive(false);
            Player.SetActive(true);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if(isNearPaint)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player.SetActive(false);
                Painter.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                TextHint.SetActive(false);

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        TextHint.SetActive(true);
        isNearPaint = true;
    }
    

    private void OnTriggerExit(Collider other)
    {
        TextHint.SetActive(false);
        isNearPaint = false;
    }
}
