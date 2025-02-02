using UnityEngine;

public class MBSLeaving : MonoBehaviour
{
    [SerializeField] Transform astro;
    [SerializeField] bool isLeaving;
    [SerializeField] float vRiseRate;
    [SerializeField] float vHeight;
    [SerializeField] Transform chair;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isLeaving && astro.transform.position.y < vHeight)
        {

            astro.transform.Translate(0, vRiseRate * Time.deltaTime, 0);

        }

    }

   

    public void ToChair()
    {

        isLeaving = true;
      

       
    }


}
