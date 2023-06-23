using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

public class TimeController : MonoBehaviour
{
    private const string URL = "http://worldtimeapi.org/api/timezone/Europe/Moscow";

    [DllImport("__Internal")]
    private static extern void RecieveMoscowTime(string time);

    public void GetMoscowTime()
    {
        StartCoroutine(GetRequest());
    }

    private IEnumerator GetRequest()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(URL)) 
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Ошибка:" + webRequest.error);
            }
            else
            {
                string text = webRequest.downloadHandler.text;
                TimeFormat success = JsonConvert.DeserializeObject<TimeFormat>(text);
                //DateTime moscowTime = DateTime.Parse(webRequest.downloadHandler.text);

                RecieveMoscowTime(success.utc_datetime.ToString());
            }

        }
    }
}
