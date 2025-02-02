using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Splines;

public class MBSDolly : MonoBehaviour
{
    [SerializeField] CinemachineSplineDolly dolly;
    [SerializeField] CinemachineSplineCart cart;
    [SerializeField] SplineAnimate scart;
    [SerializeField] CinemachineDollyCart dolly1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //dolly = GetComponent<CinemachineSplineDolly>();
        cart = GetComponent<CinemachineSplineCart>();
        dolly1 =    GetComponent<CinemachineDollyCart>();

     //   scart = GetComponent<SplineAnimate>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpeedIncrease()

    {
        dolly1.m_Speed += .05f;
        //scart.MaxSpeed += .05f;

    }


}
