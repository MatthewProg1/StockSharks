using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecCo : MonoBehaviour
{
    public int help = 0;
    public int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count > 3)
        {
            count = 1;
            help = 0;
        }

    }

    public void OnClick()
    {
        count++;
    }

    public void First()
    {

        if(count < 4)
        {
            help = 1;
            count++;
        }
    }

    public void Sec()
    {
        if (count < 4)
        {
           
            count++;
            if (help == 1)
            {

                help = 2;
            }

        }
    }

    public void Three()
    {
        if (count < 4)
        {
            
            count++;

            if (help == 2)
            {

                help = 3;
               SceneManager.LoadScene("Secret");
            }
        }
    }
}
