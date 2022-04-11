/**** 
 * Created by: Sage
 * Date Created: 4/11/2022
 * 
 * Last Edited by: Sage
 * Last Edited: 4/11/2022
 * 
 * Description: Return objects back into the pool
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScroller : MonoBehaviour
{

    private Material goMat; //the game object's material
    private Renderer goRenderer; //the game object's mesh renderer
    
    public Vector2 scrollSpeed = new Vector2(0, 0);//x and y speed of scroll

    private Vector2 offset; //the offset of the scroll over time

    // Start is called before the first frame update
    void Start()
    {
        goRenderer = GetComponent<Renderer>();
        goMat = goRenderer.material;
    }//end Start()

    // Update is called once per frame
    void Update()
    {
        offset = (scrollSpeed * Time.deltaTime);
        goMat.mainTextureOffset += offset;

    }//end Update()
}
