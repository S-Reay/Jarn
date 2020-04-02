using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : CharacterStats
{
    #region Singleton
    public static PlayerStats instance;
    public override void Awake()
    {
        instance = this;
        base.Awake();
    }
    #endregion

    public Image redScreen;
    public float redScreenAlpha = 0f;
    public PlayerActions playerActions;
    public PlayerMotor playerMotor;
    public UpdateWeaponModel updateWeaponModel;
    public MouseLook mouseLook;
    public GameObject inventoryUI;
    public GameObject redScreenUI;
    public GameObject deathScreen;

    void Start()
    {
        EquipmentManager.instance.onEquipmentChangedCallback += OnEquipmentChanged;
    }
    private void Update()
    {
        if (redScreenAlpha >= 0f)
        {
            redScreenAlpha -= Time.deltaTime/2;
            var tempColour = redScreen.color;
            tempColour.a = redScreenAlpha;
            redScreen.color = tempColour;

        }
    }

    void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
    {
        if (newItem != null)
        {
            armour.AddModifier(newItem.armourModifier);
            damage.AddModifier(newItem.damageModifier);
            moveSpeed.AddModifier(newItem.moveSpeedModifier);
            jumpHeight.AddModifier(newItem.jumpModifier);
        }

        if (oldItem != null)
        {
            armour.RemoveModifier(oldItem.armourModifier);
            damage.RemoveModifier(oldItem.damageModifier);
            moveSpeed.RemoveModifier(oldItem.moveSpeedModifier);
            jumpHeight.RemoveModifier(oldItem.jumpModifier);
        }
    }

    public override int TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        redScreenAlpha = 1f;
        return damage;
    }

    public override void Die()
    {
        base.Die();
        //DEATH SCREEN
        playerActions.enabled = false;
        playerMotor.enabled = false;
        updateWeaponModel.enabled = false;
        inventoryUI.SetActive(false);
        redScreenUI.SetActive(false);
        mouseLook.enabled = false;
        deathScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        //RESPAWN
    }
}
