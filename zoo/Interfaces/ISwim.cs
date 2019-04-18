using System;

namespace ZooZaniness
{
    public interface ISwim
    {
        int MaxDepth { get; }
        string Size { get; }
        void Swim();
    }
}