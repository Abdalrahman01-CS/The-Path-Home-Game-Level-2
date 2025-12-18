using UnityEngine;

public class SirajTrigger : MonoBehaviour
{
    public GameObject dialogueUI;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rin"))
        {
            dialogueUI.SetActive(true);
            other.GetComponent<AbdelrahmanRinController>().UnlockWaterOrbs();
        }
    }
}
