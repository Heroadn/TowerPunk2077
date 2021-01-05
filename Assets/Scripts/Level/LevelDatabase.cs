using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "New Database", menuName = "Level/New Database")]
public class LevelDatabase : ScriptableObject{

    public List<Level> levels = new List<Level>();
    public int indexOfCurrentLevel = 0;

    public void loadLevel(string level){
        SceneManager.LoadScene(level);
    }

    public void loadCurrentLevel(){
        if(indexOfCurrentLevel >= levels.Count)
        {
            Debug.Log("Index out of bounds");
            return;
        }

        SceneManager.LoadScene(levels[indexOfCurrentLevel].name);
    }

    public void loadLevel(int index){
        if(index >= levels.Count)
        {
            Debug.Log("Index out of bounds");
            return;
        }

        indexOfCurrentLevel = index;
        SceneManager.LoadScene(levels[index].name);
    }

    public void loadNextLevel(){
        if(++indexOfCurrentLevel >= levels.Count)
        {
            Debug.Log("++indexOfCurrentLevel out of bounds");
            return;
        }

        SceneManager.LoadScene(levels[indexOfCurrentLevel].name);
    }

    public void loadPrevLevel(){
        if(--indexOfCurrentLevel >= levels.Count)
        {
            Debug.Log("--indexOfCurrentLevel out of bounds");
            return;
        }

        SceneManager.LoadScene(levels[indexOfCurrentLevel].name);
    }
}