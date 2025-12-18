using UnityEngine;

public class WaterWheel : MonoBehaviour
{
    public float rotateSpeed = 120f;
    private bool active = false;

    public void StartWheel()
    {
        active = true;
    }

    void Update()
    {
        if (active)
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }
    }
}
