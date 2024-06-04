using UnityEngine.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

using System;
using System.Collections.Generic;

public class ToPlay : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnClick2()
    {
        SceneManager.LoadScene("DeliMoney");
    }

    public void OnClick3()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnClick4()
    {
        SceneManager.LoadScene("House");
    }

}


