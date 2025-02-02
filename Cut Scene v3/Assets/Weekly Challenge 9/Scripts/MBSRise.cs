using UnityEngine;

public class MBSRise : MonoBehaviour
{
    [SerializeField] float vRiseRate;
    [SerializeField] Rigidbody rb;
    [SerializeField] bool isRising;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (isRising)
        {
            rb.AddForce(transform.up * vRiseRate * Time.deltaTime, ForceMode.Acceleration);
        }

    }


    public void FnRise()

    {
        
        isRising = true;


    }


}
