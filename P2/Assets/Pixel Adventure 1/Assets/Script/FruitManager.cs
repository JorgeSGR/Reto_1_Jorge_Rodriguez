using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitManager : MonoBehaviour
{
    public GameObject transition;

    public void Update()
    {
        AllFruitsCollected();
    }
    public void AllFruitsCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("No quedan Frutas, Victoria");
            transition.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
