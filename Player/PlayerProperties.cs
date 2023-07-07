using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{
    private int playerHealth = 100;
    private int playerStamina = 100;

    public void DamageHealth(int damage)
    {
        playerHealth -= damage;
        playerHealth = Mathf.Clamp(playerHealth, 0, 100);
    }
    public void AddHealth(int restore)
    {
        playerHealth += restore;
        playerHealth = Mathf.Clamp(playerHealth, 0, 100);
    }

    public void DamageStamina(int damage)
    {
        playerStamina -= damage;
        playerStamina = Mathf.Clamp(playerStamina, 0, 100);
    }
    public void AddStamina(int restore)
    {
        playerStamina += restore;
        playerStamina = Mathf.Clamp(playerStamina, 0, 100);
    }
}
