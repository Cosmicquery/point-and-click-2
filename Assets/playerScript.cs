using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;
using Random = UnityEngine.Random;


public class playerScript : MonoBehaviour
{
    //declarerar sliders
    public Slider pX;//x-axis
    public Slider pY;//y-axis
    public Slider pS;//scale
    public Slider pH;//hue
    public Material pMaterial;
    public Slider pR;//rail
    public Slider rotation;

    public void Start()
    {
        //genererar startvärden
        pMaterial = GetComponent<SpriteRenderer>().material;
        
        pX.value = Random.Range(pX.minValue, pX.maxValue);
        pY.value = Random.Range(pY.minValue, pY.maxValue);
        pH.value = Random.Range(pH.minValue, pH.maxValue);
        pS.value = Random.Range (pS.minValue, pS.maxValue);
        rotation.value = Random.Range(rotation.minValue, rotation.maxValue);

        //applicerar startvärden
        UpdatePlayer();
    }
    //applicerar slider inputs
    public void UpdatePlayer()
    {
        transform.SetPositionAndRotation(new Vector3(pX.value,pY.value), Quaternion.Euler(1,1,rotation.value));

        pMaterial.color = Color.HSVToRGB(pH.value, 1f, 1f, true);

        transform.localScale = new (pS.value, pS.value, 1f);
    }
    public void Update()
    {
        //input management

        //Vi behöver egentligen inte updatera alla värden samtidigt,
        //men det var det smidigaste sättet att förebygga en en mechanic som inte implementerades.
        if (Input.GetKey(KeyCode.Mouse0))
        {
            UpdatePlayer();
        }

        //refreshar värdena
        if (Input.GetKeyUp(KeyCode.Mouse1)) 
        {
            Start();
        }
    }
}
