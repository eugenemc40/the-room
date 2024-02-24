using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabBasket : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Ensure the XRGrabInteractable component is present
        if (grabInteractable == null)
        {
            grabInteractable = gameObject.AddComponent<XRGrabInteractable>();
        }

        // Subscribe to grab and release events
        grabInteractable.onSelectEntered.AddListener(OnGrab);
        grabInteractable.onSelectExited.AddListener(OnRelease);
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        // Custom logic when the basket is grabbed
        Debug.Log("Basket grabbed!");

        // Optionally, you can disable the Rigidbody's gravity while grabbed
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.useGravity = false;
        }
    }

    private void OnRelease(XRBaseInteractor interactor)
    {
        // Custom logic when the basket is released
        Debug.Log("Basket released!");

        // Optionally, you can enable the Rigidbody's gravity when released
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.useGravity = true;
        }
    }
}

