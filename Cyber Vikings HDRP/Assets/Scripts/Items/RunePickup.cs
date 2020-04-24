using UnityEngine;

public class RunePickup : Interactable
{
    [Tooltip("0 = Double Jump\n1 = Glide\n2 = Dash")]
    [Range(0, 2)]
    public int abilityID;
    public PlayerMotor playerMotor;

    private void Awake()
    {
        playerMotor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
    }

    public override void Interact()
    {
        base.Interact();
        switch (abilityID)
        {
            case 0:
                playerMotor.canDoubleJump = true;
                Destroy(gameObject);
                break;
            case 1:
                playerMotor.canGlide = true;
                Destroy(gameObject);
                break;
            case 2:
                playerMotor.canDash = true;
                Destroy(gameObject);
                break;
            default:
                Debug.LogError("Cannot determind which ability to activate");
                break;
        }
    }
}
