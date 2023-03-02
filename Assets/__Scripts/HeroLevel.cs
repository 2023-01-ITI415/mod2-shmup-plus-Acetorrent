using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class HeroLevel : MonoBehaviour
{
    public int PlayerLevel = 1;
    public float maxExp;
    public float currentExp = 0f;
    // Start is called before the first frame update

    void Awake()
    {
        maxExp = 500f;
        PlayerLevel = 1;
        currentExp = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void exp_Gain(float amount)
    {
        currentExp += amount;
        if (currentExp >= maxExp)
        {
            float temp = currentExp - maxExp;
            level_Up();
            
            if (temp > 0f)
            {
                currentExp = temp;
            }
            else
            {
                currentExp = 0f;
            }
        }
    }

    public void level_Up()
    {
        PlayerLevel += 1;
        maxExp = ((PlayerLevel)*.25f * maxExp) + maxExp; 
    }
    public float get_exp()
    {
        return currentExp;
    }

    public float get_maxExp()
    {
        return maxExp;
    }

    public int get_level()
    {
        return PlayerLevel;
    }
}
