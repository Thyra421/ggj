using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSystem : MonoBehaviour
{
    [SerializeField]
    private Camera characterCamera;

    [SerializeField]
    private Transform slot;

    private PickableItem pickedItem;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (pickedItem)
            {
                DropItem(pickedItem);
            }
            else
            {
                var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1.5f))
                {
                    var pickable = hit.transform.GetComponent<PickableItem>();

                    if (pickable)
                    {
                        PickItem(pickable);
                    }
                }
            }
        }
    }

    private void PickItem(PickableItem item)
    {
        pickedItem = item;

        // Disable rigidbody and reset velocities
        item.Rb.isKinematic = true;
        item.Rb.velocity = Vector3.zero;
        item.Rb.angularVelocity = Vector3.zero;

        // Set Slot as a parent
        item.transform.SetParent(slot);

        // Reset position and rotation
        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;

    }

    private void DropItem(PickableItem item)
    {
        // Remove reference
        pickedItem = null;

        // Remove parent
        item.transform.SetParent(null);

        // Enable rigidbody
        item.Rb.isKinematic = false;

        // Add force to throw item a little bit
        item.Rb.AddForce(item.transform.forward * 2, ForceMode.VelocityChange);
    }
}
