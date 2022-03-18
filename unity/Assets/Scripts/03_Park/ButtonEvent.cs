using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
   public void showEmoticons()
    {
        if (!gameObject.GetComponent<EmoticonButton>().isPanelShown && gameObject.GetComponent<EmoticonButton>() != null)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            gameObject.GetComponent<EmoticonButton>().isPanelShown = true;
        }

        else if (gameObject.GetComponent<EmoticonButton>().isPanelShown && gameObject.GetComponent<EmoticonButton>() != null)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            gameObject.GetComponent<EmoticonButton>().isPanelShown = false;
        }
    }

}
