using System;

namespace Greshki.Model
{
    public class BattleException : ApplicationException
    {
        public BattleException(string msg) : base(msg)
        { }
        public Severity Severity { get; set; }
    }

    public enum Severity
    {
        Critical,
        Normal,
        Info
    }
}