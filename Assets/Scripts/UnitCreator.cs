using UnityEngine;

namespace Ziggurat
{
    public class UnitCreator : Interactable
    {
        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private MeshRenderer _blockMeshRenderer;
        [Header("Configs")]
        [SerializeField] public float _moveSpeed;
        [SerializeField] public int _health;
        [SerializeField] public int _lightDamage;
        [SerializeField] public int _heavyDamage;
        [SerializeField] public float _missingChance;
        [SerializeField] public float _criticalChance;
        

        public void InstantiateKnightUnit(UnitData unitData)
        {

            GameObject knight = Instantiate(_unitPrefab, _blockMeshRenderer.transform.position + Vector3.up *
                _blockMeshRenderer.bounds.extents.y, Quaternion.identity);


            knight.GetComponent<Animator>().GetBehaviour<PatrolBehaviour>().MoveSpeed = unitData.MoveSpeed;

        }

        

    }
}
