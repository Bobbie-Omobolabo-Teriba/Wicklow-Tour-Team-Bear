using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    public GameObject currentPanel;

   static private  List<GameObject> history = new List<GameObject>();

    
    public void SetCurrentPanel(GameObject newPanel)
    {
        currentPanel.gameObject.SetActive(false);
        newPanel.gameObject.SetActive(true);
    }

    public void addNewPanel(GameObject newPanel)
    {
        //add the current panel to the list of panels
        //this will be used for going back

        history.Add(currentPanel);
       // Debug.Log("HISTORY Count " + history.Count);
        SetCurrentPanel(newPanel);
    }

    public void GoToPrevious()
    {
        int previous = history.Count - 1;
        SetCurrentPanel(history[previous]);
        
        //remove current panel from the list
        history.RemoveAt(previous);

       // Debug.Log("PREVIOUS " + history.Count);

    }

    




}
