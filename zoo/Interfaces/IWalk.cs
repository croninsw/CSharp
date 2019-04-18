using System;

namespace ZooZaniness
{
    public interface IWalk
    {
        string Size { get; }
        void Walk();
        void Run();

    }
}