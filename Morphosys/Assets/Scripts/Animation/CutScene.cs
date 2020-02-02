using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    float FixedCount;
    private int Count;
    public List<SpriteRenderer> Sprites;
    

    private void Awake()
    {
        Sprites.ForEach(s => s.color += new Color(0, 0, 0, 0.0f));
    }

    // Start is called before the first frame update
    void Start()
    {
        Sprites.FirstOrDefault().color += new Color(0, 0, 0, 1.0f);
        FixedCount = 0.0f;
        Count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FixedCount += 0.02f;
        if (FixedCount % 2 == 0)
        {
            Count++;
        }

        if (Count == 10)
        {
            
        }
        if (Count == 10)
        {
            
        }
    }
}
