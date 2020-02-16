using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Runtime.InteropServices;

public class GetWeatherData : MonoBehaviour
{
    //USED TO ALLOW UNITY WEBGL TO INTERACT WITH JAVASCRIPT FILE IN JSLIB FILE
    //THE FUNCTION SPEAK IS DEFINED IN THE JSLIB FILE LOCATED IN ASSETS/PLUGINS
    [DllImport("__Internal")]
    private static extern void Speak(string str);

    //HOLD THE VALUE OF THE TEXT FROM THE DATABASE
    //public new string name;


    // Start is called before the first frame update
    void Start()
    {
        //A COROUTINE IS A FUNCTION THAT CAN SUSPEND ITS EXECUTION (yield) until the given YieldInstruction finishes
        //StartCoroutine - STARTS A COROUTINE
        //StartCoroutine(loadData());
        //Speak("The current weather is 55 degrees");
    }

    //Enumerator allows to stop the process at a specific moment, 
    //return that part of object (or nothing) and gets back to that point whenever you need it.
    //IEnumerator loadData()
    //{
        //create a webrequest object that will get the data from the server
        //UnityWebRequest www = UnityWebRequest.Get("http://localhost/sqlconnect/getName.php");

        //yield is the point at which execution will pause and be resumed the following frame
        //yield return www.SendWebRequest();

        //get the text value of the text returned from the server
        //name = www.downloadHandler.text;

        //Debug.Log(www.downloadHandler.text);

        //   if(www.downloadHandler.text.Equals("0"))
        //  {
        //  Debug.Log("database connected");
        //}
        //else
        //{
        //Debug.Log("error connecting");
        // }
    //}


    public void talk()
    {
        Debug.Log("Weather button clicked");
        Speak("The current temperature is 4 degrees");
        
        //Speak(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
