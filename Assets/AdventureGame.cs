using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = startingState.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
