using UnityEngine;
using UnityEngine.UI;

public class ShieldBar : MonoBehaviour
{
    //Connect to Shield Script In order to update bar.
    [SerializeField] private Shield playerShield;
    [SerializeField] private Image totalshieldBar;
    [SerializeField] private Image currentshieldBar;
    void Start()
    {
        totalshieldBar.fillAmount = playerShield.currentShield / 10;
    }
    void Update()
    {
        currentshieldBar.fillAmount = playerShield.currentShield / 10;
    }
}
