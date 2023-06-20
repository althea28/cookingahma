using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stats : MonoBehaviour
{
    public TextMeshProUGUI customerCountText;

    private void Start()
    {
        UpdateSliderText();
    }


    private void UpdateSliderText()
    {
        customerCountText.text = "Customers Served: " + gameflow.customersServed.ToString() + "/5";
    }
}