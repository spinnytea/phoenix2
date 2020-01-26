using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    public GameObject target;

    private AnimationData animationData;

    void Start()
    {
        if (target)
        {
            animationData = new AnimationData(target);
            animationData.OnStart(0.2f);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("1")) animationData.SetPosture(0.1f);
        if (Input.GetKeyDown("2")) animationData.SetPosture(0.2f);
        if (Input.GetKeyDown("3")) animationData.SetPosture(0.3f);
        if (Input.GetKeyDown("4")) animationData.SetPosture(0.4f);
        if (Input.GetKeyDown("5")) animationData.SetPosture(0.5f);
        if (Input.GetKeyDown("6")) animationData.SetPosture(0.6f);
        if (Input.GetKeyDown("7")) animationData.SetPosture(0.7f);
        if (Input.GetKeyDown("8")) animationData.SetPosture(0.8f);
        if (Input.GetKeyDown("9")) animationData.SetPosture(0.9f);

        if (Input.GetKeyDown("k"))
        {
            animationData.TriggerKungBu();
        }
        else if (Input.GetKeyUp("k"))
        {
            animationData.TriggerStanceFinish();
        }

        if (Input.GetKeyDown("s"))
        {
            animationData.ToggleStanceSide();
        }
    }
}
