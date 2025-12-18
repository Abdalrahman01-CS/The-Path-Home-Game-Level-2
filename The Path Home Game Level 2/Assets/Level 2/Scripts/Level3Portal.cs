using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Portal : MonoBehaviour
{
    public string Level3;
    public float nextLevelDelay = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(Level3);
    }

    private void OnTriggerEnter2D(Collider2D Rin)
    {
        if (Rin.CompareTag("Rin"))
        {
            Invoke("LoadNextScene", nextLevelDelay);
        }
    }
}
