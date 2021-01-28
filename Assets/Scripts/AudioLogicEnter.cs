﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLogicEnter : MonoBehaviour
{
    public AudioLogicEnter AudioLogicEnter;

    private void OnTriggerEnter(Collider other) //el avatar juega marco polo, toco a alguien
    {
        if (other.GetComponent<VoiceOverTrigger>() != null)
        //si toco a alguien que tiene el componente, signfica que es para
        //reproducir un voice over
        {
            //Invocamos al voice over logic para decirle que tocamos un
            //voice over trigger, con cierto índice
            AudioLogicEnter.ReproduceVoiceOver(other.GetComponent<VoiceOverTrigger>().voiceOverIndex);
        }
    }
}
