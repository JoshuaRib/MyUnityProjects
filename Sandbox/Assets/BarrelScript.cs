using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour
{
    public int m_size;
    public int m_gal;
    
    public void fill(int gallons)
    {
        m_gal += gallons;
        if (m_gal > m_size)
            m_gal = m_size;
    }
    public void drain(int gallons)
    {
        m_gal -= gallons;

        if (m_gal < 0)
            m_gal = 0;
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
