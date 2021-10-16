using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEquipper : MonoBehaviour
{
    public static string activeWeaponType;

    public GameObject pistol;
    public GameObject assaultRifle;
    public GameObject shotgun;

    GameObject activeGun;

    private void Start()
    {
        activeWeaponType = Constants.Pistol;
        activeGun = pistol;
    }

    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            LoadWeapon(pistol);
            activeWeaponType = Constants.Pistol;
        }
        else if (Input.GetKeyDown("2"))
        {
            LoadWeapon(assaultRifle);
            activeWeaponType = Constants.AssaultRifle;
        }
        else if (Input.GetKeyDown("3"))
        {
            LoadWeapon(shotgun);
            activeWeaponType = Constants.Shotgun;
        }
    }

    private void LoadWeapon(GameObject weapon)
    {
        pistol.SetActive(false);
        assaultRifle.SetActive(false);
        shotgun.SetActive(false);

        weapon.SetActive(true);
        activeGun = weapon;
    }

    public GameObject GetActiveWeapon()
    {
        return activeGun;
    }
}
