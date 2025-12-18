using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentPickup : MonoBehaviour
{
    public static int fragmentsCollected;

    // Start is called before the first frame update
    void Start()
    {
        //FindObjectOfType<Fragment>().FragmentNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rin"))
        {
            fragmentsCollected++;
            Destroy(gameObject);

            if (fragmentsCollected == 2)
                FindObjectOfType<AbdelrahmanRinController>().UnlockWaterOrbs();
        }
    }
}
