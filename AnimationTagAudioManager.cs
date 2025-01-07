using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTagAudioManager : MonoBehaviour
{
    //Replace AnimTag with the desired name for your property drawers
    //Choose a descriptive header name (like "Locomootion" or "Sweeteners")

    [Header("Section A")]
    public AK.Wwise.Event AnimTag1;
    public AK.Wwise.Event AnimTag2;
    public AK.Wwise.Event AnimTag3;
    public AK.Wwise.Event AnimTag4;

    [Header("Section B")]
    public AK.Wwise.Event AnimTag5;
    public AK.Wwise.Event AnimTag6;
    public AK.Wwise.Event AnimTag7;


    #region SectionA

    void animTag1()
    {
        AnimTag1.Post(gameObject);
    }

    void animTag2()
    {
        AnimTag2.Post(gameObject);
    }

    void animTag3()
    {
        AnimTag3.Post(gameObject);
    }

    void animTag4()
    {
        AnimTag4.Post(gameObject);
    }

    #endregion


    #region SectionB

    void animTag5()
    {
        AnimTag5.Post(gameObject);
    }

    void animTag6()
    {
        AnimTag6.Post(gameObject);
    }

    void animTag7()
    {
        AnimTag7.Post(gameObject);
    }

    #endregion

}
