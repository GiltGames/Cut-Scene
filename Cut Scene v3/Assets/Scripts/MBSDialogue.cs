using TMPro;
using UnityEngine;

public class MBSDialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tSubtitle;
    [SerializeField] TextMeshProUGUI tSubDemon;
    [SerializeField] ParticleSystem voice;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpClear()


        {
        tSubDemon.text = "";
        tSubtitle.text = "";
        voice.Stop();

    }

   public void SpWhat()
    {
        tSubtitle.text = "What is this place?" 
            ;

    }


    public void SpAmI()
    {
        tSubtitle.text = "Am I  .....     dead?"
            ;

    }


    public void SpDofor()
    {

        tSubtitle.text = "Do for what?"
            ;
    }

    public void SpMere()
    {
        tSubtitle.text = "Merely? What would I have to do?"
            ;

    }

    public void SpBut()
    {
        tSubtitle.text = "But you are a demon too. Aren't you?"
            ;

    }

    public void SpIhave()
    {

        tSubtitle.text = "I have been opposing demons all my life, and I will take such aid as I an get, even if it comes from another demon. I accept!"
            ;
    }




    public void SpNot()
    {

        tSubDemon.text = "Not quite dead."
            ;

        voice.Play();

    }

    public void SpIntercept()
    {

        tSubDemon.text = "I ... intercepted your soul on the way to the afterlife."
            ;
        voice.Play();
    }

    public void SpLook()
    {

        tSubDemon.text = "Let me look at you, properly."
            ;
        voice.Play();
    }

    public void SpYouWillDo()
    {

        tSubDemon.text = "You will do."
            ;
        voice.Play();
    }

    public void SpAsanIntrument()
    {

        tSubDemon.text = "As an instrument of my will on the mortal plane."
            ;
        voice.Play();
    }

    public void SpPrevent()
    {

        tSubDemon.text = "Merely... prevent the demon Yazathoth from taking control."
            ;
        voice.Play();
    }


    public void SpNottheSame()
    {

        tSubDemon.text = "Not of the same kind as Yazathoth. He seeks only death. I stand in balance to him."
            ;
        voice.Play();
    }

    public void SpReturn()
    {

        tSubDemon.text = "I will return your soul to your body and give you a ... familiar... shall we say...."
            ;
        voice.Play();
    }



    /*
     "What is this place? 
     
    "Am I  .....     dead?"
    "Do for what?"
    "Merely? What would I have to do?"
    "But you are a demon too. Aren't you?"
    "I have been opposing demons all my life, and I will take such aid as I an get, even if it comes from another demon. I accept!"
    
    
    "Not quite dead."
"I ... intercepted your soul on the way to the afterlife."

    "Let me look at you, properly."</voice><voice voice-id="6e6a37d8-ead7-40d0-b7fe-b0de7739edc5" speaker-id="ed6c122f-932b-463f-ada8-
    "You will do."
    
    "As an instrument of my will on the mortal plane."
    "Merely... prevent the demon Yazathoth from taking control."

"Not of the same kind as Yazathoth. He seeks only death. I stand in balance to him."

"I will return your soul to your body and give you a ... familiar... shall we say...."
     * 
     * 
     * 
     * 
     * */
}
