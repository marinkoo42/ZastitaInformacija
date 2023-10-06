using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Web;

namespace ZastitaProjekatServis.EnigmaCode
{
    public class Enigma
    {
        public Reflector re;
        public Rotor r1, r2, r3;
        public Plugboard pb;
        public Keyboard kb;

        public Enigma(Reflector re, Rotor r1, Rotor r2, Rotor r3, Plugboard pb, Keyboard kb)
        {

            this.re = re;
            this.r1 = r1;
            this.r2 = r2;
            this.r3 = r3;
            this.pb = pb;
            this.kb = kb;

        }

        //ringovi ze prosledjuju kao int vrednosti a ne kao karakteri
        public void set_rings((int,int,int) rings)
        {
            r1.set_ring(rings.Item1);
            r2.set_ring(rings.Item2);
            r3.set_ring(rings.Item3);
        }

        public void set_key(string key)
        {
            r1.rotate_to_letter(key[0]);
            r2.rotate_to_letter(key[1]);
            r3.rotate_to_letter(key[2]);
        }

        public char Encrypt(char letter)
        {
            if (r2.left[0] == r2._notch && r3.left[0] == r3._notch)
            {
                r1.rotate();
                r2.rotate();
                r3.rotate();
            }
            //ovaj else if je double notch anomalija na stvarnoj enigma masini
            else if (r2.left[0] == r2._notch)
            {
                r1.rotate();
                r2.rotate();
                r3.rotate();
            }
            else if (r3.left[0] == r3._notch)
            {
                r2.rotate();
                r3.rotate();
            }
            else
            {
                r3.rotate();
            }

            var signal = kb.forward(letter);
            signal = pb.forward(signal);
            signal = r3.forward(signal);
            signal = r2.forward(signal);
            signal = r1.forward(signal);
            signal = re.reflect(signal);
            signal = r1.backward(signal);
            signal = r2.backward(signal);
            signal = r3.backward(signal);
            signal = pb.backward(signal);
            letter = kb.backward(signal);
            return letter;

        }
    }
}