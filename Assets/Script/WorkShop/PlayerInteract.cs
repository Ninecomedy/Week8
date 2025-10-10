using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactDistance = 3f; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
          
            Collider[] nearbyObjects = Physics.OverlapSphere(transform.position, interactDistance);

            foreach (Collider col in nearbyObjects)
            {
                IInteractable interactable = col.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    interactable.Interact(GetComponent<Player>());
                    break; 
                }
            }
        }
    }

 
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactDistance);
    }
}
