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
        if (gameflow.sceneCounter == 1)
        {
            customerCountText.text = "Customers Served: " + gameflow.customersServed.ToString() + "/5";
        }

        else if (gameflow.sceneCounter == 2)
        {
            customerCountText.text = "Customers Served: " + gameflow.customersServed.ToString() + "/10";
        }
        
        else if (gameflow.sceneCounter == 3)
        {
            customerCountText.text = "Customers Served: " + gameflow.customersServed.ToString() + "/15";
        }    }
}