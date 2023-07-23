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
            customerCountText.text = "Level 1\nCustomers Served: \n" + gameflow.customersServed.ToString() + "/5";
        }

        else if (gameflow.sceneCounter == 2)
        {
            customerCountText.text = "Level 2\nCustomers Served: \n" + gameflow.customersServed.ToString() + "/10";
        }
        
        else if (gameflow.sceneCounter == 3)
        {
            customerCountText.text = "Level 3\nCustomers Served: \n" + gameflow.customersServed.ToString() + "/15";
        }   
        
        else if (gameflow.sceneCounter == 4)
        {            
            customerCountText.text = "Level 4\nCustomers Served: \n" + gameflow2.customersServed.ToString() + "/5";

        }        
        
        else if (gameflow.sceneCounter == 5)
        {            
            customerCountText.text = "Level 5\nCustomers Served: \n" + gameflow2.customersServed.ToString() + "/10";

        }
        
        else if (gameflow.sceneCounter == 6)
        {            
            customerCountText.text = "Level 6\nCustomers Served: \n" + gameflow2.customersServed.ToString() + "/15";

        }
        
        else if (gameflow.sceneCounter == 7)
        {            
            customerCountText.text = "Level 7\nCustomers Served: \n" + gameflow3.customersServed.ToString() + "/5";

        }

        else if (gameflow.sceneCounter == 8)
        {            
            customerCountText.text = "Level 8\nCustomers Served: \n" + gameflow3.customersServed.ToString() + "/10";

        }

        else if (gameflow.sceneCounter == 9)
        {            
            customerCountText.text = "Level 9\nCustomers Served: \n" + gameflow3.customersServed.ToString() + "/15";

        }
        }
}
