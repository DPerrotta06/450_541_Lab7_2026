using TMPro;
using UnityEngine;

public class PowerUpHUD : MonoBehaviour
{
    [SerializeField] private PlayerPowerUps powerUps;
    [SerializeField] private GameObject speedIndicator;
    [SerializeField] private TMP_Text speedTimeText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timeLeft = powerUps.SpeedTimeLeft;
        speedIndicator.SetActive(timeLeft > 0);
        speedTimeText.text = Mathf.CeilToInt(timeLeft) + "s";
    }
}
