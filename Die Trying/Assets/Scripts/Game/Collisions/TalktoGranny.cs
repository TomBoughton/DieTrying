using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalktoGranny : MonoBehaviour
{

    public GameObject textbox;
    public Text text;
    private void OnTriggerEnter(Collider aaa)
    {
        textbox.SetActive(true);
        text.text = "*Maybe I should go and see what all the screaming is about first...*";
    }

    public void Clicked()
    {
        textbox.SetActive(false);
    }
}
