using TMPro.EditorUtilities;
using TMPro;
using UnityEngine;

public class MBSDemon : MonoBehaviour
{
    public float[] vEventStart;
    public float[] vEventEnd;
    public bool[] isEvent;
    [SerializeField] float vMove;
    [SerializeField] float vTime;
    [SerializeField] Animator anim;
    [SerializeField] bool isDemonMove;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if (isDemonMove)
        {
            FnDemonMoving();

        }
        
               

        


    }

    void FnDemonMoving()
    {
        transform.Translate(0, 0, vMove * Time.deltaTime);



        anim.SetBool("Float", true);


    }

    public void FnDemonMoveStart()

    {

        isDemonMove = true;
    }

    public void  FnDemonMoveEnd()

    {
        isDemonMove= false;
        anim.SetBool("Float", false);
    }


}
