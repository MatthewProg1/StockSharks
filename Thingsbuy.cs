using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thingsbuy : MonoBehaviour
{

    public Sprite car1;
    public Sprite snowcar1;
    public Sprite car2;

    public Sprite house1;
    public Sprite house2;
    public Sprite snowhouse2;

    public Image house;
    public Image car;

    public int ca = 0;
    public int hou = 0;
    public int money;

    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        hou = PlayerPrefs.GetInt("SaveHouse");
        ca = PlayerPrefs.GetInt("SaveCar");
        money = PlayerPrefs.GetInt("SaveMoney");



        ca = PlayerPrefs.GetInt("SaveCar");

        if (ca == 1)
        {
            car.enabled = true;
            car.GetComponent<Image>().sprite = car1;
        }
        if(ca == 2)
        {
            car.enabled = true;
            car.GetComponent<Image>().sprite = car2;
        }

        if (ca == 3)
        {
            car.enabled = true;
            car.GetComponent<Image>().sprite = snowcar1;
        }
        if (ca == 0)
        {
            car.enabled = false;
        }

        hou = PlayerPrefs.GetInt("SaveHouse");

        if (hou == 1)
        {
            house.enabled = true;
            house.GetComponent<Image>().sprite = house1;
        }
        if (hou == 2)
        {
            house.enabled = true;
            house.GetComponent<Image>().sprite = house2;
        }

        if (hou == 3)
        {
            house.enabled = true;
            house.GetComponent<Image>().sprite = snowhouse2;
        }
        if (hou == 0)
        {
            house.enabled = false;
        }

       //   hou = 0;
       //   ca = 0;
       //   PlayerPrefs.SetInt("SaveHouse", hou);
      //    PlayerPrefs.SetInt("SaveCar", ca);
       //   PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        ca = PlayerPrefs.GetInt("SaveCar");

        if (ca == 1)
        {
            car.enabled = true;
        }
        if (ca == 2)
        {
            car.enabled = true;
            car.GetComponent<Image>().sprite = car2;
        }
        if (ca == 3)
        {
            car.enabled = true;
            car.GetComponent<Image>().sprite = snowcar1;
        }
        if (ca == 0)
        {
            car.enabled = false;
        }

        hou = PlayerPrefs.GetInt("SaveHouse");

        if (hou == 1)
        {
            house.enabled = true;
            house.GetComponent<Image>().sprite = house1;
        }
        if (hou == 2)
        {
            house.enabled = true;
            house.GetComponent<Image>().sprite = house2;
        }
        if (hou == 3)
        {
            house.enabled = true;
            house.GetComponent<Image>().sprite = snowhouse2;
        }
        if (hou == 0)
        {
            house.enabled = false;
        }

        text.text = money + "";
    }

    public void House()
    {
        money = PlayerPrefs.GetInt("SaveMoney");


        if (money >= 10000)
        {

            money = money - 10000;
            hou = 1;
            PlayerPrefs.SetInt("SaveMoney", money);
            PlayerPrefs.SetInt("SaveHouse", hou);
            PlayerPrefs.Save();
        }
    }

    public void SnowHouse()
    {
        money = PlayerPrefs.GetInt("SaveMoney");


        if (money >= 15000)
        {

            money = money - 15000;
            hou = 3;
            PlayerPrefs.SetInt("SaveMoney", money);
            PlayerPrefs.SetInt("SaveHouse", hou);
            PlayerPrefs.Save();
        }
    }

    public void House2()
    {
        money = PlayerPrefs.GetInt("SaveMoney");


        if (money >= 20000)
        {

            money = money - 20000;
            hou = 2;
            PlayerPrefs.SetInt("SaveMoney", money);
            PlayerPrefs.SetInt("SaveHouse", hou);
            PlayerPrefs.Save();
        }
    }
    public void Car()
    {
        money = PlayerPrefs.GetInt("SaveMoney");
        if (money >= 1000)
        {
            ca = 1;
            money = money - 1000;
            PlayerPrefs.SetInt("SaveMoney", money);
            PlayerPrefs.SetInt("SaveCar", ca);
            PlayerPrefs.Save();
        }
    }

    public void snowCar()
    {
        money = PlayerPrefs.GetInt("SaveMoney");
        if (money >= 1500)
        {
            ca = 3;
            money = money - 1500;
            PlayerPrefs.SetInt("SaveMoney", money);
            PlayerPrefs.SetInt("SaveCar", ca);
            PlayerPrefs.Save();
        }
    }

    public void Car2()
    {
        money = PlayerPrefs.GetInt("SaveMoney");

        if (money >= 2500)
        {
            ca = 2;
            money = money - 2500;
            PlayerPrefs.SetInt("SaveMoney", money);
            PlayerPrefs.SetInt("SaveCar", ca);
            PlayerPrefs.Save();
        }
    }
}
