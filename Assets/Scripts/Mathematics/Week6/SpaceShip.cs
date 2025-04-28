using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceShip : MonoBehaviour
{
    public GameUIController manager;
    public TextMeshProUGUI currenthealth;
    public bool hasBeenDefeated;
    public int Health;
    void Start()
    {
        Health = 3;
        hasBeenDefeated = false;
    }
    void Update()
    {
        currenthealth.text = "Vida: " + Health.ToString();
        if (Health <= 0 && hasBeenDefeated == false)
        {
            manager.ShowGameOverUI();
            hasBeenDefeated = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Meteorito")
        {
            Health--;
        }
    }
}