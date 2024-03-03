using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRObjectMovement : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.AddListener(OnGrab);
            grabInteractable.onSelectExited.AddListener(OnRelease);
        }
        else
        {
            Debug.LogError("XRGrabInteractable component not found.");
        }
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        // Custom logic when the object is grabbed
        Debug.Log("Object grabbed!");
    }

    private void OnRelease(XRBaseInteractor interactor)
    {
        // Custom logic when the object is released
        Debug.Log("Object released!");
    }
}

