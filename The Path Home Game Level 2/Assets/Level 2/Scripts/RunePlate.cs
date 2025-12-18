using UnityEngine;

public class RunePlate : MonoBehaviour
{
    public bool isActivated = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stone"))
        {
            isActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Stone"))
        {
            isActivated = false;
        }
    }
}
