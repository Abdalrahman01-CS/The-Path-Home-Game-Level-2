using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbdelrahmanHealthBarUI : MonoBehaviour
{
    public Image[] healthHearts;            
    public Sprite fullHealthHeart;
    public Sprite emptyHealthHeart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       UpdateHealth();
    }

    void UpdateHealth()
    {
        for (int i = 0; i < healthHearts.Length; i++)
        {
            if (i < AbdelrahmanPlayerStats.health)
            {
                healthHearts[i].sprite = fullHealthHeart;
            }
            else
            {
                healthHearts[i].sprite = emptyHealthHeart;
            }
        }
    }
}
