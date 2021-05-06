using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BookPuzzle : MonoBehaviour
{

    public Text TextBox;
    
    public GameObject space1;
    public GameObject space2;
    public GameObject space3;
    public GameObject space4;
    public GameObject space5;
    public GameObject redBook;
    public GameObject blueBook;
    public GameObject yellowBook;
    public GameObject purpleBook;
    public GameObject greenBook;
    private int x = 0;
    public GameObject currentBook;
    
    

    void Start()
    {
        TextBox.text =("There are five books here. If they are placed in the correct order, You will get the key you need.");
        currentBook = space1;
        
    }

    void Update()
    {
        if(x==5)
        {
            
        }

        
        if (x == 0)
        {
            currentBook = space1;
        }
        if (x == 1)
        {
            currentBook = space2;
        }
        if (x == 2)
        {
            currentBook = space3;
        }
        if (x == 3)
        {
            currentBook = space4;
        }
        if (x == 4)
        {
            currentBook = space5;
        }
    }

    public void BlueClicked()
    {
        Vector2 z = currentBook.transform.position;
        blueBook.transform.position = new Vector2(z.x,z.y);
        x++;
        
    }

    public void GreenClicked()
    {
        Vector2 z = currentBook.transform.position;
        greenBook.transform.position = new Vector2(z.x,z.y);
   
        x++;
  
    }

    public void RedClicked()
    {
        Vector2 z = currentBook.transform.position;
        redBook.transform.position = new Vector2(z.x,z.y);
        x++;
    }

    public void YellowClicked()
    {
        Vector2 z = currentBook.transform.position;
        yellowBootransform.position = new Vector2(z.x,z.y);
        x++;
    }
    public void PurpleClicked()
    {
        Vector2 z = currentBook.transform.position;
        transform.position = new Vector2(z.x,z.y);

        x++;
    }
}