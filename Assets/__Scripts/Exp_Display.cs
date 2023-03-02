using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exp_Display : MonoBehaviour
{
    public HeroLevel stat;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        stat = FindObjectOfType<HeroLevel>();
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float exp = stat.get_exp();
        float expMax = stat.get_maxExp();
        text.text = "-" + exp + "/" + expMax + "-";
    }
}
