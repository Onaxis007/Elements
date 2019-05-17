namespace Elements.Geometry.Interfaces
{
    /// <summary>
    /// Creates a lamina (zero-thickness) solid.
    /// </summary>
    public interface ILamina
    {
        /// <summary>
        /// The perimeter of the lamina's surfaces. 
        /// </summary>
        Polygon Perimeter{get;}
    }
}