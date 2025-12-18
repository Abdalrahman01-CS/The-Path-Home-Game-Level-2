using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SirajS2Dialogue : MonoBehaviour
{
    public AbdelrahmanDialogueManager dialogueManager;

    private string[] dialogue = {"This is The Water Wheel Chamber.",
                                "Rin... Push The Stones."};

    // Start is called before the first frame update
    void Start()
    {
            dialogueManager.SetDialogue(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
