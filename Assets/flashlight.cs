using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashlight : MonoBehaviour
{
    public float maxBattery;
    public float currentTime;
    public float currentBattery;
    public Light flash;
    public float intensity;
    public Text bottomText;
    // Start is called before the first frame update
    void Start()
    {
        maxBattery = 100f;
        currentTime = 0f;
        currentBattery = 100f;
        intensity = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && flash.intensity != 0)
        {
            flash.intensity = 0;
        } 
        else if(Input.GetMouseButtonDown(0) && flash.intensity == 0)
        {
            currentTime += Time.deltaTime;
            currentBattery = maxBattery - currentTime;
            if (currentBattery < 0)
                currentBattery = 0;
            flash.intensity = intensity * (currentBattery / 100);
        }
        if (flash.intensity > 0) {
            currentTime += Time.deltaTime;
            currentBattery = maxBattery - currentTime;
            if (currentBattery < 0)
                currentBattery = 0;
            flash.intensity = intensity * (currentBattery / 100);
        }

        bottomText.text = Mathf.Round(currentBattery) + "%";
    }
}
