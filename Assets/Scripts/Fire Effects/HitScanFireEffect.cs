using UnityEngine;

public class HitScanFireEffect : IFireEffect
{
    [SerializeField] private Color laserColor;
    [SerializeField] private float displayTime;
    [SerializeField] private bool scrolling;
    [SerializeField] private float boltSize;
    [SerializeField] private GameObject light;
    
    private LineRenderer laserLine;
    private float fireStart;
    private bool hasShown;

    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 velocity;
    
    void Start()
    {
        Setup();
    }

    void Update()
    {
        if (laserLine.enabled)
        {
            if (scrolling)
            {
                var percentage = (Time.timeSinceLevelLoad - fireStart) / displayTime;
                laserLine.SetPositions(new Vector3[]
                {
                    Vector3.Lerp(startPos, endPos + velocity * -boltSize, percentage),
                    Vector3.Lerp(startPos + velocity * boltSize, endPos, percentage)
                });
                
            }
            if (Time.timeSinceLevelLoad > fireStart + displayTime && hasShown)
            {
                light.SetActive(false);
                laserLine.enabled = false;
                Destroy(gameObject);
            }
            hasShown = true;
        }
    }

    public override bool ShouldSpawnPerBullet => true;

    public override void Fire(Transform startPosition, Vector3 endPosition)
    {
        Setup();

        startPos = startPosition.position;
        endPos = endPosition;
        velocity = (endPos - startPos).normalized;
        
        laserLine.SetPositions(new Vector3[]
        {
            startPos,
            scrolling ? startPos + velocity * boltSize : endPos
        });
        laserLine.enabled = true;
        hasShown = false;
        fireStart = Time.timeSinceLevelLoad;
        light.SetActive(true);
    }

    private void Setup()
    {
        if (laserLine == null)
        {
            laserLine = gameObject.GetComponent<LineRenderer>();
            laserLine.startColor = laserColor;
            laserLine.endColor = laserColor;
        }
    }
}
