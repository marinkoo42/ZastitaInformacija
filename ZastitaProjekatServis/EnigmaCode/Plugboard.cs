using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZastitaProjekatServis.EnigmaCode;

namespace ZastitaProjekatServis.EnigmaCode
{
    public class Plugboard
    {
        private string left, right;
        

        public Plugboard(List<string> pairs) {

            this.left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.right = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach(string pair in pairs)
            {
                var a = pair[0];
                var b = pair[1];

                var pos_a = this.left.IndexOf(a);
                var pos_b = this.left.IndexOf(b);

                this.left = this.left.Substring(0,pos_a) + b + this.left.Substring(pos_a+1);
                this.left = this.left.Substring(0, pos_b) + a + this.left.Substring(pos_b + 1);
            }

        }

        public int forward(int signal)
        {
            var letter = this.right[signal];
            signal = this.left.IndexOf(letter);
            return signal;
        }

        public int backward(int signal)
        {
            var letter = this.left[signal];
            signal = this.right.IndexOf(letter);
            return signal;

        }


        

    }
}

