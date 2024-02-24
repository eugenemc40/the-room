using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PushTurnObject : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 initialPosition;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    private void OnSelectEnter(XRBaseInteractor interactor)
    {
        // Store the initial position for reference
        initialPosition = transform.position;
    }

    private void OnSelectStay(XRBaseInteractor interactor)
    {
        // Calculate the movement direction based on the interactor's velocity
        Vector3 movementDirection = interactor.attachTransform.forward;

        // Apply force to the rigidbody in the calculated direction
        rb.AddForce(movementDirection * 5f, ForceMode.VelocityChange);
    }

    private void OnSelectExit(XRBaseInteractor interactor)
    {
        // Reset the position when the touch ends
        transform.position = initialPosition;
        // Reset the velocity to prevent constant movement
        rb.velocity = Vector3.zero;
    }
}
