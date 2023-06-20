using UnityEngine;
using TMPro;

public class CustServed : MonoBehaviour
{
    public TMP_Text countText;

    private void Update()
    {
        countText.text = "Customers Served: " + gameflow.customersServed.ToString();
    }
}