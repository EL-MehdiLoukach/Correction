using System;


namespace Correction {
    // IComparable interface
    public interface IComparable<T>
    {
        int CompareTo(T other);
    }
}