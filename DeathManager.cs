using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour
{
    public static int deathValue = 0;
    Text Deaths;

    void Start()
    {
        Deaths = GetComponent<Text>();
    }

    //void IncreaseDeaths()
    //{
        //deathValue += 1;
        //Deaths.text = Deaths.ToString();
    //}
    void Update()
    {
        Deaths.text = "Dead: " + deathValue;
        if (Deaths == null)
            return;
       
    }
}
