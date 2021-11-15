using System;

namespace Greshki.Model
{
    public class BattleException : ApplicationException
    {
        public BattleException(string msg) : base(msg)
        { }
    }
}