/**** 
 * Created by: Sage
 * Date Created: 4/6/2022
 * 
 * Last Edited by: Sage
 * Last Edited: 4/6/2022
 * 
 * Description: Return objects back into the pool
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL;
    }//end Awake()

    private void OnDisable()
    {
        if(pool != null)
        {
            pool.ReturnObjects(this.gameObject); //return this object to pool
        }
    }//end OnDisable()
}
