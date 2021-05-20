using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screaming : MonoBehaviour
{
    public GameObject textbox;
    public Text grannyText;
    // Start is called before the first frame update
    void Start()
    {
        grannyText.text = "*You hear what sounds like a woman screaming coming from your left. Maybe you should check it out*";
    }

    // Update is called once per frame
    public void Clicked()
    {
        textbox.SetActive(false);
    }
}
