using UnityEngine;

/*
 * Animation POJO
 * Animation Bean
 * Animation IF
 */
public class AnimationData
{
    private readonly GameObject target;
    private readonly Animator animator;
    private bool initialized;

    public AnimationData(GameObject target)
    {
        this.target = target;
        this.animator = target.GetComponent<Animator>();
        initialized = false;
    }

    public void OnStart(float posture)
    {
        if(animator)
        {
            initialized = true;
            SetPosture(posture);
        }
    }

    // public api

    public void TriggerKungBu()
    {
        SetTrigger("Kung Bu");
    }

    public void TriggerStanceFinish()
    {
        SetTrigger("Stance Finish");
    }


    public void ToggleStanceSide()
    {
        ToggleBool("Stance Side (right)");
    }

    /*
     * @param value: between 0 and 1; 0 is unstable (sloppy), 1 is stable (rigid)
     */
    public void SetPosture(float value)
    {
        // xREVIEW what's a good value for posture log accentricity?
        //  - if it's 0.1, then just don't use it
        //  - 100 is just no
        //  - 50 is too much
        // log(x*y + 1)/log(y + 1)
        //  - input [0, 1] => output [0, 1]
        //  - y is the accentricity; (cannot use 0, 0.01f is linear, 100f is VERY accentric)
        //  - Wolfram Alpha `plot log(x*y+1)/log(y+1), x from 0 to 1, y from 0.01 to 100`
        //value = Mathf.Log(value*5f+1f) / Mathf.Log(6f);

        // REVIEW should we limit the max posture, or let it be 1?
        value = Mathf.Clamp(value, 0f, 0.95f);

        SetFloat("Posture", value);
    }

    // interface with animator

    private void SetTrigger(string name)
    {
        if (initialized)
        {
            animator.SetTrigger(name);
        }
        else
        {
            NotInitialized();
        }
    }

    private void ToggleBool(string name)
    {
        if (initialized)
        {
            animator.SetBool(name, !animator.GetBool(name));
        }
        else
        {
            NotInitialized();
        }
    }
    
    private void SetFloat(string name, float value)
    {
        if (initialized)
        {
            animator.SetFloat(name, value);
        }
        else
        {
            NotInitialized();
        }
    }

    private void NotInitialized()
    {
        Debug.LogErrorFormat("<b>AnimationData</b> not initialized for <b>{0}</b>.", target.name);
    }
}
