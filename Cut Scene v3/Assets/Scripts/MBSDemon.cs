using TMPro.EditorUtilities;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.Splines;

public class MBSDemon : MonoBehaviour
{
    public float[] vEventStart;
    public float[] vEventEnd;
    public bool[] isEvent;
    [SerializeField] float vMove;
    [SerializeField] float vTime;
    [SerializeField] Animator anim;
    [SerializeField] bool isDemonMove;
    [SerializeField] float vExpand;
    [SerializeField] float vMaxSize;
    [SerializeField] bool isExpand;
    [SerializeField] bool isShrink;
    [SerializeField] Transform trackPoint;
    [SerializeField] Transform trackTarget;
    [SerializeField] Transform player;
    [SerializeField] Transform hand;
    [SerializeField] bool isHeld;
    [SerializeField] Vector3 vOffset;
    [SerializeField] float vOffsetx;
    [SerializeField] Vector3 vHandPos;
    [SerializeField] SplineAnimate castline;
    [SerializeField] GameObject gPower;

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

        if (isExpand)
        {
            FnDemonExpand();
        }

        if (isShrink)
        {
            FnDemonShrink();

        }

        if (isHeld)
        {
            FnLifting();

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

        trackPoint.parent = trackTarget;
        trackPoint.localPosition = Vector3.zero;

    }

    public void FnDemonMoveEnd()

    {
        isDemonMove = false;
        anim.SetBool("Float", false);
    }


    public void FnDemonExpand()
    {
        Vector3 vectExp = new Vector3(vExpand, vExpand, vExpand);

        if (transform.localScale.x < vMaxSize)
        {

            transform.localScale += vectExp * Time.deltaTime;

        }


    }


    public void FnDemonShrink()
    {
        Vector3 vectExp = new Vector3(vExpand, vExpand, vExpand);

        if (transform.localScale.x > 1)
        {

            transform.localScale -= vectExp*Time.deltaTime;

        }


    }


    public void FnDemonExpandStart()
    {
        isExpand = true;

    }


    public void FnDemonShrinkStart()
    {
        isShrink = true;

    }

    public void FnSizeSteady()
    {
        isShrink = false;
        isExpand = false;
        player.transform.rotation = Quaternion.identity;
    }



    public void FnPickup()
    {

        anim.SetTrigger("Pick");
        anim.SetBool("BPick", true);

    }
    public void Grab()
    {
        
        player.transform.AddComponent<Rigidbody>();

        Rigidbody playerrb = player.transform.GetComponent<Rigidbody>();

        playerrb.constraints = RigidbodyConstraints.FreezePositionZ;
        
        playerrb.constraints = RigidbodyConstraints.FreezeRotation;
        playerrb.isKinematic = true;


        isHeld = true;
        vOffset = hand.transform.position - player.transform.position;
       // vOffsetx = hand.transform.position.x - player.transform.position.x;



    }

    void FnLifting()
    {
        Vector3 newPos = player.transform.position;

        vHandPos = hand.position;

        player.transform.position = vHandPos - vOffset;


    }

    public void FnPutdown()
    {
        anim.SetBool("BPick",false);
        anim.SetTrigger("Drop");
        anim.SetBool("bDrop", true);


    }

    public void Drop()
    {
        player.transform.parent = null;
        player.transform.rotation = Quaternion.identity;
        Rigidbody playerrb = player.transform.GetComponent<Rigidbody>();
        Destroy(playerrb );
        isHeld = false;

    }


    public void FnStartSpell()
    {
        anim.SetTrigger("Magic");
       
    
    
    }

    public void FnPower()
    {

        gPower.SetActive(true);




    }

    public void FnCast()
    {
        castline.Play();

    }


}
