using UnityEngine;

namespace Ziggurat
{
    public class UnitCreator : MonoBehaviour
    {
        [SerializeField] GameObject unitPrefab;
        [SerializeField] private MeshRenderer _blockMeshRenderer;
        [SerializeField] GameObject SpawnPoint;

        [Header("Configs")]
        [SerializeField] public float _moveSpeed;
        [SerializeField] public int _health;
        [SerializeField] public int _lightDamage;
        [SerializeField] public int _heavyDamage;
        [SerializeField] public float _missingChance;
        [SerializeField] public float _criticalChance;
        
      

        public void InstantiateKnightUnit()
        {
            //GameObject KnightUnit = Instantiate(unitPrefab);

            Instantiate(unitPrefab, SpawnPoint.transform.position + Vector3.up * _blockMeshRenderer.bounds.extents.y, Quaternion.identity);


            //KnightUnit.transform.position = new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z);

            //KnightUnit.transform.position = new Vector3(-20f,1f,1f);

            //KnightUnit.transform.position = new Vector3(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y + 2f, SpawnPoint.transform.position.z);

            Debug.Log("Unit Knight is on!");
        }

        

    }
}
