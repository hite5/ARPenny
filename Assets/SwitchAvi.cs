using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAvi : MonoBehaviour
{
    // references to the game objects
    public GameObject avi1, avi2;

    // variable contains which avatar is on and active
    int whichAviIsOn = 1;

    // Start is called before the first frame update
    void Start()
    {
        // enable first avatar and disable the other
        avi1.gameObject.SetActive(true);
        avi2.gameObject.SetActive(false);
    }

    public void SwitchAvatar()
    {
        switch (whichAviIsOn)
        {
            case 1:
                whichAviIsOn = 2;

                // disable first avi and enable second avi
                avi1.gameObject.SetActive(false);
                avi2.gameObject.SetActive(true);
                break;

            case 2:
                whichAviIsOn = 1;

                avi1.gameObject.SetActive(true);
                avi2.gameObject.SetActive(false);
                break;
        }
    }

    /*   // Update is called once per frame
       void Update()
       {

       }*/
}