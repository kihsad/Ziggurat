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
            Instantiate(_unitPrefab, _blockMeshRenderer.transform.position + Vector3.up * _blockMeshRenderer.bounds.extents.y, Quaternion.identity);
            Debug.Log("Unit Knight is on!");
        }

        

    }
}
