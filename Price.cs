using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Price : MonoBehaviour
{

    public int price = 100;
    public int plus;
    public int newpr;
    public int refresh;
    public int money = 100;
    public int original;
    public int count = 1;

    public int buyorsell = 1;
    public int first;




    public Text text;
    public Text mo;
    public Text coun;
    public Text or;
    public Button b;
    public Image grafic;
    public Sprite red;
    public Sprite green;
    public Sprite sell;
    public Sprite buy;

 


    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(Sec());
        Sec();
        
       money =  PlayerPrefs.GetInt("SaveMoney");

       first =  PlayerPrefs.GetInt("SaveFirst");
        


       // money = PlayerPrefs.GetInt("SaveMoney");
        //first = PlayerPrefs.GetInt("First");

        

        if (first == 0)
        {
            money = 100;
            PlayerPrefs.SetInt("SaveMoney", money);
            PlayerPrefs.Save();

            mo.text = 100 + "";
        }
        else
        {
            mo.text = money + "";
        }


       
     


    }

    // Update is called once per frame
    void Update()
    {

        money = PlayerPrefs.GetInt("SaveMoney");
  
        

        mo.text = money + "";

        coun.text = "" + count;



    }

    public IEnumerator Sec()
    {
        yield return new WaitForSeconds(3);

        

            plus = Random.Range(0, 20);

        

            if (plus < 11)
            {
            
                newpr = Random.Range(10, 40);

            if (price - newpr >= 0)
            {

                price = price - newpr;
                newpr = Random.Range(10, 40);
            }
            else
            {
                plus = Random.Range(0, 20);
            }

                text.text = price + "";
                text.color = Color.red;
                grafic.GetComponent<Image>().sprite = red;
            
        }

            else
            {
                newpr = Random.Range(10, 40);
                price = price + newpr;
                text.text = price + "";
                text.color = Color.green;
                grafic.GetComponent<Image>().sprite = green;
       
        }

            

            StartCoroutine(Sec2());
            Sec2();
        



    }

    public IEnumerator Sec2()
    {
        yield return new WaitForSeconds(1);

        StartCoroutine(Sec());
        Sec();



    }

    public void OnClick()
    {

        

            buyorsell++;
            first = 1;
        PlayerPrefs.SetInt("SaveFirst", first);
        PlayerPrefs.Save();
            
        

            if (buyorsell % 2 != 0)
            {
            b.GetComponent<Image>().sprite = sell;

            money = PlayerPrefs.GetInt("SaveMoney");
       
            if (money >= (price * count))
                {
                
                    money = money - (price * count);
                original = (price * count);
              
                mo.text = money + "";

                PlayerPrefs.SetInt("SaveMoney", money);
                PlayerPrefs.Save();


            }
            
                mo.text = money + "";
                refresh = 0;
            

            PlayerPrefs.SetInt("SaveMoney", money);
            PlayerPrefs.Save();
            
            

        }

            if (buyorsell % 2 == 0)
            {
            b.GetComponent<Image>().sprite = buy;



            money = money + (price * count);

            PlayerPrefs.SetInt("SaveMoney", money);
            PlayerPrefs.Save();

            mo.text = money + "";


            mo.text = money + "";
                refresh = 0;
            
            

        }

           

        


        
            
        

    }

    public void Plus()
    {
        count++;
    }
    public void Minis()
    {
        count--;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }

   




}
