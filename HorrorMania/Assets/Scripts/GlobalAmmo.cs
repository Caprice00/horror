using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    public static int ammoCount;
    public GameObject ammoDisplay;
    public int internalAmmo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalAmmo = ammoCount;
        ammoDisplay.GetComponent<Text>().text = "" + ammoCount;
    }
}
