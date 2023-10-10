using UnityEngine;
//Made using tutorial by Pandemonium.
//As of 10/10/23 no changes,
//Planning to rework it, to allow more control.
public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    private float maxHealth;
    public float currentHealth { get; private set; }
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            //Dead
        }
        else
        {
            //Not Dead
        }
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            TakeDamage(1);
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
            AddHealth(1);
        }
    }
}
