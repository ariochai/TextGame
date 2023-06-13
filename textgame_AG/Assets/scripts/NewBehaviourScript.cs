using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int shoot = 500;
    // Start is called before the first frame update
    void Start()
    {
        

        Debug.Log("WItaj w grze - pomyśl o liczbie od 1 do 1000");
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od 500?");
     
        
    }

 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od "+shoot + " ?");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (max + min) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + " ?");

        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("brawo zgadłem");
        }


    }
}
