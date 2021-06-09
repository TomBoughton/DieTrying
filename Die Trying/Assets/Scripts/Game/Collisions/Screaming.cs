using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screaming : MonoBehaviour
{
    public GameObject textbox;
    public Text grannyText;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        grannyText.text = "*You hear what sounds like a woman screaming coming from your left. Maybe you should check it out*";
        cam.GetComponent<Controller>().enabled = false;
    }

    // Update is called once per frame
    public void Clicked()
    {
        textbox.SetActive(false);
        cam.GetComponent<Controller>().enabled = true;  
    }
}
