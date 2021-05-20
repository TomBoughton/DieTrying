using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Base : MonoBehaviour
{
    public string scene;
    public Stats skills;
    private void OnTriggerEnter(Collider other)
    {
        skills.SavePlayer();
        SceneManager.LoadScene(scene);
        skills.LoadPlayer();
    }
}
