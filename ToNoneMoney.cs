using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNoneMoney : MonoBehaviour
{
    public int money;
    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("SaveMoney");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        money = 100;
        PlayerPrefs.SetInt("SaveMoney", money);
        PlayerPrefs.Save();
    }

    public void ClickExit()
    {
        SceneManager.LoadScene("Menu");
    }
}
