using UnityEngine;

namespace Ziggurat
{
    public class UnitCreator : Interactable
    {
        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private MeshRenderer _blockMeshRenderer;

        [Header("Configs")]
        [SerializeField] protected float _moveSpeed;
        [SerializeField] protected int _health;
        [SerializeField] protected int _lightDamage;
        [SerializeField] protected int _heavyDamage;
        [SerializeField] protected float _missingChance;
        [SerializeField] protected float _criticalChance;
        
      

        public void InstantiateKnightUnit()
        {
            //GameObject KnightUnit = Instantiate(unitPrefab);

            Instantiate(_unitPrefab, _blockMeshRenderer.transform.position + Vector3.up * _blockMeshRenderer.bounds.extents.y, Quaternion.identity);


            //KnightUnit.transform.position = new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z);

            //KnightUnit.transform.position = new Vector3(-20f,1f,1f);

            //KnightUnit.transform.position = new Vector3(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y + 2f, SpawnPoint.transform.position.z);

            Debug.Log("Unit Knight is on!");
        }

        

    }
}
