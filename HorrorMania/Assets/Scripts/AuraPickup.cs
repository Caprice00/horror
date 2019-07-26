using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AuraPickup : MonoBehaviour
{
    public GameObject ThePlayer;
    public int Aura = 0;
    public GameObject auraCol;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnTriggerEnter()
    {
        
        Aura++;
        auraCol.SetActive(false);

    }
}
