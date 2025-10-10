using UnityEngine;

public class Crate : Stuff, IInteractable
{
    [Header("Crate Settings")]
    public bool isOn = true;      
    public bool canUse = true;     
    private Rigidbody rb;         

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = isOn;
        }
    }

   
    public bool isInteractable
    {
        get => canUse;
        set => canUse = value;
    }


    public void Interact(Player player)
    {
        if (!canUse) return;
        if (rb == null) rb = GetComponent<Rigidbody>();

        isOn = !isOn;
        rb.isKinematic = isOn;

    }
}
