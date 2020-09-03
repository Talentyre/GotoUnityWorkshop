
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField]
    private int _platformStartCount = 10;

    [SerializeField]
    private GameObject PlatformPrefab;

    private Vector3 _previousPlatformPosition;
    private Vector3 _screenWorldSize;

    private void Start()
    {
        _screenWorldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,-10));
                
        InitPlatforms();
    }

    /**
     * Méthode initialisant les plateformes
     */
    private void InitPlatforms()
    {
        for (int i = 0; i < _platformStartCount; i++)
        {
            SpawnPlatform();
        }
    }

    private void SpawnPlatform()
    {
        // platforme positionnée RandomY + RandomX taille écran
        var position = new Vector3(
            Random.Range(-_screenWorldSize.x, _screenWorldSize.x),
             _previousPlatformPosition.y + Random.Range(1f, 1.5f),
            0);

        var platformObject = Instantiate(PlatformPrefab, position, Quaternion.identity, transform);
        platformObject.GetComponent<OffScreenCleaner>().OnObjectClean += SpawnPlatform;
        
        _previousPlatformPosition = position;
    }
}
