using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEffects : MonoBehaviour
{

    public Animator ButtonEnter;
    public Animator WhiteBackgroundToLevel1;

    public void PointerEnter()
    {
        ButtonEnter.SetTrigger("PlayWhenEnterLvl1");
        WhiteBackgroundToLevel1.SetTrigger("WhitetoLvl1");
    }

    public void PointerExit()
    {
        ButtonEnter.SetTrigger("PlayWhenExitLvl1");
        WhiteBackgroundToLevel1.SetTrigger("Lvl1toWhite");
    }

}
