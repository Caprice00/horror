using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine;
using UnityEngine.UI;


public class AuraGivingCollider : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject auraGivCol;
    public AuraPickup au1;
    public AuraPickup au2;
    public AuraPickup au3;
    public int auAura;
    bool isFirst = true;
    public GameObject TextBox;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        auAura = au1.Aura + au2.Aura+ au3.Aura;
    }

    void OnTriggerEnter()
    {
        if (isFirst)
        {
            StartCoroutine(ScenePlayer());
          
        }
        else
        {
            StartCoroutine(PickUp());
        }

    }

    IEnumerator ScenePlayer()
    {
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        TextBox.GetComponent<Text>().text = "I hear something..";
        yield return new WaitForSeconds(2.0f);
        TextBox.GetComponent<Text>().text = "";
        TextBox.GetComponent<Text>().text = "something seems to whisper ...in my head..its the statue..";
        yield return new WaitForSeconds(3.0f);
        TextBox.GetComponent<Text>().text = "";
        //play whispering audio here
        TextBox.GetComponent<Text>().text = "They shine.. Bright , the light of 3 angels. ";
        yield return new WaitForSeconds(3.0f);
        TextBox.GetComponent<Text>().text = "";
        TextBox.GetComponent<Text>().text = "the only way to head back ..is to move forward ";
        yield return new WaitForSeconds(3.0f);
        TextBox.GetComponent<Text>().text = "";
        TextBox.GetComponent<Text>().text = "scattered ahead .. lost .. must be returned.";
        //stop the whisper audio;
        yield return new WaitForSeconds(3.0f);
        TextBox.GetComponent<Text>().text = "";
        isFirst = false;
        thePlayer.GetComponent<FirstPersonController>().enabled = true;
    }
    IEnumerator PickUp()
    {
        if(auAura==1)
        {
            thePlayer.GetComponent<FirstPersonController>().enabled = false;
            TextBox.GetComponent<Text>().text = "Need .. 2 more";
            yield return new WaitForSeconds(2.0f);
            thePlayer.GetComponent<FirstPersonController>().enabled = true;
        }
        else if(auAura==2)
        {
            thePlayer.GetComponent<FirstPersonController>().enabled = false;
            TextBox.GetComponent<Text>().text = "1 more left for the release..";
            yield return new WaitForSeconds(2.0f);
            thePlayer.GetComponent<FirstPersonController>().enabled = true;
        }
        else if (auAura == 3)
        {
            thePlayer.GetComponent<FirstPersonController>().enabled = false;
            TextBox.GetComponent<Text>().text = "Finally..its here , they are all here ";
            yield return new WaitForSeconds(2.8f);
            TextBox.GetComponent<Text>().text = "";
            //play animation of all 3 auras circling the statue;
            //play animation of the light beacon over the dish;
            //camera shake (last priority)
            TextBox.GetComponent<Text>().text = "let there be light";
            yield return new WaitForSeconds(3.0f);
            TextBox.GetComponent<Text>().text = "";
            thePlayer.GetComponent<FirstPersonController>().enabled = true;


        }
    }
    



    
}
