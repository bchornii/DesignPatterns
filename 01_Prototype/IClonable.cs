using System;

namespace _01_Prototype
{
    // This type parameter is covariant.
    // That is, you can use either the type you specified or any type that is more derived. 
    // For more information about covariance and contravariance, see Covariance and Contravariance in Generics.
    public interface IClonable<out T> : ICloneable
    {
        new T Clone();
    }
}
