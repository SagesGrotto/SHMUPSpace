/**** 
 * Created by: Sage
 * Date Created: 4/6/2022
 * 
 * Last Edited by: Sage
 * Last Edited: 4/6/2022
 * 
 * Description: Projectile behavior
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /***VARIABLES***/
    private BoundsCheck bndCheck; //reference to bounds check

    // Start is called before the first frame update
    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }//end Awake()

    // Update is called once per frame
    void Update()
    {
        if (bndCheck.offUp)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            bndCheck.offUp = false; //reset the boundary setting
        }
    }//end Update()
}
