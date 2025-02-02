using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class TimelineEvents : MonoBehaviour
{
    [SerializeField] PlayableDirector director;
    [SerializeField] GameObject player;
    [SerializeField] MBSLeaving MBSLeaving;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           player.SetActive(false);
            MBSLeaving.ToChair();
            director.Play();
        }


    }




    public void switchScene()
    {
        SceneManager.LoadScene(1);
    }
}
