using UnityEngine;

public class PlayerPowerUps : MonoBehaviour
{
    [SerializeField] private float boostMultiplier = 1.5f; //50% boost

    public float SpeedTimeLeft { get; private set; }

    private PlayerMovement playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SpeedTimeLeft <= 0) return;
        SpeedTimeLeft -= Time.deltaTime;
        if (SpeedTimeLeft <= 0)
        {
            playerMovement.SpeedMultiplier = 1f; // Reset to normal speed
        }
    }

    public void ActivateSpeedBoost(float duration)
    {
        SpeedTimeLeft = duration;
        playerMovement.SpeedMultiplier = boostMultiplier;
    }
}
