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
        }   
        
        else if (gameflow.sceneCounter == 4)
        {            
            customerCountText.text = "Customers Served: " + gameflow2.customersServed.ToString() + "/5";

        }        
        
        else if (gameflow.sceneCounter == 5)
        {            
            customerCountText.text = "Customers Served: " + gameflow2.customersServed.ToString() + "/10";

        }
        
        else if (gameflow.sceneCounter == 6)
        {            
            customerCountText.text = "Customers Served: " + gameflow2.customersServed.ToString() + "/15";

        }
        }
}