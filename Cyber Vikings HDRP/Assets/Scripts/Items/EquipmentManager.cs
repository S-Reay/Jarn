using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    #region Singleton
    public static EquipmentManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    public Weapon currentWeapon;

    public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
    public OnEquipmentChanged onEquipmentChangedCallback;
    public delegate void OnWeaponChanged(Weapon newWeapon, Weapon oldWeapon);
    public OnWeaponChanged onWeaponChangedCallback;
    Inventory inventory;

    private void Start()
    {
        inventory = Inventory.instance;
    }

    public void EquipWeapon(Weapon newWeapon)
    {
        Weapon oldWeapon = null;
        if (currentWeapon != null)
        {
            oldWeapon = currentWeapon;
            inventory.Add(oldWeapon);
        }
        if (onWeaponChangedCallback != null)                         //If any methods need to be notified of an equipment change
        {
            onWeaponChangedCallback.Invoke(newWeapon, oldWeapon);
        }

        currentWeapon = newWeapon;
    }
    public void UnequipWeapon()
    {
        if (currentWeapon != null)
        {
            Weapon oldWeapon = currentWeapon;
            inventory.Add(oldWeapon);                               //Add it back to the inventory

            currentWeapon = null;                                   //Remove it from the slot

            if (onWeaponChangedCallback != null)                    //If any methods need to be notified of an equipment change
            {
                onWeaponChangedCallback.Invoke(null, oldWeapon);
            }
        }
    }
}
