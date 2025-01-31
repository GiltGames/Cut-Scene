using UnityEngine;

public class MBSDie : MonoBehaviour
{

    [SerializeField] Animator anim;
    [SerializeField] bool isPlayed;
    [SerializeField] float vDie;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >vDie && !isPlayed)

        {
            anim.SetTrigger("Dead");

            isPlayed = true;

        }


    }
}
