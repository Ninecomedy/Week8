using UnityEngine;

public class Lamp : ISwitchControl
{
    [Header("Lamp Settings")]
    public bool isOn = false;     
    public Light lampLight;        
    public AudioSource clickSound; 

    void Start()
    {
        UpdateLampState();
    }

    public void TurnOn()
    {
        isOn = true;
        UpdateLampState();
        Debug.Log("Lamp is now ON");
    }

 
    public void TurnOff()
    {
        isOn = false;
        UpdateLampState();
        Debug.Log("Lamp is now OFF");
    }


    public void Toggle()
    {
        isOn = !isOn;
        UpdateLampState();
        Debug.Log($"Lamp toggled to {(isOn ? "ON" : "OFF")}");
    }


    private void UpdateLampState()
    {
        if (lampLight != null)
            lampLight.enabled = isOn;

        if (clickSound != null)
            clickSound.Play();
    }
}
