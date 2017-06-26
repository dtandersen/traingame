using UnityEngine;
using Savoa;

public class Cube : MonoBehaviour
{
    private PositionComponent positionComponent;
    private Vector3 vector3;

    void Start()
    {
        EngineRunner engineRunner = GameObject.Find("EngineRunner").GetComponent<EngineRunner>();
        Entity entity = new Entity();
        positionComponent = new PositionComponent();
        entity.AddComponent(positionComponent);
        engineRunner.engine.AddEntity(entity);
    }

    void Update()
    {
        vector3.Set(positionComponent.X, positionComponent.Y, 0);
        transform.position = vector3;
    }
}

class CubeSystem : IteratingEntitySystem
{
    public override void AddedToEngine(Engine engine)
    {
        entities = engine.EntitiesFor(new Family(typeof(PositionComponent)));
    }

    public override void processEntity(Entity entity)
    {
        PositionComponent position = entity.GetComponent<PositionComponent>();
        position.X++;
        position.Y++;
    }
}

class PositionComponent
{
    public float X;
    public float Y;
}
