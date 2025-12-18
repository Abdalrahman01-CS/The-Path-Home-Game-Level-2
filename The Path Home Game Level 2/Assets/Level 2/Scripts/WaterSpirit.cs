using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpirit : AbdelrahmanEnemyController
{
    private Animator anim;
    public float destroyTime = 8f;

    [Header("Appear / Disappear")]
    public float appearTime = 1f;
    public float disappearTime = 0.5f;

    [Header("Floating Movement")]
    public float floatAmplitude = 0.3f;   // how high it moves
    public float floatSpeed = 3f;          // how fast it moves

    public float knockbackForce = 4f;

    private Collider2D col;
    private SpriteRenderer sprite;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
        startPos = transform.position;

        StartCoroutine(AppearDisappearLoop());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = pos;
    }

    IEnumerator AppearDisappearLoop()
    {
        while (true)
        {
            // Appear
            sprite.enabled = true;
            col.enabled = true;
            anim.SetBool("isVisible", true);
            yield return new WaitForSeconds(appearTime);
            
            // Disappear
            anim.SetBool("isVisible", false);
            yield return new WaitForSeconds(0.2f);
            sprite.enabled = false;
            col.enabled = false;
            yield return new WaitForSeconds(disappearTime);
            Invoke("DestroyWaterGhost", destroyTime);
        }
    }
    
    void DestroyWaterGhost()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Rin")
        {
            AbdelrahmanPlayerStats stats = player.GetComponent<AbdelrahmanPlayerStats>();
            if (stats != null)
            {
                stats.TakeDamage(damage);
            }

            // Knockback
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                float direction = player.transform.position.x > transform.position.x ? 1 : -1;
                rb.velocity = new Vector2(direction * knockbackForce, rb.velocity.y);
            }
        }
    }
}
