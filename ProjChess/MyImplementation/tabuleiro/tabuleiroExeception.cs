using System;

namespace tabuleiro
{
    public class tabuleiroExeception : Exception
    {
        public tabuleiroExeception(string msg) : base(msg){}
    }
}