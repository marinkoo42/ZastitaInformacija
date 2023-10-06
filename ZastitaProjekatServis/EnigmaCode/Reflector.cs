using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZastitaProjekatServis.EnigmaCode
{
    public class Reflector
    {

        
        public string left, right;

        public Reflector(string wiring)
        {

            this.left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.right = wiring;

        }

        public int reflect(int signal)
        {
            var letter = this.right[signal];
            signal = this.left.IndexOf(letter);
            return signal;
        }
        
    }
}