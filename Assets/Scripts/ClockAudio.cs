using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class ClockAudio : MonoBehaviour
{
    public AudioSource aud;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rot = transform.eulerAngles.z;

        timer += 1 * Time.deltaTime * 5;

        if (timer >= 30)
        {
            aud.Play(); 
            Debug.Log("Works");
            timer = 0;
        }

            //if (Mathf.Round(rot) <= 33 && Mathf.Round(rot) >= 27)
            //{
            //    Debug.Log("Works");
            //    aud.Play();
            //}
        }
}
