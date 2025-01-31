using UnityEngine;

public class MBSFade : MonoBehaviour
{
    [SerializeField] Renderer render;
    [SerializeField] Color fadeColor;
    [SerializeField] float fadeDuration;
    [SerializeField] float fadeTimer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color fadeColor = render.material.color;
        
        if (fadeTimer <= fadeDuration)
        {

            fadeTimer += Time.deltaTime;
        }


        fadeColor.a = 1- (fadeTimer / fadeDuration);

        render.material.color = fadeColor;



    }
}
