using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void FirstToMain(){ SceneManager.LoadScene("main"); }
    public void MainToStart(){ SceneManager.LoadScene("raceTrack1"); }
    public void MainToMode(){ SceneManager.LoadScene("mode"); }
    public void MainToHow(){ SceneManager.LoadScene("how"); }
    public void HowToMain(){ SceneManager.LoadScene("main"); }
    public void ModeToMain(){ SceneManager.LoadScene("main"); }
    public void RaceToMain(){ SceneManager.LoadScene("main"); }
    public void ResartGame(){ SceneManager.LoadScene("raceTrack1"); }




    
}
