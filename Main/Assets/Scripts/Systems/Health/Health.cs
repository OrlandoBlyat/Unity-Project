using UnityEngine;
//Made using tutorial by Pandemonium.
public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] private Shield playerShield;
    private float maxHealth;
    public float currentHealth { get; private set; }
    private bool dead;
    private float damageMultiplier = 1;

    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void TakeDamage(float damage)
    {
        if (playerShield.currentShield != 0) playerShield.HitShield(damage);
        else currentHealth = Mathf.Clamp(currentHealth - damage * damageMultiplier, 0, startingHealth);
        
        if (currentHealth > 0)
        {
            //Not Dead
        }
        else
        {
            //Dead
        }
    }
    public void AddHealth(float value)
    {
        currentHealth = Mathf.Clamp(currentHealth + value, 0, startingHealth);
    }

    private void Update() {

       damageMultiplier = 0.5f;

        if (Input.GetKeyDown(KeyCode.E)) {
            TakeDamage(1);
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
            AddHealth(1);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerShield.AddShield(1);
        }
    }
}
