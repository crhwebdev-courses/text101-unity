using System;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {        
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            state = startingState;            
        }
        else
        {
            var nextStates = state.GetNextStates();
            for (int index = 0; index < nextStates.Length; index++)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1 + index))
                {
                    state = nextStates[index];
                }
            }
        }
                                
        textComponent.text = state.GetStateStory();
    }
}
