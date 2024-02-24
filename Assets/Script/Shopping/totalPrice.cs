using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VRShoppingTrolley : MonoBehaviour
{
    private List<Price> itemsInTrolley = new List<Price>();
    public TMP_Text totalAmountText;

    private void Start()
    {
        UpdateTotalAmountText();
    }

    private void OnTriggerEnter(Collider other)
    {
        Price item = other.GetComponent<Price>();
        if (item != null && !itemsInTrolley.Contains(item))
        {
            itemsInTrolley.Add(item);
            UpdateTotalAmountText();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Price item = other.GetComponent<Price>();
        if (item != null && itemsInTrolley.Contains(item))
        {
            itemsInTrolley.Remove(item);
            UpdateTotalAmountText();
        }
    }

    private void UpdateTotalAmountText()
    {
        float totalAmount = CalculateTotalAmount();
        totalAmountText.text = "£" + totalAmount.ToString("F2");
    }

    private float CalculateTotalAmount()
    {
        float totalAmount = 0f;
        foreach (Price item in itemsInTrolley)
        {
            totalAmount += item.price;
        }
        return totalAmount;
    }
}
