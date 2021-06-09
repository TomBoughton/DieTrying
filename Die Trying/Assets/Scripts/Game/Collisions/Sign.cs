using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public GameObject textbox;
    public Text grannyText;
    public GameObject cam;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        cam.GetComponent<Controller>().enabled = false;
        textbox.SetActive(true);
        grannyText.text = "If you ever get lost, or don't know how to continue, just follow the path! If you see just a patch of path, just follow it, and it will take you to the next location. You can press *P* to open the stats menu, but it would be unwise to do this during battle!";
    }

    // Update is called once per frame
    public void Clicked()
    {
        textbox.SetActive(false);
        cam.GetComponent<Controller>().enabled = true;  
    }
}
