using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEmote : MonoBehaviour
{
    public Image emote;
    public Transform tf;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        emote.enabled = false;

        if (tf.position.x >= 2)
        {
            emote.enabled = true;
        }
    }
}
