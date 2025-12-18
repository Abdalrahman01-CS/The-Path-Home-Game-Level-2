using UnityEngine;
using TMPro;

public class RinLivesUI : MonoBehaviour
{
    public TextMeshProUGUI livesNumber;

    void Update()
    {
        livesNumber.text = AbdelrahmanPlayerStats.lives.ToString();
    }
}
