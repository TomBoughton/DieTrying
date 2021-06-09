using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalktoGranny : MonoBehaviour
{

    public GameObject textbox;
    public Text text;
    public GameObject cam;
    private void OnTriggerEnter(Collider aaa)
    {
        textbox.SetActive(true);
        text.text = "*Maybe I should go and see what all the screaming is about first...*";
        cam.GetComponent<Controller>().enabled = false;
    }

    public void Clicked()
    {
        textbox.SetActive(false);
        cam.GetComponent<Controller>().enabled = true; 
    }
}
