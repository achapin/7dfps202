using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    [SerializeField] private RectTransform indicatorField;
    [SerializeField] private EnemyIndicator indicatorPrefab;
    
    private Dictionary<GameObject, EnemyIndicator> activeIndicators = new Dictionary<GameObject, EnemyIndicator>(); 
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddIndicatorFor(GameObject enemy)
    {
        if (!activeIndicators.ContainsKey(enemy))
        {
            var newIndicator = Instantiate(indicatorPrefab, indicatorField.transform) as EnemyIndicator;
            newIndicator.SetEnemy(enemy, gameObject);
        }
    }
}
