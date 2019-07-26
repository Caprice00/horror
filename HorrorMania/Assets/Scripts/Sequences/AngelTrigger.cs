using System;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine;

public class AngelTrigger : MonoBehaviour
{
    
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject AngelCam;
  


     void OnTriggerEnter()
    {
        Debug.Log("inside angel trigger ");
        this.GetComponent<BoxCollider>().enabled = false;
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }
    
    IEnumerator ScenePlayer()
    {
        AngelCam.SetActive(true);
        TextBox.GetComponent<Text>().text = "What .. what is that.!";
        yield return new WaitForSeconds(9.0f);
        TextBox.GetComponent<Text>().text = "";
        
        AngelCam.SetActive(false);
        TextBox.GetComponent<Text>().text = "it looks like its calling me ";
        yield return new WaitForSeconds(3.0f);
        TextBox.GetComponent<Text>().text = "";
        TextBox.GetComponent<Text>().text = "something is not fitting ..first a zombie and now this..";
        yield return new WaitForSeconds(3.0f);
        TextBox.GetComponent<Text>().text = "";

        ThePlayer.GetComponent<FirstPersonController>().enabled = true;


    }
        
}
