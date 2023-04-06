using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    public GameObject mainPage;
    public GameObject toPage;

    public void ButtonChangeActive(){
        mainPage.SetActive(false);
        toPage.SetActive(true);
    }
}

