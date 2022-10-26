using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Text titleText;
    public Color startColor;
    public Color endColor;
   public float speed = 1f;
    float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
       
    }

    // Update is called once per frame
    void Update()
    {
        AnimateBorder();
    }

    void AnimateBorder()
    {
        float t = (Mathf.Sin(Time.time - startTime) * speed);
        titleText.color = Color.Lerp(startColor, endColor, t);
        
         
    }

}
