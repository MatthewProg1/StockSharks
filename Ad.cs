using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowAd();
    }

    // Update is called once per frame
    public void ShowAd()
    {
        Application.ExternalCall("ShowAd");
    }
}
