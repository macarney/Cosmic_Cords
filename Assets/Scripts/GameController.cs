using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
       
    enum GameState
                    {
                        OnGround,
                        FloatingTowardsStar,
                        RotatingAroundStar,
                        LookAtCredits
                    }

    GameState currentState;

    //Time the last state change happened
    float lastStateChange = 0.0f;

    void Start()
    {
        SetCurrentState(GameState.OnGround);
    }

    ///<summary>
    /// Sets the state of the game to a new state
    /// </summary>
    /// <param name="state">The new state</param>
    void SetCurrentState(GameState state)
    {
        currentState = state;
        lastStateChange = Time.time;
    }

    ///<summary>
    /// Gets the elapsed time spent in the current state
    /// /<summary>
    /// <returns>The state elapsed.</returns>
    float GetStateEllapsed()
    {
        return Time.time - lastStateChange;
    }

    void Update()
    {     
        switch (currentState)
        {
            case GameState.OnGround:
                transform.Translate(Vector3.up * 2.0f * Time.deltaTime);  //translate up, two units per second
       
                break;

            case GameState.FloatingTowardsStar:    //dont do anything, this is a waiting state
                                  
                break;

            case GameState.RotatingAroundStar:
                //Quaternion targetRotation = Quaternion.LookRotation(ball.position - transform.position);
                //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime);                           

                break;

            case GameState.LookAtCredits:
                //Quaternion rotation = Quaternion.LookRotation(credits.position - transform.position);
                //transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime);
                break;

            default:

                break;
        }

    }

}
