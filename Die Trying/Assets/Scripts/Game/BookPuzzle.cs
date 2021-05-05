using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BookPuzzle : MonoBehaviour
{

    public Text TextBox;
    private string[] books = {"","","","",""};
    private int x = 0;
    

    void Start()
    {
        TextBox.text =("There are five books here. If they are placed in the correct order, You will get the key you need.");
    }

    void Update()
    {
        if(x==5)
        {
            string y = string.Join(", ", books);
            TextBox.text = (y);
            x = 0;
        }
    }

    public void BlueClicked()
    {
        books[x] = "Blue";
        TextBox.text =(books[x]);
        x++;
        
    }

    public void GreenClicked()
    {
        books[x] = "Green";
        TextBox.text =(books[x]);
        x++;
    }

    public void RedClicked()
    {
        books[x] = "Red";
        TextBox.text =(books[x]);
        x++;
    }

    public void YellowClicked()
    {
        books[x] = "Yellow";
        TextBox.text =(books[x]);
        x++;
    }
    public void PurpleClicked()
    {
        books[x] = "Purple";
        TextBox.text =(books[x]);
        x++;
    }
}