using UnityEngine;
using UnityEngine.Playables;

public class MBSStart : MonoBehaviour
{

    [SerializeField] GameObject gButton;
    [SerializeField] GameObject gPanel;
    [SerializeField] PlayableDirector director;

    private void Awake()
    {
        Time.timeScale = 0f;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FnStart()
    {
        Time.timeScale = 1.0f;
        gButton.SetActive(false);
        gPanel.SetActive(false);
        director.Play();


    }
}
