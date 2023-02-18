using UnityEngine;

namespace Ziggurat
{
    public class UnitCreator : MonoBehaviour
    {
        [SerializeField] GameObject unitPrefab;

        [Header("Configs")]
        [SerializeField] private float _moveSpeed = 1f;
        [SerializeField] private int _health = 10;
        [SerializeField] private int _lightDamage = 1;
        [SerializeField] private int _heavyDamage = 3;
        [SerializeField] private float _missAbility = 0.5f;
        
      

        public void InstantiateKnightUnit()
        {
            GameObject KnightUnit = Instantiate(unitPrefab);

            KnightUnit.transform.position = new Vector3(1f, 1f, 1f);
            //KnightUnit.transform.position = new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z);

            Debug.Log("Unit Knight is on!");
        }

        

    }
}
