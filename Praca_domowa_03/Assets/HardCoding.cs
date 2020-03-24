using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    
    void Start()
    {

        int cale = 74;
        float pol = 59.3f;

        bool si = true;
        bool no = false;

        string jed = "Programuję w C#";
        string dwa = "EPG";

        Debug.Log("cale: " + cale + " pol: " + pol + " si: " + si + " no: " + no + " jed: " + jed + " dwa: " + dwa);

        ZadaniePiec();

        //if ((jed) != (dwa))                    SPOSÓB 1, ALE CHYBA NIE O TO CHODZIŁO
        //{                                      DLATEGO |
        //    Debug.Log("Różne");                        |
       // }                                              V

        if ((jed)==(dwa))
        {
            Debug.Log("Takie same");
        }                   //SPOSÓB 2
        else
        {
            Debug.Log("Różne");
        }


        Alternatywa();
        Koniunkcja();


    }



    public void ZadaniePiec()
    {
        int cale = 74;
        float pol = 59.3f; 

        if ((cale == pol))
        {
            Debug.Log("Tak, są równe");
        }
        else
        {
            Debug.Log("Nie, są różne");

        }
        if ((cale != pol))
        {
            Debug.Log("Tak, są różne");

        }
        else
        {
            Debug.Log("Nie, są równe");
        }
        if ((cale > pol))
        {
            Debug.Log("Tak, jest większa");

        }
        else
        {
            Debug.Log("Nie, jest mniejsza");
        }
        if ((cale >= pol))
        {
            Debug.Log("Tak, jest większa bądź równa");

        }
        else
        {
            Debug.Log("Nie, jest mniejsza");
        }
        if ((cale < pol))
        {
            Debug.Log("Tak, jest mniejsza");

        }
        else
        {
            Debug.Log("Nie, jest większa");
        }
        if ((cale <= pol))
        {
            Debug.Log("Tak, jest mniejsza bądź równa");

        }
        else
        {
            Debug.Log("Nie, jest większa");
        }
    }

    public void Alternatywa()
    {

        bool jed = true;
        bool due = false;
        bool tri = true;
        bool quatr = false;

        bool wynik1, wynik2, wynik3;

        if (jed || due)
        {
            wynik1 = true;
        }
        else
        {
            wynik1 = false;
        }

        if (due || quatr)
        {
            wynik2 = false;
        }
        else
        {
            wynik2 = false;
        }

      if (jed || tri)
        {
            wynik3 = true;
        }
        else
        {
            wynik3 = false;
        }

        Debug.Log(" Alternatywa : True + false : " + wynik1 + " False + false : " + wynik2 + " True + true : " + wynik3);
    }
    
    public void Koniunkcja()
    {
        bool jed = true;
        bool due = false;
        bool tri = true;
        bool quatr = false;

        bool wynik1, wynik2, wynik3;

        if (jed && due)
        {
            wynik1 = false;
        }
        else
        {
            wynik1 = false;
        }

        if (due && quatr)
        {
            wynik2 = false;
        }
        else
        {
            wynik2 = false;
        }

        if (jed && tri)
        {
            wynik3 = true;
        }
        else
        {
            wynik3 = false;
        }

        Debug.Log(" Koniunkcja : True + false : " + wynik1 + " False + false : " + wynik2 + " True + true : " + wynik3);
    }

    void Update()
    {
        
    }
}
