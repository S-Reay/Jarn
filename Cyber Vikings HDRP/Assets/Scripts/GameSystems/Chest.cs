using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactable
{
    public List<Item> items = new List<Item>();
    public int capacity = 20;
    public GameObject UI;
    public GameObject itemsParent;
    GameObject player;

    ChestSlot[] slots;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        slots = itemsParent.GetComponentsInChildren<ChestSlot>();
        UpdateUI();
    }

    public override void Interact()
    {
        base.Interact();
        OpenChest();
    }

    public void OpenChest()
    {
        Debug.Log("Chest: " + transform.name + " has been opened");
        UI.SetActive(true);
        //Camera.main.GetComponent<MouseLook>().enabled = false;
        //player.GetComponent<PlayerMotor>().enabled = false;
        //player.GetComponent<PlayerActions>().enabled = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    private void Update()
    {
        if (UI.activeSelf)
        {
            if (Vector3.Distance(player.transform.position, transform.position) > 5f)
            {
                UI.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                UI.SetActive(false);
                Camera.main.GetComponent<MouseLook>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                player.GetComponent<PlayerMotor>().enabled = true;
                player.GetComponent<PlayerActions>().enabled = true;
            }
        }
    }

    public void UpdateUI()
    {
        Debug.Log("Updating UI");
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < items.Count)
            {
                slots[i].AddItem(items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        UpdateUI();
    }
}
