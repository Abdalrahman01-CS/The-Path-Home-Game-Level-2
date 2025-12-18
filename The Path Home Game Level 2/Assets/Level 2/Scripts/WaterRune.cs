using UnityEngine;

public class WaterRune : MonoBehaviour
{
    public bool isActivated = false;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.gray;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stone"))
        {
            isActivated = true;
            sr.color = Color.cyan;
            //FindObjectOfType<WaterWheelManager>().CheckRunes();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Stone"))
        {
            isActivated = false;
            sr.color = Color.gray;
        }
    }
}
