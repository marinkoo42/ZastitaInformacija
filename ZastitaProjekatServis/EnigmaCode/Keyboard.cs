using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZastitaProjekatServis.EnigmaCode
{
    public class Keyboard
    {

        public int forward(char letter)
        {
            var signal = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(letter);
            return signal;
        }

        public char backward(int signal)
        {
            var letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[signal];
            return letter;
        }
    }
}