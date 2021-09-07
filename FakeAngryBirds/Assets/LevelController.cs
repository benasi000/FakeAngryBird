using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private Enemy[] _enemies;
    private static int nextLevelIndex = 1;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if (enemy != null)
            {
                return;
            }

            Debug.Log("You killed all enemies");

            nextLevelIndex++;
            string nextLevelName = "Level" + nextLevelIndex;
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
