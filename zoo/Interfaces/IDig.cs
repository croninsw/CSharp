using System;

namespace ZooZaniness
{
    public interface IDig
    {
        string DigTool { get; }

        string Size { get; }
        void Dig();
        void Walk();

    }
}