using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents soundEvent;

    private void Awake()
    {
        soundEvent = this;
    }

    public event Action onPickaxeHit;
    public event Action onPickaxeHitAI;

    public event Action onCanisterFall;
    public event Action onCanFall;

    public event Action onLampIgnite;
    public event Action onLampOut;

    public event Action onLiquidPour;

    public event Action onGeneratorSwitch;
    public event Action onGeneratorWorking;
    public event Action onGeneratorNotWorking;

    public event Action onRatIDLE;
    public event Action onRatAttack;
    public event Action onRatDeath;


    public void PickaxeHit()
    {
        onPickaxeHit?.Invoke();
    }
    public void PickaxeHitAI()
    {
        onPickaxeHitAI?.Invoke();
    }

    public void CanisterFall()
    {
        onCanisterFall?.Invoke();
    }
    public void CanFall()
    {
        onCanFall?.Invoke();
    }

    public void LampIgnite()
    {
        onLampIgnite?.Invoke();
    }
    public void LampOut()
    {
        onLampOut?.Invoke();
    }
    public void LiquidPour()
    {
        onLiquidPour?.Invoke();
    }
    public void GeneratorSwitch()
    {
        onGeneratorSwitch?.Invoke();
    }
    public void GeneratorWorking()
    {
        onGeneratorWorking?.Invoke();
    }
    public void GeneratorNotWorking()
    {
        onGeneratorNotWorking?.Invoke();
    }
    public void RatIDLE()
    {
        onRatIDLE?.Invoke();
    }
    public void RatAttack()
    {
        onRatAttack?.Invoke();
    }
    public void RatDeath()
    {
        onRatDeath?.Invoke();
    }

}
