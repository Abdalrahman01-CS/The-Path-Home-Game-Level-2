using UnityEngine;

public class WaterWheelManager : MonoBehaviour
{
    public RunePlate[] runes;          // 3 runes
    public Transform waterWheel;       // the wheel image
    public float rotationSpeed = 100f; // degrees per second

    private bool wheelActive = false;

    void Update()
    {
        if (!wheelActive && AllRunesActivated())
        {
            wheelActive = true;
        }

        if (wheelActive)
        {
            RotateWheel();
        }
    }

    bool AllRunesActivated()
    {
        foreach (RunePlate rune in runes)
        {
            if (!rune.isActivated)
                return false;
        }
        return true;
    }

    void RotateWheel()
    {
        waterWheel.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
