using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio_Manager : MonoBehaviour
{

    public Animator musicAnim;
    public float waitTime;
    private Player player;
    private ButtonEffects buttonEffects;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
        buttonEffects = GameObject.FindObjectOfType<ButtonEffects>();
    }


    // Update is called once per frame
    void Update()
    {
        if (player.dead == true)
        {
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        musicAnim.SetTrigger("Fade Out");
        yield return new WaitForSeconds(waitTime);
    }

}
