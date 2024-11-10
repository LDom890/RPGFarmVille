using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    public List<GameObject> trees = new List<GameObject>(); 

    private void Start()
    {
        StartCoroutine(CheckAndReactivateTrees());
    }

    private IEnumerator CheckAndReactivateTrees()
    {
        while (true)
        {
            foreach (GameObject tree in trees)
            {
                if (!tree.activeInHierarchy)
                {
                    yield return StartCoroutine(ReactivateTreeAfterDelay(tree, 120f)); 
                }
            }
            yield return new WaitForSeconds(1f); 
        }
    }

    private IEnumerator ReactivateTreeAfterDelay(GameObject tree, float delay)
    {
        yield return new WaitForSeconds(delay);
        tree.SetActive(true);
    }
}