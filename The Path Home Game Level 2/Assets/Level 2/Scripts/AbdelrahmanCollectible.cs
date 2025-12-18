using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbdelrahmanCollectible : MonoBehaviour
{

    public AudioClip cooling1;
    public AudioClip cooling2;

    void OnTriggerEnter2D(Collider2D Rin)
    {
        if (Rin.tag == "Rin")
        {
            //AbdelrahmanPlayerStats.score++;
            AbdelrahmanAudioManager.Instance.PlayRandomSFX(cooling1, cooling2);
            //Debug.Log("Score: " + AbdelrahmanPlayerStats.score);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
