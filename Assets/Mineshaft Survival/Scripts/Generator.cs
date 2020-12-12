using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    [Header("Generator Stats")]
    public float CurrentFuel;
    public float MaxFuel;
    public bool Toggled = false;

    [Header("Visuals")]
    public GameObject VisualObjects;

    // [Header("ID")]
    string GeneratorID;

    string GeneratorTogg;
    public void Start()
    {
        GeneratorID = GetInstanceID().ToString() + "GENERATOR";
        GeneratorTogg = GeneratorID + "togg";
        StartCoroutine(autoSave());
        LoadStats();
    }
    public void Update()
    {
        if(CurrentFuel <= 2)
        {
            CurrentFuel = 2;
            Toggled = false;
            GameEvents.soundEvent.GeneratorWorking();
            Debug.Log("Generator ON");

        }

        if (Toggled)
        {
            VisualObjects.SetActive(true);
            CurrentFuel -= 0.03f;
            GameEvents.soundEvent.GeneratorWorking();

        }
        else
        {
            VisualObjects.SetActive(false);
            GameEvents.soundEvent.GeneratorNotWorking();
            Debug.Log("Generator OFF");
        }
    }

    public void LoadStats()
    {
        if(PlayerPrefs.GetFloat(GeneratorID) == 0)
        {

        }
        else
        {
            CurrentFuel = PlayerPrefs.GetFloat(GeneratorID);
        }
        if(PlayerPrefs.GetInt(GeneratorTogg) == 1)
        {
            Toggled = true;

        }
        if(PlayerPrefs.GetInt(GeneratorTogg) == 2)
        {
            Toggled = false;
        }
    }

    public void SaveStats()
    {
        PlayerPrefs.SetFloat(GeneratorID, CurrentFuel);
        if(Toggled == true)
        {
            PlayerPrefs.SetInt(GeneratorTogg, 1);
        }
        else
        {
            PlayerPrefs.SetInt(GeneratorTogg, 2);
        }
        PlayerPrefs.Save();
        Debug.Log("Generator SAVED!");
    }
    public void Toggle()
    {
        Toggled = !Toggled;
        GameEvents.soundEvent.GeneratorSwitch();

    }
    IEnumerator autoSave()
    {
        yield return new WaitForSeconds(5);
        SaveStats();
        StartCoroutine(autoSave());
    }
}
