using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageVisible : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject image;

    public void OpenImage()
    {
        if(image != null)
        {
            bool isActive = image.activeSelf;
            image.SetActive(!isActive);
            
        }  
    }

    public void CloseImage()
    {
        if(image != null)
        {
            image.SetActive(true);
        }
    }

}
