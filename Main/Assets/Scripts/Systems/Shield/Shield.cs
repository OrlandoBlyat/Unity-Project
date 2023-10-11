using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Essentially clone of Health system as of now.
public class Shield : MonoBehaviour
{
    [SerializeField] private float startingShield;
    public float currentShield { get; private set; }
    //On wake, set current shield to max shield value.
    private void Awake()
    {
        currentShield = startingShield;
    }

    public void HitShield(float damage)
    {
        currentShield = Mathf.Clamp(currentShield - damage, 0, startingShield);
    }

    public void AddShield(float value)
    {
        currentShield = Mathf.Clamp(currentShield + value, 0, startingShield);
    }
}
