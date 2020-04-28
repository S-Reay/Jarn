using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
    public int armourModifier;
    public int damageModifier;
    public int moveSpeedModifier;
    public int jumpModifier;

    public override void Use()
    {
        base.Use();
        RemoveFromInventory();
    }
}