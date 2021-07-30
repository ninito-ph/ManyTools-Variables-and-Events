﻿namespace Ninito.ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class StringReference : Reference<string, StringVariable>
    {
        public StringReference(string value) : base(value)
        {
        }
    }
}