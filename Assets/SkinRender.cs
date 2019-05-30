using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinRender : MonoBehaviour
{

    public GameObject[] skins;
    private GameObject currentSkin;

    // Start is called before the first frame update
    void Start()
    {
        int getSkin = PlayerPrefs.GetInt("SKIN_ID",0);
        currentSkin = Instantiate(skins[getSkin], transform);
        currentSkin.AddComponent<MeshCollider>();
        
    }

    private void Update()
    {
        
    }

}
