using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Trolly : MonoBehaviour
{
    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void OnSelectEnter(XRBaseInteractor interactor)
    {

        Rigidbody trolleyRb = interactor.GetComponentInParent<Rigidbody>();
        if (trolleyRb != null)
        {
            trolleyRb.AddForce(interactor.attachTransform.forward * 10f, ForceMode.VelocityChange);
        }
    }
}
