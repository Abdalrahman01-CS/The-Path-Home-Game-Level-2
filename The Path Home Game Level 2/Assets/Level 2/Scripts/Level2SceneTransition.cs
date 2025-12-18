using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2SceneTransition : MonoBehaviour
{
    public string Level2Scene2;
    public float nextSceneDelay = 1.2f;

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
        SceneManager.LoadScene(Level2Scene2);
    }

    private void OnTriggerEnter2D(Collider2D Rin)
    {
        if (Rin.CompareTag("Rin"))
        {
            Invoke("LoadNextScene", nextSceneDelay);
        }
    }
}
