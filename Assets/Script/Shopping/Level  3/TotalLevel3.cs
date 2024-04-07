using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalLevel3 : MonoBehaviour
{
    private List<Price> itemsInTrolley = new List<Price>();
    public TMP_Text totalAmountText;

    public GameObject setActive3;
    public GameObject update1;
    public GameObject update2;
    public GameObject update3;
    public GameObject update4;

    float totalAmount;
    float maxAmount = 11;

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
            if (totalAmount < maxAmount && update1.activeSelf && update2.activeSelf && update3.activeSelf && update4.activeSelf)
            {
                setActive3.SetActive(true);


            }
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
        totalAmount = CalculateTotalAmount();
        totalAmountText.text = "�" + totalAmount.ToString("F2");
    }

    public float CalculateTotalAmount()
    {
        float totalAmount = 0f;
        foreach (Price item in itemsInTrolley)
        {
            totalAmount += item.price;
        }
        return totalAmount;
    }


}
