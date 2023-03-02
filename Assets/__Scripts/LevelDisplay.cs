using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelDisplay : MonoBehaviour
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
        int level = stat.get_level();
        text.text = "LEVEL " + level; 
    }
}
