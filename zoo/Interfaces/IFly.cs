using System;

namespace ZooZaniness
{
    public interface IFly
    {
        int MaxHeight { get; }
        string Size { get; }
        void Fly();

    }
}