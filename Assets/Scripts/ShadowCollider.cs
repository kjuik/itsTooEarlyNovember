using System.Collections.Generic;
using UnityEngine;

public class ShadowCollider : MonoBehaviour
{
    [SerializeField]
    private RenderTexture cameraTexture; 

    [SerializeField]
    private PolygonCollider2D collider; 

    void Update()
    {
        var shadowPaths = GetShadowPaths();
        
        collider.pathCount = shadowPaths.Count;
        for (var i = 0; i < shadowPaths.Count; i++)
            collider.SetPath(i, shadowPaths[i].ToArray());
    }

    private List<List<Vector2>> GetShadowPaths()
    {
        var ret = new List<List<Vector2>>();

        ret.Add(new List<Vector2>
        {
            new Vector2(0.2f, 0.2f),
            new Vector2(0.8f, 0.2f),
            new Vector2(0.8f, 0.8f),
            new Vector2(0.2f, 0.8f),
        });
        
        return ret;
    }
}
