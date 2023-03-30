namespace Ziggurat 
{
    public class CreatorButton : UnitCreator
    {
        public void CreateUnit(UnitData unitData)
        {
            InstantiateKnightUnit(unitData);
        }
    }

}
