using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class EnemyIndicator : MonoBehaviour
{
    [SerializeField] private Vector3 extents;
    [SerializeField] private Color startDetectionColor;
    [SerializeField] private Color endDetectionColor;
    [SerializeField] private Color underAttackColor;

    private Image myImage;
    private RectTransform myRectTransform;

    private GameObject myEnemy;
    private GameObject mySource;

    private BadGuyPatrol _patrol;
    private BadGuyAttackState _attack;
    private BadGuyDeadState _dead;

    void Start()
    {
        myRectTransform = GetComponent<RectTransform>();
        myImage = GetComponent<Image>();
    }

    public void SetEnemy(GameObject enemy, GameObject playerObject)
    {
        myEnemy = enemy;
        mySource = playerObject;
        _patrol = myEnemy.GetComponent<BadGuyPatrol>();
        _attack = myEnemy.GetComponent<BadGuyAttackState>();
        _dead = myEnemy.GetComponent<BadGuyDeadState>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myEnemy == null || _dead.IsActiveState)
        {
            Destroy(gameObject);
            myImage.enabled = false;
            return;
        }

        Vector3 towardsEnemy = mySource.transform.InverseTransformPoint(myEnemy.transform.position);
        towardsEnemy.y = towardsEnemy.z;
        towardsEnemy.z = 0f;
        towardsEnemy.Normalize();
        towardsEnemy.x *= extents.x;
        towardsEnemy.y *= extents.y;

        myRectTransform.localPosition = towardsEnemy; 

        if (_attack.IsActiveState)
        {
            myImage.enabled = true;
            myImage.color = underAttackColor;
        }

        if (_patrol.IsActiveState)
        {
            var discovery = _patrol.DiscoveryPercentage();
            if (discovery > .1f)
            {
                myImage.enabled = true;
                myImage.color = Color.Lerp(startDetectionColor, endDetectionColor, discovery);
            }
            else
            {
                myImage.enabled = false;
            }
        }
    }
}