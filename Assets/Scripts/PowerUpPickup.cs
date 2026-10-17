using UnityEngine;

public class PowerUpPickup : MonoBehaviour
{
    [SerializeField] private float duration = 10f;
    [SerializeField] private float respawnDelay = 5f;
    [SerializeField] private GameObject visuals;
    [SerializeField] private AudioClip pickupSound;
    [SerializeField] private GameObject pickupEffects;

    private void OnTriggerEnter(Collider other)
    {
        PlayerPowerUps playerPowerUps = other.GetComponent<PlayerPowerUps>();
        if (playerPowerUps == null)
        {
            return;
        }
        playerPowerUps.ActivateSpeedBoost(duration);
        GetComponent<AudioSource>().PlayOneShot(pickupSound);
        Instantiate(pickupEffects, transform.position, Quaternion.identity);
        visuals.SetActive(false);
        GetComponent<Collider>().enabled = false;
        Invoke(nameof(Reappear), respawnDelay);
    }

    private void Reappear()
    {
        visuals.SetActive(true);
        GetComponent<Collider>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
