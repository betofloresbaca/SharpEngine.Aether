using SharpEngine.Core.Entity;
using SharpEngine.Core.Math;

namespace SharpEngine.AetherPhysics.Joint;

/// <summary>
/// Abstract class of Join
/// </summary>
public abstract class Joint
{
    /// <summary>
    /// Target of Joint
    /// </summary>
    public Entity Target { get; set; }
    
    /// <summary>
    /// Type of Joint
    /// </summary>
    public JointType Type { get; set; }
    
    /// <summary>
    /// From position of Joint
    /// </summary>
    public Vec2 FromPosition { get; set; }
    
    /// <summary>
    /// Target Position of Joint
    /// </summary>
    public Vec2 TargetPosition { get; set; }

    /// <summary>
    /// Create Joint
    /// </summary>
    /// <param name="target">Joint Target</param>
    /// <param name="type">Joint Type</param>
    /// <param name="fromPosition">Joint From Position</param>
    /// <param name="targetPosition">Joint Target Position</param>
    protected Joint(Entity target, JointType type, Vec2 fromPosition, Vec2 targetPosition)
    {
        Target = target;
        Type = type;
        FromPosition = fromPosition;
        TargetPosition = targetPosition;
    }
}