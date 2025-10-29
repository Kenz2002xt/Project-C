using Fusion;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    private NetworkRunner runner;

    public async void OnPlayButtonClicked()
    {
        runner = GetComponent<NetworkRunner>();
        var sceneManager = GetComponent<NetworkSceneManagerDefault>();

        await runner.StartGame(new StartGameArgs()
        {
            GameMode = GameMode.AutoHostOrClient,
            SessionName = "SpacePrison",
            Scene = SceneRef.FromIndex(1),
            SceneManager = sceneManager
        });
    }
 
}
