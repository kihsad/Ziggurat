using UnityEngine;

namespace Ziggurat
{
    public class UnitCreator : MonoBehaviour
    {
        [SerializeField] GameObject unitPrefab;

        [Header("Configs")]
        [SerializeField] public float _moveSpeed = 1f;
        [SerializeField] public int _health = 10;
        [SerializeField] public int _lightDamage = 1;
        [SerializeField] public int _heavyDamage = 3;
        [SerializeField] public float _missingChance = 0.5f;
        [SerializeField] public float _criticalChance = 2.5f;
        
      

        public void InstantiateKnightUnit()
        {
            GameObject KnightUnit = Instantiate(unitPrefab);

            KnightUnit.transform.position = new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z);

            Debug.Log("Unit Knight is on!");
        }

        

    }
}
