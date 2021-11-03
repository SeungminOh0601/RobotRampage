using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int armor;
    public GameUI gameUI;

    private GunEquipper gunEquipper;
    private Ammo ammo;
    void Start()
    {
        ammo = GetComponent<Ammo>();
        gunEquipper = GetComponent<GunEquipper>();
    }

    public void TakeDamage(int amount)
    {
        int healthDamage = amount;

        if (armor > 0)
        {
            int effectiveArmor = armor * 2;
            effectiveArmor -= healthDamage;

            if (effectiveArmor > 0)
            {
                armor = effectiveArmor / 2;
                gameUI.SetArmorText(armor);

                return;
            }

            armor = 0;
            gameUI.SetArmorText(armor);
        }

        health -= healthDamage;
        gameUI.SetHealthText(health);

        if (health <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }

    private void PickupHealth()
    {
        health += 50;

        if (health > 200)
        {
            health = 200;
        }

        gameUI.SetPickupText("Health picked up + 50 Health");
        gameUI.SetHealthText(health);
    }

    private void PickupArmor()
    {
        armor += 15;
        gameUI.SetPickupText("Armor picked up + 15 armor");
        gameUI.SetArmorText(armor);
    }

    private void PickupAssaultRifleAmmo()
    {
        ammo.AddAmmo(Constants.AssaultRifle, 50);
        gameUI.SetPickupText("Assualt rifle ammo picked up + 50 ammo");
        if (gunEquipper.GetActiveWeapon().tag == Constants.AssaultRifle)
        {
            gameUI.SetAmmoText(ammo.GetAmmo(Constants.AssaultRifle));
        }
    }

    private void PickupPistolAmmo()
    {
        ammo.AddAmmo(Constants.Pistol, 20);
        gameUI.SetPickupText("Pistol ammo picked up + 20 ammo");
        if (gunEquipper.GetActiveWeapon().tag == Constants.Pistol)
        {
            gameUI.SetAmmoText(ammo.GetAmmo(Constants.Pistol));
        }
    }

    private void PickupShotgunAmmo()
    {
        ammo.AddAmmo(Constants.Shotgun, 10);
        gameUI.SetPickupText("Shotgun ammo picked up + 10 ammo");
        if (gunEquipper.GetActiveWeapon().tag == Constants.Shotgun)
        {
            gameUI.SetAmmoText(ammo.GetAmmo(Constants.Shotgun));
        }
    }

    public void PickupItem(int pickupType)
    {
        switch (pickupType)
        {
            case Constants.PickUpArmor:
                PickupArmor();
                break;
            case Constants.PickUpHealth:
                PickupHealth();
                break;
            case Constants.PickUpAssualtRifleAmmo:
                PickupAssaultRifleAmmo();
                break;
            case Constants.PickUpPistolAmmo:
                PickupPistolAmmo();
                break;
            case Constants.PickUpShotgunAmmo:
                PickupShotgunAmmo();
                break;
            default:
                Debug.LogError("Bad pickup type passed: " + pickupType);
                break;
        }
    }
}
