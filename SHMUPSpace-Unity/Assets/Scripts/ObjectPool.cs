/**** 
 * Created by: Sage
 * Date Created: 4/6/2022
 * 
 * Last Edited by: Sage
 * Last Edited: 4/6/2022
 * 
 * Description: Pool of objects for reuse
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    /***VARIABLES***/


    #region POOL Singleton
    static public ObjectPool POOL;

    void CheckPOOLIsInScene()
    {
        if(POOL == null)
        {
            POOL = this;
        }
        else
        {
            Debug.LogError("POOL.Awake() - Attempted to assign a second ObjectPool.POOL");
        }
    }
    #endregion

    private Queue<GameObject> projectiles = new Queue<GameObject>(); //queue of game objects to be added to pool

    [Header("Pool Settings")]
    public GameObject projectilePrefab;
    public int poolStartSize = 5;

    /***METHODS***/

    private void Awake()
    {
        CheckPOOLIsInScene();
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<poolStartSize; i++)
        {
            GameObject gObject = Instantiate(projectilePrefab);
            projectiles.Enqueue(gObject); //add to queue
            gObject.SetActive(false); //disable projectile in scene
        }
    }//end Start()

    public GameObject GetObject()
    {
        if (projectiles.Count > 0)
        {
            GameObject gObject = projectiles.Dequeue();
            gObject.SetActive(true);
            return gObject;
        }
        else
        {
            Debug.LogWarning("Out of projectiles, Reloading...");
            return null;
        }
    }//end GetObject()

    public void ReturnObjects(GameObject gObject)
    {
        projectiles.Enqueue(gObject);
        gObject.SetActive(false);
    }//end ReturnObjects()
}
