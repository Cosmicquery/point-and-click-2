using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class playerScript : MonoBehaviour
{
    public Slider pX;//x-axis
    public Slider pY;//y-axis
    public Slider pS;//scale
    public Slider pH;//hue
    public Slider pR;//rail
    public Slider rotation;
    public void UpdatePlayer()
    {
        transform.SetPositionAndRotation(new Vector3(pX.value,pY.value),new Quaternion(0,0,rotation.value,0));
        Color hue = GetComponent<Material>().color;
        hue = Color.HSVToRGB(pH.value, 1, 1);
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            UpdatePlayer();
        }
    }
}
