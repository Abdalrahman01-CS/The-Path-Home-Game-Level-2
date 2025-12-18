using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbdelrahmanEnemyController : MonoBehaviour
{

    public float maxSpeed;
    public int damage = 1;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Flip()
    {
        sr.flipX = !sr.flipX;
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if(player.tag == "Rin")
        {
            FindObjectOfType<AbdelrahmanPlayerStats>().TakeDamage(damage);
            Flip();
        }

        else if(player.tag == "Wall")
            Flip();
    }
}